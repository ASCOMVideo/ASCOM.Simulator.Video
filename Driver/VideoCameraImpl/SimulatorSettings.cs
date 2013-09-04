using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using ASCOM.Simulator.Properties;
using Microsoft.Win32;

namespace Simulator.VideoCameraImpl
{


	public class SimulatorSettings
	{
		private static string REGISTRY_SUBKEY_NAME = @"Software\ASCOM\VideoCameraSimulator";

		private const string DEFAULT_VIDEO_CAPTURE_DEVICE_NAME = "Simulated Video Capture Device";
		private const string DEFAULT_SUPPORTED_ACTIONS_LIST = "SimulatedAction1\r\nSimulatedAction2";
		private const double DEFAULT_EXPOSURE_MAX = 8.0;
		private const double DEFAULT_EXPOSURE_MIN = 1 / 30.0;
		private const SiumulatedCameraType DEFAULT_CAMERA_TYPE = SiumulatedCameraType.AnalogueNonIntegrating;
		private const AnalogueCameraFrameRate DEFAULT_CAMERA_FRAME_RATE = AnalogueCameraFrameRate.PAL;
		private const string DEFAULT_SUPPORTED_EXPOSURES_LIST = "0.04,0.08,0.16,0.32,0.64,1.28,2.56,5.12,10.24";
		private const string DEFAULT_SENSOR_NAME = "ICX285AL";
		private static string DEFAULT_SENSOR_TYPE = ASCOM.DeviceInterface.SensorType.Monochrome.ToString();
		private const int DEFAULT_BIT_DEPTH = 8;
		private const string DEFAULT_BITMAPS_LOCATION = "./VideoCameraSimulatorImages";

		private SimulatorSettings()
		{ }

		public static SimulatorSettings Instance = new SimulatorSettings();


		public string VideoCaptureDeviceName;
		public string SupportedActionsList;
		public string SupportedExposuresList;
		public double ExposureMax;
		public double ExposureMin;
		public SiumulatedCameraType CameraType;
		public AnalogueCameraFrameRate CameraFrameRate;
		public string SensorName;
		public string SensorType;
		public int BitDepth;
		public string SourceBitmapFilesLocation;

		private RegistryKey EnsureRegistryKey()
		{
			RegistryKey key = Registry.CurrentUser.OpenSubKey(REGISTRY_SUBKEY_NAME, true);
			if (key == null)
				key = Registry.CurrentUser.CreateSubKey(REGISTRY_SUBKEY_NAME, RegistryKeyPermissionCheck.ReadWriteSubTree);

			return key;
		}

		public void Load()
		{
			using(RegistryKey key = EnsureRegistryKey())
			{
				VideoCaptureDeviceName = (string)key.GetValue("VideoCaptureDeviceName", DEFAULT_VIDEO_CAPTURE_DEVICE_NAME);
				SupportedActionsList = (string)key.GetValue("SupportedActionsList", DEFAULT_SUPPORTED_ACTIONS_LIST);
				ExposureMin = double.Parse((string)key.GetValue("ExposureMin", DEFAULT_EXPOSURE_MIN), CultureInfo.InvariantCulture);
				ExposureMax = double.Parse((string)key.GetValue("ExposureMax", DEFAULT_EXPOSURE_MAX), CultureInfo.InvariantCulture);
				CameraType = (SiumulatedCameraType)key.GetValue("CameraType", DEFAULT_CAMERA_TYPE);
				CameraFrameRate = (AnalogueCameraFrameRate)key.GetValue("CameraFrameRate", DEFAULT_CAMERA_FRAME_RATE);
				SupportedExposuresList = (string)key.GetValue("SupportedExposuresList", DEFAULT_SUPPORTED_EXPOSURES_LIST);
				SensorName = (string)key.GetValue("SensorName", DEFAULT_SENSOR_NAME);
				SensorType = (string)key.GetValue("SensorType", DEFAULT_SENSOR_TYPE);
				BitDepth = (int)key.GetValue("BitDepth", DEFAULT_BIT_DEPTH);
				SourceBitmapFilesLocation = (string)key.GetValue("SourceBitmapFilesLocation", DEFAULT_BITMAPS_LOCATION);
			}
		}

		public void Save()
		{
			using (RegistryKey key = EnsureRegistryKey())
			{
				key.SetValue("VideoCaptureDeviceName", VideoCaptureDeviceName);
				key.SetValue("SupportedActionsList", SupportedActionsList);
				key.SetValue("ExposureMin", ExposureMin.ToString(CultureInfo.InvariantCulture));
				key.SetValue("ExposureMax", ExposureMax.ToString(CultureInfo.InvariantCulture));
				key.SetValue("CameraType", (int)CameraType);
				key.SetValue("CameraFrameRate", (int)CameraFrameRate);
				key.SetValue("SupportedExposuresList", SupportedExposuresList);
				key.SetValue("SensorName", SensorName);
				key.SetValue("SensorType", SensorType);
				key.SetValue("BitDepth", BitDepth);
				key.SetValue("SourceBitmapFilesLocation", SourceBitmapFilesLocation);
			}
		}

		public void Reset()
		{
			VideoCaptureDeviceName = DEFAULT_VIDEO_CAPTURE_DEVICE_NAME;
			SupportedActionsList = DEFAULT_SUPPORTED_ACTIONS_LIST;
			ExposureMin = DEFAULT_EXPOSURE_MIN;
			ExposureMax = DEFAULT_EXPOSURE_MAX;
			CameraType = DEFAULT_CAMERA_TYPE;
			CameraFrameRate = DEFAULT_CAMERA_FRAME_RATE;
			SupportedExposuresList = DEFAULT_SUPPORTED_EXPOSURES_LIST;
			SensorName = DEFAULT_SENSOR_NAME;
			SensorType = DEFAULT_SENSOR_TYPE;
			BitDepth = DEFAULT_BIT_DEPTH;
			SourceBitmapFilesLocation = DEFAULT_BITMAPS_LOCATION;
		}
	}
}
