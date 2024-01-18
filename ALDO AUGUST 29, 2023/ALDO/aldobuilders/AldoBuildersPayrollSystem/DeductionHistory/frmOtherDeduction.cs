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

namespace AldoBuildersPayrollSystem.DeductionHistory
{
	public partial class frmOtherDeduction : Form
	{
		SqlConnection cn;
		SqlCommand cm;
		SqlDataReader dr;
		DataTable dt;
		DataTable dt1;
		DataTable dt2;
		DataTable dt3;
		DataTable dt4;
		DataTable dt5;
		DataTable dt6;
		DBConnection db = new DBConnection();
		public frmOtherDeduction()
		{
			InitializeComponent();
			cn = new SqlConnection(db.GetConnection());
			LoadRecordsEmployee();
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			DataView DV = new DataView(dt);
			DV.RowFilter = string.Format("FULLNAME LIKE '%{0}%'", txtSearch.Text);
			dataGridView1.DataSource = DV;
		}

		public void LoadRecordsEmployee()
		{
			//Load Records to datagridview
			try
			{
				cn.Open();
				cm = new SqlCommand("SELECT idnumber as ID_NUMBER,FULLNAME FROM tblemployee ORDER BY FULLNAME", cn);

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

		private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			DataGridViewColumn column1 = dataGridView1.Columns[0];
			column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
			dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


			DataGridViewColumn column2 = dataGridView1.Columns[1];
			column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
		}

		private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			idnumber.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
		}

		public void LoadRecordsOther1()
		{
			//Load Records to datagridview
			try
			{
				cn.Open();
				cm = new SqlCommand("SELECT idfinalPayroll,ID,Date_Covered,other1Desc AS Description, other1 AS Amount FROM tblPayroll WHERE ID = '" + idnumber.Text + "' ORDER BY idfinalPayroll DESC", cn);

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

		public void LoadRecordsOther2()
		{
			//Load Records to datagridview
			try
			{
				cn.Open();
				cm = new SqlCommand("SELECT idfinalPayroll,ID,Date_Covered,other2Desc AS Description, other2 AS Amount FROM tblPayroll WHERE ID = '" + idnumber.Text + "' ORDER BY idfinalPayroll DESC", cn);

				SqlDataAdapter sda = new SqlDataAdapter();
				sda.SelectCommand = cm;
				dt2 = new DataTable();
				sda.Fill(dt2);
				BindingSource bSource = new BindingSource();
				bSource.DataSource = dt2;
				dataGridView3.DataSource = bSource;
				sda.Update(dt2);
				cn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				cn.Close();
			}
			// DatagridviewModify();
		}

		public void LoadRecordsOther3()
		{
			//Load Records to datagridview
			try
			{
				cn.Open();
				cm = new SqlCommand("SELECT idfinalPayroll,ID,Date_Covered,other3Desc AS Description, other3 AS Amount FROM tblPayroll WHERE ID = '" + idnumber.Text + "' ORDER BY idfinalPayroll DESC", cn);

				SqlDataAdapter sda = new SqlDataAdapter();
				sda.SelectCommand = cm;
				dt3 = new DataTable();
				sda.Fill(dt3);
				BindingSource bSource = new BindingSource();
				bSource.DataSource = dt3;
				dataGridView4.DataSource = bSource;
				sda.Update(dt3);
				cn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				cn.Close();
			}
			// DatagridviewModify();
		}

		public void LoadRecordsVale()
		{
			//Load Records to datagridview
			try
			{
				cn.Open();
				cm = new SqlCommand("SELECT idfinalPayroll,ID,Date_Covered,ValeDesc AS Description, Vale AS Amount FROM tblPayroll WHERE ID = '" + idnumber.Text + "' ORDER BY idfinalPayroll DESC", cn);

				SqlDataAdapter sda = new SqlDataAdapter();
				sda.SelectCommand = cm;
				dt4 = new DataTable();
				sda.Fill(dt4);
				BindingSource bSource = new BindingSource();
				bSource.DataSource = dt4;
				dataGridView5.DataSource = bSource;
				sda.Update(dt4);
				cn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				cn.Close();
			}
			// DatagridviewModify();
		}

		private void dataGridView2_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			dataGridView2.Columns[0].Visible = false;


			DataGridViewColumn column1 = dataGridView2.Columns[1];
			column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridView2.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			DataGridViewColumn column2 = dataGridView2.Columns[2];
			column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView2.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			DataGridViewColumn column3 = dataGridView2.Columns[3];
			column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridView2.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			DataGridViewColumn column4 = dataGridView2.Columns[4];
			column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridView2.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		}

		private void idnumber_TextChanged(object sender, EventArgs e)
		{
			LoadRecordsOther1();
			LoadRecordsOther2();
			LoadRecordsOther3();
			LoadRecordsVale();
		}

		private void dataGridView3_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			dataGridView3.Columns[0].Visible = false;


			DataGridViewColumn column1 = dataGridView3.Columns[1];
			column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridView3.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			DataGridViewColumn column2 = dataGridView3.Columns[2];
			column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView3.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			DataGridViewColumn column3 = dataGridView3.Columns[3];
			column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridView3.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			DataGridViewColumn column4 = dataGridView3.Columns[4];
			column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridView3.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		}

		private void dataGridView5_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			dataGridView5.Columns[0].Visible = false;


			DataGridViewColumn column1 = dataGridView5.Columns[1];
			column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridView5.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			DataGridViewColumn column2 = dataGridView5.Columns[2];
			column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView5.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			DataGridViewColumn column3 = dataGridView5.Columns[3];
			column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridView5.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			DataGridViewColumn column4 = dataGridView5.Columns[4];
			column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridView5.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		}

		private void dataGridView4_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			dataGridView4.Columns[0].Visible = false;


			DataGridViewColumn column1 = dataGridView4.Columns[1];
			column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridView4.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			DataGridViewColumn column2 = dataGridView4.Columns[2];
			column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView4.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			DataGridViewColumn column3 = dataGridView4.Columns[3];
			column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridView4.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			DataGridViewColumn column4 = dataGridView4.Columns[4];
			column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridView4.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		}
	}
}
