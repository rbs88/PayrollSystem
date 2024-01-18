using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using AldoBuildersPayrollSystem.attendanceandpayroll;

namespace AldoBuildersPayrollSystem.report
{
	public partial class frmReportSample : Form
	{
		SqlConnection cn;
		SqlDataAdapter da;

		DBConnection db = new DBConnection();

		frmFinalResult f;
		public frmReportSample(frmFinalResult f)
		{
			InitializeComponent();
			cn = new SqlConnection(db.GetConnection());
			this.f = f;
		}

		public void LoadReport()
		{
			try
			{
				ReportDataSource reportDS;
				ReportDataSource reportDS2;
				ReportDataSource reportDS1;
				this.reportViewer1.LocalReport.ReportPath = @"C:\AldoReport\Report1.rdlc";
				this.reportViewer1.LocalReport.DataSources.Clear();

				DataSet1 ds = new DataSet1();
				da = new SqlDataAdapter();

				cn.Open();
				da.SelectCommand = new SqlCommand("SELECT * FROM tblPayroll WHERE Date_Covered = '" + f.cbodatecoveredPrint.Text + "' ORDER BY Category, Name", cn);
				da.Fill(ds.Tables["tblPayroll"]);

				da.SelectCommand = new SqlCommand("SELECT * FROM tblService WHERE Date_Covered = '" + f.cbodatecoveredPrint.Text + "' ORDER BY Name", cn);
				da.Fill(ds.Tables["tblService"]);
				cn.Close();

				cn.Open();
				da.SelectCommand = new SqlCommand("SELECT * FROM tblSignatories", cn);
				da.Fill(ds.Tables["tblSignatories"]);
				cn.Close();

				var DateCovered = f.cbodatecoveredPrint.Text;
				ReportParameter p1 = new ReportParameter("dcovered", DateCovered);
				this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p1 });

				var SampleString = "Ronel B. Sason";
				ReportParameter subreportParameter = new Microsoft.Reporting.WinForms.ReportParameter("Signatories1", SampleString);
				ReportParameter subreportParameter1 = new Microsoft.Reporting.WinForms.ReportParameter("Signatories2", SampleString);
				ReportParameter subreportParameter2 = new Microsoft.Reporting.WinForms.ReportParameter("Position1", SampleString);
				ReportParameter subreportParameter3 = new Microsoft.Reporting.WinForms.ReportParameter("Position2", SampleString);
				this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { subreportParameter, subreportParameter1, subreportParameter2, subreportParameter3 });


				reportDS = new ReportDataSource("DataSet1", ds.Tables["tblPayroll"]);
				reportViewer1.LocalReport.DataSources.Add(reportDS);

				reportDS2 = new ReportDataSource("DataSet3", ds.Tables["tblService"]);
				reportViewer1.LocalReport.DataSources.Add(reportDS2);

