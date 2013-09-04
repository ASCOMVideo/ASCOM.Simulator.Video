//tabs=4
// --------------------------------------------------------------------------------
//
// ASCOM Video - Late Binding COM IVideo Wrapper
//
// Description:	A wrapper of the IVideo COM interface that works via late binding
//
// Author:		(HDP) Hristo Pavlov <hristo_dpavlov@yahoo.com>
//
// --------------------------------------------------------------------------------
//

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using ASCOM.DeviceInterface;
using ASCOM.Utilities;

namespace ASCOM.DriverAccess
{
	[DebuggerStepThrough]
	public class Video : IVideo
	{
		private Type comType;
		private object comObject;

		public Video(string deviceProgId)
		{
			comType = Type.GetTypeFromProgID(deviceProgId);
			comObject = Activator.CreateInstance(comType);
		}

		public string VideoCaptureDeviceName
		{
			get
			{
				return TargetInvocationShield(() => 
					Convert.ToString(comType.InvokeMember("VideoCaptureDeviceName", BindingFlags.GetProperty, (Binder)null, comObject, new object[0], CultureInfo.InvariantCulture)));
			}
		}

		public double ExposureMax
		{
			get
			{
				return TargetInvocationShield(() => 
					Convert.ToDouble(comType.InvokeMember("ExposureMax", BindingFlags.GetProperty, (Binder)null, comObject, new object[0], CultureInfo.InvariantCulture)));
			}
		}

		public double ExposureMin
		{
			get
			{
				return TargetInvocationShield(() => 
					Convert.ToDouble(comType.InvokeMember("ExposureMin", BindingFlags.GetProperty, (Binder)null, comObject, new object[0], CultureInfo.InvariantCulture)));
			}
		}

		public VideoCameraFrameRate FrameRate
		{
			get
			{
				return TargetInvocationShield(() => 
					(VideoCameraFrameRate)Convert.ToInt32(comType.InvokeMember("FrameRate", BindingFlags.GetProperty, (Binder)null, comObject, new object[0], CultureInfo.InvariantCulture)));
			}
		}

		public System.Collections.ArrayList SupportedIntegrationRates
		{
			get
			{
				return TargetInvocationShield(() => 
					(ArrayList)comType.InvokeMember("SupportedIntegrationRates", BindingFlags.GetProperty, (Binder)null, comObject, new object[0], CultureInfo.InvariantCulture));
			}
		}

		public int IntegrationRate
		{
			get
			{
				return TargetInvocationShield(() => 
					Convert.ToInt32(comType.InvokeMember("IntegrationRate", BindingFlags.GetProperty, (Binder)null, comObject, new object[0], CultureInfo.InvariantCulture)));
			}
			set
			{
				TargetInvocationShield(() => 
					comType.InvokeMember("IntegrationRate", BindingFlags.SetProperty, (Binder)null, comObject, new object[] { value }, CultureInfo.InvariantCulture));
			}
		}

		public IVideoFrame LastVideoFrame
		{
			get
			{
				return TargetInvocationShield(() => 
					(IVideoFrame)comType.InvokeMember("LastVideoFrame", BindingFlags.GetProperty, (Binder)null, comObject, new object[0], CultureInfo.InvariantCulture));
			}
		}

		public IVideoFrame LastVideoFrameImageArrayVariant
		{
			get
			{
				return TargetInvocationShield(() => 
					(IVideoFrame)comType.InvokeMember("LastVideoFrameImageArrayVariant", BindingFlags.GetProperty, (Binder)null, comObject, new object[0], CultureInfo.InvariantCulture));
			}
		}

		public string SensorName
		{
			get
			{
				return TargetInvocationShield(() => 
					Convert.ToString(comType.InvokeMember("SensorName", BindingFlags.GetProperty, (Binder)null, comObject, new object[0], CultureInfo.InvariantCulture)));
			}
		}

		public SensorType SensorType
		{
			get
			{
				return TargetInvocationShield(() => 
					(SensorType)Convert.ToInt32(comType.InvokeMember("SensorType", BindingFlags.GetProperty, (Binder)null, comObject, new object[0], CultureInfo.InvariantCulture)));
			}
		}

		public int CameraXSize
		{
			get
			{
				return TargetInvocationShield(() => 
					Convert.ToInt32(comType.InvokeMember("CameraXSize", BindingFlags.GetProperty, (Binder)null, comObject, new object[0], CultureInfo.InvariantCulture)));
			}
		}

		public int CameraYSize
		{
			get
			{
				return TargetInvocationShield(() => 
					Convert.ToInt32(comType.InvokeMember("CameraYSize", BindingFlags.GetProperty, (Binder)null, comObject, new object[0], CultureInfo.InvariantCulture)));
			}
		}

