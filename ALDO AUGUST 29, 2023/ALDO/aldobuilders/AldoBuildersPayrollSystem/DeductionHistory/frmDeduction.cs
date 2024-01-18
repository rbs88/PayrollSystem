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
    public partial class frmDeduction : Form
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
        public frmDeduction()
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

        public void LoadRecordsSSS()
        {
            //Load Records to datagridview
            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT idfinalPayroll,ID,Date_Covered,SSS AS Amount FROM tblPayroll WHERE ID = '" + idnumber.Text + "' ORDER BY idfinalPayroll DESC", cn);

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

        public void LoadRecordsPhilhealth()
        {
            //Load Records to datagridview
            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT idfinalPayroll,ID,Date_Covered,Philhealth AS Amount FROM tblPayroll WHERE ID = '" + idnumber.Text + "' ORDER BY idfinalPayroll DESC", cn);

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
        public void LoadRecordsPagibig()
        {
            //Load Records to datagridview
            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT idfinalPayroll,ID,Date_Covered,Pagibig AS Amount FROM tblPayroll WHERE ID = '" + idnumber.Text + "' ORDER BY idfinalPayroll DESC", cn);

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

        public void LoadRecordsWater()
        {
            //Load Records to datagridview
            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT idfinalPayroll,ID,Date_Covered,Water AS Amount FROM tblPayroll WHERE ID = '" + idnumber.Text + "' ORDER BY idfinalPayroll DESC", cn);

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

        public void LoadRecordsElectricity()
        {
            //Load Records to datagridview
            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT idfinalPayroll,ID,Date_Covered,Electricity AS Amount FROM tblPayroll WHERE ID = '" + idnumber.Text + "' ORDER BY idfinalPayroll DESC", cn);

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cm;
                dt5 = new DataTable();
                sda.Fill(dt5);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dt5;
                dataGridView6.DataSource = bSource;
                sda.Update(dt5);
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cn.Close();
            }
            // DatagridviewModify();
        }

        public void LoadRecordsHousing()
        {
            //Load Records to datagridview
            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT idfinalPayroll,ID,Date_Covered,Housingbill AS Amount FROM tblPayroll WHERE ID = '" + idnumber.Text + "' ORDER BY idfinalPayroll DESC", cn);

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cm;
                dt6 = new DataTable();
                sda.Fill(dt6);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dt6;
                dataGridView7.DataSource = bSource;
                sda.Update(dt6);
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cn.Close();
            }
            // DatagridviewModify();
        }

        private void frmDeduction_Load(object sender, EventArgs e)
        {

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

        private void idnumber_TextChanged(object sender, EventArgs e)
        {
            LoadRecordsSSS();
            LoadRecordsPhilhealth();
            LoadRecordsPagibig();
            LoadRecordsWater();
            LoadRecordsElectricity();
            LoadRecordsHousing();
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
            dataGridView2.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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
            dataGridView3.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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
            dataGridView4.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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
            dataGridView5.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void dataGridView6_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView6.Columns[0].Visible = false;


            DataGridViewColumn column1 = dataGridView6.Columns[1];
            column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView6.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewColumn column2 = dataGridView6.Columns[2];
            column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView6.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewColumn column3 = dataGridView6.Columns[3];
            column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView6.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void dataGridView7_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView7.Columns[0].Visible = false;


            DataGridViewColumn column1 = dataGridView7.Columns[1];
            column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView7.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewColumn column2 = dataGridView7.Columns[2];
            column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView7.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewColumn column3 = dataGridView7.Columns[3];
            column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView7.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
    }
}
