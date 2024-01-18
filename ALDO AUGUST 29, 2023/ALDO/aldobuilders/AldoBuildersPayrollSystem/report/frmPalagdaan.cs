using AldoBuildersPayrollSystem.attendanceandpayroll;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AldoBuildersPayrollSystem.report
{
	public partial class frmPalagdaan : Form
	{
		SqlConnection cn;
		SqlDataAdapter da;

		DBConnection db = new DBConnection();

		frmFinalResult f;
		public frmPalagdaan(frmFinalResult f)
		{
			InitializeComponent();
			cn = new SqlConnection(db.GetConnection());
			this.f = f;

		}

		public void LoadReport1()
		{
			try
			{
				ReportDataSource reportDS;
				ReportDataSource reportDS1;
				this.reportViewer1.LocalReport.ReportPath = @"C:\AldoReport\Palagdaan.rdlc";
				//this.reportViewer1.LocalReport.ReportPath = @"C:\AldoReport\PalagdaanSub.rdlc";
				this.reportViewer1.LocalReport.DataSources.Clear();

				DataSet1 ds = new DataSet1();
				da = new SqlDataAdapter();

				cn.Open();
				da.SelectCommand = new SqlCommand("SELECT * FROM tblPayroll WHERE Date_Covered = '" + f.cbodatecoveredPrint.Text + "' AND Category='WORKER' ORDER BY Name", cn);
				da.Fill(ds.Tables["tblPayroll"]);
				cn.Close();

				cn.Open();
				da.SelectCommand = new SqlCommand("SELECT * FROM tblSignatories", cn);
				da.Fill(ds.Tables["tblSignatories"]);
				cn.Close();

                var DateCovered = f.cbodatecoveredPrint.Text;
                var Category = "WORKERS";
                ReportParameter p1 = new ReportParameter("dcovered", DateCovered);
                ReportParameter p2 = new ReportParameter("Categories", Category);
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p1, p2 });

                var SampleString = "Ronel B. Sason";
				ReportParameter subreportParameter = new Microsoft.Reporting.WinForms.ReportParameter("Signatories1", SampleString);
				ReportParameter subreportParameter1 = new Microsoft.Reporting.WinForms.ReportParameter("Signatories2", SampleString);
				ReportParameter subreportParameter2 = new Microsoft.Reporting.WinForms.ReportParameter("Position1", SampleString);
				ReportParameter subreportParameter3 = new Microsoft.Reporting.WinForms.ReportParameter("Position2", SampleString);
				this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { subreportParameter, subreportParameter1, subreportParameter2, subreportParameter3 });

				reportDS = new ReportDataSource("DataSet1", ds.Tables["tblPayroll"]);
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

        public void LoadReportStaff()
        {
            try
            {
                ReportDataSource reportDS;
                ReportDataSource reportDS1;
                this.reportViewer1.LocalReport.ReportPath = @"C:\AldoReport\Palagdaan.rdlc";
                //this.reportViewer1.LocalReport.ReportPath = @"C:\AldoReport\PalagdaanSub.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                da = new SqlDataAdapter();

                cn.Open();
                da.SelectCommand = new SqlCommand("SELECT * FROM tblPayroll WHERE Date_Covered = '" + f.cbodatecoveredPrint.Text + "' AND Category='STAFF' ORDER BY Name", cn);
                da.Fill(ds.Tables["tblPayroll"]);
                cn.Close();

                cn.Open();
                da.SelectCommand = new SqlCommand("SELECT * FROM tblSignatories", cn);
                da.Fill(ds.Tables["tblSignatories"]);
                cn.Close();

                var DateCovered = f.cbodatecoveredPrint.Text;
                var Category = "STAFF";
                ReportParameter p1 = new ReportParameter("dcovered", DateCovered);
                ReportParameter p2 = new ReportParameter("Categories", Category);
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p1, p2 });

                var SampleString = "Ronel B. Sason";
                ReportParameter subreportParameter = new Microsoft.Reporting.WinForms.ReportParameter("Signatories1", SampleString);
                ReportParameter subreportParameter1 = new Microsoft.Reporting.WinForms.ReportParameter("Signatories2", SampleString);
                ReportParameter subreportParameter2 = new Microsoft.Reporting.WinForms.ReportParameter("Position1", SampleString);
                ReportParameter subreportParameter3 = new Microsoft.Reporting.WinForms.ReportParameter("Position2", SampleString);
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { subreportParameter, subreportParameter1, subreportParameter2, subreportParameter3 });

                reportDS = new ReportDataSource("DataSet1", ds.Tables["tblPayroll"]);
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
    }
}
