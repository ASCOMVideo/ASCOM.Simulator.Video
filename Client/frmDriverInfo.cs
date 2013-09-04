using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client
{
	public partial class frmDriverInfo : Form
	{
		private VideoWrapper videoObject;

		public frmDriverInfo()
		{
			InitializeComponent();
		}

		internal void SetVideoObject(VideoWrapper wrapper)
		{
			videoObject = wrapper;
		}

		private void frmDriverInfo_Load(object sender, EventArgs e)
		{
			gbxDriverInfo.Text = videoObject.DeviceName;

			lblInterfaceVersion.Text = videoObject.InterfaceVersion;
			lblDriverVersion.Text = videoObject.DriverVersion;

			tbxDeviceDescription.Text = videoObject.DeviceDescription;
			tbxDriverInfo.Text = videoObject.DriverInfo;

			btnClose.Focus();
		}
	}
}
