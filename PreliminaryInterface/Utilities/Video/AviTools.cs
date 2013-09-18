//tabs=4
// --------------------------------------------------------------------------------
//
// ASCOM Video - Simulator
//
// Description:	Helper class used by the Video Simulator
//
// Author:		(HDP) Hristo Pavlov <hristo_dpavlov@yahoo.com>
//
// --------------------------------------------------------------------------------
//

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using ASCOM.Utilities.Video;

namespace ASCOM.DeviceInterface.Utilities.Video
{
    public class AviTools
    {
        public static void SetNewGamma(double newGamma)
        {
            NativeHelpers.SetGamma(newGamma);
        }

        public static void SetNewWhiteBalance(int newWhiteBalance)
        {
            NativeHelpers.SetWhiteBalance(255 - newWhiteBalance);
        }

        public static void ApplyGammaBrightness(int[,] pixelsIn, int[,] pixelsOut, int width, int height, short brightness)
        {
            NativeHelpers.ApplyGammaBrightness(width, height, 8, pixelsIn, pixelsOut, brightness);
        }

        public static void InitFrameIntegration(int width, int height)
        {
            NativeHelpers.InitFrameIntegration(width, height, 8);
        }

        public static void AddIntegrationFrame(int[,] pixelsIn)
        {
            NativeHelpers.AddFrameForIntegration(pixelsIn);
        }

        public static int[,] GetResultingIntegratedFrame(int width, int height)
        {
            int[,] rv = new int[height, width];

            NativeHelpers.GetResultingIntegratedFrame(rv);

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

                NativeHelpers.GetLastAviFileError(buffer);

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
            if (NativeHelpers.CreateNewAviFile(fileName, width, height, bpp, fps, showCompressionDialog) != 0)
            {
                ThrowLastNativeError();
            }
        }

        public static void AddAviVideoFrame(int[,] pixels)
        {
            if (NativeHelpers.AviFileAddFrame(pixels) != 0)
            {
                ThrowLastNativeError();
            }
        }

        public static void CloseAviFile()
        {
            if (NativeHelpers.AviFileClose() != 0)
            {
                ThrowLastNativeError();
            }
        }

        public static string GetUsedAviFourCC()
        {
            uint fourcc = NativeHelpers.GetUsedAviCompression();

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