		public int Width
		{
			get
			{
				return TargetInvocationShield(() => 
					Convert.ToInt32(comType.InvokeMember("Width", BindingFlags.GetProperty, (Binder)null, comObject, new object[0], CultureInfo.InvariantCulture)));
			}
		}

		public int Height
		{
			get
			{
				return TargetInvocationShield(() => 
					Convert.ToInt32(comType.InvokeMember("Height", BindingFlags.GetProperty, (Binder)null, comObject, new object[0], CultureInfo.InvariantCulture)));
			}
		}

		public double PixelSizeX
		{
			get
			{
				return TargetInvocationShield(() => 
					Convert.ToDouble(comType.InvokeMember("PixelSizeX", BindingFlags.GetProperty, (Binder)null, comObject, new object[0], CultureInfo.InvariantCulture)));
			}
		}

		public double PixelSizeY
		{
			get
			{
				return TargetInvocationShield(() => 
					Convert.ToDouble(comType.InvokeMember("PixelSizeY", BindingFlags.GetProperty, (Binder)null, comObject, new object[0], CultureInfo.InvariantCulture)));
			}
		}

		public int BitDepth
		{
			get
			{
				return TargetInvocationShield(() => 
					Convert.ToInt32(comType.InvokeMember("BitDepth", BindingFlags.GetProperty, (Binder)null, comObject, new object[0], CultureInfo.InvariantCulture)));
			}
		}

		public string VideoCodec
		{
			get
			{
				return TargetInvocationShield(() => 
					Convert.ToString(comType.InvokeMember("VideoCodec", BindingFlags.GetProperty, (Binder)null, comObject, new object[0], CultureInfo.InvariantCulture)));
			}
		}

		public string VideoFileFormat
		{
			get
			{
				return TargetInvocationShield(() => 
					Convert.ToString(comType.InvokeMember("VideoFileFormat", BindingFlags.GetProperty, (Binder)null, comObject, new object[0], CultureInfo.InvariantCulture)));
			}
		}

		public int VideoFramesBufferSize
		{
			get
			{
				return TargetInvocationShield(() => 
					Convert.ToInt32(comType.InvokeMember("VideoFramesBufferSize", BindingFlags.GetProperty, (Binder)null, comObject, new object[0], CultureInfo.InvariantCulture)));
			}
		}

		public string StartRecordingVideoFile(string PreferredFileName)
		{
			return TargetInvocationShield(() => 
					Convert.ToString(comType.InvokeMember("StartRecordingVideoFile", BindingFlags.InvokeMethod, (Binder)null, comObject, new object[] { PreferredFileName }, CultureInfo.InvariantCulture)));
		}

		public void StopRecordingVideoFile()
		{
			TargetInvocationShield(() => 
					comType.InvokeMember("StopRecordingVideoFile", BindingFlags.InvokeMethod, (Binder)null, comObject, new object[0], CultureInfo.InvariantCulture));
		}

		public VideoCameraState CameraState
		{
			get
			{
				return TargetInvocationShield(() => 
					(VideoCameraState)Convert.ToInt32(comType.InvokeMember("CameraState", BindingFlags.GetProperty, (Binder)null, comObject, new object[0], CultureInfo.InvariantCulture)));
			}
		}

		public short GainMax
		{
			get
			{
				return TargetInvocationShield(() => 
					Convert.ToInt16(comType.InvokeMember("GainMax", BindingFlags.GetProperty, (Binder)null, comObject, new object[0], CultureInfo.InvariantCulture)));
			}
		}

		public short GainMin
		{
			get
			{
				return TargetInvocationShield(() => 
					Convert.ToInt16(comType.InvokeMember("GainMin", BindingFlags.GetProperty, (Binder)null, comObject, new object[0], CultureInfo.InvariantCulture)));
			}
		}

		public short Gain
		{
			get
			{
				return TargetInvocationShield(() => 
					Convert.ToInt16(comType.InvokeMember("Gain", BindingFlags.GetProperty, (Binder)null, comObject, new object[0], CultureInfo.InvariantCulture)));
			}
			set
			{
				TargetInvocationShield(() => 
					comType.InvokeMember("Gain", BindingFlags.SetProperty, (Binder)null, comObject, new object[] { value }, CultureInfo.InvariantCulture));
			}
		}

		public System.Collections.ArrayList Gains
		{
			get
			{
				return TargetInvocationShield(() => 
					(ArrayList)(comType.InvokeMember("Gains", BindingFlags.GetProperty, (Binder)null, comObject, new object[0], CultureInfo.InvariantCulture)));
			}
		}

