namespace Client
{
	partial class frmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.tssCameraState = new System.Windows.Forms.ToolStripStatusLabel();
			this.tssFrameNo = new System.Windows.Forms.ToolStripStatusLabel();
			this.tssDisplayRate = new System.Windows.Forms.ToolStripStatusLabel();
			this.tssRecordingFile = new System.Windows.Forms.ToolStripStatusLabel();
			this.msMain = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.miConnect = new System.Windows.Forms.ToolStripMenuItem();
			this.miDisconnect = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.miCameraInfo = new System.Windows.Forms.ToolStripMenuItem();
			this.miDriverInfo = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.miActions = new System.Windows.Forms.ToolStripMenuItem();
			this.miSettings = new System.Windows.Forms.ToolStripMenuItem();
			this.pnlClient = new System.Windows.Forms.Panel();
			this.pnlVideoFrames = new System.Windows.Forms.Panel();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.pnlVideoControls = new System.Windows.Forms.Panel();
			this.btnImageSettings = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.lblBuffering = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblVideoFormat = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblBitDepth = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblCameraType = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.lblIntegration = new System.Windows.Forms.Label();
			this.btnIntegrationDown = new System.Windows.Forms.Button();
			this.btnIntegrationUp = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lblGain = new System.Windows.Forms.Label();
			this.btnGainDown = new System.Windows.Forms.Button();
			this.btnGainUp = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblGamma = new System.Windows.Forms.Label();
			this.btnGammaDown = new System.Windows.Forms.Button();
			this.btnGammaUp = new System.Windows.Forms.Button();
			this.btnStopRecording = new System.Windows.Forms.Button();
			this.btnRecord = new System.Windows.Forms.Button();
			this.cbFrameFetcher = new System.Windows.Forms.CheckBox();
			this.statusStrip.SuspendLayout();
			this.msMain.SuspendLayout();
			this.pnlClient.SuspendLayout();
			this.pnlVideoFrames.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.pnlVideoControls.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssCameraState,
            this.tssFrameNo,
            this.tssDisplayRate,
            this.tssRecordingFile});
			this.statusStrip.Location = new System.Drawing.Point(0, 504);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(840, 22);
			this.statusStrip.TabIndex = 1;
			this.statusStrip.Text = "statusStrip1";
			// 
			// tssCameraState
			// 
			this.tssCameraState.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.tssCameraState.Name = "tssCameraState";
			this.tssCameraState.Size = new System.Drawing.Size(75, 17);
			this.tssCameraState.Text = "Disconnected";
			// 
			// tssFrameNo
			// 
			this.tssFrameNo.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.tssFrameNo.Name = "tssFrameNo";
			this.tssFrameNo.Size = new System.Drawing.Size(57, 17);
			this.tssFrameNo.Text = "Frame No";
			this.tssFrameNo.Visible = false;
			// 
			// tssDisplayRate
			// 
			this.tssDisplayRate.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.tssDisplayRate.Name = "tssDisplayRate";
			this.tssDisplayRate.Size = new System.Drawing.Size(71, 17);
			this.tssDisplayRate.Text = "Display Rate";
			this.tssDisplayRate.Visible = false;
			// 
			// tssRecordingFile
			// 
			this.tssRecordingFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.tssRecordingFile.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.tssRecordingFile.Name = "tssRecordingFile";
			this.tssRecordingFile.Size = new System.Drawing.Size(73, 17);
			this.tssRecordingFile.Text = "File (xxx Mb)";
			this.tssRecordingFile.Visible = false;
			// 
			// msMain
			// 
			this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.miActions,
            this.miSettings});
			this.msMain.Location = new System.Drawing.Point(0, 0);
			this.msMain.Name = "msMain";
			this.msMain.Size = new System.Drawing.Size(840, 24);
			this.msMain.TabIndex = 2;
			this.msMain.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miConnect,
            this.miDisconnect,
            this.toolStripSeparator2,
            this.miCameraInfo,
            this.miDriverInfo,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
			this.fileToolStripMenuItem.Text = "&Video Camera";
			// 
			// miConnect
			// 
			this.miConnect.Name = "miConnect";
			this.miConnect.Size = new System.Drawing.Size(134, 22);
			this.miConnect.Text = "&Connect";
			this.miConnect.Click += new System.EventHandler(this.miConnect_Click);
			// 
			// miDisconnect
			// 
			this.miDisconnect.Enabled = false;
			this.miDisconnect.Name = "miDisconnect";
			this.miDisconnect.Size = new System.Drawing.Size(134, 22);
			this.miDisconnect.Text = "&Disconnect";
			this.miDisconnect.Click += new System.EventHandler(this.miDisconnect_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(131, 6);
			// 
			// miCameraInfo
			// 
			this.miCameraInfo.Enabled = false;
			this.miCameraInfo.Name = "miCameraInfo";
			this.miCameraInfo.Size = new System.Drawing.Size(134, 22);
			this.miCameraInfo.Text = "Ca&mera Info";
			this.miCameraInfo.Click += new System.EventHandler(this.miCameraInfo_Click);
			// 
			// miDriverInfo
			// 
			this.miDriverInfo.Enabled = false;
			this.miDriverInfo.Name = "miDriverInfo";
			this.miDriverInfo.Size = new System.Drawing.Size(134, 22);
			this.miDriverInfo.Text = "Dri&ver Info";
			this.miDriverInfo.Click += new System.EventHandler(this.miDriverInfo_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(131, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// miActions
			// 
			this.miActions.Enabled = false;
			this.miActions.Name = "miActions";
			this.miActions.Size = new System.Drawing.Size(54, 20);
			this.miActions.Text = "&Actions";
			// 
			// miSettings
			// 
			this.miSettings.Name = "miSettings";
			this.miSettings.Size = new System.Drawing.Size(58, 20);
			this.miSettings.Text = "&Settings";
			this.miSettings.Click += new System.EventHandler(this.miConfigure_Click);
			// 
			// pnlClient
			// 
			this.pnlClient.BackColor = System.Drawing.SystemColors.ControlDark;
			this.pnlClient.Controls.Add(this.pnlVideoFrames);
			this.pnlClient.Controls.Add(this.pnlVideoControls);
			this.pnlClient.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlClient.Location = new System.Drawing.Point(0, 24);
			this.pnlClient.Name = "pnlClient";
			this.pnlClient.Size = new System.Drawing.Size(840, 480);
			this.pnlClient.TabIndex = 4;
			// 
			// pnlVideoFrames
			// 
			this.pnlVideoFrames.Controls.Add(this.pictureBox);
			this.pnlVideoFrames.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlVideoFrames.Location = new System.Drawing.Point(0, 0);
			this.pnlVideoFrames.Name = "pnlVideoFrames";
			this.pnlVideoFrames.Size = new System.Drawing.Size(640, 480);
			this.pnlVideoFrames.TabIndex = 2;
			// 
			// pictureBox
			// 
			this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox.Location = new System.Drawing.Point(0, 0);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(640, 480);
			this.pictureBox.TabIndex = 0;
			this.pictureBox.TabStop = false;
			// 
			// pnlVideoControls
			// 
			this.pnlVideoControls.BackColor = System.Drawing.SystemColors.Control;
			this.pnlVideoControls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlVideoControls.Controls.Add(this.btnImageSettings);
			this.pnlVideoControls.Controls.Add(this.groupBox4);
			this.pnlVideoControls.Controls.Add(this.groupBox3);
			this.pnlVideoControls.Controls.Add(this.groupBox2);
			this.pnlVideoControls.Controls.Add(this.groupBox1);
			this.pnlVideoControls.Controls.Add(this.btnStopRecording);
			this.pnlVideoControls.Controls.Add(this.btnRecord);
			this.pnlVideoControls.Controls.Add(this.cbFrameFetcher);
			this.pnlVideoControls.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnlVideoControls.Enabled = false;
			this.pnlVideoControls.Location = new System.Drawing.Point(640, 0);
			this.pnlVideoControls.Name = "pnlVideoControls";
			this.pnlVideoControls.Size = new System.Drawing.Size(200, 480);
			this.pnlVideoControls.TabIndex = 1;
			// 
			// btnImageSettings
			// 
			this.btnImageSettings.Location = new System.Drawing.Point(79, 8);
			this.btnImageSettings.Name = "btnImageSettings";
			this.btnImageSettings.Size = new System.Drawing.Size(105, 23);
			this.btnImageSettings.TabIndex = 10;
			this.btnImageSettings.Text = "Device Properties";
			this.btnImageSettings.UseVisualStyleBackColor = true;
			this.btnImageSettings.Click += new System.EventHandler(this.btnImageSettings_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.lblBuffering);
			this.groupBox4.Controls.Add(this.label4);
			this.groupBox4.Controls.Add(this.lblVideoFormat);
			this.groupBox4.Controls.Add(this.label5);
			this.groupBox4.Controls.Add(this.lblBitDepth);
			this.groupBox4.Controls.Add(this.label3);
			this.groupBox4.Controls.Add(this.lblCameraType);
			this.groupBox4.Controls.Add(this.label1);
			this.groupBox4.Location = new System.Drawing.Point(13, 35);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(171, 145);
			this.groupBox4.TabIndex = 9;
			this.groupBox4.TabStop = false;
			// 
			// lblBuffering
			// 
			this.lblBuffering.AutoSize = true;
			this.lblBuffering.ForeColor = System.Drawing.Color.Navy;
			this.lblBuffering.Location = new System.Drawing.Point(76, 67);
			this.lblBuffering.Name = "lblBuffering";
			this.lblBuffering.Size = new System.Drawing.Size(27, 13);
			this.lblBuffering.TabIndex = 9;
			this.lblBuffering.Text = "N/A";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(27, 67);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Buffering: ";
			// 
			// lblVideoFormat
			// 
			this.lblVideoFormat.ForeColor = System.Drawing.Color.Navy;
			this.lblVideoFormat.Location = new System.Drawing.Point(15, 122);
			this.lblVideoFormat.Name = "lblVideoFormat";
			this.lblVideoFormat.Size = new System.Drawing.Size(150, 14);
			this.lblVideoFormat.TabIndex = 7;
			this.lblVideoFormat.Text = "N/A";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(14, 101);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(91, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "Video File Format:";
			// 
			// lblBitDepth
			// 
			this.lblBitDepth.AutoSize = true;
			this.lblBitDepth.ForeColor = System.Drawing.Color.Navy;
			this.lblBitDepth.Location = new System.Drawing.Point(76, 36);
			this.lblBitDepth.Name = "lblBitDepth";
			this.lblBitDepth.Size = new System.Drawing.Size(27, 13);
			this.lblBitDepth.TabIndex = 3;
			this.lblBitDepth.Text = "N/A";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(25, 36);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Bit Depth: ";
			// 
			// lblCameraType
			// 
			this.lblCameraType.AutoSize = true;
			this.lblCameraType.ForeColor = System.Drawing.Color.Navy;
			this.lblCameraType.Location = new System.Drawing.Point(76, 18);
			this.lblCameraType.Name = "lblCameraType";
			this.lblCameraType.Size = new System.Drawing.Size(27, 13);
			this.lblCameraType.TabIndex = 1;
			this.lblCameraType.Text = "N/A";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Frame Rate: ";
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox3.Controls.Add(this.lblIntegration);
			this.groupBox3.Controls.Add(this.btnIntegrationDown);
			this.groupBox3.Controls.Add(this.btnIntegrationUp);
			this.groupBox3.Location = new System.Drawing.Point(13, 371);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(171, 53);
			this.groupBox3.TabIndex = 8;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Integration";
			// 
			// lblIntegration
			// 
			this.lblIntegration.Location = new System.Drawing.Point(54, 24);
			this.lblIntegration.Name = "lblIntegration";
			this.lblIntegration.Size = new System.Drawing.Size(64, 18);
			this.lblIntegration.TabIndex = 2;
			this.lblIntegration.Text = "INTGR";
			this.lblIntegration.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btnIntegrationDown
			// 
			this.btnIntegrationDown.Location = new System.Drawing.Point(11, 19);
			this.btnIntegrationDown.Name = "btnIntegrationDown";
			this.btnIntegrationDown.Size = new System.Drawing.Size(37, 23);
			this.btnIntegrationDown.TabIndex = 1;
			this.btnIntegrationDown.Text = "<<";
			this.btnIntegrationDown.UseVisualStyleBackColor = true;
			this.btnIntegrationDown.Click += new System.EventHandler(this.btnIntegrationDown_Click);
			// 
			// btnIntegrationUp
			// 
			this.btnIntegrationUp.Location = new System.Drawing.Point(124, 19);
			this.btnIntegrationUp.Name = "btnIntegrationUp";
			this.btnIntegrationUp.Size = new System.Drawing.Size(37, 23);
			this.btnIntegrationUp.TabIndex = 0;
			this.btnIntegrationUp.Text = ">>";
			this.btnIntegrationUp.UseVisualStyleBackColor = true;
			this.btnIntegrationUp.Click += new System.EventHandler(this.btnIntegrationUp_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox2.Controls.Add(this.lblGain);
			this.groupBox2.Controls.Add(this.btnGainDown);
			this.groupBox2.Controls.Add(this.btnGainUp);
			this.groupBox2.Location = new System.Drawing.Point(13, 312);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(171, 53);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Gain";
			// 
			// lblGain
			// 
			this.lblGain.Location = new System.Drawing.Point(54, 24);
			this.lblGain.Name = "lblGain";
			this.lblGain.Size = new System.Drawing.Size(64, 18);
			this.lblGain.TabIndex = 2;
			this.lblGain.Text = "GAIN";
			this.lblGain.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btnGainDown
			// 
			this.btnGainDown.Location = new System.Drawing.Point(11, 19);
			this.btnGainDown.Name = "btnGainDown";
			this.btnGainDown.Size = new System.Drawing.Size(37, 23);
			this.btnGainDown.TabIndex = 1;
			this.btnGainDown.Text = "<<";
			this.btnGainDown.UseVisualStyleBackColor = true;
			this.btnGainDown.Click += new System.EventHandler(this.btnGainDown_Click);
			// 
			// btnGainUp
			// 
			this.btnGainUp.Location = new System.Drawing.Point(124, 19);
			this.btnGainUp.Name = "btnGainUp";
			this.btnGainUp.Size = new System.Drawing.Size(37, 23);
			this.btnGainUp.TabIndex = 0;
			this.btnGainUp.Text = ">>";
			this.btnGainUp.UseVisualStyleBackColor = true;
			this.btnGainUp.Click += new System.EventHandler(this.btnGainUp_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox1.Controls.Add(this.lblGamma);
			this.groupBox1.Controls.Add(this.btnGammaDown);
			this.groupBox1.Controls.Add(this.btnGammaUp);
			this.groupBox1.Location = new System.Drawing.Point(13, 253);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(171, 53);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Gamma";
			// 
			// lblGamma
			// 
			this.lblGamma.Location = new System.Drawing.Point(54, 24);
			this.lblGamma.Name = "lblGamma";
			this.lblGamma.Size = new System.Drawing.Size(64, 18);
			this.lblGamma.TabIndex = 2;
			this.lblGamma.Text = "GAMMA";
			this.lblGamma.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btnGammaDown
			// 
			this.btnGammaDown.Location = new System.Drawing.Point(11, 19);
			this.btnGammaDown.Name = "btnGammaDown";
			this.btnGammaDown.Size = new System.Drawing.Size(37, 23);
			this.btnGammaDown.TabIndex = 1;
			this.btnGammaDown.Text = "<<";
			this.btnGammaDown.UseVisualStyleBackColor = true;
			this.btnGammaDown.Click += new System.EventHandler(this.btnGammaDown_Click);
			// 
			// btnGammaUp
			// 
			this.btnGammaUp.Location = new System.Drawing.Point(124, 19);
			this.btnGammaUp.Name = "btnGammaUp";
			this.btnGammaUp.Size = new System.Drawing.Size(37, 23);
			this.btnGammaUp.TabIndex = 0;
			this.btnGammaUp.Text = ">>";
			this.btnGammaUp.UseVisualStyleBackColor = true;
			this.btnGammaUp.Click += new System.EventHandler(this.btnGammaUp_Click);
			// 
			// btnStopRecording
			// 
			this.btnStopRecording.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnStopRecording.Enabled = false;
			this.btnStopRecording.Location = new System.Drawing.Point(104, 446);
			this.btnStopRecording.Name = "btnStopRecording";
			this.btnStopRecording.Size = new System.Drawing.Size(76, 23);
			this.btnStopRecording.TabIndex = 5;
			this.btnStopRecording.Text = "STOP";
			this.btnStopRecording.UseVisualStyleBackColor = true;
			this.btnStopRecording.Click += new System.EventHandler(this.btnStopRecording_Click);
			// 
			// btnRecord
			// 
			this.btnRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnRecord.Enabled = false;
			this.btnRecord.Location = new System.Drawing.Point(15, 446);
			this.btnRecord.Name = "btnRecord";
			this.btnRecord.Size = new System.Drawing.Size(76, 23);
			this.btnRecord.TabIndex = 4;
			this.btnRecord.Text = "REC";
			this.btnRecord.UseVisualStyleBackColor = true;
			this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
			// 
			// cbFrameFetcher
			// 
			this.cbFrameFetcher.AutoSize = true;
			this.cbFrameFetcher.Checked = true;
			this.cbFrameFetcher.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbFrameFetcher.Location = new System.Drawing.Point(15, 11);
			this.cbFrameFetcher.Name = "cbFrameFetcher";
			this.cbFrameFetcher.Size = new System.Drawing.Size(64, 17);
			this.cbFrameFetcher.TabIndex = 3;
			this.cbFrameFetcher.Text = "Preview";
			this.cbFrameFetcher.UseVisualStyleBackColor = true;
			this.cbFrameFetcher.CheckedChanged += new System.EventHandler(this.cbFrameFetcher_CheckedChanged);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(840, 526);
			this.Controls.Add(this.pnlClient);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.msMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.msMain;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmMain";
			this.Text = "ASCOM Video Client";
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.msMain.ResumeLayout(false);
			this.msMain.PerformLayout();
			this.pnlClient.ResumeLayout(false);
			this.pnlVideoFrames.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.pnlVideoControls.ResumeLayout(false);
			this.pnlVideoControls.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.MenuStrip msMain;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.Panel pnlClient;
		private System.Windows.Forms.Panel pnlVideoControls;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.ToolStripMenuItem miSettings;
		private System.Windows.Forms.ToolStripMenuItem miConnect;
		private System.Windows.Forms.ToolStripMenuItem miDisconnect;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripStatusLabel tssDisplayRate;
		private System.Windows.Forms.ToolStripStatusLabel tssFrameNo;
		private System.Windows.Forms.CheckBox cbFrameFetcher;
		private System.Windows.Forms.Button btnStopRecording;
		private System.Windows.Forms.Button btnRecord;
		private System.Windows.Forms.ToolStripMenuItem miActions;
		private System.Windows.Forms.ToolStripStatusLabel tssCameraState;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblGamma;
		private System.Windows.Forms.Button btnGammaDown;
		private System.Windows.Forms.Button btnGammaUp;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label lblGain;
		private System.Windows.Forms.Button btnGainDown;
		private System.Windows.Forms.Button btnGainUp;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label lblIntegration;
		private System.Windows.Forms.Button btnIntegrationDown;
		private System.Windows.Forms.Button btnIntegrationUp;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label lblCameraType;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblBitDepth;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblVideoFormat;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem miCameraInfo;
		private System.Windows.Forms.ToolStripMenuItem miDriverInfo;
		private System.Windows.Forms.Label lblBuffering;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel pnlVideoFrames;
		private System.Windows.Forms.ToolStripStatusLabel tssRecordingFile;
        private System.Windows.Forms.Button btnImageSettings;

	}
}

