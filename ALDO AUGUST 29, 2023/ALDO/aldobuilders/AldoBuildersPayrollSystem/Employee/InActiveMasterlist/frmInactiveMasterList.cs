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


namespace AldoBuildersPayrollSystem.Employee.InActiveMasterlist
{
	public partial class frmInactiveMasterList : Form
	{
		SqlConnection cn;
		SqlCommand cm;
		SqlDataReader dr;
		DataTable dt;

		DBConnection db = new DBConnection();
		public frmInactiveMasterList()
		{
			InitializeComponent();
			cn = new SqlConnection(db.GetConnection());
			LoadRecords();
		}

		private void frmInactiveMasterList_Load(object sender, EventArgs e)
		{

		}

		public void LoadRecords()
		{
			//Load Records to datagridview
			try
			{
				cn.Open();
				cm = new SqlCommand("SELECT idemployee,idnumber as ID_NUMBER,RFID,firstname as FIRSTNAME,middlename as MIDDLENAME,lastname as LASTNAME,birthday as BIRTHDAY,age as AGE,address as ADDRESS,designation,rate,sssnumber,philhealth,pagibig,datehired,dateout,status,assign,pictureURL,otherinformation,postedby,Category FROM tblemployee WHERE status = 'INACTIVE' ORDER BY lastname", cn);

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
			// Adjust Column Header
			dataGridView1.Columns[0].Visible = false;
			//dataGridView1.Columns[6].Visible = false;
			dataGridView1.Columns[9].Visible = false;
			dataGridView1.Columns[10].Visible = false;
			dataGridView1.Columns[11].Visible = false;
			dataGridView1.Columns[12].Visible = false;
			dataGridView1.Columns[13].Visible = false;
			dataGridView1.Columns[14].Visible = false;
			dataGridView1.Columns[15].Visible = false;
			dataGridView1.Columns[16].Visible = false;
			dataGridView1.Columns[17].Visible = false;
			dataGridView1.Columns[18].Visible = false;
			dataGridView1.Columns[19].Visible = false;
			dataGridView1.Columns[20].Visible = false;

			DataGridViewColumn column1 = dataGridView1.Columns[1];
			column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
			dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


			DataGridViewColumn column2 = dataGridView1.Columns[2];
			column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
			dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			DataGridViewColumn column3 = dataGridView1.Columns[3];
			column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

			DataGridViewColumn column4 = dataGridView1.Columns[4];
			column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

			DataGridViewColumn column5 = dataGridView1.Columns[5];
			column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

			DataGridViewColumn column6 = dataGridView1.Columns[6];
			column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
			dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

			DataGridViewColumn column7 = dataGridView1.Columns[7];
			column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
			dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			DataGridViewColumn column8 = dataGridView1.Columns[8];
			column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView1.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
		}

		private void dataGridView1_DoubleClick(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				var f = new Employee.MasterList.frmAddNewEmployee(null, this);
				f.btnSave.Enabled = false;
				f.btnDelete.Enabled = false;
				f.btnUpdate.Visible = false;
				f.btnUpdate2.Visible = true;
				f.btnCancel.Enabled = false;
				f.txtBrowseImage.Enabled = false;
				f.btnStarCamera.Enabled = false;
				f.btnCaptureImage.Enabled = false;
				f.txtIDNumber.Enabled = false;
				f.txtRFID.Enabled = false;
				f.txtFirstName.Enabled = false;
				f.txtMiddleName.Enabled = false;
				f.txtLastName.Enabled = false;
				f.dtBirthDay.Enabled = false;
				f.txtAddress.Enabled = false;
				f.txtSSSNumber.Enabled = false;
				f.txtPhilhealthNumber.Enabled = false;
				f.txtPagibig.Enabled = false;
				f.dtDateHired.Enabled = false;
				f.cboAssign.Enabled = false;
				f.dtDateOut.Enabled = false;
				f.txtOtherInformation.Enabled = false;
				f.cboDesignation.Enabled = false;
				f.cboRate.Enabled = false;
				f.btnDesignation.Enabled = false;
				f.btnAssignment.Enabled = false;
				f.cboCategory.Enabled = false;
			



				//if (suser == "Administrator")
				//{
				//	f.btnDelete.Enabled = true;
				//}

				//  f.txtSearch.Visible = false;
				if (e.RowIndex >= 0)
				{
					f.lblid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
					f.txtIDNumber.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
					f.txtRFID.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
					f.txtFirstName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
					f.txtMiddleName.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
					f.txtLastName.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
					f.dtBirthDay.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
					f.txtAge.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
					f.txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
					f.cboDesignation.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
					f.cboRate.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
					f.txtSSSNumber.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
					f.txtPhilhealthNumber.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
					f.txtPagibig.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
					f.dtDateHired.Text = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
					f.dtDateOut.Text = dataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString();
					f.cboStatus.Text = dataGridView1.Rows[e.RowIndex].Cells[16].Value.ToString();
					f.cboAssign.Text = dataGridView1.Rows[e.RowIndex].Cells[17].Value.ToString();
					f.txtPictureURL.Text = dataGridView1.Rows[e.RowIndex].Cells[18].Value.ToString();
					f.txtOtherInformation.Text = dataGridView1.Rows[e.RowIndex].Cells[19].Value.ToString();
					f.cboCategory.Text = dataGridView1.Rows[e.RowIndex].Cells[21].Value.ToString();
					//	f.lblPostedby.Text = dataGridView1.Rows[e.RowIndex].Cells[20].Value.ToString();
					f.LoadImageToPictureBox();
					f.ShowDialog();
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}

		private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
		{
			int numRows1 = dataGridView1.Rows.Count;
			label4.Text = numRows1.ToString("#,##0");
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			DataView DV = new DataView(dt);
			DV.RowFilter = string.Format("lastname LIKE '%{0}%'", txtSearch.Text);
			dataGridView1.DataSource = DV;
		}
	}
}
