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

namespace AldoBuildersPayrollSystem.attendanceandpayroll
{
	public partial class frmDateCovered : Form
	{
		SqlConnection cn;
		SqlCommand cm;
		SqlDataReader dr;
		DBConnection db = new DBConnection();
		public frmDateCovered()
		{
			InitializeComponent();
			cn = new SqlConnection(db.GetConnection());
			LoadRecords();
		}

		private void frmDateCovered_Load(object sender, EventArgs e)
		{

		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				//	if (txtFirstName.Text == string.Empty || txtLastName.Text == string.Empty || txtRFID.Text == string.Empty || txtIDNumber.Text == string.Empty)
				//	{
				//		MessageBox.Show("REQUIRED MISSING FIELDS", _title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				//		return;

				//	}
				//if (MessageBox.Show("ADD NEW RECORD? CLICK YES TO CONFIRM", "Date Covered", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				//{
				cn.Open();
				cm = new SqlCommand("INSERT INTO tblDateCovered (Date_Covered)VALUES(@Date_Covered)", cn);
				cm.Parameters.AddWithValue("@Date_Covered", dtFrom.Text + " - " + dtTo.Text);

				cm.ExecuteNonQuery();
				cn.Close();
				MessageBox.Show("DATE_COVERED HAS BEEN SUCCESSFULLY SAVED", "Date Covered", MessageBoxButtons.OK, MessageBoxIcon.Information);
				//Clear();
				LoadRecords();
				//}

			}
			catch (Exception ex)
			{
				cn.Close();
				MessageBox.Show(ex.Message, "Date Covered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		public void LoadRecords()
		{
			try
			{
				dataGridView1.Rows.Clear();
				//int i = 0;
				cn.Open();
				cm = new SqlCommand("SELECT * FROM tblDateCovered ORDER BY idDateCovered DESC", cn);
				dr = cm.ExecuteReader();
				while (dr.Read())
				{
					//i++;
					dataGridView1.Rows.Add(dr["idDateCovered"].ToString(), dr["Date_Covered"].ToString());//, DateTime.Parse(dr["DCOVERED_FROM"].ToString()).ToShortDateString(), DateTime.Parse(dr["DCOVERED_TO"].ToString()).ToShortDateString(), dr["PURPOSE"].ToString(), dr["REMARKS"].ToString(), dr["STATUS"].ToString(), dr["P1"].ToString(), dr["P2"].ToString(), dr["P3"].ToString(), dr["P4"].ToString(), dr["P5"].ToString(), dr["P6"].ToString(), dr["P7"].ToString(), dr["P8"].ToString(), dr["P9"].ToString(), dr["P10"].ToString(), dr["P11"].ToString(), dr["P12"].ToString(), dr["P13"].ToString(), dr["P14"].ToString(), dr["P15"].ToString(), dr["sNO"].ToString(), dr["SECTION_CHIEF"].ToString());
				}
				dr.Close();
				cn.Close();
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

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			string colName = dataGridView1.Columns[e.ColumnIndex].Name;

			if (colName == "colDelete")
			{
				if (MessageBox.Show("YOU WANT TO DELETE THIS RECORD? CLICK YES TO CONFIRM", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					cn.Open();
					cm = new SqlCommand("DELETE FROM tblDateCovered WHERE idDateCovered = '" + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", cn);
					cm.ExecuteNonQuery();
					cn.Close();
					MessageBox.Show("RECORD HAS BEEN SUCCESSFULLY DELETED", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
					LoadRecords();
				}
			}
		}
	}
}
