namespace PowerOffScheduler
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            labelTestWiFi = new Label();
            buttonTestWiFi = new Button();
            labelExtra2 = new Label();
            numExtra = new NumericUpDown();
            labelExtra1 = new Label();
            checkBoxExtra = new CheckBox();
            label8 = new Label();
            numCCInt = new NumericUpDown();
            label7 = new Label();
            label6 = new Label();
            numLCInt = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            numLCTimes = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            numMbps = new NumericUpDown();
            label1 = new Label();
            buttonStart = new Button();
            buttonStop = new Button();
            labelStatus = new Label();
            comboBoxSDType = new ComboBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numExtra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCCInt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numLCInt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numLCTimes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMbps).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(12, 8);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(530, 514);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(labelTestWiFi);
            tabPage1.Controls.Add(buttonTestWiFi);
            tabPage1.Controls.Add(labelExtra2);
            tabPage1.Controls.Add(numExtra);
            tabPage1.Controls.Add(labelExtra1);
            tabPage1.Controls.Add(checkBoxExtra);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(numCCInt);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(numLCInt);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(numLCTimes);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(numMbps);
            tabPage1.Controls.Add(label1);
            tabPage1.Font = new Font("Segoe UI", 11.25F);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(522, 486);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Internet Speed Tracked";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelTestWiFi
            // 
            labelTestWiFi.AutoSize = true;
            labelTestWiFi.Font = new Font("Calibri", 14.25F);
            labelTestWiFi.Location = new Point(178, 451);
            labelTestWiFi.Name = "labelTestWiFi";
            labelTestWiFi.Size = new Size(0, 23);
            labelTestWiFi.TabIndex = 19;
            // 
            // buttonTestWiFi
            // 
            buttonTestWiFi.BackColor = Color.Gold;
            buttonTestWiFi.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            buttonTestWiFi.Location = new Point(6, 444);
            buttonTestWiFi.Name = "buttonTestWiFi";
            buttonTestWiFi.Size = new Size(166, 36);
            buttonTestWiFi.TabIndex = 18;
            buttonTestWiFi.Text = "Test Wi-Fi Speed";
            buttonTestWiFi.UseVisualStyleBackColor = false;
            buttonTestWiFi.Click += buttonTestWiFi_Click;
            // 
            // labelExtra2
            // 
            labelExtra2.AutoSize = true;
            labelExtra2.Font = new Font("Calibri", 14.25F);
            labelExtra2.Location = new Point(216, 339);
            labelExtra2.Name = "labelExtra2";
            labelExtra2.Size = new Size(72, 23);
            labelExtra2.TabIndex = 16;
            labelExtra2.Text = "minutes";
            // 
            // numExtra
            // 
            numExtra.DecimalPlaces = 1;
            numExtra.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            numExtra.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            numExtra.Location = new Point(141, 332);
            numExtra.Name = "numExtra";
            numExtra.Size = new Size(69, 30);
            numExtra.TabIndex = 15;
            numExtra.Value = new decimal(new int[] { 15, 0, 0, 65536 });
            // 
            // labelExtra1
            // 
            labelExtra1.AutoSize = true;
            labelExtra1.Font = new Font("Calibri", 14.25F);
            labelExtra1.Location = new Point(47, 339);
            labelExtra1.Name = "labelExtra1";
            labelExtra1.Size = new Size(88, 23);
            labelExtra1.TabIndex = 14;
            labelExtra1.Text = "Extra Wait";
            // 
            // checkBoxExtra
            // 
            checkBoxExtra.AutoSize = true;
            checkBoxExtra.Checked = true;
            checkBoxExtra.CheckState = CheckState.Checked;
            checkBoxExtra.Font = new Font("Calibri", 14.25F);
            checkBoxExtra.Location = new Point(15, 287);
            checkBoxExtra.Name = "checkBoxExtra";
            checkBoxExtra.Size = new Size(232, 27);
            checkBoxExtra.TabIndex = 13;
            checkBoxExtra.Text = "Extra Wait for File Merging";
            checkBoxExtra.UseVisualStyleBackColor = true;
            checkBoxExtra.CheckedChanged += checkBoxExtra_CheckedChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 14.25F);
            label8.Location = new Point(314, 103);
            label8.Name = "label8";
            label8.Size = new Size(73, 23);
            label8.TabIndex = 11;
            label8.Text = "seconds";
            // 
            // numCCInt
            // 
            numCCInt.DecimalPlaces = 1;
            numCCInt.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            numCCInt.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            numCCInt.Location = new Point(239, 96);
            numCCInt.Name = "numCCInt";
            numCCInt.Size = new Size(69, 30);
            numCCInt.TabIndex = 10;
            numCCInt.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 14.25F);
            label7.Location = new Point(15, 103);
            label7.Name = "label7";
            label7.Size = new Size(218, 23);
            label7.TabIndex = 9;
            label7.Text = "Continious Control Interval";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 14.25F);
            label6.Location = new Point(262, 225);
            label6.Name = "label6";
            label6.Size = new Size(73, 23);
            label6.TabIndex = 8;
            label6.Text = "seconds";
            // 
            // numLCInt
            // 
            numLCInt.DecimalPlaces = 1;
            numLCInt.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            numLCInt.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            numLCInt.Location = new Point(187, 218);
            numLCInt.Name = "numLCInt";
            numLCInt.Size = new Size(69, 30);
            numLCInt.TabIndex = 7;
            numLCInt.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 14.25F);
            label5.Location = new Point(15, 225);
            label5.Name = "label5";
            label5.Size = new Size(166, 23);
            label5.TabIndex = 6;
            label5.Text = "Last Control Interval";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 14.25F);
            label4.Location = new Point(206, 163);
            label4.Name = "label4";
            label4.Size = new Size(53, 23);
            label4.TabIndex = 5;
            label4.Text = "times";
            // 
            // numLCTimes
            // 
            numLCTimes.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            numLCTimes.Location = new Point(131, 156);
            numLCTimes.Name = "numLCTimes";
            numLCTimes.Size = new Size(69, 30);
            numLCTimes.TabIndex = 4;
            numLCTimes.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F);
            label3.Location = new Point(15, 163);
            label3.Name = "label3";
            label3.Size = new Size(110, 23);
            label3.TabIndex = 3;
            label3.Text = "Last Controls";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F);
            label2.Location = new Point(225, 39);
            label2.Name = "label2";
            label2.Size = new Size(54, 23);
            label2.TabIndex = 2;
            label2.Text = "Mbps";
            // 
            // numMbps
            // 
            numMbps.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            numMbps.Location = new Point(156, 32);
            numMbps.Name = "numMbps";
            numMbps.Size = new Size(63, 30);
            numMbps.TabIndex = 1;
            numMbps.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14.25F);
            label1.Location = new Point(15, 39);
            label1.Name = "label1";
            label1.Size = new Size(135, 23);
            label1.TabIndex = 0;
            label1.Text = "Min Wi-Fi Speed";
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.FromArgb(0, 192, 0);
            buttonStart.Font = new Font("Calibri", 12F, FontStyle.Bold);
            buttonStart.ForeColor = Color.DarkRed;
            buttonStart.Location = new Point(450, 528);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(92, 44);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonStop
            // 
            buttonStop.BackColor = Color.Red;
            buttonStop.Font = new Font("Calibri", 12F, FontStyle.Bold);
            buttonStop.ForeColor = Color.DarkGreen;
            buttonStop.Location = new Point(358, 528);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(86, 44);
            buttonStop.TabIndex = 2;
            buttonStop.Text = "Stop";
            buttonStop.UseVisualStyleBackColor = false;
            buttonStop.Click += buttonStop_Click;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            labelStatus.Location = new Point(12, 536);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(116, 25);
            labelStatus.TabIndex = 4;
            labelStatus.Text = "Ready to Go";
            // 
            // comboBoxSDType
            // 
            comboBoxSDType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSDType.FormattingEnabled = true;
            comboBoxSDType.Items.AddRange(new object[] { "Shut Down", "Restart", "Hibernate" });
            comboBoxSDType.Location = new Point(203, 541);
            comboBoxSDType.Name = "comboBoxSDType";
            comboBoxSDType.Size = new Size(149, 23);
            comboBoxSDType.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 576);
            Controls.Add(comboBoxSDType);
            Controls.Add(labelStatus);
            Controls.Add(buttonStop);
            Controls.Add(buttonStart);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(570, 615);
            MinimumSize = new Size(570, 615);
            Name = "Form1";
            Text = "Power Off Scheduler";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numExtra).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCCInt).EndInit();
            ((System.ComponentModel.ISupportInitialize)numLCInt).EndInit();
            ((System.ComponentModel.ISupportInitialize)numLCTimes).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMbps).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button buttonStart;
        private Label label1;
        private Button buttonStop;
        private Label labelStatus;
        private ComboBox comboBoxSDType;
        private Label label2;
        private NumericUpDown numMbps;
        private NumericUpDown numLCTimes;
        private Label label3;
        private Label label7;
        private Label label6;
        private NumericUpDown numLCInt;
        private Label label5;
        private Label label4;
        private Label label8;
        private NumericUpDown numCCInt;
        private Label labelExtra2;
        private NumericUpDown numExtra;
        private Label labelExtra1;
        private CheckBox checkBoxExtra;
        private Label labelTestWiFi;
        private Button buttonTestWiFi;
    }
}