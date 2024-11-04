using System.Diagnostics;
using System.Net.NetworkInformation;

namespace PowerOffScheduler
{
    public partial class Form1 : Form
    {

        private readonly Dictionary<string, string> typesOfSD = new()
        {
            {"Shut Down", "s"},
            {"Restart", "r"},
            {"Hibernate", "h"}
        };

        public Thread? startedThread = null;
        public bool stopthread = false;
        NetworkInterface? networkInt = null;

        public Form1()
        {
            InitializeComponent();
            comboBoxSDType.SelectedIndex = 0;
        }

        static void ShutdownComputer(string sdType)
        {
            if (!sdType.Equals("h"))
            {
                Process.Start("shutdown", $"/{sdType} /t 0");
            }
            else
            {
                Process.Start("shutdown", "/h");
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            startedThread = null;

            int counter = 0;
            int thresholdMbps = (int)numMbps.Value;
            string sdt = typesOfSD[comboBoxSDType.Text];
            int lastc = (int)numLCTimes.Value;
            int lci = (int)(numLCInt.Value * 1000);
            int cci = (int)(numCCInt.Value * 1000);
            int extramin = (int)(numExtra.Value * 60000);
            bool extrachecked = checkBoxExtra.Checked;
            double? speedMbps;
            string tabText = tabControl1.SelectedTab.Text;

            if (tabText.Equals("Internet Speed Tracked") && networkInt != null)
            {
                startedThread = new Thread(async () =>
                {
                    counter = 0;
                    while (counter < lastc)
                    {
                        speedMbps = await GetWiFiSpeed(1000);

                        if (speedMbps < thresholdMbps)
                        {
                            counter++;
                            changeLabel(labelStatus, $"Last Controls: {counter}");
                            for (int i = 0; i < lci; i += 100)
                            {
                                if (stopthread)
                                {
                                    break;
                                }

                                Thread.Sleep(100);
                            }

                            if (stopthread)
                            {
                                break;
                            }

                        }
                        else
                        {
                            changeLabel(labelStatus, $"Started: {speedMbps:F4} Mbps");
                            counter = 0;
                            for (int i = 0; i < cci; i += 100)
                            {
                                if (stopthread)
                                {
                                    break;
                                }

                                Thread.Sleep(100);
                            }

                            if (stopthread)
                            {
                                break;
                            }
                        }
                    }

                    while (true)
                    {
                        if (!stopthread)
                        {
                            if (extrachecked)
                            {
                                for (int i = 0; i < extramin; i += 100)
                                {
                                    if (stopthread)
                                    {
                                        break;
                                    }

                                    Thread.Sleep(100);
                                }

                                if (stopthread)
                                {
                                    break;
                                }
                            }

                            ShutdownComputer(sdt);
                        }

                        break;
                    }

                    stopthread = false;
                    changeLabel(labelStatus, "Ready to Go");
                    counter = 0;
                    startedThread = null;
                });
                startedThread.Start();
            }
        }

        private void checkBoxExtra_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxExtra.Checked)
            {
                labelExtra1.Enabled = true;
                labelExtra2.Enabled = true;
                numExtra.Enabled = true;
            }
            else
            {
                labelExtra1.Enabled = false;
                labelExtra2.Enabled = false;
                numExtra.Enabled = false;
            }
        }

        private void buttonTestWiFi_Click(object sender, EventArgs e) // Shows current Wi-Fi usage
        {
            new Thread(async () =>
            {
                double? spd = await GetWiFiSpeed(200);
                changeLabel(labelTestWiFi, $"{spd:F4} Mbps");
            }).Start();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (startedThread != null)
            {
                stopthread = true;
                changeLabel(labelStatus, "Stopping...");
            }
        }

        private void changeLabel(Label lbl, string newText) // Changes text of the mentioned label
        {
            if (lbl.InvokeRequired)
            {
                lbl.Invoke(new Action<Label, string>(changeLabel), lbl, newText);
            }
            else
            {
                lbl.Text = newText;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.Name.Contains("Ethernet") && ni.OperationalStatus.ToString().Equals("Up"))
                {
                    networkInt = ni;
                }
            }

            if (networkInt == null)
            {
                foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
                {
                    if (ni.Name.Contains("Wi-Fi") && ni.OperationalStatus.ToString().Equals("Up"))
                    {
                        networkInt = ni;
                    }
                }
            }

            if (networkInt == null)
            {
                foreach (Control ctl in tabPage1.Controls)
                {
                    ctl.Enabled = false;
                }
            }

            //Args section

            if (Program.args.Contains("-Default"))
            {
                buttonStart_Click(true, EventArgs.Empty);
            }
        }

        private async Task<double?> GetWiFiSpeed(int interval) // Returns average Wi-Fi speed in <interval> milliseconds
        {
            if (networkInt != null)
            {
                return await Task.Factory.StartNew(() =>
                {
                    long oldBytes = networkInt.GetIPStatistics().BytesReceived;
                    Thread.Sleep(interval);
                    long newBytes = networkInt.GetIPStatistics().BytesReceived;
                    return (double)(newBytes - oldBytes) / 131072 * 1000 / interval;
                });
            }
            else { return null; }
        }
    }
}