		public int Gamma
		{
			get
			{
				return TargetInvocationShield(() => 
					Convert.ToInt32(comType.InvokeMember("Gamma", BindingFlags.GetProperty, (Binder)null, comObject, new object[0], CultureInfo.InvariantCulture)));
			}
			set
			{
				TargetInvocationShield(() => 
					comType.InvokeMember("Gamma", BindingFlags.SetProperty, (Binder)null, comObject, new object[] { value }, CultureInfo.InvariantCulture));
			}
		}

		public System.Collections.ArrayList Gammas
		{
			get
			{
				return TargetInvocationShield(() => 
					(ArrayList)comType.InvokeMember("Gammas", BindingFlags.GetProperty, (Binder)null, comObject, new object[0], CultureInfo.InvariantCulture));
			}
		}

		public bool CanConfigureImage
		{
			get
			{
				return TargetInvocationShield(() => 
					Convert.ToBoolean(comType.InvokeMember("CanConfigureImage", BindingFlags.GetProperty, (Binder)null, comObject, new object[0], CultureInfo.InvariantCulture)));
			}
		}

		public void ConfigureImage()
		{
			TargetInvocationShield(() => 
					comType.InvokeMember("ConfigureImage", BindingFlags.InvokeMethod, (Binder)null, comObject, new object[0], CultureInfo.InvariantCulture));
		}

		public bool Connected
		{
			get
			{
				return TargetInvocationShield(() => 
					Convert.ToBoolean(comType.InvokeMember("Connected", BindingFlags.GetProperty, (Binder)null, comObject, new object[0], CultureInfo.InvariantCulture)));
			}
			set
			{
				TargetInvocationShield(() => 
					comType.InvokeMember("Connected", BindingFlags.SetProperty, (Binder)null, comObject, new object[] { value }, CultureInfo.InvariantCulture));
			}
		}

		public string Description
		{
			get
			{
				return TargetInvocationShield(() => 
					Convert.ToString(comType.InvokeMember("Description", BindingFlags.GetProperty, (Binder)null, comObject, new object[0], CultureInfo.InvariantCulture)));
			}
		}

		public string DriverInfo
		{
			get
			{
				return TargetInvocationShield(() => 
					Convert.ToString(comType.InvokeMember("DriverInfo", BindingFlags.GetProperty, (Binder)null, comObject, new object[0], CultureInfo.InvariantCulture)));
			}
		}

		public string DriverVersion
		{
			get
			{
				return TargetInvocationShield(() => 
					Convert.ToString(comType.InvokeMember("DriverVersion", BindingFlags.GetProperty, (Binder)null, comObject, new object[0], CultureInfo.InvariantCulture)));
			}
		}

		public short InterfaceVersion
		{
			get
			{
				return TargetInvocationShield(() => 
					Convert.ToInt16(comType.InvokeMember("InterfaceVersion", BindingFlags.GetProperty, (Binder)null, comObject, new object[0], CultureInfo.InvariantCulture)));
			}
		}

		public string Name
		{
			get
			{
				return TargetInvocationShield(() => 
					Convert.ToString(comType.InvokeMember("Name", BindingFlags.GetProperty, (Binder)null, comObject, new object[0], CultureInfo.InvariantCulture)));
			}
		}

		public void SetupDialog()
		{
			TargetInvocationShield(() =>
					comType.InvokeMember("SetupDialog", BindingFlags.InvokeMethod, (Binder) null, comObject, new object[0], CultureInfo.InvariantCulture));
		}

		public string Action(string ActionName, string ActionParameters)
		{
			return TargetInvocationShield(() => 
					Convert.ToString(comType.InvokeMember("Action", BindingFlags.InvokeMethod, (Binder)null, comObject, new object[] { ActionName, ActionParameters }, CultureInfo.InvariantCulture)));
		}

		public ArrayList SupportedActions
		{
			get
			{
				return TargetInvocationShield(() => 
					(ArrayList)comType.InvokeMember("SupportedActions", BindingFlags.GetProperty, (Binder)null, comObject, new object[0], CultureInfo.InvariantCulture));
			}
		}

		public void Dispose()
		{
			(comObject as IDisposable).Dispose();
		}

		private TReturnType TargetInvocationShield<TReturnType>(Func<TReturnType> func)
		{
			try
			{
				return func();
			}
			catch (TargetInvocationException tex)
			{
				throw tex.InnerException;
			}
		}

		private void TargetInvocationShield(Action action)
		{
			try
			{
				action();
			}
			catch (TargetInvocationException tex)
			{
				throw tex.InnerException;
			}
		}
	}
}