				reportDS1 = new ReportDataSource("DataSet2", ds.Tables["tblSignatories"]);
				reportViewer1.LocalReport.DataSources.Add(reportDS1);
				reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);

				reportViewer1.ZoomMode = ZoomMode.Percent;
				reportViewer1.ZoomPercent = 100;
				this.reportViewer1.RefreshReport();

			}
			catch (Exception ex)
			{
				cn.Close();
				MessageBox.Show(ex.Message);
			}
		}

        public void LoadReportSummary()
        {
            try
            {
                ReportDataSource reportDS;
				ReportDataSource reportDS2;
				ReportDataSource reportDS1;
                this.reportViewer1.LocalReport.ReportPath = @"C:\AldoReport\ReportPayrollSummary.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                da = new SqlDataAdapter();

                cn.Open();
                da.SelectCommand = new SqlCommand("SELECT * FROM PayrollSummary WHERE Date_Covered = '" + f.cbodatecoveredPrint.Text + "' ORDER BY Result", cn);
                da.Fill(ds.Tables["PayrollSummary"]);
                cn.Close();

				cn.Open();
				da.SelectCommand = new SqlCommand("SELECT * FROM PayrollSummaryAndService WHERE Date_Covered = '" + f.cbodatecoveredPrint.Text + "'", cn);
				da.Fill(ds.Tables["PayrollSummaryAndService"]);
				cn.Close();

				cn.Open();
                da.SelectCommand = new SqlCommand("SELECT * FROM tblSignatories", cn);
                da.Fill(ds.Tables["tblSignatories"]);
                cn.Close();

                var DateCovered = f.cbodatecoveredPrint.Text;
                ReportParameter p1 = new ReportParameter("dcovered", DateCovered);
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p1 });

                var SampleString = "Ronel B. Sason";
                ReportParameter subreportParameter = new Microsoft.Reporting.WinForms.ReportParameter("Signatories1", SampleString);
                ReportParameter subreportParameter1 = new Microsoft.Reporting.WinForms.ReportParameter("Signatories2", SampleString);
                ReportParameter subreportParameter2 = new Microsoft.Reporting.WinForms.ReportParameter("Position1", SampleString);
                ReportParameter subreportParameter3 = new Microsoft.Reporting.WinForms.ReportParameter("Position2", SampleString);
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { subreportParameter, subreportParameter1, subreportParameter2, subreportParameter3 });


                reportDS = new ReportDataSource("DataSet1", ds.Tables["PayrollSummary"]);
                reportViewer1.LocalReport.DataSources.Add(reportDS);
				reportDS2 = new ReportDataSource("DataSet3", ds.Tables["PayrollSummaryAndService"]);
				reportViewer1.LocalReport.DataSources.Add(reportDS2);
				reportDS1 = new ReportDataSource("DataSet2", ds.Tables["tblSignatories"]);
                reportViewer1.LocalReport.DataSources.Add(reportDS1);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);

                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
                this.reportViewer1.RefreshReport();

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

		public void LoadReportService()
		{
			try
			{
				ReportDataSource reportDS;			
				ReportDataSource reportDS1;
				this.reportViewer1.LocalReport.ReportPath = @"C:\AldoReport\ReportService.rdlc";
				this.reportViewer1.LocalReport.DataSources.Clear();

				DataSet1 ds = new DataSet1();
				da = new SqlDataAdapter();

				
				da.SelectCommand = new SqlCommand("SELECT * FROM tblService WHERE Date_Covered = '" + f.cbodatecoveredPrint.Text + "' ORDER BY Name", cn);
				da.Fill(ds.Tables["tblService"]);
				cn.Close();

				cn.Open();
				da.SelectCommand = new SqlCommand("SELECT * FROM tblSignatories", cn);
				da.Fill(ds.Tables["tblSignatories"]);
				cn.Close();

				var DateCovered = f.cbodatecoveredPrint.Text;
				ReportParameter p1 = new ReportParameter("dcovered", DateCovered);
				this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p1 });
				
				var SampleString = "Ronel B. Sason";
				ReportParameter subreportParameter = new Microsoft.Reporting.WinForms.ReportParameter("Signatories1", SampleString);
				ReportParameter subreportParameter1 = new Microsoft.Reporting.WinForms.ReportParameter("Signatories2", SampleString);
				ReportParameter subreportParameter2 = new Microsoft.Reporting.WinForms.ReportParameter("Position1", SampleString);
				ReportParameter subreportParameter3 = new Microsoft.Reporting.WinForms.ReportParameter("Position2", SampleString);
				this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { subreportParameter, subreportParameter1, subreportParameter2, subreportParameter3 });


				reportDS = new ReportDataSource("DataSet1", ds.Tables["tblService"]);
				reportViewer1.LocalReport.DataSources.Add(reportDS);			

				reportDS1 = new ReportDataSource("DataSet2", ds.Tables["tblSignatories"]);
				reportViewer1.LocalReport.DataSources.Add(reportDS1);
				reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);

				reportViewer1.ZoomMode = ZoomMode.Percent;
				reportViewer1.ZoomPercent = 100;
				this.reportViewer1.RefreshReport();

			}
			catch (Exception ex)
			{
				cn.Close();
				MessageBox.Show(ex.Message);
			}
		}




		public void ParameterDate()
		{

		}
	}
}
