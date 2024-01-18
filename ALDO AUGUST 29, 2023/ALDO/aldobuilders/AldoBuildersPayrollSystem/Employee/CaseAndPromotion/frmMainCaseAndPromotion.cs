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
using Microsoft.Reporting.Map.WebForms.BingMaps;

namespace AldoBuildersPayrollSystem.Employee.CaseAndPromotion
{
	public partial class frmMainCaseAndPromotion : Form
	{
		SqlConnection cn;
		SqlCommand cm;
		SqlDataReader dr;
		DBConnection db = new DBConnection();

		DataTable dt;
		DataTable dt1;
		DataTable dt2;
		public frmMainCaseAndPromotion()
		{
			InitializeComponent();
			cn = new SqlConnection(db.GetConnection());
			LoadRecords();
		}

		private void btnAddNewPromotion_Click(object sender, EventArgs e)
		{
			var frm = new Employee.CaseAndPromotion.frmAddNewPromotionRecord(this);
			frm.label5.Text = id.Text;
			frm.lblpostedby.Text = lblLoginName.Text;
			frm.ShowDialog();
		}

		private void btnAddNewCase_Click(object sender, EventArgs e)
		{
			var frm = new Employee.CaseAndPromotion.frmAddNewCaseRecord(this);
			frm.label1.Text = id.Text;
			frm.lblpostedby.Text = lblLoginName.Text;
			frm.ShowDialog();
		}

		public void LoadRecords()
		{
			//Load Records to datagridview
			try
			{
				cn.Open();
				cm = new SqlCommand("SELECT idemployee, firstname AS FirstName, middlename as MiddleName, lastname AS LastName, status as Status FROM tblemployee WHERE lastname LIKE '%" + txtSearch.Text + "%' ORDER BY lastname", cn);

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
				cm = new SqlCommand("SELECT idcase,idemployee,datecase AS DATE,type as TYPE,reason,postedby FROM tblcase WHERE idemployee = '" + id.Text + "' ORDER BY datecase DESC", cn);

				SqlDataAdapter sda = new SqlDataAdapter();
				sda.SelectCommand = cm;
				dt1 = new DataTable();
				sda.Fill(dt1);
				BindingSource bSource = new BindingSource();
				bSource.DataSource = dt1;
				dataGridView3.DataSource = bSource;
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

		public void LoadRecords2()
		{
			//Load Records to datagridview
			try
			{
				cn.Open();
				cm = new SqlCommand("SELECT idpromotion,idemployee,datepromoted AS DATE,designation as Designation,rate AS Rate,reasonofpromotion AS Reason,postedby FROM tblpromotion WHERE idemployee = '" + id.Text + "' ORDER BY datepromoted DESC", cn);

				SqlDataAdapter sda = new SqlDataAdapter();
				sda.SelectCommand = cm;
				dt2 = new DataTable();
				sda.Fill(dt2);
				BindingSource bSource = new BindingSource();
				bSource.DataSource = dt2;
				dataGridView2.DataSource = bSource;
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

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			DataView DV = new DataView(dt);
			DV.RowFilter = string.Format("lastname LIKE '%{0}%'", txtSearch.Text);
			dataGridView1.DataSource = DV;
			//LoadRecords();
		}

		private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			dataGridView1.Columns[0].Visible = false;

			DataGridViewColumn column1 = dataGridView1.Columns[1];
			column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

			DataGridViewColumn column2 = dataGridView1.Columns[2];
			column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

			DataGridViewColumn column3 = dataGridView1.Columns[3];
			column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

			DataGridViewColumn column4 = dataGridView1.Columns[4];
			column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

			//DataGridViewColumn column5 = dataGridView1.Columns[5];
			//column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			//dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
		}

		private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
			LoadRecords1();
			LoadRecords2();
			txtCaseReason.Clear();
			txtReasonPromotion.Clear();
		}

		private void dataGridView3_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			dataGridView3.Columns[0].Visible = false;
			dataGridView3.Columns[1].Visible = false;
			dataGridView3.Columns[4].Visible = false;
			dataGridView3.Columns[5].Visible = false;


			//DataGridViewColumn column1 = dataGridView1.Columns[1];
			//column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			//dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

			DataGridViewColumn column2 = dataGridView3.Columns[2];
			column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridView3.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			DataGridViewColumn column3 = dataGridView3.Columns[3];
			column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView3.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

			//DataGridViewColumn column4 = dataGridView1.Columns[4];
			//column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			//dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
		}

		private void dataGridView3_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			txtCaseReason.Text = dataGridView3.CurrentRow.Cells[4].Value.ToString();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			LoadRecords1();
			LoadRecords2();
		   //txtCaseReason.Clear();
		}

		private void dataGridView3_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
		{

		}

		private void dataGridView2_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{

		}

		private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			txtReasonPromotion.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
		}

		private void dataGridView2_DataBindingComplete_1(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			dataGridView2.Columns[0].Visible = false;
			dataGridView2.Columns[1].Visible = false;
			dataGridView2.Columns[5].Visible = false;
			dataGridView2.Columns[6].Visible = false;

			//DataGridViewColumn column1 = dataGridView1.Columns[1];
			//column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			//dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

			DataGridViewColumn column2 = dataGridView2.Columns[2];
			column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridView2.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			DataGridViewColumn column3 = dataGridView2.Columns[3];
			column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView2.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

			DataGridViewColumn column4 = dataGridView2.Columns[4];
			column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridView2.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		}

		private void dataGridView2_CellEnter_1(object sender, DataGridViewCellEventArgs e)
		{
			txtReasonPromotion.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
		}
	}
}
