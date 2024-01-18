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
using AldoBuildersPayrollSystem.Employee.MasterList;

namespace AldoBuildersPayrollSystem.report
{
	public partial class frmEmployeeMasterList : Form
	{
		SqlConnection cn;
		SqlDataAdapter da;

		DBConnection db = new DBConnection();

		frmMainEmployeeLoadRecord f;
		public frmEmployeeMasterList(frmMainEmployeeLoadRecord f)
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
				ReportDataSource reportDS1;
				this.reportViewer1.LocalReport.ReportPath = @"C:\AldoReport\ReportEmployeeMasterList.rdlc";
				this.reportViewer1.LocalReport.DataSources.Clear();

				DataSet1 ds = new DataSet1();
				da = new SqlDataAdapter();

				cn.Open();
				da.SelectCommand = new SqlCommand("SELECT * FROM tblemployee WHERE Category = '" + f.cboSearchPrint.Text + "' ORDER BY FULLNAME", cn);
				da.Fill(ds.Tables["tblemployee"]);
				cn.Close();

				cn.Open();
				da.SelectCommand = new SqlCommand("SELECT * FROM tblSignatories", cn);
				da.Fill(ds.Tables["tblSignatories"]);
				cn.Close();

				var DateCovered = f.cboSearchPrint.Text;
				ReportParameter p1 = new ReportParameter("Category", DateCovered);
				this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p1 });

				var SampleString = "Ronel B. Sason";
				ReportParameter subreportParameter = new Microsoft.Reporting.WinForms.ReportParameter("Signatories1", SampleString);
				ReportParameter subreportParameter1 = new Microsoft.Reporting.WinForms.ReportParameter("Signatories2", SampleString);
				ReportParameter subreportParameter2 = new Microsoft.Reporting.WinForms.ReportParameter("Position1", SampleString);
				ReportParameter subreportParameter3 = new Microsoft.Reporting.WinForms.ReportParameter("Position2", SampleString);
				this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { subreportParameter, subreportParameter1, subreportParameter2, subreportParameter3 });

				reportDS = new ReportDataSource("DataSet1", ds.Tables["tblemployee"]);
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

        public void LoadReportAll()
        {
            try
            {
                ReportDataSource reportDS;
                ReportDataSource reportDS1;
                this.reportViewer1.LocalReport.ReportPath = @"C:\AldoReport\ReportEmployeeMasterList.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                da = new SqlDataAdapter();

                cn.Open();
                da.SelectCommand = new SqlCommand("SELECT * FROM tblemployee ORDER BY Category, FUlLNAME", cn);
                da.Fill(ds.Tables["tblemployee"]);
                cn.Close();

                cn.Open();
                da.SelectCommand = new SqlCommand("SELECT * FROM tblSignatories", cn);
                da.Fill(ds.Tables["tblSignatories"]);
                cn.Close();

                var DateCovered = f.cboSearchPrint.Text;
                ReportParameter p1 = new ReportParameter("Category", DateCovered);
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p1 });

                var SampleString = "Ronel B. Sason";
                ReportParameter subreportParameter = new Microsoft.Reporting.WinForms.ReportParameter("Signatories1", SampleString);
                ReportParameter subreportParameter1 = new Microsoft.Reporting.WinForms.ReportParameter("Signatories2", SampleString);
                ReportParameter subreportParameter2 = new Microsoft.Reporting.WinForms.ReportParameter("Position1", SampleString);
                ReportParameter subreportParameter3 = new Microsoft.Reporting.WinForms.ReportParameter("Position2", SampleString);
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { subreportParameter, subreportParameter1, subreportParameter2, subreportParameter3 });

                reportDS = new ReportDataSource("DataSet1", ds.Tables["tblemployee"]);
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
