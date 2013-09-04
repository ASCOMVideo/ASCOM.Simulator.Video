//tabs=4
// --------------------------------------------------------------------------------
//
// ASCOM Video Driver - Video Client
//
// Description:	A managed wrapper to call unmanaged methods used by the Video Client
//
// Author:		(HDP) Hristo Pavlov <hristo_dpavlov@yahoo.com>
//
// --------------------------------------------------------------------------------
//

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using ASCOM.DeviceInterface;

namespace ASCOM.Simulator.Utils
{
	public class VideoNativeException : Exception
	{
		public 	VideoNativeException(string message)
			: base(message)
		{ }
	}

	public static class NativeHelpers
	{		
		private const string VIDEOUTILS_DLL_NAME = "ASCOM.Simulator.Video.Native.dll";

		[DllImport(VIDEOUTILS_DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int SetGamma(double gamma);

		[DllImport(VIDEOUTILS_DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int ApplyGammaBrightness(
			int width,
			int height,
			int bpp,
			[In, Out] int[,] pixelsIn,
			[In, Out] int[,] pixelsOut,
			short brightness);

		[DllImport(VIDEOUTILS_DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int InitFrameIntegration(int width, int height, int bpp);

		[DllImport(VIDEOUTILS_DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int AddFrameForIntegration([In, Out] int[,] pixels);

		[DllImport(VIDEOUTILS_DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int GetResultingIntegratedFrame([In, Out] int[,] pixels);

		[DllImport(VIDEOUTILS_DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int CreateNewAviFile([MarshalAs(UnmanagedType.LPStr)]string fileName, int width, int height, int bpp, double fps, bool showCompressionDialog);

		[DllImport(VIDEOUTILS_DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int AviFileAddFrame([In, MarshalAs(UnmanagedType.LPArray)] int[,] pixels);

		[DllImport(VIDEOUTILS_DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int AviFileClose();

		[DllImport(VIDEOUTILS_DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int GetLastAviFileError(IntPtr errorMessage);

		[DllImport(VIDEOUTILS_DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern uint GetUsedAviCompression();

		[DllImport(VIDEOUTILS_DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int SetWhiteBalance(int newWhiteBalance);


		public static void SetNewGamma(double newGamma)
		{
			SetGamma(newGamma);
		}

		public static void SetNewWhiteBalance(int newWhiteBalance)
		{
			SetWhiteBalance(255 - newWhiteBalance);
		}

		public static void ApplyGammaBrightness(int[,] pixelsIn, int[,] pixelsOut, int width, int height, short brightness)
		{
			ApplyGammaBrightness(width, height, 8, pixelsIn, pixelsOut, brightness);
		}

		public static void InitFrameIntegration(int width, int height)
		{
			InitFrameIntegration(width, height, 8);
		}

		public static void AddIntegrationFrame(int[,] pixelsIn)
		{
			AddFrameForIntegration(pixelsIn);
		}

		public static int[,] GetResultingIntegratedFrame(int width, int height)
		{
			int[,] rv = new int[height, width];

			GetResultingIntegratedFrame(rv);

			return rv;
		}

		public static string GetLastAviErrorMessage()
		{
			string error = null;
			IntPtr buffer = IntPtr.Zero;

			try
			{
				byte[] errorMessage = new byte[200];
				buffer = Marshal.AllocHGlobal(errorMessage.Length + 1);
				Marshal.Copy(errorMessage, 0, buffer, errorMessage.Length);
				Marshal.WriteByte(buffer + errorMessage.Length, 0); // terminating null

				GetLastAviFileError(buffer);

				error = Marshal.PtrToStringAnsi(buffer);

				if (error != null)
					error = error.Trim();
			}
			finally
			{
				if (buffer != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(buffer);
				}
			}

			return error;
		}

		private static void ThrowLastNativeError()
		{
			string error = GetLastAviErrorMessage();
			//throw new VideoNativeException(error);
			//MessageBox.Show(error, "VideoNativeException", MessageBoxButtons.OK, MessageBoxIcon.Error);
			Trace.WriteLine(error, "VideoNativeException");
		}

		public static void StartNewAviFile(string fileName, int width, int height, int bpp, double fps, bool showCompressionDialog)
		{
			if (CreateNewAviFile(fileName, width, height, bpp, fps, showCompressionDialog) != 0)
			{
				ThrowLastNativeError();
			}
		}

		public static void AddAviVideoFrame(int[,] pixels)
		{
			if (AviFileAddFrame(pixels) != 0)
			{
				ThrowLastNativeError();
			}
		}

		public static void CloseAviFile()
		{
			if (AviFileClose() != 0)
			{
				ThrowLastNativeError();
			}
		}

		public static string GetUsedAviFourCC()
		{
			uint fourcc = GetUsedAviCompression();

			if (fourcc == 0)
				return null;
			else
				return string.Concat(
					Convert.ToString((char)(fourcc & 0xFF)),
					Convert.ToString((char)((fourcc >> 8) & 0xFF)),
					Convert.ToString((char)((fourcc >> 16) & 0xFF)),
					Convert.ToString((char)((fourcc >> 24) & 0xFF))).ToUpper();
		}
	}
}
