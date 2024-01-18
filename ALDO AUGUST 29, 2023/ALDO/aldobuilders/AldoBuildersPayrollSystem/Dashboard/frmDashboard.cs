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

namespace AldoBuildersPayrollSystem.Dashboard
{
	public partial class frmDashboard : Form
	{
		SqlConnection cn;
		SqlCommand cm;
		SqlDataReader dr;
		DBConnection db = new DBConnection();

		private int ActiveWorker_Staff;
		private int ActiveWorkingToday;
		private int ActiveWorkedYesterday;
		private int ActiveWorkedLate;
		private int Inactiveworker_staff;
		//private int genderF;
		//private int civilStatusS;
		public frmDashboard()
		{
			InitializeComponent();
			cn = new SqlConnection(db.GetConnection());
			CountActiveStaffAndWorker();
			CountActiveStaffWorkerToday();
			CountActiveStaffWorkerWorkedYesterday();
			CountWorkingHistory();
			CountWorkersLateForToday();
			Inactiveworker();
		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		public void CountActiveStaffAndWorker()
		{
			//  string sdate = DateTime.Now.ToShortDateString();          
			cn.Open();
			cm = new SqlCommand("SELECT COUNT(*) as c FROM tblemployee WHERE status LIKE 'ACTIVE'", cn);
			ActiveWorker_Staff = int.Parse(cm.ExecuteScalar().ToString());
			label1.Text = ActiveWorker_Staff.ToString("#,##0");
			cn.Close();
		}

		public void CountActiveStaffWorkerToday()
		{
			//  string sdate = DateTime.Now.ToShortDateString();          
			cn.Open();
			cm = new SqlCommand("SELECT COUNT(*) as c FROM tblAttendancePayroll WHERE logdate = '" + DateTime.Now + "'", cn);
			ActiveWorkingToday = int.Parse(cm.ExecuteScalar().ToString());
			label4.Text = ActiveWorkingToday.ToString("#,##0");
			cn.Close();
		}

		public void CountActiveStaffWorkerWorkedYesterday()
		{
			DateTime oneDayAgo = DateTime.Now - TimeSpan.FromDays(1);
			//  string sdate = DateTime.Now.ToShortDateString();          
			cn.Open();
			cm = new SqlCommand("SELECT COUNT(*) as c FROM tblAttendancePayroll WHERE logdate = '" + oneDayAgo + "'", cn);
			ActiveWorkedYesterday = int.Parse(cm.ExecuteScalar().ToString());
			label6.Text = ActiveWorkedYesterday.ToString("#,##0");
			cn.Close();
		}

		public void CountWorkersLateForToday()
		{
			DateTime oneDayAgo = DateTime.Now;
			TimeSpan ForLate = TimeSpan.Parse("07:00:00");
			//  string sdate = DateTime.Now.ToShortDateString();          
			cn.Open();
			cm = new SqlCommand("SELECT COUNT(*) as c FROM tblAttendancePayroll WHERE logdate = '" + oneDayAgo + "' AND am_in > '" + ForLate + "'", cn);
			ActiveWorkedLate = int.Parse(cm.ExecuteScalar().ToString());
			label8.Text = ActiveWorkedLate.ToString("#,##0");
			cn.Close();
		}


		public void Inactiveworker()
		{
			//  string sdate = DateTime.Now.ToShortDateString();          
			cn.Open();
			cm = new SqlCommand("SELECT COUNT(*) as c FROM tblemployee WHERE status LIKE 'INACTIVE'", cn);
			Inactiveworker_staff = int.Parse(cm.ExecuteScalar().ToString());
			label10.Text = Inactiveworker_staff.ToString("#,##0");
			cn.Close();
		}

		private void CountWorkingHistory()
		{
			dataGridView1.Rows.Clear();
			int i = 0;
			cn.Open();
			cm = new SqlCommand("SELECT logdate AS LOGDATE, COUNT(*) as COUNT FROM tblAttendancePayroll GROUP BY logdate ORDER BY logdate DESC", cn);
			dr = cm.ExecuteReader();
			while (dr.Read())
			{
				//var s = dr["sex"].ToString();
				//var b = dr["duplicate"].ToString();
				i++;
				dataGridView1.Rows.Add(i, DateTime.Parse(dr["LOGDATE"].ToString()).ToShortDateString(), dr["COUNT"].ToString());
				//label6.Text = s;
				//label4.Text = b;
			}
			dr.Close();
			cn.Close();
		}
	}
}
