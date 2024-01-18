namespace AldoBuildersPayrollSystem.report
{
	partial class frmPayrollSlip
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
			reportViewer1.Anchor = AnchorStyles.None;
			reportViewer1.Location = new Point(10, 23);
			reportViewer1.Name = "ReportViewer";
			reportViewer1.Padding = new Padding(5);
			reportViewer1.ServerReport.BearerToken = null;
			reportViewer1.Size = new Size(1160, 615);
			reportViewer1.TabIndex = 0;
			// 
			// frmPayrollSlip
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1184, 651);
			Controls.Add(reportViewer1);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "frmPayrollSlip";
			Padding = new Padding(10);
			StartPosition = FormStartPosition.CenterScreen;
			ResumeLayout(false);
		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
	}
}