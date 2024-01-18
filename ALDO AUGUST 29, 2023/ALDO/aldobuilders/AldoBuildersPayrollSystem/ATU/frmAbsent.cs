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

namespace AldoBuildersPayrollSystem.ATU
{
	public partial class frmAbsent : Form
	{
		SqlConnection cn;
		SqlCommand cm;
		SqlDataReader dr;
		DBConnection db = new DBConnection();

		DataTable dt;
		DataTable dt1;
		public frmAbsent()
		{
			InitializeComponent();
			cn = new SqlConnection(db.GetConnection());
			LoadRecords();
		}

		public void LoadRecords()
		{
			//Load Records to datagridview
			try
			{
				cn.Open();
				cm = new SqlCommand("SELECT idemployee,idnumber,FULLNAME FROM tblemployee WHERE FULLNAME LIKE '%" + txtSearch.Text + "%' ORDER BY FULLNAME", cn);

				SqlDataAdapter sda = new SqlDataAdapter();
				sda.SelectCommand = cm;
				dt = new DataTable();
				sda.Fill(dt);
				BindingSource bSource = new BindingSource();
				bSource.DataSource = dt;
				dataGridView1.DataSource = bSource;
				sda.Update(dt);
				cn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				cn.Close();
			}
			// DatagridviewModify();
		}

		public void LoadRecords1()
		{
			//Load Records to datagridview
			try
			{
				cn.Open();
				cm = new SqlCommand("SELECT * FROM tblAbsences WHERE idemployee = '" + idemployee.Text + "' ORDER BY Name,Logdate DESC", cn);

				SqlDataAdapter sda = new SqlDataAdapter();
				sda.SelectCommand = cm;
				dt1 = new DataTable();
				sda.Fill(dt1);
				BindingSource bSource = new BindingSource();
				bSource.DataSource = dt1;
				dataGridView2.DataSource = bSource;
				sda.Update(dt1);
				cn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				cn.Close();
			}
			// DatagridviewModify();
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{

			DataView DV = new DataView(dt);
			DV.RowFilter = string.Format("FULLNAME LIKE '%{0}%'", txtSearch.Text);
			dataGridView1.DataSource = DV;
		}

		private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
		{

			idemployee.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
			idnumber.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
			lblName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
			LoadRecords1();
		}

		private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			dataGridView1.Columns[0].Visible = false;
			dataGridView1.Columns[1].Visible = false;

			DataGridViewColumn column2 = dataGridView1.Columns[2];
			column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				if (txtReason.Text == string.Empty || txtRemarks.Text == string.Empty)
				{
					MessageBox.Show("REQUIRED MISSING FIELDS", "Absent", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;

				}
				if (MessageBox.Show("ADD NEW RECORD? CLICK YES TO CONFIRM", "Absent", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					cn.Open();
					cm = new SqlCommand("INSERT INTO tblAbsences (idemployee,IDNumber,Name,Logdate,ReasonForAbsence,Remarks,AskedForPermission,Posted_By)VALUES(@idemployee,@IDNumber,@Name,@Logdate,@ReasonForAbsence,@Remarks,@AskedForPermission,@Posted_By)", cn);
					cm.Parameters.AddWithValue("@idemployee", idemployee.Text);
					cm.Parameters.AddWithValue("@IDNumber", idnumber.Text);
					cm.Parameters.AddWithValue("@Name", lblName.Text);
					cm.Parameters.AddWithValue("@Logdate", DateTime.Parse(dtDateAbsence.Text));
					cm.Parameters.AddWithValue("@ReasonForAbsence", txtReason.Text);
					cm.Parameters.AddWithValue("@Remarks", txtRemarks.Text);
					cm.Parameters.AddWithValue("@AskedForPermission", cboPermission.Text);
					cm.Parameters.AddWithValue("@Posted_By", lblLoginName.Text);
					cm.ExecuteNonQuery();
					cn.Close();
					MessageBox.Show("RECORD HAS BEEN SUCCESSFULLY SAVED", "ABSENCES", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Clear();
					LoadRecords1();
				}
			}
			catch (Exception ex)
			{
				cn.Close();
				MessageBox.Show(ex.Message, "Absent", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		public void Clear()
		{
			txtReason.Clear();
			txtRemarks.Clear();
			dtDateAbsence.Text = DateTime.Now.ToString();
		}

		private void dataGridView2_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			dataGridView2.Columns[0].Visible = false;
			dataGridView2.Columns[1].Visible = false;
			dataGridView2.Columns[3].Visible = false;
			dataGridView2.Columns[8].Visible = false;

			DataGridViewColumn column2 = dataGridView2.Columns[2];
			column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
			dataGridView2.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

			DataGridViewColumn column4 = dataGridView2.Columns[4];
			column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
			dataGridView2.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			DataGridViewColumn column5 = dataGridView2.Columns[5];
			column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView2.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

			DataGridViewColumn column6 = dataGridView2.Columns[6];
			column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
			dataGridView2.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

			DataGridViewColumn column7 = dataGridView2.Columns[7];
			column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
			dataGridView2.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			DataGridViewColumn column9 = dataGridView2.Columns[9];
			column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
			dataGridView2.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		}

		private void dataGridView2_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
		{
			int numRows1 = dataGridView2.Rows.Count;
			label7.Text = numRows1.ToString("#,##0");
		}
	}
}
