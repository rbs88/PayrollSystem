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
using System.Data.Common;

namespace AldoBuildersPayrollSystem.attendanceandpayroll
{
    public partial class frmDeduction : Form
    {
        DataTable dt = new DataTable();
        SqlDataAdapter sda = new SqlDataAdapter();
        SqlConnection cn;
        SqlCommand cm;
        SqlDataReader dr;
        SqlDataAdapter da;
        DBConnection db = new DBConnection();
        public frmDeduction()
        {
            InitializeComponent();
            cn = new SqlConnection(db.GetConnection());
            //SetColumnType();
        }

        //public void LoadRecords1()
        //{
        //	try
        //	{
        //		dataGridView1.Rows.Clear();
        //		int i = 0;
        //		cn.Open();
        //		cm = new SqlCommand("SELECT idemployee,FULLNAME,ssscontribution, philhealthcontribution, pagibigcontribution, water, electricity, Housing, other1Disc, other1, other2Disc, other2, other3Disc, other3 FROM tblemployee WHERE status='ACTIVE' ORDER BY FULLNAME", cn);
        //		dr = cm.ExecuteReader();
        //		while (dr.Read())
        //		{
        //			i++;
        //			dataGridView1.Rows.Add(i, dr["idemployee"].ToString(), dr["FULLNAME"].ToString(), dr["ssscontribution"].ToString(), dr["philhealthcontribution"].ToString(), dr["pagibigcontribution"].ToString(), dr["water"].ToString(), dr["electricity"].ToString(), dr["Housing"].ToString(), dr["other1Disc"].ToString(), dr["other1"].ToString(), dr["other2Disc"].ToString(), dr["other2"].ToString(), dr["other3Disc"].ToString(), dr["other3"].ToString());   // DateTime.Parse(dr["DCOVERED_FROM"].ToString()).ToShortDateString(), DateTime.Parse(dr["DCOVERED_TO"].ToString()).ToShortDateString(), dr["PURPOSE"].ToString(), dr["REMARKS"].ToString(), dr["STATUS"].ToString(), dr["P1"].ToString(), dr["P2"].ToString(), dr["P3"].ToString(), dr["P4"].ToString(), dr["P5"].ToString(), dr["P6"].ToString(), dr["P7"].ToString(), dr["P8"].ToString(), dr["P9"].ToString(), dr["P10"].ToString(), dr["P11"].ToString(), dr["P12"].ToString(), dr["P13"].ToString(), dr["P14"].ToString(), dr["P15"].ToString(), dr["sNO"].ToString(), dr["SECTION_CHIEF"].ToString());
        //		}
        //		dr.Close();
        //		cn.Close();
        //	}
        //	catch (Exception ex)
        //	{
        //		MessageBox.Show(ex.Message);
        //		cn.Close();
        //	}
        //}

        public void LoadRecords()
        {
            // Load Records to datagridview
            try
            {
                dt.Clear();
                cn.Open();
                cm = new SqlCommand("SELECT idemployee,FULLNAME,ssscontribution AS SSS, philhealthcontribution AS Philhealth, pagibigcontribution AS Pagibig, water AS Water, electricity AS Electricity, Housing, other1Disc AS Other1Desc, other1 AS Other1Amount, other2Disc AS Other2Desc, other2 AS Other2Amount, other3Disc AS Other3Desc, other3 AS Other3Amount, ValeDisc AS ValeDesc,Vale FROM tblemployee WHERE status='ACTIVE' ORDER BY FULLNAME", cn);
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

        private void btnLoadRecord_Click(object sender, EventArgs e)
        {
            LoadRecords();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //public void SetColumnType()
        //{
        //	// Create a DataGridViewTextBoxColumn
        //	//DataGridViewTextBoxColumn decimalColumn = new DataGridViewTextBoxColumn();
        //	try
        //	{
        //		dataGridView1.Columns[3].ValueType = typeof(decimal);
        //		dataGridView1.Columns[4].ValueType = typeof(decimal);
        //		dataGridView1.Columns[5].ValueType = typeof(decimal);
        //		dataGridView1.Columns[6].ValueType = typeof(decimal);
        //		dataGridView1.Columns[7].ValueType = typeof(decimal);
        //		dataGridView1.Columns[8].ValueType = typeof(decimal);
        //		dataGridView1.Columns[10].ValueType = typeof(decimal);
        //		dataGridView1.Columns[12].ValueType = typeof(decimal);
        //		dataGridView1.Columns[14].ValueType = typeof(decimal);
        //	}
        //	catch (Exception)
        //	{

        //		MessageBox.Show("Please Enter number only");
        //	}


        //	// Set the column header text
        //	//decimalColumn.HeaderText = "Decimal Column";

        //	//// Set the column data type to decimal
        //	//decimalColumn.ValueType = typeof(decimal);

        //	//// Add the column to the DataGridView
        //	//dataGridView1.Columns.Add(decimalColumn);
        //}


        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //	if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            //	{
            //		// Get the changed cell value
            //		DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            //		string columnName = dataGridView1.Columns[e.ColumnIndex].Name;
            //		object newValue = cell.Value;

            //		// Update the corresponding row in the DataTable
            //		DataRow row = dt.Rows[e.RowIndex];
            //		row[columnName] = newValue;

            //		// Update the database using the DataAdapter
            //		sda.Update(dt);
            //	}
            //}
            //catch (Exception ex)
            //{

            //	MessageBox.Show(ex.Message);
            //}

        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Adjust Column Header
            dataGridView1.Columns[0].Visible = false;
            //dataGridView1.Columns[6].Visible = false;
            //dataGridView1.Columns[9].Visible = false;
            //dataGridView1.Columns[10].Visible = false;
            //dataGridView1.Columns[11].Visible = false;
            //dataGridView1.Columns[12].Visible = false;
            //dataGridView1.Columns[13].Visible = false;
            //dataGridView1.Columns[14].Visible = false;
            //dataGridView1.Columns[15].Visible = false;
            //dataGridView1.Columns[16].Visible = false;
            //dataGridView1.Columns[17].Visible = false;
            //dataGridView1.Columns[18].Visible = false;
            //dataGridView1.Columns[19].Visible = false;
            //dataGridView1.Columns[20].Visible = false;

            //DataGridViewColumn column1 = dataGridView1.Columns[0];
            //column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            DataGridViewColumn column1 = dataGridView1.Columns[1];
            column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[1].ReadOnly = true;

            DataGridViewColumn column2 = dataGridView1.Columns[2];
            column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewColumn column3 = dataGridView1.Columns[3];
            column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewColumn column4 = dataGridView1.Columns[4];
            column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewColumn column5 = dataGridView1.Columns[5];
            column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewColumn column6 = dataGridView1.Columns[6];
            column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewColumn column7 = dataGridView1.Columns[7];
            column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewColumn column8 = dataGridView1.Columns[8];
            column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewColumn column9 = dataGridView1.Columns[9];
            column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewColumn column10 = dataGridView1.Columns[10];
            column10.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewColumn column11 = dataGridView1.Columns[11];
            column11.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewColumn column12 = dataGridView1.Columns[12];
            column12.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewColumn column13 = dataGridView1.Columns[13];
            column13.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewColumn column14 = dataGridView1.Columns[14];
            column14.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewColumn column15 = dataGridView1.Columns[15];
            column15.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dt);
            DV.RowFilter = string.Format("FULLNAME LIKE '%{0}%'", txtSearch.Text);
            dataGridView1.DataSource = DV;
        }
    }
}
