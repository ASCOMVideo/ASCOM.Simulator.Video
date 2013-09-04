//tabs=4
// --------------------------------------------------------------------------------
//
// ASCOM Video Driver - Video Client
//
// Description:	The settings form
//
// Author:		(HDP) Hristo Pavlov <hristo_dpavlov@yahoo.com>
//
// --------------------------------------------------------------------------------
//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Client.Properties;

namespace Client
{
	public partial class frmSettings : Form
	{
		public frmSettings()
		{
			InitializeComponent();

			rbNative.Checked = Settings.Default.UseNativeCode;
			rbManaged.Checked = !Settings.Default.UseNativeCode;
			nudGainIntervals.Value = Settings.Default.FreeRangeGainIntervals;

			tbxOutputLocation.Text = Settings.Default.OutputLocation;
			rbPixelsVariant.Checked = Settings.Default.VariantPixels;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			if (!Directory.Exists(tbxOutputLocation.Text))
			{
				MessageBox.Show(
					string.Format("Directory '{0}' could not be found.", tbxOutputLocation.Text),
					"Error", 
					MessageBoxButtons.OK, 
					MessageBoxIcon.Error);

				tbxOutputLocation.Focus();
				return;
			}

			Settings.Default.FreeRangeGainIntervals = (short)nudGainIntervals.Value;
			Settings.Default.UseNativeCode = rbNative.Checked;
			Settings.Default.OutputLocation = tbxOutputLocation.Text;
			Settings.Default.VariantPixels = rbPixelsVariant.Checked;

			Settings.Default.Save();

			DialogResult = DialogResult.OK;
			Close();
		}

		private void btnBrowseOutputFolder_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
				tbxOutputLocation.Text = folderBrowserDialog.SelectedPath;
		}
	}
}
