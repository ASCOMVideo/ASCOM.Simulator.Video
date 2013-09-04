namespace Simulator.VideoCameraImpl
{
	partial class frmConfigureCamera
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabGeneral = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbAnalogueNonIntegrating = new System.Windows.Forms.RadioButton();
			this.rbAnalogueIntegrating = new System.Windows.Forms.RadioButton();
			this.rbVideoSystem = new System.Windows.Forms.RadioButton();
			this.rbDigitalCamera = new System.Windows.Forms.RadioButton();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.nudMaxExposureSec = new System.Windows.Forms.NumericUpDown();
			this.nudMinExposureSec = new System.Windows.Forms.NumericUpDown();
			this.tbxSupportedActionsList = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.pnlAnalogueCameraSettings = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rbVideoFrameRateNTSC = new System.Windows.Forms.RadioButton();
			this.rbVideoFrameRatePAL = new System.Windows.Forms.RadioButton();
			this.tbxVideoCaptureDeviceName = new System.Windows.Forms.TextBox();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.pnlIntegratingCameraSettings = new System.Windows.Forms.Panel();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.tbxSupportedExposures = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.tbxSensorName = new System.Windows.Forms.TextBox();
			this.cbxSensorType = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.cbxBitDepth = new System.Windows.Forms.ComboBox();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.label9 = new System.Windows.Forms.Label();
			this.tbxBitmapFolder = new System.Windows.Forms.TextBox();
			this.btnBrowseForFolder = new System.Windows.Forms.Button();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.tabControl1.SuspendLayout();
			this.tabGeneral.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudMaxExposureSec)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMinExposureSec)).BeginInit();
			this.tabPage2.SuspendLayout();
			this.pnlAnalogueCameraSettings.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.pnlIntegratingCameraSettings.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabGeneral);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(532, 313);
			this.tabControl1.TabIndex = 0;
			// 
			// tabGeneral
			// 
			this.tabGeneral.Controls.Add(this.label7);
			this.tabGeneral.Controls.Add(this.cbxSensorType);
			this.tabGeneral.Controls.Add(this.label6);
			this.tabGeneral.Controls.Add(this.tbxSensorName);
			this.tabGeneral.Controls.Add(this.groupBox1);
			this.tabGeneral.Controls.Add(this.label4);
			this.tabGeneral.Controls.Add(this.label3);
			this.tabGeneral.Controls.Add(this.nudMaxExposureSec);
			this.tabGeneral.Controls.Add(this.nudMinExposureSec);
			this.tabGeneral.Controls.Add(this.tbxSupportedActionsList);
			this.tabGeneral.Controls.Add(this.label2);
			this.tabGeneral.Location = new System.Drawing.Point(4, 22);
			this.tabGeneral.Name = "tabGeneral";
			this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
			this.tabGeneral.Size = new System.Drawing.Size(524, 287);
			this.tabGeneral.TabIndex = 0;
			this.tabGeneral.Text = "General";
			this.tabGeneral.UseVisualStyleBackColor = true;
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
			this.rbAnalogueNonIntegrating.CheckedChanged += new System.EventHandler(this.CameraTypeChanged);
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
			this.rbAnalogueIntegrating.CheckedChanged += new System.EventHandler(this.CameraTypeChanged);
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
			this.rbVideoSystem.CheckedChanged += new System.EventHandler(this.CameraTypeChanged);
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
			this.rbDigitalCamera.CheckedChanged += new System.EventHandler(this.CameraTypeChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(281, 223);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(74, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Max Exposure";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(281, 164);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Min Exposure";
			// 
			// nudMaxExposureSec
			// 
			this.nudMaxExposureSec.DecimalPlaces = 3;
			this.nudMaxExposureSec.Location = new System.Drawing.Point(284, 240);
			this.nudMaxExposureSec.Name = "nudMaxExposureSec";
			this.nudMaxExposureSec.Size = new System.Drawing.Size(72, 20);
			this.nudMaxExposureSec.TabIndex = 5;
			// 
			// nudMinExposureSec
			// 
			this.nudMinExposureSec.DecimalPlaces = 3;
			this.nudMinExposureSec.Location = new System.Drawing.Point(284, 181);
			this.nudMinExposureSec.Name = "nudMinExposureSec";
			this.nudMinExposureSec.Size = new System.Drawing.Size(72, 20);
			this.nudMinExposureSec.TabIndex = 4;
			// 
			// tbxSupportedActionsList
			// 
			this.tbxSupportedActionsList.Location = new System.Drawing.Point(16, 161);
			this.tbxSupportedActionsList.Multiline = true;
			this.tbxSupportedActionsList.Name = "tbxSupportedActionsList";
			this.tbxSupportedActionsList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbxSupportedActionsList.Size = new System.Drawing.Size(247, 112);
			this.tbxSupportedActionsList.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 145);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Supported Actions";
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
			this.pnlAnalogueCameraSettings.Controls.Add(this.label1);
			this.pnlAnalogueCameraSettings.Controls.Add(this.groupBox2);
			this.pnlAnalogueCameraSettings.Controls.Add(this.tbxVideoCaptureDeviceName);
			this.pnlAnalogueCameraSettings.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlAnalogueCameraSettings.Location = new System.Drawing.Point(3, 3);
			this.pnlAnalogueCameraSettings.Name = "pnlAnalogueCameraSettings";
			this.pnlAnalogueCameraSettings.Size = new System.Drawing.Size(518, 281);
			this.pnlAnalogueCameraSettings.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(142, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Video Capture Device Name";
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
			this.pnlIntegratingCameraSettings.Controls.Add(this.tbxSupportedExposures);
			this.pnlIntegratingCameraSettings.Controls.Add(this.label5);
			this.pnlIntegratingCameraSettings.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlIntegratingCameraSettings.Location = new System.Drawing.Point(3, 3);
			this.pnlIntegratingCameraSettings.Name = "pnlIntegratingCameraSettings";
			this.pnlIntegratingCameraSettings.Size = new System.Drawing.Size(518, 281);
			this.pnlIntegratingCameraSettings.TabIndex = 4;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(388, 337);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "&Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(16, 337);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(119, 23);
			this.btnReset.TabIndex = 2;
			this.btnReset.Text = "&Reset Defaults";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(469, 337);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// tbxSupportedExposures
			// 
			this.tbxSupportedExposures.Location = new System.Drawing.Point(16, 27);
			this.tbxSupportedExposures.Multiline = true;
			this.tbxSupportedExposures.Name = "tbxSupportedExposures";
			this.tbxSupportedExposures.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbxSupportedExposures.Size = new System.Drawing.Size(247, 112);
			this.tbxSupportedExposures.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(13, 11);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(134, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Supported Exposure Rates";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(15, 101);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(71, 13);
			this.label6.TabIndex = 14;
			this.label6.Text = "Sensor Name";
			// 
			// tbxSensorName
			// 
			this.tbxSensorName.Location = new System.Drawing.Point(92, 98);
			this.tbxSensorName.Name = "tbxSensorName";
			this.tbxSensorName.Size = new System.Drawing.Size(111, 20);
			this.tbxSensorName.TabIndex = 15;
			// 
			// cbxSensorType
			// 
			this.cbxSensorType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxSensorType.FormattingEnabled = true;
			this.cbxSensorType.Location = new System.Drawing.Point(315, 97);
			this.cbxSensorType.Name = "cbxSensorType";
			this.cbxSensorType.Size = new System.Drawing.Size(121, 21);
			this.cbxSensorType.TabIndex = 16;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(241, 101);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(67, 13);
			this.label7.TabIndex = 17;
			this.label7.Text = "Sensor Type";
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
			// cbxBitDepth
			// 
			this.cbxBitDepth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxBitDepth.Enabled = false;
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
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.btnBrowseForFolder);
			this.tabPage3.Controls.Add(this.label9);
			this.tabPage3.Controls.Add(this.tbxBitmapFolder);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(524, 287);
			this.tabPage3.TabIndex = 3;
			this.tabPage3.Text = "Video Source";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(19, 20);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(144, 13);
			this.label9.TabIndex = 4;
			this.label9.Text = "Source Bitmap Files Location";
			// 
			// tbxBitmapFolder
			// 
			this.tbxBitmapFolder.Location = new System.Drawing.Point(22, 36);
			this.tbxBitmapFolder.Name = "tbxBitmapFolder";
			this.tbxBitmapFolder.Size = new System.Drawing.Size(446, 20);
			this.tbxBitmapFolder.TabIndex = 5;
			// 
			// btnBrowseForFolder
			// 
			this.btnBrowseForFolder.Location = new System.Drawing.Point(474, 34);
			this.btnBrowseForFolder.Name = "btnBrowseForFolder";
			this.btnBrowseForFolder.Size = new System.Drawing.Size(31, 23);
			this.btnBrowseForFolder.TabIndex = 6;
			this.btnBrowseForFolder.Text = "...";
			this.btnBrowseForFolder.UseVisualStyleBackColor = true;
			this.btnBrowseForFolder.Click += new System.EventHandler(this.btnBrowseForFolder_Click);
			// 
			// folderBrowserDialog
			// 
			this.folderBrowserDialog.Description = "Select source bitmap files location ...";
			// 
			// frmConfigureCamera
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(556, 372);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.tabControl1);
			this.Name = "frmConfigureCamera";
			this.Text = "Configure Video Camera Simulator";
			this.tabControl1.ResumeLayout(false);
			this.tabGeneral.ResumeLayout(false);
			this.tabGeneral.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudMaxExposureSec)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMinExposureSec)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.pnlAnalogueCameraSettings.ResumeLayout(false);
			this.pnlAnalogueCameraSettings.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.tabPage1.ResumeLayout(false);
			this.pnlIntegratingCameraSettings.ResumeLayout(false);
			this.pnlIntegratingCameraSettings.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabGeneral;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TextBox tbxSupportedActionsList;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.NumericUpDown nudMaxExposureSec;
		private System.Windows.Forms.NumericUpDown nudMinExposureSec;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbVideoSystem;
		private System.Windows.Forms.RadioButton rbDigitalCamera;
		private System.Windows.Forms.RadioButton rbAnalogueIntegrating;
		private System.Windows.Forms.RadioButton rbAnalogueNonIntegrating;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton rbVideoFrameRateNTSC;
		private System.Windows.Forms.RadioButton rbVideoFrameRatePAL;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbxVideoCaptureDeviceName;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Panel pnlAnalogueCameraSettings;
		private System.Windows.Forms.Panel pnlIntegratingCameraSettings;
		private System.Windows.Forms.TextBox tbxSupportedExposures;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbxSensorName;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cbxSensorType;
		private System.Windows.Forms.ComboBox cbxBitDepth;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox tbxBitmapFolder;
		private System.Windows.Forms.Button btnBrowseForFolder;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
	}
}