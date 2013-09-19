namespace ASCOM.Simulator
{
	partial class frmSetupDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetupDialog));
			this.cmdOK = new System.Windows.Forms.Button();
			this.cmdCancel = new System.Windows.Forms.Button();
			this.picASCOM = new System.Windows.Forms.PictureBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabGeneral = new System.Windows.Forms.TabPage();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.nudPixelSizeY = new System.Windows.Forms.NumericUpDown();
			this.nudPixelSizeX = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbxSupportedActionsList = new System.Windows.Forms.TextBox();
			this.cbxSensorType = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.tbxSensorName = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cbxBitDepth = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.rbAnalogueNonIntegrating = new System.Windows.Forms.RadioButton();
			this.rbAnalogueIntegrating = new System.Windows.Forms.RadioButton();
			this.rbVideoSystem = new System.Windows.Forms.RadioButton();
			this.rbDigitalCamera = new System.Windows.Forms.RadioButton();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.pnlAnalogueCameraSettings = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rbVideoFrameRateNTSC = new System.Windows.Forms.RadioButton();
			this.rbVideoFrameRatePAL = new System.Windows.Forms.RadioButton();
			this.tbxVideoCaptureDeviceName = new System.Windows.Forms.TextBox();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.pnlIntegratingCameraSettings = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.nudMaxExposureSec = new System.Windows.Forms.NumericUpDown();
			this.nudMinExposureSec = new System.Windows.Forms.NumericUpDown();
			this.tbxSupportedExposures = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.cbxShowCompressionDialog = new System.Windows.Forms.CheckBox();
			this.pnlBufferingControls = new System.Windows.Forms.Panel();
			this.label17 = new System.Windows.Forms.Label();
			this.nudBufferSize = new System.Windows.Forms.NumericUpDown();
			this.label16 = new System.Windows.Forms.Label();
			this.cbxBuffering = new System.Windows.Forms.CheckBox();
			this.pnlUserBitmaps = new System.Windows.Forms.Panel();
			this.tbxBitmapFolder = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.btnBrowseForFolder = new System.Windows.Forms.Button();
			this.rbUserBitmaps = new System.Windows.Forms.RadioButton();
			this.rbDriverDefaultSource = new System.Windows.Forms.RadioButton();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.pnlRangeGain = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.nudMinGain = new System.Windows.Forms.NumericUpDown();
			this.nudMaxGain = new System.Windows.Forms.NumericUpDown();
			this.label11 = new System.Windows.Forms.Label();
			this.pnlDiscreteGain = new System.Windows.Forms.Panel();
			this.tbxSupportedGains = new System.Windows.Forms.TextBox();
			this.rbDiscreteGain = new System.Windows.Forms.RadioButton();
			this.rbGainRange = new System.Windows.Forms.RadioButton();
			this.btnReset = new System.Windows.Forms.Button();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.rbDiscreteGamma = new System.Windows.Forms.RadioButton();
			this.tbxSupportedGammas = new System.Windows.Forms.TextBox();
			this.pnlRangeGamma = new System.Windows.Forms.Panel();
			this.label12 = new System.Windows.Forms.Label();
			this.nudMinGamma = new System.Windows.Forms.NumericUpDown();
			this.nudMaxGamma = new System.Windows.Forms.NumericUpDown();
			this.label18 = new System.Windows.Forms.Label();
			this.rbGammaRange = new System.Windows.Forms.RadioButton();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.picASCOM)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabGeneral.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudPixelSizeY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudPixelSizeX)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.pnlAnalogueCameraSettings.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.pnlIntegratingCameraSettings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudMaxExposureSec)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMinExposureSec)).BeginInit();
			this.tabPage3.SuspendLayout();
			this.pnlBufferingControls.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudBufferSize)).BeginInit();
			this.pnlUserBitmaps.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.pnlRangeGain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudMinGain)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMaxGain)).BeginInit();
			this.pnlDiscreteGain.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.pnlRangeGamma.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudMinGamma)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMaxGamma)).BeginInit();
			this.SuspendLayout();
			// 
			// cmdOK
			// 
			this.cmdOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdOK.Location = new System.Drawing.Point(555, 270);
			this.cmdOK.Name = "cmdOK";
			this.cmdOK.Size = new System.Drawing.Size(59, 24);
			this.cmdOK.TabIndex = 0;
			this.cmdOK.Text = "OK";
			this.cmdOK.UseVisualStyleBackColor = true;
			this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
			// 
			// cmdCancel
			// 
			this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cmdCancel.Location = new System.Drawing.Point(555, 300);
			this.cmdCancel.Name = "cmdCancel";
			this.cmdCancel.Size = new System.Drawing.Size(59, 25);
			this.cmdCancel.TabIndex = 1;
			this.cmdCancel.Text = "Cancel";
			this.cmdCancel.UseVisualStyleBackColor = true;
			this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
			// 
			// picASCOM
			// 
			this.picASCOM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picASCOM.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picASCOM.Image = global::ASCOM.Simulator.Properties.Resources.ASCOM;
			this.picASCOM.Location = new System.Drawing.Point(566, 9);
			this.picASCOM.Name = "picASCOM";
			this.picASCOM.Size = new System.Drawing.Size(48, 56);
			this.picASCOM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picASCOM.TabIndex = 3;
			this.picASCOM.TabStop = false;
			this.picASCOM.Click += new System.EventHandler(this.BrowseToAscom);
			this.picASCOM.DoubleClick += new System.EventHandler(this.BrowseToAscom);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabGeneral);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(532, 313);
			this.tabControl1.TabIndex = 4;
			// 
			// tabGeneral
			// 
			this.tabGeneral.Controls.Add(this.label13);
			this.tabGeneral.Controls.Add(this.label14);
			this.tabGeneral.Controls.Add(this.nudPixelSizeY);
			this.tabGeneral.Controls.Add(this.nudPixelSizeX);
			this.tabGeneral.Controls.Add(this.label7);
			this.tabGeneral.Controls.Add(this.label2);
			this.tabGeneral.Controls.Add(this.tbxSupportedActionsList);
			this.tabGeneral.Controls.Add(this.cbxSensorType);
			this.tabGeneral.Controls.Add(this.label6);
			this.tabGeneral.Controls.Add(this.tbxSensorName);
			this.tabGeneral.Controls.Add(this.groupBox1);
			this.tabGeneral.Location = new System.Drawing.Point(4, 22);
			this.tabGeneral.Name = "tabGeneral";
			this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
			this.tabGeneral.Size = new System.Drawing.Size(524, 287);
			this.tabGeneral.TabIndex = 0;
			this.tabGeneral.Text = "General";
			this.tabGeneral.UseVisualStyleBackColor = true;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(108, 193);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(62, 13);
			this.label13.TabIndex = 21;
			this.label13.Text = "Pixel Size Y";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(16, 193);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(62, 13);
			this.label14.TabIndex = 20;
			this.label14.Text = "Pixel Size X";
			// 
			// nudPixelSizeY
			// 
			this.nudPixelSizeY.DecimalPlaces = 1;
			this.nudPixelSizeY.Location = new System.Drawing.Point(111, 210);
			this.nudPixelSizeY.Name = "nudPixelSizeY";
			this.nudPixelSizeY.Size = new System.Drawing.Size(72, 20);
			this.nudPixelSizeY.TabIndex = 19;
			// 
			// nudPixelSizeX
			// 
			this.nudPixelSizeX.DecimalPlaces = 1;
			this.nudPixelSizeX.Location = new System.Drawing.Point(19, 210);
			this.nudPixelSizeX.Name = "nudPixelSizeX";
			this.nudPixelSizeX.Size = new System.Drawing.Size(72, 20);
			this.nudPixelSizeX.TabIndex = 18;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(15, 156);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(67, 13);
			this.label7.TabIndex = 17;
			this.label7.Text = "Sensor Type";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(233, 111);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Supported Actions";
			// 
			// tbxSupportedActionsList
			// 
			this.tbxSupportedActionsList.Location = new System.Drawing.Point(236, 127);
			this.tbxSupportedActionsList.Multiline = true;
			this.tbxSupportedActionsList.Name = "tbxSupportedActionsList";
			this.tbxSupportedActionsList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbxSupportedActionsList.Size = new System.Drawing.Size(247, 112);
			this.tbxSupportedActionsList.TabIndex = 3;
			// 
			// cbxSensorType
			// 
			this.cbxSensorType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxSensorType.FormattingEnabled = true;
			this.cbxSensorType.Location = new System.Drawing.Point(94, 153);
			this.cbxSensorType.Name = "cbxSensorType";
			this.cbxSensorType.Size = new System.Drawing.Size(121, 21);
			this.cbxSensorType.TabIndex = 16;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(17, 130);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(71, 13);
			this.label6.TabIndex = 14;
			this.label6.Text = "Sensor Name";
			// 
			// tbxSensorName
			// 
			this.tbxSensorName.Location = new System.Drawing.Point(94, 127);
			this.tbxSensorName.Name = "tbxSensorName";
			this.tbxSensorName.Size = new System.Drawing.Size(121, 20);
			this.tbxSensorName.TabIndex = 15;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cbxBitDepth);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.rbAnalogueNonIntegrating);
			this.groupBox1.Controls.Add(this.rbAnalogueIntegrating);
			this.groupBox1.Controls.Add(this.rbVideoSystem);
			this.groupBox1.Controls.Add(this.rbDigitalCamera);
			this.groupBox1.Location = new System.Drawing.Point(16, 10);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(502, 76);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Simulated Camera Type";
			// 
			// cbxBitDepth
			// 
			this.cbxBitDepth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxBitDepth.FormattingEnabled = true;
			this.cbxBitDepth.Items.AddRange(new object[] {
            "8 bit",
            "12 bit",
            "16 bit"});
			this.cbxBitDepth.Location = new System.Drawing.Point(375, 41);
			this.cbxBitDepth.Name = "cbxBitDepth";
			this.cbxBitDepth.Size = new System.Drawing.Size(93, 21);
			this.cbxBitDepth.TabIndex = 17;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(374, 25);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(51, 13);
			this.label8.TabIndex = 13;
			this.label8.Text = "Bit Depth";
			// 
			// rbAnalogueNonIntegrating
			// 
			this.rbAnalogueNonIntegrating.AutoSize = true;
			this.rbAnalogueNonIntegrating.Checked = true;
			this.rbAnalogueNonIntegrating.Location = new System.Drawing.Point(18, 25);
			this.rbAnalogueNonIntegrating.Name = "rbAnalogueNonIntegrating";
			this.rbAnalogueNonIntegrating.Size = new System.Drawing.Size(146, 17);
			this.rbAnalogueNonIntegrating.TabIndex = 8;
			this.rbAnalogueNonIntegrating.TabStop = true;
			this.rbAnalogueNonIntegrating.Text = "Analogue Non Integrating";
			this.rbAnalogueNonIntegrating.UseVisualStyleBackColor = true;
			this.rbAnalogueNonIntegrating.Click += new System.EventHandler(this.CameraTypeChanged);
			// 
			// rbAnalogueIntegrating
			// 
			this.rbAnalogueIntegrating.AutoSize = true;
			this.rbAnalogueIntegrating.Location = new System.Drawing.Point(18, 48);
			this.rbAnalogueIntegrating.Name = "rbAnalogueIntegrating";
			this.rbAnalogueIntegrating.Size = new System.Drawing.Size(123, 17);
			this.rbAnalogueIntegrating.TabIndex = 9;
			this.rbAnalogueIntegrating.Text = "Analogue Integrating";
			this.rbAnalogueIntegrating.UseVisualStyleBackColor = true;
			this.rbAnalogueIntegrating.Click += new System.EventHandler(this.CameraTypeChanged);
			// 
			// rbVideoSystem
			// 
			this.rbVideoSystem.AutoSize = true;
			this.rbVideoSystem.Location = new System.Drawing.Point(242, 48);
			this.rbVideoSystem.Name = "rbVideoSystem";
			this.rbVideoSystem.Size = new System.Drawing.Size(89, 17);
			this.rbVideoSystem.TabIndex = 11;
			this.rbVideoSystem.Text = "Video System";
			this.rbVideoSystem.UseVisualStyleBackColor = true;
			this.rbVideoSystem.Click += new System.EventHandler(this.CameraTypeChanged);
			// 
			// rbDigitalCamera
			// 
			this.rbDigitalCamera.AutoSize = true;
			this.rbDigitalCamera.Location = new System.Drawing.Point(242, 25);
			this.rbDigitalCamera.Name = "rbDigitalCamera";
			this.rbDigitalCamera.Size = new System.Drawing.Size(54, 17);
			this.rbDigitalCamera.TabIndex = 10;
			this.rbDigitalCamera.Text = "Digital";
			this.rbDigitalCamera.UseVisualStyleBackColor = true;
			this.rbDigitalCamera.Click += new System.EventHandler(this.CameraTypeChanged);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.pnlAnalogueCameraSettings);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(524, 287);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Analogue Camera Settings";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// pnlAnalogueCameraSettings
			// 
			this.pnlAnalogueCameraSettings.Controls.Add(this.label5);
			this.pnlAnalogueCameraSettings.Controls.Add(this.groupBox2);
			this.pnlAnalogueCameraSettings.Controls.Add(this.tbxVideoCaptureDeviceName);
			this.pnlAnalogueCameraSettings.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlAnalogueCameraSettings.Location = new System.Drawing.Point(3, 3);
			this.pnlAnalogueCameraSettings.Name = "pnlAnalogueCameraSettings";
			this.pnlAnalogueCameraSettings.Size = new System.Drawing.Size(518, 281);
			this.pnlAnalogueCameraSettings.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(15, 11);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(142, 13);
			this.label5.TabIndex = 2;
			this.label5.Text = "Video Capture Device Name";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.rbVideoFrameRateNTSC);
			this.groupBox2.Controls.Add(this.rbVideoFrameRatePAL);
			this.groupBox2.Location = new System.Drawing.Point(18, 72);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(237, 48);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Video Frame Rate";
			// 
			// rbVideoFrameRateNTSC
			// 
			this.rbVideoFrameRateNTSC.AutoSize = true;
			this.rbVideoFrameRateNTSC.Location = new System.Drawing.Point(123, 20);
			this.rbVideoFrameRateNTSC.Name = "rbVideoFrameRateNTSC";
			this.rbVideoFrameRateNTSC.Size = new System.Drawing.Size(107, 17);
			this.rbVideoFrameRateNTSC.TabIndex = 1;
			this.rbVideoFrameRateNTSC.Text = "29.97 fps (NTSC)";
			this.rbVideoFrameRateNTSC.UseVisualStyleBackColor = true;
			// 
			// rbVideoFrameRatePAL
			// 
			this.rbVideoFrameRatePAL.AutoSize = true;
			this.rbVideoFrameRatePAL.Checked = true;
			this.rbVideoFrameRatePAL.Location = new System.Drawing.Point(16, 20);
			this.rbVideoFrameRatePAL.Name = "rbVideoFrameRatePAL";
			this.rbVideoFrameRatePAL.Size = new System.Drawing.Size(83, 17);
			this.rbVideoFrameRatePAL.TabIndex = 0;
			this.rbVideoFrameRatePAL.TabStop = true;
			this.rbVideoFrameRatePAL.Text = "25 fps (PAL)";
			this.rbVideoFrameRatePAL.UseVisualStyleBackColor = true;
			// 
			// tbxVideoCaptureDeviceName
			// 
			this.tbxVideoCaptureDeviceName.Location = new System.Drawing.Point(18, 27);
			this.tbxVideoCaptureDeviceName.Name = "tbxVideoCaptureDeviceName";
			this.tbxVideoCaptureDeviceName.Size = new System.Drawing.Size(247, 20);
			this.tbxVideoCaptureDeviceName.TabIndex = 3;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.pnlIntegratingCameraSettings);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(524, 287);
			this.tabPage1.TabIndex = 2;
			this.tabPage1.Text = "Integrating Camera Settings";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// pnlIntegratingCameraSettings
			// 
			this.pnlIntegratingCameraSettings.Controls.Add(this.label4);
			this.pnlIntegratingCameraSettings.Controls.Add(this.label3);
			this.pnlIntegratingCameraSettings.Controls.Add(this.nudMaxExposureSec);
			this.pnlIntegratingCameraSettings.Controls.Add(this.nudMinExposureSec);
			this.pnlIntegratingCameraSettings.Controls.Add(this.tbxSupportedExposures);
			this.pnlIntegratingCameraSettings.Controls.Add(this.label9);
			this.pnlIntegratingCameraSettings.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlIntegratingCameraSettings.Location = new System.Drawing.Point(3, 3);
			this.pnlIntegratingCameraSettings.Name = "pnlIntegratingCameraSettings";
			this.pnlIntegratingCameraSettings.Size = new System.Drawing.Size(518, 281);
			this.pnlIntegratingCameraSettings.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(105, 191);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(74, 13);
			this.label4.TabIndex = 15;
			this.label4.Text = "Max Exposure";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 191);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 13);
			this.label3.TabIndex = 14;
			this.label3.Text = "Min Exposure";
			// 
			// nudMaxExposureSec
			// 
			this.nudMaxExposureSec.DecimalPlaces = 3;
			this.nudMaxExposureSec.Location = new System.Drawing.Point(108, 208);
			this.nudMaxExposureSec.Name = "nudMaxExposureSec";
			this.nudMaxExposureSec.Size = new System.Drawing.Size(72, 20);
			this.nudMaxExposureSec.TabIndex = 13;
			// 
			// nudMinExposureSec
			// 
			this.nudMinExposureSec.DecimalPlaces = 3;
			this.nudMinExposureSec.Location = new System.Drawing.Point(16, 208);
			this.nudMinExposureSec.Name = "nudMinExposureSec";
			this.nudMinExposureSec.Size = new System.Drawing.Size(72, 20);
			this.nudMinExposureSec.TabIndex = 12;
			// 
			// tbxSupportedExposures
			// 
			this.tbxSupportedExposures.Location = new System.Drawing.Point(16, 27);
			this.tbxSupportedExposures.Multiline = true;
			this.tbxSupportedExposures.Name = "tbxSupportedExposures";
			this.tbxSupportedExposures.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbxSupportedExposures.Size = new System.Drawing.Size(247, 146);
			this.tbxSupportedExposures.TabIndex = 5;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(13, 11);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(134, 13);
			this.label9.TabIndex = 4;
			this.label9.Text = "Supported Exposure Rates";
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.cbxShowCompressionDialog);
			this.tabPage3.Controls.Add(this.pnlBufferingControls);
			this.tabPage3.Controls.Add(this.cbxBuffering);
			this.tabPage3.Controls.Add(this.pnlUserBitmaps);
			this.tabPage3.Controls.Add(this.rbUserBitmaps);
			this.tabPage3.Controls.Add(this.rbDriverDefaultSource);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(524, 287);
			this.tabPage3.TabIndex = 3;
			this.tabPage3.Text = "Video Source";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// cbxShowCompressionDialog
			// 
			this.cbxShowCompressionDialog.AutoSize = true;
			this.cbxShowCompressionDialog.Location = new System.Drawing.Point(16, 236);
			this.cbxShowCompressionDialog.Name = "cbxShowCompressionDialog";
			this.cbxShowCompressionDialog.Size = new System.Drawing.Size(179, 17);
			this.cbxShowCompressionDialog.TabIndex = 23;
			this.cbxShowCompressionDialog.Text = "Show Video Compression Dialog";
			this.cbxShowCompressionDialog.UseVisualStyleBackColor = true;
			// 
			// pnlBufferingControls
			// 
			this.pnlBufferingControls.Controls.Add(this.label17);
			this.pnlBufferingControls.Controls.Add(this.nudBufferSize);
			this.pnlBufferingControls.Controls.Add(this.label16);
			this.pnlBufferingControls.Enabled = false;
			this.pnlBufferingControls.Location = new System.Drawing.Point(17, 158);
			this.pnlBufferingControls.Name = "pnlBufferingControls";
			this.pnlBufferingControls.Size = new System.Drawing.Size(236, 39);
			this.pnlBufferingControls.TabIndex = 11;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(136, 12);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(38, 13);
			this.label17.TabIndex = 2;
			this.label17.Text = "frames";
			// 
			// nudBufferSize
			// 
			this.nudBufferSize.Location = new System.Drawing.Point(75, 8);
			this.nudBufferSize.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
			this.nudBufferSize.Name = "nudBufferSize";
			this.nudBufferSize.Size = new System.Drawing.Size(55, 20);
			this.nudBufferSize.TabIndex = 1;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(14, 12);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(59, 13);
			this.label16.TabIndex = 0;
			this.label16.Text = "Buffer size:";
			// 
			// cbxBuffering
			// 
			this.cbxBuffering.AutoSize = true;
			this.cbxBuffering.Location = new System.Drawing.Point(16, 136);
			this.cbxBuffering.Name = "cbxBuffering";
			this.cbxBuffering.Size = new System.Drawing.Size(89, 17);
			this.cbxBuffering.TabIndex = 10;
			this.cbxBuffering.Text = "Use buffering";
			this.cbxBuffering.UseVisualStyleBackColor = true;
			this.cbxBuffering.CheckedChanged += new System.EventHandler(this.cbxBuffering_CheckedChanged);
			// 
			// pnlUserBitmaps
			// 
			this.pnlUserBitmaps.Controls.Add(this.tbxBitmapFolder);
			this.pnlUserBitmaps.Controls.Add(this.label10);
			this.pnlUserBitmaps.Controls.Add(this.btnBrowseForFolder);
			this.pnlUserBitmaps.Enabled = false;
			this.pnlUserBitmaps.Location = new System.Drawing.Point(7, 60);
			this.pnlUserBitmaps.Name = "pnlUserBitmaps";
			this.pnlUserBitmaps.Size = new System.Drawing.Size(511, 54);
			this.pnlUserBitmaps.TabIndex = 9;
			// 
			// tbxBitmapFolder
			// 
			this.tbxBitmapFolder.Location = new System.Drawing.Point(27, 23);
			this.tbxBitmapFolder.Name = "tbxBitmapFolder";
			this.tbxBitmapFolder.Size = new System.Drawing.Size(428, 20);
			this.tbxBitmapFolder.TabIndex = 5;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(24, 7);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(255, 13);
			this.label10.TabIndex = 4;
			this.label10.Text = "Location of the BMP files to be used as video frames";
			// 
			// btnBrowseForFolder
			// 
			this.btnBrowseForFolder.Location = new System.Drawing.Point(461, 21);
			this.btnBrowseForFolder.Name = "btnBrowseForFolder";
			this.btnBrowseForFolder.Size = new System.Drawing.Size(31, 23);
			this.btnBrowseForFolder.TabIndex = 6;
			this.btnBrowseForFolder.Text = "...";
			this.btnBrowseForFolder.UseVisualStyleBackColor = true;
			this.btnBrowseForFolder.Click += new System.EventHandler(this.btnBrowseForFolder_Click);
			// 
			// rbUserBitmaps
			// 
			this.rbUserBitmaps.AutoSize = true;
			this.rbUserBitmaps.Location = new System.Drawing.Point(16, 36);
			this.rbUserBitmaps.Name = "rbUserBitmaps";
			this.rbUserBitmaps.Size = new System.Drawing.Size(152, 17);
			this.rbUserBitmaps.TabIndex = 8;
			this.rbUserBitmaps.Text = "User supplied video frames";
			this.rbUserBitmaps.UseVisualStyleBackColor = true;
			// 
			// rbDriverDefaultSource
			// 
			this.rbDriverDefaultSource.AutoSize = true;
			this.rbDriverDefaultSource.Checked = true;
			this.rbDriverDefaultSource.Location = new System.Drawing.Point(16, 13);
			this.rbDriverDefaultSource.Name = "rbDriverDefaultSource";
			this.rbDriverDefaultSource.Size = new System.Drawing.Size(446, 17);
			this.rbDriverDefaultSource.TabIndex = 7;
			this.rbDriverDefaultSource.TabStop = true;
			this.rbDriverDefaultSource.Text = "Driver supplied - Occultation of TYC 6849-01777-1 by (25631) 2000AJ55 on 20 Aug 2" +
    "007";
			this.rbDriverDefaultSource.UseVisualStyleBackColor = true;
			this.rbDriverDefaultSource.CheckedChanged += new System.EventHandler(this.rbDriverDefaultSource_CheckedChanged);
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.groupBox3);
			this.tabPage4.Controls.Add(this.pnlRangeGain);
			this.tabPage4.Controls.Add(this.pnlDiscreteGain);
			this.tabPage4.Controls.Add(this.rbDiscreteGain);
			this.tabPage4.Controls.Add(this.rbGainRange);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(524, 287);
			this.tabPage4.TabIndex = 4;
			this.tabPage4.Text = "Gain & Gamma";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// pnlRangeGain
			// 
			this.pnlRangeGain.Controls.Add(this.label1);
			this.pnlRangeGain.Controls.Add(this.nudMinGain);
			this.pnlRangeGain.Controls.Add(this.nudMaxGain);
			this.pnlRangeGain.Controls.Add(this.label11);
			this.pnlRangeGain.Location = new System.Drawing.Point(26, 199);
			this.pnlRangeGain.Name = "pnlRangeGain";
			this.pnlRangeGain.Size = new System.Drawing.Size(179, 61);
			this.pnlRangeGain.TabIndex = 19;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(98, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 13);
			this.label1.TabIndex = 15;
			this.label1.Text = "Max Gain";
			// 
			// nudMinGain
			// 
			this.nudMinGain.Location = new System.Drawing.Point(9, 23);
			this.nudMinGain.Name = "nudMinGain";
			this.nudMinGain.Size = new System.Drawing.Size(72, 20);
			this.nudMinGain.TabIndex = 12;
			// 
			// nudMaxGain
			// 
			this.nudMaxGain.Location = new System.Drawing.Point(101, 23);
			this.nudMaxGain.Name = "nudMaxGain";
			this.nudMaxGain.Size = new System.Drawing.Size(72, 20);
			this.nudMaxGain.TabIndex = 13;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(6, 6);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(49, 13);
			this.label11.TabIndex = 14;
			this.label11.Text = "Min Gain";
			// 
			// pnlDiscreteGain
			// 
			this.pnlDiscreteGain.Controls.Add(this.tbxSupportedGains);
			this.pnlDiscreteGain.Location = new System.Drawing.Point(26, 29);
			this.pnlDiscreteGain.Name = "pnlDiscreteGain";
			this.pnlDiscreteGain.Size = new System.Drawing.Size(207, 132);
			this.pnlDiscreteGain.TabIndex = 18;
			// 
			// tbxSupportedGains
			// 
			this.tbxSupportedGains.Location = new System.Drawing.Point(9, 3);
			this.tbxSupportedGains.Multiline = true;
			this.tbxSupportedGains.Name = "tbxSupportedGains";
			this.tbxSupportedGains.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbxSupportedGains.Size = new System.Drawing.Size(186, 126);
			this.tbxSupportedGains.TabIndex = 4;
			// 
			// rbDiscreteGain
			// 
			this.rbDiscreteGain.AutoSize = true;
			this.rbDiscreteGain.Location = new System.Drawing.Point(11, 6);
			this.rbDiscreteGain.Name = "rbDiscreteGain";
			this.rbDiscreteGain.Size = new System.Drawing.Size(121, 17);
			this.rbDiscreteGain.TabIndex = 17;
			this.rbDiscreteGain.Text = "Discrete gain values";
			this.rbDiscreteGain.UseVisualStyleBackColor = true;
			// 
			// rbGainRange
			// 
			this.rbGainRange.AutoSize = true;
			this.rbGainRange.Checked = true;
			this.rbGainRange.Location = new System.Drawing.Point(11, 179);
			this.rbGainRange.Name = "rbGainRange";
			this.rbGainRange.Size = new System.Drawing.Size(126, 17);
			this.rbGainRange.TabIndex = 16;
			this.rbGainRange.TabStop = true;
			this.rbGainRange.Text = "Range of gain values";
			this.rbGainRange.UseVisualStyleBackColor = true;
			// 
			// btnReset
			// 
			this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnReset.Location = new System.Drawing.Point(555, 192);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(59, 25);
			this.btnReset.TabIndex = 5;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.pnlRangeGamma);
			this.groupBox3.Controls.Add(this.rbGammaRange);
			this.groupBox3.Controls.Add(this.rbDiscreteGamma);
			this.groupBox3.Controls.Add(this.tbxSupportedGammas);
			this.groupBox3.Location = new System.Drawing.Point(248, -1);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(268, 272);
			this.groupBox3.TabIndex = 24;
			this.groupBox3.TabStop = false;
			// 
			// rbDiscreteGamma
			// 
			this.rbDiscreteGamma.AutoSize = true;
			this.rbDiscreteGamma.Checked = true;
			this.rbDiscreteGamma.Location = new System.Drawing.Point(10, 11);
			this.rbDiscreteGamma.Name = "rbDiscreteGamma";
			this.rbDiscreteGamma.Size = new System.Drawing.Size(135, 17);
			this.rbDiscreteGamma.TabIndex = 26;
			this.rbDiscreteGamma.Text = "Discrete gamma values";
			this.rbDiscreteGamma.UseVisualStyleBackColor = true;
			// 
			// tbxSupportedGammas
			// 
			this.tbxSupportedGammas.Location = new System.Drawing.Point(19, 34);
			this.tbxSupportedGammas.Multiline = true;
			this.tbxSupportedGammas.Name = "tbxSupportedGammas";
			this.tbxSupportedGammas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbxSupportedGammas.Size = new System.Drawing.Size(186, 129);
			this.tbxSupportedGammas.TabIndex = 24;
			this.toolTip1.SetToolTip(this.tbxSupportedGammas, "NOTE: This driver supports the values \'LO\', \'HI\', \'OFF\', a number: 0.33 or a name" +
        " and number in brackets: MAX (0.25)");
			// 
			// pnlRangeGamma
			// 
			this.pnlRangeGamma.Controls.Add(this.label12);
			this.pnlRangeGamma.Controls.Add(this.nudMinGamma);
			this.pnlRangeGamma.Controls.Add(this.nudMaxGamma);
			this.pnlRangeGamma.Controls.Add(this.label18);
			this.pnlRangeGamma.Location = new System.Drawing.Point(22, 200);
			this.pnlRangeGamma.Name = "pnlRangeGamma";
			this.pnlRangeGamma.Size = new System.Drawing.Size(179, 61);
			this.pnlRangeGamma.TabIndex = 28;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(98, 6);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(66, 13);
			this.label12.TabIndex = 15;
			this.label12.Text = "Max Gamma";
			// 
			// nudMinGamma
			// 
			this.nudMinGamma.Location = new System.Drawing.Point(9, 23);
			this.nudMinGamma.Name = "nudMinGamma";
			this.nudMinGamma.Size = new System.Drawing.Size(72, 20);
			this.nudMinGamma.TabIndex = 12;
			// 
			// nudMaxGamma
			// 
			this.nudMaxGamma.Location = new System.Drawing.Point(101, 23);
			this.nudMaxGamma.Name = "nudMaxGamma";
			this.nudMaxGamma.Size = new System.Drawing.Size(72, 20);
			this.nudMaxGamma.TabIndex = 13;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(6, 6);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(63, 13);
			this.label18.TabIndex = 14;
			this.label18.Text = "Min Gamma";
			// 
			// rbGammaRange
			// 
			this.rbGammaRange.AutoSize = true;
			this.rbGammaRange.Location = new System.Drawing.Point(7, 180);
			this.rbGammaRange.Name = "rbGammaRange";
			this.rbGammaRange.Size = new System.Drawing.Size(140, 17);
			this.rbGammaRange.TabIndex = 27;
			this.rbGammaRange.Text = "Range of gamma values";
			this.rbGammaRange.UseVisualStyleBackColor = true;
			this.rbGammaRange.CheckedChanged += new System.EventHandler(this.rbGammaRange_CheckedChanged);
			// 
			// frmSetupDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 333);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.picASCOM);
			this.Controls.Add(this.cmdCancel);
			this.Controls.Add(this.cmdOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSetupDialog";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Simulator Setup";
			this.Load += new System.EventHandler(this.frmSetupDialog_Load);
			((System.ComponentModel.ISupportInitialize)(this.picASCOM)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabGeneral.ResumeLayout(false);
			this.tabGeneral.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudPixelSizeY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudPixelSizeX)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.pnlAnalogueCameraSettings.ResumeLayout(false);
			this.pnlAnalogueCameraSettings.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.tabPage1.ResumeLayout(false);
			this.pnlIntegratingCameraSettings.ResumeLayout(false);
			this.pnlIntegratingCameraSettings.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudMaxExposureSec)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMinExposureSec)).EndInit();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.pnlBufferingControls.ResumeLayout(false);
			this.pnlBufferingControls.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudBufferSize)).EndInit();
			this.pnlUserBitmaps.ResumeLayout(false);
			this.pnlUserBitmaps.PerformLayout();
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			this.pnlRangeGain.ResumeLayout(false);
			this.pnlRangeGain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudMinGain)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMaxGain)).EndInit();
			this.pnlDiscreteGain.ResumeLayout(false);
			this.pnlDiscreteGain.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.pnlRangeGamma.ResumeLayout(false);
			this.pnlRangeGamma.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudMinGamma)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMaxGamma)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button cmdOK;
		private System.Windows.Forms.Button cmdCancel;
		private System.Windows.Forms.PictureBox picASCOM;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabGeneral;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cbxSensorType;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbxSensorName;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cbxBitDepth;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.RadioButton rbAnalogueNonIntegrating;
		private System.Windows.Forms.RadioButton rbAnalogueIntegrating;
		private System.Windows.Forms.RadioButton rbVideoSystem;
		private System.Windows.Forms.RadioButton rbDigitalCamera;
		private System.Windows.Forms.TextBox tbxSupportedActionsList;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Panel pnlAnalogueCameraSettings;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton rbVideoFrameRateNTSC;
		private System.Windows.Forms.RadioButton rbVideoFrameRatePAL;
		private System.Windows.Forms.TextBox tbxVideoCaptureDeviceName;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Panel pnlIntegratingCameraSettings;
		private System.Windows.Forms.TextBox tbxSupportedExposures;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Button btnBrowseForFolder;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox tbxBitmapFolder;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.NumericUpDown nudMaxGain;
		private System.Windows.Forms.NumericUpDown nudMinGain;
		private System.Windows.Forms.RadioButton rbDiscreteGain;
		private System.Windows.Forms.RadioButton rbGainRange;
		private System.Windows.Forms.Panel pnlRangeGain;
		private System.Windows.Forms.Panel pnlDiscreteGain;
		private System.Windows.Forms.TextBox tbxSupportedGains;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.NumericUpDown nudPixelSizeY;
		private System.Windows.Forms.NumericUpDown nudPixelSizeX;
		private System.Windows.Forms.Panel pnlUserBitmaps;
		private System.Windows.Forms.RadioButton rbUserBitmaps;
		private System.Windows.Forms.RadioButton rbDriverDefaultSource;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown nudMaxExposureSec;
		private System.Windows.Forms.NumericUpDown nudMinExposureSec;
		private System.Windows.Forms.Panel pnlBufferingControls;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.NumericUpDown nudBufferSize;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.CheckBox cbxBuffering;
		private System.Windows.Forms.CheckBox cbxShowCompressionDialog;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Panel pnlRangeGamma;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.NumericUpDown nudMinGamma;
		private System.Windows.Forms.NumericUpDown nudMaxGamma;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.RadioButton rbGammaRange;
		private System.Windows.Forms.RadioButton rbDiscreteGamma;
		private System.Windows.Forms.TextBox tbxSupportedGammas;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}