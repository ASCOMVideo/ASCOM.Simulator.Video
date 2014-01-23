using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Client
{
	public class ThreadIsolatedVideoWrapper : IVideoWrapper
	{
		#region Thread-Isolated Invocation
		private class InvocationDescriptor
		{
			public Delegate Delegate;
			public object[] Arguments;
			public object ReturnValue;
			public bool InvocationCompleted;
		}

		private IVideoWrapper m_delegate;
		private static object s_SyncLock = new object();
		private static bool s_Running = false;
		private static ConcurrentQueue<InvocationDescriptor> s_Queue = new ConcurrentQueue<InvocationDescriptor>();

		static ThreadIsolatedVideoWrapper()
		{
			if (!s_Running)
			{
				lock (s_SyncLock)
				{
					if (!s_Running)
					{
						s_Running = true;
						ThreadPool.QueueUserWorkItem(WorkerThread);
					}
				}
			}
		}

		public ThreadIsolatedVideoWrapper(IVideoWrapper delegateWrapper)
		{
			m_delegate = delegateWrapper;
		}


		private static void WorkerThread(object state)
		{
			while (s_Running)
			{
				while (s_Queue.Count > 0)
				{
					InvocationDescriptor item;
					if (s_Queue.TryDequeue(out item))
					{
						item.ReturnValue = item.Delegate.DynamicInvoke(item.Arguments);
						item.InvocationCompleted = true;
					}
				}
			}
		}

		private static TResult IsolatedFunc<TResult>(Func<TResult> callback)
		{
			var item = new InvocationDescriptor()
			{
				Delegate = callback,
				Arguments = new object[] {},
				ReturnValue = null,
				InvocationCompleted = false
			};

			s_Queue.Enqueue(item);

			SpinWait.SpinUntil(() => item.InvocationCompleted);
			return (TResult)item.ReturnValue;
		}

		private TResult IsolatedFunc<TResult, T>(Func<T, TResult> callback, T value1)
		{
			var item = new InvocationDescriptor()
			{
				Delegate = callback,
				Arguments = new object[] { value1 },
				ReturnValue = null,
				InvocationCompleted = false
			};

			s_Queue.Enqueue(item);

			SpinWait.SpinUntil(() => item.InvocationCompleted);
			return (TResult)item.ReturnValue;
		}

		private TResult IsolatedFunc<TResult, T1, T2>(Func<T1, T2, TResult> callback, T1 value1, T2 value2)
		{
			var item = new InvocationDescriptor()
			{
				Delegate = callback,
				Arguments = new object[] { value1, value2 },
				ReturnValue = null,
				InvocationCompleted = false
			};

			s_Queue.Enqueue(item);

			SpinWait.SpinUntil(() => item.InvocationCompleted);
			return (TResult)item.ReturnValue;
		}

		private void IsolatedAction(Action callback)
		{
			var item = new InvocationDescriptor()
			{
				Delegate = callback,
				Arguments = new object[] { },
				ReturnValue = null,
				InvocationCompleted = false
			};

			s_Queue.Enqueue(item);

			SpinWait.SpinUntil(() => item.InvocationCompleted);
		}

		private void IsolatedAction<T>(Action<T> callback, T value1)
		{
			var item = new InvocationDescriptor()
			{
				Delegate = callback,
				Arguments = new object[] { value1 },
				ReturnValue = null,
				InvocationCompleted = false
			};

			s_Queue.Enqueue(item);

			SpinWait.SpinUntil(() => item.InvocationCompleted);
		}

		private void IsolatedAction<T1, T2>(Action<T1, T2> callback, T1 value1, T2 value2)
		{
			var item = new InvocationDescriptor()
			{
				Delegate = callback,
				Arguments = new object[] { value1, value2 },
				ReturnValue = null,
				InvocationCompleted = false
			};

			s_Queue.Enqueue(item);

			SpinWait.SpinUntil(() => item.InvocationCompleted);
		}
		#endregion


		public bool Connected
		{
			get { return IsolatedFunc(() => m_delegate.Connected); }
			set { IsolatedAction((x) => m_delegate.Connected = x, value); }
		}

		public void Disconnect()
		{
			IsolatedAction(() => m_delegate.Disconnect());
		}

		public bool IsConnected
		{
			get
			{
				return IsolatedFunc(() => m_delegate.IsConnected);
			}
		}

		public bool SupporstFreeStyleGain
		{
			get { return IsolatedFunc(() => m_delegate.SupporstFreeStyleGain); }
		}

		public void SetFreeRangeGainIntervals(short numIntervals)
		{
			IsolatedAction((x) => m_delegate.SetFreeRangeGainIntervals(x), numIntervals); 
		}

		public int Width
		{
			get { return IsolatedFunc(() => m_delegate.Width); }
		}

		public int Height
		{
			get { return IsolatedFunc(() => m_delegate.Height); }
		}

		public bool HasSupportedActions
		{
			get { return IsolatedFunc(() => m_delegate.HasSupportedActions); }
		}

		public string[] SupportedActions
		{
			get { return IsolatedFunc(() => m_delegate.SupportedActions); }
		}

		public ASCOM.DeviceInterface.VideoCameraState State
		{
			get { return IsolatedFunc(() => m_delegate.State); }
		}

		public bool CanConfigureDeviceProperties
		{
			get { return IsolatedFunc(() => m_delegate.CanConfigureDeviceProperties); }
		}

		public string CameraFrameRate
		{
			get { return IsolatedFunc(() => m_delegate.CameraFrameRate); }
		}

		public string CameraBitDepth
		{
			get { return IsolatedFunc(() => m_delegate.CameraBitDepth); }
		}

		public string CameraVideoFormat
		{
			get { return IsolatedFunc(() => m_delegate.CameraVideoFormat); }
		}

		public string BufferingInfo
		{
			get { return IsolatedFunc(() => m_delegate.BufferingInfo); }
		}

		public string DeviceName
		{
			get { return IsolatedFunc(() => m_delegate.DeviceName); }
		}

		public string VideoCaptureDeviceName
		{
			get { return IsolatedFunc(() => m_delegate.VideoCaptureDeviceName); }
		}

		public string ExecuteAction(string actionName, string actionParameters)
		{
			return IsolatedFunc((x, y) => m_delegate.ExecuteAction(x, y), actionName, actionParameters); 
		}

		public ASCOM.DeviceInterface.IVideoFrame LastVideoFrame
		{
			get { return IsolatedFunc(() => m_delegate.LastVideoFrame); }
		}

		public ASCOM.DeviceInterface.SensorType SensorType
		{
			get { return IsolatedFunc(() => m_delegate.SensorType); }
		}

		public string Gamma
		{
			get { return IsolatedFunc(() => m_delegate.Gamma); }
		}

		public bool CanIncreaseGamma
		{
			get { return IsolatedFunc(() => m_delegate.CanIncreaseGamma); }
		}

		public bool CanDecreaseGamma
		{
			get { return IsolatedFunc(() => m_delegate.CanDecreaseGamma); }
		}

		public string Gain
		{
			get { return IsolatedFunc(() => m_delegate.Gain); }
		}

		public bool CanIncreaseGain
		{
			get { return IsolatedFunc(() => m_delegate.CanIncreaseGain); }
		}

		public bool CanDecreaseGain
		{
			get { return IsolatedFunc(() => m_delegate.CanDecreaseGain); }
		}

		public string Integration
		{
			get { return IsolatedFunc(() => m_delegate.Integration); }
		}

		public bool CanIncreaseIntegration
		{
			get { return IsolatedFunc(() => m_delegate.CanIncreaseIntegration); }
		}

		public bool CanDecreaseIntegration
		{
			get { return IsolatedFunc(() => m_delegate.CanDecreaseIntegration); }
		}

		public string StartRecording(string fileName)
		{
			return IsolatedFunc((x) => m_delegate.StartRecording(x), fileName); 
		}

		public void StopRecording()
		{
			IsolatedAction(() => m_delegate.StopRecording()); 
		}

		public void IncreaseGamma()
		{
			IsolatedAction(() => m_delegate.IncreaseGamma()); 
		}

		public void DecreaseGamma()
		{
			IsolatedAction(() => m_delegate.DecreaseGamma()); 
		}

		public void DecreaseGain()
		{
			IsolatedAction(() => m_delegate.DecreaseGain()); 
		}

		public void IncreaseGain()
		{
			IsolatedAction(() => m_delegate.IncreaseGain()); 
		}

		public void DecreaseIntegration()
		{
			IsolatedAction(() => m_delegate.DecreaseIntegration()); 
		}

		public void IncreaseIntegration()
		{
			IsolatedAction(() => m_delegate.IncreaseIntegration()); 
		}

		public void ConfigureDeviceProperties()
		{
			IsolatedAction(() => m_delegate.ConfigureDeviceProperties()); 
		}

		public void SetupDialog()
		{
			IsolatedAction(() => m_delegate.SetupDialog()); 
		}

		public string InterfaceVersion
		{
			get { return IsolatedFunc(() => m_delegate.InterfaceVersion); }
		}

		public string DriverVersion
		{
			get { return IsolatedFunc(() => m_delegate.DriverVersion); }
		}

		public string DeviceDescription
		{
			get { return IsolatedFunc(() => m_delegate.DeviceDescription); }
		}

		public string DriverInfo
		{
			get { return IsolatedFunc(() => m_delegate.DriverInfo); }
		}

		public string CameraSensorInfo
		{
			get { return IsolatedFunc(() => m_delegate.CameraSensorInfo); }
		}

		public string CameraCCDCellSize
		{
			get { return IsolatedFunc(() => m_delegate.CameraCCDCellSize); }
		}

		public string CameraCCDDimentionInPixels
		{
			get { return IsolatedFunc(() => m_delegate.CameraCCDDimentionInPixels); }
		}

		public string ExposureRangeInfo
		{
			get { return IsolatedFunc(() => m_delegate.ExposureRangeInfo); }
		}

		public string GainRangeInfo
		{
			get { return IsolatedFunc(() => m_delegate.GainRangeInfo); }
		}

		public string GammaRangeInfo
		{
			get { return IsolatedFunc(() => m_delegate.GammaRangeInfo); }
		}
	}
}
