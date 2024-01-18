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


namespace AldoBuildersPayrollSystem.attendanceandpayroll
{
	public partial class frmSignatories : Form
	{
		DataTable dt = new DataTable();
		SqlDataAdapter sda = new SqlDataAdapter();
		SqlConnection cn;
		SqlCommand cm;
		DBConnection db = new DBConnection();
		public frmSignatories()
		{
			InitializeComponent();
			cn = new SqlConnection(db.GetConnection());
			LoadRecords();
		}

		public void LoadRecords()
		{
			// Load Records to datagridview
			try
			{
				dt.Clear();
				cn.Open();
				cm = new SqlCommand("SELECT idSignatories AS ID, Name1 AS NAME1, Position1 AS POSITION1, Name2 AS NAME2, Position2 AS POSITION2 FROM tblSignatories", cn);
				sda.SelectCommand = cm;
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

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sda);

				// Update changes made in the DataGridView back to the database
				sda.UpdateCommand = commandBuilder.GetUpdateCommand();
				sda.Update(dt);
				MessageBox.Show("Changes saved successfully.");
				LoadRecords();
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}

		private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{

			dataGridView1.Columns[0].Visible = false;

			DataGridViewColumn column1 = dataGridView1.Columns[1];
			column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			DataGridViewColumn column2 = dataGridView1.Columns[2];
			column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			DataGridViewColumn column3 = dataGridView1.Columns[3];
			column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			DataGridViewColumn column4 = dataGridView1.Columns[4];
			column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		}
	}
}
