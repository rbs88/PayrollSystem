namespace AldoBuildersPayrollSystem.report
{
	partial class frmPalagdaanSaPagtanggap
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
			reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			SuspendLayout();
			// 
			// reportViewer1
			// 
			reportViewer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			reportViewer1.Location = new Point(7, 5);
			reportViewer1.Name = "ReportViewer";
			reportViewer1.ServerReport.BearerToken = null;
			reportViewer1.Size = new Size(1193, 670);
			reportViewer1.TabIndex = 0;
			// 
			// frmPalagdaanSaPagtanggap
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoScroll = true;
			ClientSize = new Size(1207, 677);
			Controls.Add(reportViewer1);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "frmPalagdaanSaPagtanggap";
			StartPosition = FormStartPosition.CenterScreen;
			ResumeLayout(false);
		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
	}
}