/*
 * This product includes software developed by Dennis Rand - CIRT.DK.
All use and distribution of the CIRT.DK developed software is subject to Version 2.0
of the Apache License (http://www.apache.org/licenses/LICENSE-2.0).
*/

namespace FiletoEXD
{
	partial class FiletoEXDlForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FiletoEXDlForm));
            this.ExportPathTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.LblLoad = new System.Windows.Forms.Label();
            this.ImportPathTB = new System.Windows.Forms.TextBox();
            this.WindowsRB = new System.Windows.Forms.RadioButton();
            this.LinuxRB = new System.Windows.Forms.RadioButton();
            this.BrowseLoadBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtVirtualDir = new System.Windows.Forms.TextBox();
            this.checkBoxExcludeFT = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxEnableHelp = new System.Windows.Forms.CheckBox();
            this.checkBoxImportApp = new System.Windows.Forms.CheckBox();
            this.lblReplace = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.BtnSearchNReplace = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.textBoxReplace = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExportPathTB
            // 
            this.ExportPathTB.Enabled = false;
            this.ExportPathTB.Location = new System.Drawing.Point(69, 51);
            this.ExportPathTB.Name = "ExportPathTB";
            this.ExportPathTB.Size = new System.Drawing.Size(365, 20);
            this.ExportPathTB.TabIndex = 10;
            this.ExportPathTB.Text = "C:\\default.exd";
            this.ExportPathTB.TextChanged += new System.EventHandler(this.ExportPathTB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Save To:";
            // 
            // CreateBtn
            // 
            this.CreateBtn.Enabled = false;
            this.CreateBtn.Location = new System.Drawing.Point(440, 51);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(78, 21);
            this.CreateBtn.TabIndex = 11;
            this.CreateBtn.Text = "Create";
            this.toolTip1.SetToolTip(this.CreateBtn, "Now lets create that EXD file.\r\n");
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(662, 563);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(78, 21);
            this.CancelBtn.TabIndex = 17;
            this.CancelBtn.Text = "Exit";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // LblLoad
            // 
            this.LblLoad.AutoSize = true;
            this.LblLoad.Location = new System.Drawing.Point(7, 24);
            this.LblLoad.Name = "LblLoad";
            this.LblLoad.Size = new System.Drawing.Size(57, 13);
            this.LblLoad.TabIndex = 9;
            this.LblLoad.Text = "Load from:";
            // 
            // ImportPathTB
            // 
            this.ImportPathTB.Location = new System.Drawing.Point(69, 24);
            this.ImportPathTB.Name = "ImportPathTB";
            this.ImportPathTB.Size = new System.Drawing.Size(281, 20);
            this.ImportPathTB.TabIndex = 7;
            this.ImportPathTB.Text = "C:\\*.*";
            // 
            // WindowsRB
            // 
            this.WindowsRB.AutoSize = true;
            this.WindowsRB.Checked = true;
            this.WindowsRB.Location = new System.Drawing.Point(618, 20);
            this.WindowsRB.Name = "WindowsRB";
            this.WindowsRB.Size = new System.Drawing.Size(69, 17);
            this.WindowsRB.TabIndex = 5;
            this.WindowsRB.TabStop = true;
            this.WindowsRB.Text = "Windows";
            this.toolTip1.SetToolTip(this.WindowsRB, "To get a valid format for the importer use:\r\n\"dir /B /S > text.txt\" from the root" +
                    " path of\r\nthe website.\r\n");
            this.WindowsRB.UseVisualStyleBackColor = true;
            this.WindowsRB.Click += new System.EventHandler(this.WindowsRB_Click);
            this.WindowsRB.CheckedChanged += new System.EventHandler(this.WindowsRB_CheckedChanged);
            // 
            // LinuxRB
            // 
            this.LinuxRB.AutoSize = true;
            this.LinuxRB.Location = new System.Drawing.Point(74, 18);
            this.LinuxRB.Name = "LinuxRB";
            this.LinuxRB.Size = new System.Drawing.Size(50, 17);
            this.LinuxRB.TabIndex = 0;
            this.LinuxRB.Text = "Linux";
            this.toolTip1.SetToolTip(this.LinuxRB, resources.GetString("LinuxRB.ToolTip"));
            this.LinuxRB.UseVisualStyleBackColor = true;
            this.LinuxRB.Click += new System.EventHandler(this.LinuxRB_Click);
            this.LinuxRB.CheckedChanged += new System.EventHandler(this.LinuxRB_CheckedChanged);
            // 
            // BrowseLoadBtn
            // 
            this.BrowseLoadBtn.Location = new System.Drawing.Point(356, 24);
            this.BrowseLoadBtn.Name = "BrowseLoadBtn";
            this.BrowseLoadBtn.Size = new System.Drawing.Size(78, 21);
            this.BrowseLoadBtn.TabIndex = 8;
            this.BrowseLoadBtn.Text = "Browse...";
            this.BrowseLoadBtn.UseVisualStyleBackColor = true;
            this.BrowseLoadBtn.Click += new System.EventHandler(this.BrowseLoadBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Text file|*.txt|All files|*.*";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(96, 19);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(236, 20);
            this.txtURL.TabIndex = 2;
            this.txtURL.Text = "127.0.0.1";
            this.txtURL.Leave += new System.EventHandler(this.txtURL_Leave);
            this.txtURL.TextChanged += new System.EventHandler(this.txtURL_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "http",
            "https"});
            this.comboBox1.Location = new System.Drawing.Point(8, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(69, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "://";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(330, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = ":";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(341, 20);
            this.txtPort.MaxLength = 5;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(40, 20);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "80";
            this.txtPort.Leave += new System.EventHandler(this.txtPort_Leave);
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(440, 24);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(78, 21);
            this.BtnLoad.TabIndex = 9;
            this.BtnLoad.Text = "Load";
            this.toolTip1.SetToolTip(this.BtnLoad, "Remember af you load in the file you can edit \r\nbefore Creating the EXD file.\r\n\r\n" +
                    "");
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.DetectUrls = false;
            this.richTextBox1.Location = new System.Drawing.Point(8, 45);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.richTextBox1.Size = new System.Drawing.Size(732, 316);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.toolTip1.SetToolTip(this.richTextBox1, "You can change the data \r\nbefore making the EXD file.\r\n\r\nDon\'t change " +
                    "the Scheme, Host \r\nor Port during operation\r\n\r\nhttp://127.0.0.1:80/<HERE YOU " +
                    "CAN CHANGE ANYTHING>\r\n\r\n");
            this.richTextBox1.WordWrap = false;
            // 
            // toolTip1
            // 
            this.toolTip1.Active = false;
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // txtVirtualDir
            // 
            this.txtVirtualDir.Location = new System.Drawing.Point(389, 20);
            this.txtVirtualDir.Name = "txtVirtualDir";
            this.txtVirtualDir.Size = new System.Drawing.Size(204, 20);
            this.txtVirtualDir.TabIndex = 4;
            this.txtVirtualDir.Text = "altoro/test";
            this.toolTip1.SetToolTip(this.txtVirtualDir, "If you have any sub-sites that are virtual directories\r\nyou can add them here.\r\nE" +
                    "g.: \"altoro\"\r\n\r\nDon\'t put any \"/\" in before or after\r\n\r\n\r\n\r\n");
            // 
            // checkBoxExcludeFT
            // 
            this.checkBoxExcludeFT.AutoSize = true;
            this.checkBoxExcludeFT.Checked = true;
            this.checkBoxExcludeFT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxExcludeFT.Location = new System.Drawing.Point(9, 129);
            this.checkBoxExcludeFT.Name = "checkBoxExcludeFT";
            this.checkBoxExcludeFT.Size = new System.Drawing.Size(157, 17);
            this.checkBoxExcludeFT.TabIndex = 15;
            this.checkBoxExcludeFT.Text = "Remove Excluded file types";
            this.toolTip1.SetToolTip(this.checkBoxExcludeFT, "\r\nIf you use \"remove Excluded file type\" the \r\nmangling time will increase.\r\n\r\n");
            this.checkBoxExcludeFT.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LinuxRB);
            this.groupBox1.Location = new System.Drawing.Point(614, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 45);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File format";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 566);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(49, 566);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(309, 17);
            this.lblStatus.TabIndex = 23;
            this.lblStatus.Text = " ....";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxEnableHelp);
            this.groupBox2.Controls.Add(this.checkBoxImportApp);
            this.groupBox2.Controls.Add(this.lblReplace);
            this.groupBox2.Controls.Add(this.lblSearch);
            this.groupBox2.Controls.Add(this.BtnSearchNReplace);
            this.groupBox2.Controls.Add(this.textBoxSearch);
            this.groupBox2.Controls.Add(this.textBoxReplace);
            this.groupBox2.Controls.Add(this.BtnLoad);
            this.groupBox2.Controls.Add(this.checkBoxExcludeFT);
            this.groupBox2.Controls.Add(this.LblLoad);
            this.groupBox2.Controls.Add(this.ExportPathTB);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ImportPathTB);
            this.groupBox2.Controls.Add(this.CreateBtn);
            this.groupBox2.Controls.Add(this.BrowseLoadBtn);
            this.groupBox2.Location = new System.Drawing.Point(8, 367);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(648, 194);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings / Advanced ";
            // 
            // checkBoxEnableHelp
            // 
            this.checkBoxEnableHelp.AutoSize = true;
            this.checkBoxEnableHelp.Location = new System.Drawing.Point(9, 174);
            this.checkBoxEnableHelp.Name = "checkBoxEnableHelp";
            this.checkBoxEnableHelp.Size = new System.Drawing.Size(118, 17);
            this.checkBoxEnableHelp.TabIndex = 17;
            this.checkBoxEnableHelp.Text = "Enable help tooltips";
            this.checkBoxEnableHelp.UseVisualStyleBackColor = true;
            this.checkBoxEnableHelp.CheckStateChanged += new System.EventHandler(this.checkBoxEnableHelp_CheckStateChanged);
            // 
            // checkBoxImportApp
            // 
            this.checkBoxImportApp.AutoSize = true;
            this.checkBoxImportApp.Location = new System.Drawing.Point(9, 152);
            this.checkBoxImportApp.Name = "checkBoxImportApp";
            this.checkBoxImportApp.Size = new System.Drawing.Size(303, 17);
            this.checkBoxImportApp.TabIndex = 16;
            this.checkBoxImportApp.Text = "Import automatically into Appscan when EXD file is created";
            this.checkBoxImportApp.UseVisualStyleBackColor = true;
            // 
            // lblReplace
            // 
            this.lblReplace.AutoSize = true;
            this.lblReplace.Location = new System.Drawing.Point(6, 104);
            this.lblReplace.Name = "lblReplace";
            this.lblReplace.Size = new System.Drawing.Size(90, 13);
            this.lblReplace.TabIndex = 5;
            this.lblReplace.Text = "Replace keyword";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(6, 82);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(84, 13);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Search keyword";
            // 
            // BtnSearchNReplace
            // 
            this.BtnSearchNReplace.Enabled = false;
            this.BtnSearchNReplace.Location = new System.Drawing.Point(440, 88);
            this.BtnSearchNReplace.Name = "BtnSearchNReplace";
            this.BtnSearchNReplace.Size = new System.Drawing.Size(100, 23);
            this.BtnSearchNReplace.TabIndex = 14;
            this.BtnSearchNReplace.Text = "Search/Replace";
            this.BtnSearchNReplace.UseVisualStyleBackColor = true;
            this.BtnSearchNReplace.Click += new System.EventHandler(this.BtnSearchNReplace_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(96, 79);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(338, 20);
            this.textBoxSearch.TabIndex = 12;
            // 
            // textBoxReplace
            // 
            this.textBoxReplace.Location = new System.Drawing.Point(96, 102);
            this.textBoxReplace.Name = "textBoxReplace";
            this.textBoxReplace.Size = new System.Drawing.Size(338, 20);
            this.textBoxReplace.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(379, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "/";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(591, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "/";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(364, 563);
            this.progressBar1.MarqueeAnimationSpeed = 200;
            this.progressBar1.Maximum = 200;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(292, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Scheme:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Host:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(338, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Port:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(387, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Path:";
            // 
            // FiletoEXDlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(750, 586);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtVirtualDir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.WindowsRB);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FiletoEXDlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import Explore Data - Files to EXD";
            this.Activated += new System.EventHandler(this.FiletoEXDlForm_Activated);
            this.Load += new System.EventHandler(this.FiletoEXDlForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

      private System.Windows.Forms.TextBox ExportPathTB;
      private System.Windows.Forms.Label label1;
	  private System.Windows.Forms.Button CreateBtn;
      private System.Windows.Forms.Button CancelBtn;
      private System.Windows.Forms.Label LblLoad;
      private System.Windows.Forms.TextBox ImportPathTB;
      private System.Windows.Forms.RadioButton WindowsRB;
      private System.Windows.Forms.RadioButton LinuxRB;
      private System.Windows.Forms.Button BrowseLoadBtn;
      private System.Windows.Forms.OpenFileDialog openFileDialog1;
      private System.Windows.Forms.TextBox txtURL;
      private System.Windows.Forms.ComboBox comboBox1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.TextBox txtPort;
      private System.Windows.Forms.Button BtnLoad;
      private System.Windows.Forms.RichTextBox richTextBox1;
      private System.Windows.Forms.ToolTip toolTip1;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxExcludeFT;
        private System.Windows.Forms.TextBox txtVirtualDir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblReplace;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button BtnSearchNReplace;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TextBox textBoxReplace;
        private System.Windows.Forms.CheckBox checkBoxImportApp;
      private System.Windows.Forms.ProgressBar progressBar1;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.Label label10;
      private System.Windows.Forms.CheckBox checkBoxEnableHelp;
	}
}