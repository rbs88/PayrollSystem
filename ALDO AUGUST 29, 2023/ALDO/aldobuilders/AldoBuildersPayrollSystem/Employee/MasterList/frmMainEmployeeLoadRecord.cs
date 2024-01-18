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
using System.Reflection.Emit;

namespace AldoBuildersPayrollSystem.Employee.MasterList
{
    public partial class frmMainEmployeeLoadRecord : Form
    {
        SqlConnection cn;
        SqlCommand cm;
        SqlDataReader dr;
        DataTable dt;

        DBConnection db = new DBConnection();
        public frmMainEmployeeLoadRecord()
        {
            InitializeComponent();
            cn = new SqlConnection(db.GetConnection());
            LoadRecords();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            //Access This form name
            var frm = new frmAddNewEmployee(this, null);
            frm.lblLoginName.Text = lblLoginName.Text;
            frm.role.Text = role.Text;
            frm.btnUpdate.Enabled = false;
            frm.btnUpdate2.Visible = false;
            frm.btnDelete.Enabled = false;
            frm.cboStatus.Text = "ACTIVE";
            frm.cboCategory.Text = "WORKER";
            frm.cboRate.Text = "0";
            frm.ShowDialog();
        }

        public void LoadRecords()
        {
            //Load Records to datagridview
            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT idemployee,idnumber as ID_NUMBER,RFID,firstname as FIRSTNAME,middlename as MIDDLENAME,lastname as LASTNAME,birthday as BIRTHDAY,age as AGE,address as ADDRESS,designation,rate,sssnumber,philhealth,pagibig,datehired,dateout,status,assign,pictureURL,otherinformation,postedby,Category FROM tblemployee WHERE status = 'ACTIVE' ORDER BY lastname", cn);

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

            DataGridViewColumn column21 = dataGridView1.Columns[21];
            column21.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[21].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var f = new Employee.MasterList.frmAddNewEmployee(this, null);
                f.btnSave.Enabled = false;
                //f.btnDelete.Enabled = true;
                f.btnUpdate.Visible = true;
                f.btnUpdate2.Visible = false;
                //f.btnUpdate.Enabled = false;
                f.btnCancel.Enabled = true;
                f.lblLoginName.Text = lblLoginName.Text;
                f.role.Text = role.Text;

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
                    //	f.lblPostedby.Text = dataGridView1.Rows[e.RowIndex].Cells[20].Value.ToString();
                    f.cboCategory.Text = dataGridView1.Rows[e.RowIndex].Cells[21].Value.ToString();
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

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (cboSearchPrint.Text == string.Empty)
            {
                MessageBox.Show("Please select Category");
                return;
            }
            else if (cboSearchPrint.Text == "ALL")
            {
                try
                {
                    report.frmEmployeeMasterList frm = new report.frmEmployeeMasterList(this);
                    frm.LoadReportAll();
                    frm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    cn.Close();
                }
            }
            else
            {
                try
                {
                    report.frmEmployeeMasterList frm = new report.frmEmployeeMasterList(this);
                    frm.LoadReport();
                    frm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    cn.Close();
                }
            }
        }
    }
}
