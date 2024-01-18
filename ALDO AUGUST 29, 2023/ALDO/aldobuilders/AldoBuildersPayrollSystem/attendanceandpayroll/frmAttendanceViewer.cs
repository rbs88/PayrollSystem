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
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace AldoBuildersPayrollSystem.attendanceandpayroll
{
	public partial class frmAttendanceViewer : Form
	{

		SqlConnection cn;
		SqlCommand cm;
		SqlDataReader dr;
		DBConnection db = new DBConnection();
		public frmAttendanceViewer()
		{
			InitializeComponent();
			cn = new SqlConnection(db.GetConnection());
			LoadFullNameToComboBox();
			//	LoadAssignToComboBox();
			LoadAssignRecord();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (cboAssign.Text == "ALL" && cboFullName.Text == "ALL")
			{
				LoadRecords1();
			}
			else if (cboAssign.Text == "ALL" && cboFullName.Text != "")
			{
				LoadRecords2();
			}
			else if (cboAssign.Text != "" && cboFullName.Text == "ALL")
			{
				LoadRecords3();
			}
			else if (cboAssign.Text != "" && cboFullName.Text != "")
			{
				LoadRecords4();
			}
			else
			{
				dataGridView1.Rows.Clear();
				return;
			}
		}

		public void LoadRecords1()
		{
			try
			{
				dataGridView1.Rows.Clear();
				int i = 0;
				cn.Open();
				cm = new SqlCommand("SELECT idattendancepayroll,CONCAT(lastname,', ',firstname,' ',middlename) as NAME,idnumber as EMPLOYEEID,logdate as LOGDATE,am_in AS AM_IN,am_out AS AM_OUT,TotalAM,pm_in AS PM_IN,pm_out as PM_OUT,TotalPM,OT_IN,OT_OUT,TotalOT,CalAM,CalPM,CalOT,AddHours,Total_Hours,status FROM tblAttendancePayroll INNER JOIN tblemployee ON tblAttendancePayroll.idemployee=tblemployee.idemployee WHERE(cast(logdate as datetime) BETWEEN '" + dtFrom.Text + "' AND '" + dtTo.Text + "') AND status='ACTIVE' ORDER BY NAME,logdate", cn);
				dr = cm.ExecuteReader();
				while (dr.Read())
				{
					i++;
					dataGridView1.Rows.Add(i, dr["idattendancepayroll"].ToString(), dr["EMPLOYEEID"].ToString(), dr["NAME"].ToString(), DateTime.Parse(dr["LOGDATE"].ToString()).ToShortDateString(), dr["AM_IN"].ToString(), dr["AM_OUT"].ToString(), dr["CalAM"].ToString(), dr["TotalAM"].ToString(), dr["PM_IN"].ToString(), dr["PM_OUT"].ToString(), dr["CalPM"].ToString(), dr["TotalPM"].ToString(), dr["OT_IN"].ToString(), dr["OT_OUT"].ToString(), dr["CalOT"].ToString(), dr["TotalOT"].ToString(), dr["AddHours"].ToString(), dr["Total_Hours"].ToString());//, DateTime.Parse(dr["DCOVERED_FROM"].ToString()).ToShortDateString(), DateTime.Parse(dr["DCOVERED_TO"].ToString()).ToShortDateString(), dr["PURPOSE"].ToString(), dr["REMARKS"].ToString(), dr["STATUS"].ToString(), dr["P1"].ToString(), dr["P2"].ToString(), dr["P3"].ToString(), dr["P4"].ToString(), dr["P5"].ToString(), dr["P6"].ToString(), dr["P7"].ToString(), dr["P8"].ToString(), dr["P9"].ToString(), dr["P10"].ToString(), dr["P11"].ToString(), dr["P12"].ToString(), dr["P13"].ToString(), dr["P14"].ToString(), dr["P15"].ToString(), dr["sNO"].ToString(), dr["SECTION_CHIEF"].ToString());
				}
				dr.Close();
				cn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public void LoadRecords2()
		{
			try
			{
				dataGridView1.Rows.Clear();
				int i = 0;
				cn.Open();
				cm = new SqlCommand("SELECT idattendancepayroll,CONCAT(lastname,', ',firstname,' ',middlename) as NAME,idnumber as EMPLOYEEID,logdate as LOGDATE,am_in AS AM_IN,am_out AS AM_OUT,TotalAM,pm_in AS PM_IN,pm_out as PM_OUT,TotalPM,OT_IN,OT_OUT,TotalOT,CalAM,CalPM,CalOT,AddHours,Total_Hours,FULLNAME,status FROM tblAttendancePayroll INNER JOIN tblemployee ON tblAttendancePayroll.idemployee=tblemployee.idemployee WHERE(cast(logdate as datetime) BETWEEN '" + dtFrom.Text + "' AND '" + dtTo.Text + "') AND FULLNAME= '" + cboFullName.Text + "' AND status= 'ACTIVE' ORDER BY NAME,logdate", cn);
				dr = cm.ExecuteReader();
				while (dr.Read())
				{
					i++;
					dataGridView1.Rows.Add(i, dr["idattendancepayroll"].ToString(), dr["EMPLOYEEID"].ToString(), dr["NAME"].ToString(), DateTime.Parse(dr["LOGDATE"].ToString()).ToShortDateString(), dr["AM_IN"].ToString(), dr["AM_OUT"].ToString(), dr["CalAM"].ToString(), dr["TotalAM"].ToString(), dr["PM_IN"].ToString(), dr["PM_OUT"].ToString(), dr["CalPM"].ToString(), dr["TotalPM"].ToString(), dr["OT_IN"].ToString(), dr["OT_OUT"].ToString(), dr["CalOT"].ToString(), dr["TotalOT"].ToString(), dr["AddHours"].ToString(), dr["Total_Hours"].ToString());//, DateTime.Parse(dr["DCOVERED_FROM"].ToString()).ToShortDateString(), DateTime.Parse(dr["DCOVERED_TO"].ToString()).ToShortDateString(), dr["PURPOSE"].ToString(), dr["REMARKS"].ToString(), dr["STATUS"].ToString(), dr["P1"].ToString(), dr["P2"].ToString(), dr["P3"].ToString(), dr["P4"].ToString(), dr["P5"].ToString(), dr["P6"].ToString(), dr["P7"].ToString(), dr["P8"].ToString(), dr["P9"].ToString(), dr["P10"].ToString(), dr["P11"].ToString(), dr["P12"].ToString(), dr["P13"].ToString(), dr["P14"].ToString(), dr["P15"].ToString(), dr["sNO"].ToString(), dr["SECTION_CHIEF"].ToString());
				}
				dr.Close();
				cn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				dr.Close();
				cn.Close();
			}
		}

		public void LoadRecords3()
		{
			try
			{
				dataGridView1.Rows.Clear();
				int i = 0;
				cn.Open();
				cm = new SqlCommand("SELECT idattendancepayroll, CONCAT(lastname,', ',firstname,' ',middlename) as NAME,idnumber as EMPLOYEEID,logdate as LOGDATE,am_in AS AM_IN,am_out AS AM_OUT,TotalAM,pm_in AS PM_IN,pm_out as PM_OUT,TotalPM,OT_IN,OT_OUT,TotalOT,CalAM,CalPM,CalOT,AddHours,Total_Hours,FULLNAME,status,assign FROM tblAttendancePayroll INNER JOIN tblemployee ON tblAttendancePayroll.idemployee=tblemployee.idemployee WHERE(cast(logdate as datetime) BETWEEN '" + dtFrom.Text + "' AND '" + dtTo.Text + "') AND assign= '" + cboAssign.Text + "' AND status= 'ACTIVE' ORDER BY NAME,logdate", cn);
				dr = cm.ExecuteReader();
				while (dr.Read())
				{
					i++;
					dataGridView1.Rows.Add(i, dr["idattendancepayroll"].ToString(), dr["EMPLOYEEID"].ToString(), dr["NAME"].ToString(), DateTime.Parse(dr["LOGDATE"].ToString()).ToShortDateString(), dr["AM_IN"].ToString(), dr["AM_OUT"].ToString(), dr["CalAM"].ToString(), dr["TotalAM"].ToString(), dr["PM_IN"].ToString(), dr["PM_OUT"].ToString(), dr["CalPM"].ToString(), dr["TotalPM"].ToString(), dr["OT_IN"].ToString(), dr["OT_OUT"].ToString(), dr["CalOT"].ToString(), dr["TotalOT"].ToString(), dr["AddHours"].ToString(), dr["Total_Hours"].ToString());//, DateTime.Parse(dr["DCOVERED_FROM"].ToString()).ToShortDateString(), DateTime.Parse(dr["DCOVERED_TO"].ToString()).ToShortDateString(), dr["PURPOSE"].ToString(), dr["REMARKS"].ToString(), dr["STATUS"].ToString(), dr["P1"].ToString(), dr["P2"].ToString(), dr["P3"].ToString(), dr["P4"].ToString(), dr["P5"].ToString(), dr["P6"].ToString(), dr["P7"].ToString(), dr["P8"].ToString(), dr["P9"].ToString(), dr["P10"].ToString(), dr["P11"].ToString(), dr["P12"].ToString(), dr["P13"].ToString(), dr["P14"].ToString(), dr["P15"].ToString(), dr["sNO"].ToString(), dr["SECTION_CHIEF"].ToString());
				}
				dr.Close();
				cn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				dr.Close();
				cn.Close();
			}
		}

		public void LoadRecords4()
		{
			try
			{
				dataGridView1.Rows.Clear();
				int i = 0;
				cn.Open();
				cm = new SqlCommand("SELECT idattendancepayroll, CONCAT(lastname,', ',firstname,' ',middlename) as NAME,idnumber as EMPLOYEEID,logdate as LOGDATE,am_in AS AM_IN,am_out AS AM_OUT,TotalAM,pm_in AS PM_IN,pm_out as PM_OUT,TotalPM,OT_IN,OT_OUT,TotalOT,CalAM,CalPM,CalOT,AddHours,Total_Hours,FULLNAME,status,assign FROM tblAttendancePayroll INNER JOIN tblemployee ON tblAttendancePayroll.idemployee=tblemployee.idemployee WHERE(cast(logdate as datetime) BETWEEN '" + dtFrom.Text + "' AND '" + dtTo.Text + "') AND assign= '" + cboAssign.Text + "' AND FULLNAME ='" + cboFullName.Text + "' AND status= 'ACTIVE' ORDER BY NAME,logdate", cn);
				dr = cm.ExecuteReader();
				while (dr.Read())
				{
					i++;
					dataGridView1.Rows.Add(i, dr["idattendancepayroll"].ToString(), dr["EMPLOYEEID"].ToString(), dr["NAME"].ToString(), DateTime.Parse(dr["LOGDATE"].ToString()).ToShortDateString(), dr["AM_IN"].ToString(), dr["AM_OUT"].ToString(), dr["CalAM"].ToString(), dr["TotalAM"].ToString(), dr["PM_IN"].ToString(), dr["PM_OUT"].ToString(), dr["CalPM"].ToString(), dr["TotalPM"].ToString(), dr["OT_IN"].ToString(), dr["OT_OUT"].ToString(), dr["CalOT"].ToString(), dr["TotalOT"].ToString(), dr["AddHours"].ToString(), dr["Total_Hours"].ToString());//, DateTime.Parse(dr["DCOVERED_FROM"].ToString()).ToShortDateString(), DateTime.Parse(dr["DCOVERED_TO"].ToString()).ToShortDateString(), dr["PURPOSE"].ToString(), dr["REMARKS"].ToString(), dr["STATUS"].ToString(), dr["P1"].ToString(), dr["P2"].ToString(), dr["P3"].ToString(), dr["P4"].ToString(), dr["P5"].ToString(), dr["P6"].ToString(), dr["P7"].ToString(), dr["P8"].ToString(), dr["P9"].ToString(), dr["P10"].ToString(), dr["P11"].ToString(), dr["P12"].ToString(), dr["P13"].ToString(), dr["P14"].ToString(), dr["P15"].ToString(), dr["sNO"].ToString(), dr["SECTION_CHIEF"].ToString());
				}
				dr.Close();
				cn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				dr.Close();
				cn.Close();
			}
		}

		public void LoadFullNameToComboBox()
		{
			cn.Open();
			cm = new SqlCommand("SELECT CONCAT(lastname,', ',firstname,' ',middlename) AS FullName FROM tblemployee ORDER BY FullName", cn);
			dr = cm.ExecuteReader();
			AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

			while (dr.Read())
			{
				collection.Add(dr["FullName"].ToString());
			}

			cboFullName.AutoCompleteMode = AutoCompleteMode.Suggest;
			cboFullName.AutoCompleteSource = AutoCompleteSource.CustomSource;
			cboFullName.AutoCompleteCustomSource = collection;

			//cboPrint.AutoCompleteMode = AutoCompleteMode.Suggest;
			//cboPrint.AutoCompleteSource = AutoCompleteSource.CustomSource;
			//cboPrint.AutoCompleteCustomSource = collection;

			dr.Close();
			cn.Close();
		}

		public void LoadAssignToComboBox()
		{
			cn.Open();
			cm = new SqlCommand("SELECT Assignment FROM tblAssignment ORDER BY Assignment", cn);
			dr = cm.ExecuteReader();
			AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

			while (dr.Read())
			{
				collection.Add(dr["Assignment"].ToString());
			}

			cboAssign.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			cboAssign.AutoCompleteSource = AutoCompleteSource.CustomSource;
			cboAssign.AutoCompleteCustomSource = collection;

			//cboPrint.AutoCompleteMode = AutoCompleteMode.Suggest;
			//cboPrint.AutoCompleteSource = AutoCompleteSource.CustomSource;
			//cboPrint.AutoCompleteCustomSource = collection;

			dr.Close();
			cn.Close();
		}

		public void LoadAssignRecord()
		{
			cboAssign.Items.Clear();
			cboAssign.Items.Add("ALL");
			int i = 0;
			cn.Open();
			cm = new SqlCommand("SELECT Assignment FROM tblAssignment ORDER BY Assignment", cn);
			dr = cm.ExecuteReader();
			while (dr.Read())
			{
				i++;
				//cboSectionChief.Text.ToUpper();
				cboAssign.Items.Add(dr["Assignment"].ToString().ToUpper());
				//comboBox4.Items.Add(dr["NAME"].ToString().ToUpper());
			}
			dr.Close();
			cn.Close();
		}

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				var f = new attendanceandpayroll.frmUpdateTimeAndHours();
				f.lblTodaysdate.Text = DateTime.Now.ToString();
				f.lblLoginName.Text = lblLoginName.Text;
				if (e.RowIndex >= 0)
				{
					f.lblIdPayroll.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
					f.lblName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
					f.dtLogdate.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
					//f.txtAddHours.Text = dataGridView1.Rows[e.RowIndex].Cells[17].Value.ToString();
					f.ShowDialog();
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}

		private void dtFrom_ValueChanged(object sender, EventArgs e)
		{
			dtTo.Value = dtFrom.Value.AddDays(5);
		}
	}
}
