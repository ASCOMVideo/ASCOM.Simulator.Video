//tabs=4
// --------------------------------------------------------------------------------
//
// ASCOM Video
//
// Description:	Managed PInvoke definitions over the ASCOM.Unmanaged library 
//
// Author:		(HDP) Hristo Pavlov <hristo_dpavlov@yahoo.com>
//
// --------------------------------------------------------------------------------
//

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using ASCOM.DeviceInterface;
using ASCOM.DeviceInterface.DirectShowVideo;

namespace ASCOM.Utilities.Video
{
    public class VideoNativeException : Exception
    {
        public VideoNativeException(string message)
            : base(message)
        { }
    }

	public enum FlipMode
	{
		None = 0,
		FlipHorizontally = 1,
		FlipVertically = 2,
		FlipBoth = 3,
	}

	internal static class NativeHelpers
	{
        private const string VIDEOUTILS_DLL_NAME = "ASCOM.Native.6.1.dll";

		[DllImport(VIDEOUTILS_DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        private static extern int GetBitmapPixels(
			int width, 
			int height, 
			int bpp,
			FlipMode flipMode,
			[In, MarshalAs(UnmanagedType.LPArray)] int[,] pixels,
			[In, Out] byte[] bitmapBytes);

		[DllImport(VIDEOUTILS_DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int GetColourBitmapPixels(
			int width,
			int height,
			int bpp,
			FlipMode flipMode,
			[In, MarshalAs(UnmanagedType.LPArray)] int[,,] pixels,
			[In, Out] byte[] bitmapBytes);

		[DllImport(VIDEOUTILS_DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int GetMonochromePixelsFromBitmap(
			int width,
			int height,
			int bpp,
			FlipMode flipMode,
			[In] IntPtr hBitmap,
			[In, Out, MarshalAs(UnmanagedType.LPArray)] int[,] bitmapBytes,
			int mode);

		[DllImport(VIDEOUTILS_DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int GetColourPixelsFromBitmap(
			int width,
			int height,
			int bpp,
			FlipMode flipMode,
			[In] IntPtr hBitmap,
			[In, Out, MarshalAs(UnmanagedType.LPArray)] int[,,] bitmapBytes);

        [DllImport(VIDEOUTILS_DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int SetGamma(double gamma);

        [DllImport(VIDEOUTILS_DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int ApplyGammaBrightness(
            int width,
            int height,
            int bpp,
            [In, Out] int[,] pixelsIn,
            [In, Out] int[,] pixelsOut,
            short brightness);

        [DllImport(VIDEOUTILS_DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int InitFrameIntegration(int width, int height, int bpp);

        [DllImport(VIDEOUTILS_DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int AddFrameForIntegration([In, Out] int[,] pixels);

        [DllImport(VIDEOUTILS_DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GetResultingIntegratedFrame([In, Out] int[,] pixels);

        [DllImport(VIDEOUTILS_DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int CreateNewAviFile([MarshalAs(UnmanagedType.LPStr)]string fileName, int width, int height, int bpp, double fps, bool showCompressionDialog);

        [DllImport(VIDEOUTILS_DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int AviFileAddFrame([In, MarshalAs(UnmanagedType.LPArray)] int[,] pixels);

        [DllImport(VIDEOUTILS_DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int AviFileClose();

        [DllImport(VIDEOUTILS_DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GetLastAviFileError(IntPtr errorMessage);

        [DllImport(VIDEOUTILS_DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint GetUsedAviCompression();

        [DllImport(VIDEOUTILS_DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int SetWhiteBalance(int newWhiteBalance);

		[DllImport("gdi32.dll")]
		public static extern bool DeleteObject(IntPtr hObject);


		public static Bitmap PrepareBitmapForDisplay(int[,] imageArray, int width, int height, FlipMode flipMode)
        {
			return PrepareBitmapForDisplay(imageArray, width, height, false, flipMode);
        }

		public static Bitmap PrepareBitmapForDisplay(object[,] imageArray, int width, int height, FlipMode flipMode)
        {
			return PrepareBitmapForDisplay(imageArray, width, height, true, flipMode);
        }

		public static Bitmap PrepareColourBitmapForDisplay(int[, ,] imageArray, int width, int height, FlipMode flipMode)
		{
			return PrepareColourBitmapForDisplay(imageArray, width, height, false, flipMode);
		}

		public static Bitmap PrepareColourBitmapForDisplay(object[, ,] imageArray, int width, int height, FlipMode flipMode)
		{
			return PrepareColourBitmapForDisplay(imageArray, width, height, true, flipMode);
		}

		public static object GetMonochromePixelsFromBitmap(Bitmap bitmap, LumaConversionMode conversionMode, FlipMode flipMode)
		{
			int[,] bitmapBytes = new int[bitmap.Width, bitmap.Height];

			IntPtr hBitmap = bitmap.GetHbitmap();
			try
			{
				GetMonochromePixelsFromBitmap(bitmap.Width, bitmap.Height, 8, flipMode, hBitmap, bitmapBytes, (int)conversionMode);
			}
			finally
			{
				DeleteObject(hBitmap);
			}

			return bitmapBytes;
		}

		public static object GetColourPixelsFromBitmap(Bitmap bitmap, FlipMode flipMode)
		{
			int[,,] bitmapBytes = new int[bitmap.Width, bitmap.Height, 3];

			IntPtr hBitmap = bitmap.GetHbitmap();
			try
			{
				GetColourPixelsFromBitmap(bitmap.Width, bitmap.Height, 8, flipMode, hBitmap, bitmapBytes);
			}
			finally
			{
				DeleteObject(hBitmap);
			}

			return bitmapBytes;			
		}

		private static Bitmap PrepareBitmapForDisplay(object imageArray, int width, int height, bool useVariantPixels, FlipMode flipMode)
		{
			Bitmap displayBitmap = null;

			int[,] pixels = new int[height, width];

			if (useVariantPixels)
			{
                Array safeArr = (Array)imageArray;
				Array.Copy(safeArr, pixels, pixels.Length);
			}
			else
			{
                Array safeArr = (Array)imageArray;
				Array.Copy(safeArr, pixels, pixels.Length);
			}

			byte[] rawBitmapBytes = new byte[(width * height * 3) + 40 + 14 + 1];

			GetBitmapPixels(width, height, (int)8, flipMode, pixels, rawBitmapBytes);

			using (MemoryStream memStr = new MemoryStream(rawBitmapBytes))
			{
				displayBitmap = (Bitmap)Image.FromStream(memStr);
			}

			return displayBitmap;
		}

		private static Bitmap PrepareColourBitmapForDisplay(object imageArray, int width, int height, bool useVariantPixels, FlipMode flipMode)
		{
			Bitmap displayBitmap = null;

			int[,,] pixels = new int[height, width, 3];

			if (useVariantPixels)
			{
				Array safeArr = (Array)imageArray;
				Array.Copy(safeArr, pixels, pixels.Length);
			}
			else
			{
				Array safeArr = (Array)imageArray;
				Array.Copy(safeArr, pixels, pixels.Length);
			}

			byte[] rawBitmapBytes = new byte[(width * height * 3) + 40 + 14 + 1];

			GetColourBitmapPixels(width, height, (int)8, flipMode, pixels, rawBitmapBytes);

			using (MemoryStream memStr = new MemoryStream(rawBitmapBytes))
			{
				displayBitmap = (Bitmap)Image.FromStream(memStr);
			}

			return displayBitmap;
		}
	}
}
