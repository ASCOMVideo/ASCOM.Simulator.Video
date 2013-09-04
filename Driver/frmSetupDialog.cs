//tabs=4
// --------------------------------------------------------------------------------
//
// ASCOM Video Driver - Simulator
//
// Description:	This is the set up form for the Video Driver Simulator 
//
// Author:		(HDP) Hristo Pavlov <hristo_dpavlov@yahoo.com>
//
// --------------------------------------------------------------------------------
//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using ASCOM.DeviceInterface;
using ASCOM.Simulator.Properties;

namespace ASCOM.Simulator
{
	[ComVisible(false)]					// Form not registered for COM!
	public partial class frmSetupDialog : Form
	{
		public frmSetupDialog()
		{
			InitializeComponent();

			cbxSensorType.Items.Clear();
			cbxSensorType.Items.AddRange(Enum.GetValues(typeof(SensorType)).Cast<SensorType>().Select(x => x.ToString()).ToArray());
		}

		private void frmSetupDialog_Load(object sender, EventArgs e)
		{
			LoadSettings();
		}

		private void cmdOK_Click(object sender, EventArgs e)
		{
			if (SaveSettings())
			{
				Properties.Settings.Default.Save();
				DialogResult = DialogResult.OK;

				Close();
			}
		}

		private void LoadSettings()
		{
			tbxVideoCaptureDeviceName.Text = Properties.Settings.Default.VideoCaptureDeviceName;
			tbxSupportedActionsList.Lines = Properties.Settings.Default.SupportedActionsList.Split(new string[] { "#;" }, StringSplitOptions.RemoveEmptyEntries);
			nudMinExposureSec.Value = (decimal)Properties.Settings.Default.ExposureMin;
			nudMaxExposureSec.Value = (decimal)Properties.Settings.Default.ExposureMax;

			switch (Properties.Settings.Default.CameraType)
			{
				case SiumulatedCameraType.AnalogueNonIntegrating:
					rbAnalogueNonIntegrating.Checked = true;
					break;

				case SiumulatedCameraType.AnalogueIntegrating:
					rbAnalogueIntegrating.Checked = true;
					break;

				case SiumulatedCameraType.Digital:
					rbDigitalCamera.Checked = true;
					break;

				case SiumulatedCameraType.VideoSystem:
					rbVideoSystem.Checked = true;
					break;
			}

			rbVideoFrameRatePAL.Checked = Properties.Settings.Default.CameraFrameRate == AnalogueCameraFrameRate.PAL;
			rbVideoFrameRateNTSC.Checked = Properties.Settings.Default.CameraFrameRate == AnalogueCameraFrameRate.NTSC;

			tbxSupportedExposures.Lines = Properties.Settings.Default.SupportedExposuresList.Split(new string[] { "#;" }, StringSplitOptions.RemoveEmptyEntries);
			tbxSensorName.Text = Properties.Settings.Default.SensorName;

			string selectedSensor = Properties.Settings.Default.SensorType.ToString();

			cbxSensorType.SelectedIndex = cbxSensorType.Items.IndexOf(selectedSensor);
			nudPixelSizeX.Value = (decimal)Properties.Settings.Default.PixelSizeX;
			nudPixelSizeY.Value = (decimal)Properties.Settings.Default.PixelSizeY;
			SetBitDepthSelection(Properties.Settings.Default.BitDepth);

			rbUserBitmaps.Checked = !Properties.Settings.Default.UseEmbeddedVideoSource;
			tbxBitmapFolder.Text = Properties.Settings.Default.SourceBitmapFilesLocation;

			rbGainRange.Checked = Properties.Settings.Default.SupportsGainRange;
			rbDiscreteGain.Checked = !Properties.Settings.Default.SupportsGainRange;
			nudMinGain.Value = Properties.Settings.Default.GainMin;
			nudMaxGain.Value = Properties.Settings.Default.GainMax;
			tbxSupportedGains.Lines = Properties.Settings.Default.Gains.Split(new string[] { "#;" }, StringSplitOptions.RemoveEmptyEntries);
			tbxSupportedGammas.Lines = Properties.Settings.Default.Gammas.Split(new string[] { "#;" }, StringSplitOptions.RemoveEmptyEntries);

			cbxBuffering.Checked = Properties.Settings.Default.UseBuffering;
			nudBufferSize.Value = Properties.Settings.Default.BufferSize;
			cbxShowCompressionDialog.Checked = Properties.Settings.Default.ShowCompressionDialog;

			UpdateControlsState();
		}

