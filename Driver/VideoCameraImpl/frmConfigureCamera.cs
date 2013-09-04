using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ASCOM.DeviceInterface;
using ASCOM.Simulator.Properties;

namespace Simulator.VideoCameraImpl
{
	public partial class frmConfigureCamera : Form
	{
		public frmConfigureCamera()
		{
			InitializeComponent();

			SimulatorSettings.Instance.Load();

			cbxSensorType.Items.Clear();
			cbxSensorType.Items.AddRange(
				Enum.GetValues(typeof(SensorType))
				.Cast<SensorType>()
				.Select(x => (object)x.ToString())
				.ToArray()
			);

			LoadSettings();
		}

		private void LoadSettings()
		{
			tbxVideoCaptureDeviceName.Text = SimulatorSettings.Instance.VideoCaptureDeviceName;
			tbxSupportedActionsList.Text = SimulatorSettings.Instance.SupportedActionsList;
			nudMinExposureSec.Value = (decimal)SimulatorSettings.Instance.ExposureMin;
			nudMaxExposureSec.Value = (decimal)SimulatorSettings.Instance.ExposureMax;

			switch(SimulatorSettings.Instance.CameraType)
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

			rbVideoFrameRatePAL.Checked = SimulatorSettings.Instance.CameraFrameRate == AnalogueCameraFrameRate.PAL;
			rbVideoFrameRateNTSC.Checked = SimulatorSettings.Instance.CameraFrameRate == AnalogueCameraFrameRate.NTSC;

			tbxSupportedExposures.Text = SimulatorSettings.Instance.SupportedExposuresList;
			tbxSensorName.Text = SimulatorSettings.Instance.SensorName;

			string selectedSensor = Enum.GetValues(typeof(SensorType))
				.Cast<SensorType>()
				.SingleOrDefault(x => string.Equals(x.ToString(), SimulatorSettings.Instance.SensorType))
				.ToString();

			cbxSensorType.SelectedIndex = cbxSensorType.Items.IndexOf(selectedSensor);
			SetBitDepthSelection(SimulatorSettings.Instance.BitDepth);
			tbxBitmapFolder.Text = SimulatorSettings.Instance.SourceBitmapFilesLocation;
		}

		private bool SaveSettings()
		{
			SimulatorSettings.Instance.VideoCaptureDeviceName = tbxVideoCaptureDeviceName.Text;
			SimulatorSettings.Instance.SupportedActionsList = tbxSupportedActionsList.Text;
			SimulatorSettings.Instance.ExposureMin = (double)nudMinExposureSec.Value;
			SimulatorSettings.Instance.ExposureMax = (double)nudMaxExposureSec.Value;

			if (rbAnalogueNonIntegrating.Checked)
				SimulatorSettings.Instance.CameraType = SiumulatedCameraType.AnalogueNonIntegrating;
			else if (rbAnalogueIntegrating.Checked)
				SimulatorSettings.Instance.CameraType = SiumulatedCameraType.AnalogueIntegrating;
			else if (rbDigitalCamera.Checked)
				SimulatorSettings.Instance.CameraType = SiumulatedCameraType.Digital;
			else if (rbVideoSystem.Checked)
				SimulatorSettings.Instance.CameraType = SiumulatedCameraType.VideoSystem;

			SimulatorSettings.Instance.CameraFrameRate = rbVideoFrameRatePAL.Checked 
				? AnalogueCameraFrameRate.PAL
				: AnalogueCameraFrameRate.NTSC;

			SimulatorSettings.Instance.SupportedExposuresList = tbxSupportedExposures.Text;
			SimulatorSettings.Instance.SensorName = tbxSensorName.Text;
			SimulatorSettings.Instance.SensorType = cbxSensorType.Text;
			SimulatorSettings.Instance.BitDepth = GetBitDepthSelection();

			if (!ValidateBitmapFilesLocation())
				return false;

			SimulatorSettings.Instance.SourceBitmapFilesLocation = tbxBitmapFolder.Text;

			return true;
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

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (SaveSettings())
			{
				SimulatorSettings.Instance.Save();
				DialogResult = DialogResult.OK;

				Close();				
			}
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			SimulatorSettings.Instance.Reset();

			LoadSettings();
		}

		private void CameraTypeChanged(object sender, EventArgs e)
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

		private void btnBrowseForFolder_Click(object sender, EventArgs e)
		{
			folderBrowserDialog.SelectedPath = tbxBitmapFolder.Text;
			if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
				tbxBitmapFolder.Text = folderBrowserDialog.SelectedPath;
		}
	}
}
