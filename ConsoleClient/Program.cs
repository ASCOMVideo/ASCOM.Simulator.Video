using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ASCOM.DriverAccess;

namespace ConsoleClient
{
	class Program
	{
		private static Form ownerForm;
		static void Main(string[] args)
		{
			string progId = "Tangra.DirectShow.Video";

			//InvokeUsingDriverAccess(progId);

			InvokeUsingDynamicTypes(progId);

			Console.ReadKey();
		}

		private static void InvokeUsingDriverAccess(string progId)
		{
			ASCOM.DriverAccess.Video video = new ASCOM.DriverAccess.Video(progId);
			video.Connected = true;
			video.ConfigureDeviceProperties();
		}

		private static void InvokeUsingDynamicTypes(string progId)
		{
			Type oType = Type.GetTypeFromProgID(progId);
			if (oType != null)
			{
				dynamic video = Activator.CreateInstance(oType);
				video.Connected = true;
				video.ConfigureDeviceProperties();
			}
		}
	}
}