		private bool SaveSettings()
		{
			Properties.Settings.Default.VideoCaptureDeviceName = tbxVideoCaptureDeviceName.Text;
			Properties.Settings.Default.SupportedActionsList = string.Join("#;", tbxSupportedActionsList.Lines);
			Properties.Settings.Default.ExposureMin = (double)nudMinExposureSec.Value;
			Properties.Settings.Default.ExposureMax = (double)nudMaxExposureSec.Value;

			if (rbAnalogueNonIntegrating.Checked)
			    Properties.Settings.Default.CameraType = SiumulatedCameraType.AnalogueNonIntegrating;
			else if (rbAnalogueIntegrating.Checked)
			    Properties.Settings.Default.CameraType = SiumulatedCameraType.AnalogueIntegrating;
			else if (rbDigitalCamera.Checked)
				Properties.Settings.Default.CameraType = SiumulatedCameraType.Digital;
			else if (rbVideoSystem.Checked)
				Properties.Settings.Default.CameraType = SiumulatedCameraType.VideoSystem;

			Properties.Settings.Default.CameraFrameRate = rbVideoFrameRatePAL.Checked
				? AnalogueCameraFrameRate.PAL
				: AnalogueCameraFrameRate.NTSC;

			Properties.Settings.Default.SupportedExposuresList = string.Join("#;", tbxSupportedExposures.Lines);
			Properties.Settings.Default.SensorName = tbxSensorName.Text;
			Properties.Settings.Default.SensorType = (SensorType)cbxSensorType.SelectedIndex;
			Properties.Settings.Default.PixelSizeX = (double)nudPixelSizeX.Value;
			Properties.Settings.Default.PixelSizeY = (double)nudPixelSizeY.Value;
			Properties.Settings.Default.BitDepth = GetBitDepthSelection();

			if (rbUserBitmaps.Checked)
			{
				if (!ValidateBitmapFilesLocation())
					return false;

				Properties.Settings.Default.UseEmbeddedVideoSource = false;
				Properties.Settings.Default.SourceBitmapFilesLocation = tbxBitmapFolder.Text;
			}
			else
			{
				Properties.Settings.Default.UseEmbeddedVideoSource = true;
			}

			Properties.Settings.Default.SupportsGainRange = rbGainRange.Checked;
			Properties.Settings.Default.Gains = string.Join("#;", tbxSupportedGains.Lines);
			Properties.Settings.Default.Gammas = string.Join("#;", tbxSupportedGammas.Lines);
			if (Properties.Settings.Default.SupportsGainRange)
			{
				Properties.Settings.Default.GainMin = (short)nudMinGain.Value;
				Properties.Settings.Default.GainMax = (short)nudMaxGain.Value;
			}

			Properties.Settings.Default.UseBuffering = cbxBuffering.Checked;
			if (Properties.Settings.Default.UseBuffering)
				Properties.Settings.Default.BufferSize = (short)nudBufferSize.Value;

			Properties.Settings.Default.ShowCompressionDialog = cbxShowCompressionDialog.Checked;

			return true;
		}

		private void UpdateControlsState()
		{
			CameraTypeChanged();

			pnlUserBitmaps.Enabled = !rbDriverDefaultSource.Checked;
			pnlBufferingControls.Enabled = cbxBuffering.Checked;
		}

		private void CameraTypeChanged()
		{
			pnlAnalogueCameraSettings.Enabled = rbAnalogueIntegrating.Checked || rbAnalogueNonIntegrating.Checked;
			pnlIntegratingCameraSettings.Enabled = !rbAnalogueNonIntegrating.Checked;

			cbxBitDepth.Enabled = rbDigitalCamera.Checked || rbVideoSystem.Checked;
			if (rbAnalogueIntegrating.Checked || rbAnalogueNonIntegrating.Checked)
				SetBitDepthSelection(8);
		}

		private void SetBitDepthSelection(int bitDepth)
		{
			if (bitDepth == 16)
				cbxBitDepth.SelectedIndex = 2;
			else if (bitDepth == 12)
				cbxBitDepth.SelectedIndex = 1;
			else
				cbxBitDepth.SelectedIndex = 0;
		}

		private int GetBitDepthSelection()
		{
			if (cbxBitDepth.SelectedIndex == 0)
				return 8;
			else if (cbxBitDepth.SelectedIndex == 1)
				return 12;
			else if (cbxBitDepth.SelectedIndex == 2)
				return 16;

			throw new IndexOutOfRangeException();
		}

		private bool ValidateBitmapFilesLocation()
		{
			string fullPath = Path.GetFullPath(tbxBitmapFolder.Text);
			if (!Directory.Exists(fullPath))
			{
				MessageBox.Show(
					this,
					string.Format("Bitmap files location '{0}' does not exist.", fullPath),
					"Error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);

				tbxBitmapFolder.Focus();

				return false;
			}

			string[] allBitmapFiles = Directory.GetFiles(fullPath, "*.bmp");
			if (allBitmapFiles.Length == 0)
			{
				MessageBox.Show(
					this,
					string.Format("There are no bitmap files in '{0}'.", fullPath),
					"Error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);

				tbxBitmapFolder.Focus();

				return false;
			}

			return true;
		}

		private void cmdCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void BrowseToAscom(object sender, EventArgs e)
		{
			try
			{
				System.Diagnostics.Process.Start("http://ascom-standards.org/");
			}
			catch (System.ComponentModel.Win32Exception noBrowser)
			{
				if (noBrowser.ErrorCode == -2147467259)
					MessageBox.Show(noBrowser.Message);
			}
			catch (System.Exception other)
			{
				MessageBox.Show(other.Message);
			}
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			var frmReset = new frmResetSettings();
			if (frmReset.ShowDialog(this) == DialogResult.OK)
			{
				LoadSettings();
			}
		}

		private void CameraTypeChanged(object sender, EventArgs e)
		{
			CameraTypeChanged();
		}

		private void btnBrowseForFolder_Click(object sender, EventArgs e)
		{
			folderBrowserDialog.SelectedPath = tbxBitmapFolder.Text;
			if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
				tbxBitmapFolder.Text = folderBrowserDialog.SelectedPath;
		}

		private void rbDriverDefaultSource_CheckedChanged(object sender, EventArgs e)
		{
			pnlUserBitmaps.Enabled = !rbDriverDefaultSource.Checked;
		}

		private void cbxBuffering_CheckedChanged(object sender, EventArgs e)
		{
			pnlBufferingControls.Enabled = cbxBuffering.Checked;
		}
	}
}