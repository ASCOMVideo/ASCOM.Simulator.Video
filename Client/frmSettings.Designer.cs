namespace Client
{
	partial class frmSettings
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbManaged = new System.Windows.Forms.RadioButton();
			this.rbNative = new System.Windows.Forms.RadioButton();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.tbxOutputLocation = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnBrowseOutputFolder = new System.Windows.Forms.Button();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.nudGainIntervals = new System.Windows.Forms.NumericUpDown();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.rbPixelsVariant = new System.Windows.Forms.RadioButton();
			this.rbPixelsIntegers = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudGainIntervals)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbManaged);
			this.groupBox1.Controls.Add(this.rbNative);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(181, 52);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Bitmap Handling";
			// 
			// rbManaged
			// 
			this.rbManaged.AutoSize = true;
			this.rbManaged.Location = new System.Drawing.Point(94, 25);
			this.rbManaged.Name = "rbManaged";
			this.rbManaged.Size = new System.Drawing.Size(70, 17);
			this.rbManaged.TabIndex = 3;
			this.rbManaged.Text = "Managed";
			this.rbManaged.UseVisualStyleBackColor = true;
			// 
			// rbNative
			// 
			this.rbNative.AutoSize = true;
			this.rbNative.Checked = true;
			this.rbNative.Location = new System.Drawing.Point(20, 25);
			this.rbNative.Name = "rbNative";
			this.rbNative.Size = new System.Drawing.Size(56, 17);
			this.rbNative.TabIndex = 2;
			this.rbNative.TabStop = true;
			this.rbNative.Text = "Native";
			this.rbNative.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(318, 189);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(237, 189);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// tbxOutputLocation
			// 
			this.tbxOutputLocation.Location = new System.Drawing.Point(12, 154);
			this.tbxOutputLocation.Name = "tbxOutputLocation";
			this.tbxOutputLocation.Size = new System.Drawing.Size(345, 20);
			this.tbxOutputLocation.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 135);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Output Video Location";
			// 
			// btnBrowseOutputFolder
			// 
			this.btnBrowseOutputFolder.Location = new System.Drawing.Point(363, 151);
			this.btnBrowseOutputFolder.Name = "btnBrowseOutputFolder";
			this.btnBrowseOutputFolder.Size = new System.Drawing.Size(30, 23);
			this.btnBrowseOutputFolder.TabIndex = 5;
			this.btnBrowseOutputFolder.Text = "...";
			this.btnBrowseOutputFolder.UseVisualStyleBackColor = true;
			this.btnBrowseOutputFolder.Click += new System.EventHandler(this.btnBrowseOutputFolder_Click);
			// 
			// nudGainIntervals
			// 
			this.nudGainIntervals.Location = new System.Drawing.Point(25, 22);
			this.nudGainIntervals.Name = "nudGainIntervals";
			this.nudGainIntervals.Size = new System.Drawing.Size(57, 20);
			this.nudGainIntervals.TabIndex = 7;
			this.nudGainIntervals.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.nudGainIntervals);
			this.groupBox2.Location = new System.Drawing.Point(213, 13);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(181, 51);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Free range gain intervals";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.rbPixelsVariant);
			this.groupBox3.Controls.Add(this.rbPixelsIntegers);
			this.groupBox3.Location = new System.Drawing.Point(12, 70);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(181, 52);
			this.groupBox3.TabIndex = 9;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Frame Pixels";
			// 
			// rbPixelsVariant
			// 
			this.rbPixelsVariant.AutoSize = true;
			this.rbPixelsVariant.Location = new System.Drawing.Point(94, 25);
			this.rbPixelsVariant.Name = "rbPixelsVariant";
			this.rbPixelsVariant.Size = new System.Drawing.Size(63, 17);
			this.rbPixelsVariant.TabIndex = 3;
			this.rbPixelsVariant.Text = "Variants";
			this.rbPixelsVariant.UseVisualStyleBackColor = true;
			// 
			// rbPixelsIntegers
			// 
			this.rbPixelsIntegers.AutoSize = true;
			this.rbPixelsIntegers.Checked = true;
			this.rbPixelsIntegers.Location = new System.Drawing.Point(20, 25);
			this.rbPixelsIntegers.Name = "rbPixelsIntegers";
			this.rbPixelsIntegers.Size = new System.Drawing.Size(63, 17);
			this.rbPixelsIntegers.TabIndex = 2;
			this.rbPixelsIntegers.TabStop = true;
			this.rbPixelsIntegers.Text = "Integers";
			this.rbPixelsIntegers.UseVisualStyleBackColor = true;
			// 
			// frmSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(408, 223);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btnBrowseOutputFolder);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbxOutputLocation);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSettings";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "ASCOM Video Client Settings";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudGainIntervals)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbManaged;
		private System.Windows.Forms.RadioButton rbNative;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.TextBox tbxOutputLocation;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnBrowseOutputFolder;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.NumericUpDown nudGainIntervals;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton rbPixelsVariant;
		private System.Windows.Forms.RadioButton rbPixelsIntegers;
	}
}