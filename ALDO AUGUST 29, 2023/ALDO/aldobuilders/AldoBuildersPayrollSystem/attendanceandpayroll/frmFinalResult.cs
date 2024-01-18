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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace AldoBuildersPayrollSystem.attendanceandpayroll
{
    public partial class frmFinalResult : Form
    {
        DataTable dt;
        DataTable dt1;
        SqlConnection cn;
        SqlCommand cm;
        SqlDataReader dr;
        DBConnection db = new DBConnection();

        public frmFinalResult()
        {
            InitializeComponent();
            cn = new SqlConnection(db.GetConnection());
            LoadDateCoveredToComboBox();
            LoadDateCoveredToComboBoxPrint();
        }

        //public void LoadDateCoveredToComboBox()
        //{
        //    cn.Open();
        //    cm = new SqlCommand("SELECT Date_Covered FROM tblDateCovered ORDER BY Date_Covered", cn);
        //    dr = cm.ExecuteReader();
        //    AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

        //    while (dr.Read())
        //    {
        //        collection.Add(dr["Date_Covered"].ToString());
        //    }

        //    comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        //    comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
        //    comboBox1.AutoCompleteCustomSource = collection;

        //    dr.Close();
        //    cn.Close();
        //}

        public void LoadDateCoveredToComboBox()
        {
            cboDateCovered.Items.Clear();
            // comboBox1.Items.Add("ALL");
            int i = 0;
            cn.Open();
            cm = new SqlCommand("SELECT Date_Covered FROM tblDateCovered ORDER BY Date_Covered DESC", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                //cboSectionChief.Text.ToUpper();
                cboDateCovered.Items.Add(dr["Date_Covered"].ToString().ToUpper());
                //comboBox4.Items.Add(dr["NAME"].ToString().ToUpper());
            }
            dr.Close();
            cn.Close();
        }

        public void LoadDateCoveredToComboBoxPrint()
        {
            cbodatecoveredPrint.Items.Clear();
            // comboBox1.Items.Add("ALL");
            int i = 0;
            cn.Open();
            cm = new SqlCommand("SELECT Date_Covered FROM tblDateCovered ORDER BY Date_Covered DESC", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                //cboSectionChief.Text.ToUpper();
                cbodatecoveredPrint.Items.Add(dr["Date_Covered"].ToString().ToUpper());
                //comboBox4.Items.Add(dr["NAME"].ToString().ToUpper());
            }
            dr.Close();
            cn.Close();
        }

        private void btnClickhere_Click(object sender, EventArgs e)
        {
            if (cboDateCovered.Text == string.Empty)
            {
                MessageBox.Show("Please select date covered");
                return;
            }
            else
            {
                LoadRecordSummary();
                LoadRecordSummaryService();
            }
        }

        public void LoadRecordSummary()
        {
            try
            {
                cn.Open();
                //  cm = new SqlCommand("SELECT * FROM PayrollComputation WHERE logdate >= @StartDate  AND logdate <= @EndDate ORDER BY Name, Logdate", cn);
                cm = new SqlCommand("SELECT * from tblPayroll WHERE Date_Covered = '" + cboDateCovered.Text + "' ORDER BY NAME", cn);
                //	cm.Parameters.AddWithValue("@StartDateAndEND", dtFrom.Text );
                //cm.Parameters.AddWithValue("@EndDate", dtTo.Text);

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
        }

        public void LoadRecordSummaryService()
        {
            try
            {
                cn.Open();
                //  cm = new SqlCommand("SELECT * FROM PayrollComputation WHERE logdate >= @StartDate  AND logdate <= @EndDate ORDER BY Name, Logdate", cn);
                cm = new SqlCommand("SELECT * from tblService WHERE Date_Covered = '" + cboDateCovered.Text + "' ORDER BY Name", cn);
                //	cm.Parameters.AddWithValue("@StartDateAndEND", dtFrom.Text );
                //cm.Parameters.AddWithValue("@EndDate", dtTo.Text);

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
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[25].Visible = false;
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

            //DataGridViewColumn column1 = dataGridView1.Columns[1];
            //column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;


            DataGridViewColumn column2 = dataGridView1.Columns[2];
            column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.Blue;

            DataGridViewColumn column3 = dataGridView1.Columns[3];
            column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridViewColumn column4 = dataGridView1.Columns[4];
            column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dataGridView1.Columns[4].DefaultCellStyle.SelectionBackColor = Color.Black;
            dataGridView1.Columns[4].DefaultCellStyle.SelectionForeColor = Color.Red;
            //dataGridView1.Columns[4].DefaultCellStyle.BackColor = Color.Black;
            dataGridView1.Columns[4].DefaultCellStyle.ForeColor = Color.Red;

            DataGridViewColumn column5 = dataGridView1.Columns[5];
            column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dataGridView1.Columns[5].DefaultCellStyle.SelectionBackColor = Color.Black;
            dataGridView1.Columns[5].DefaultCellStyle.SelectionForeColor = Color.Red;
            //dataGridView1.Columns[5].DefaultCellStyle.BackColor = Color.Black;
            dataGridView1.Columns[5].DefaultCellStyle.ForeColor = Color.Red;

            DataGridViewColumn column6 = dataGridView1.Columns[6];
            column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dataGridView1.Columns[6].DefaultCellStyle.SelectionBackColor = Color.Black;
            dataGridView1.Columns[6].DefaultCellStyle.SelectionForeColor = Color.Red;
            //dataGridView1.Columns[6].DefaultCellStyle.BackColor = Color.Black;
            dataGridView1.Columns[6].DefaultCellStyle.ForeColor = Color.Red;

            DataGridViewColumn column7 = dataGridView1.Columns[7];
            column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dataGridView1.Columns[7].DefaultCellStyle.SelectionBackColor = Color.Black;
            dataGridView1.Columns[7].DefaultCellStyle.SelectionForeColor = Color.Red;
            //dataGridView1.Columns[7].DefaultCellStyle.BackColor = Color.Black;
            dataGridView1.Columns[7].DefaultCellStyle.ForeColor = Color.Red;

            DataGridViewColumn column8 = dataGridView1.Columns[8];
            column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dataGridView1.Columns[8].DefaultCellStyle.SelectionBackColor = Color.Black;
            dataGridView1.Columns[8].DefaultCellStyle.SelectionForeColor = Color.Red;
            //dataGridView1.Columns[8].DefaultCellStyle.BackColor = Color.Black;
            dataGridView1.Columns[8].DefaultCellStyle.ForeColor = Color.Red;

            DataGridViewColumn column9 = dataGridView1.Columns[9];
            column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridViewColumn column10 = dataGridView1.Columns[10];
            column10.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridViewColumn column11 = dataGridView1.Columns[11];
            column11.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridViewColumn column12 = dataGridView1.Columns[12];
            column12.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridViewColumn column13 = dataGridView1.Columns[13];
            column13.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridViewColumn column14 = dataGridView1.Columns[14];
            column14.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridViewColumn column15 = dataGridView1.Columns[15];
            column15.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridViewColumn column16 = dataGridView1.Columns[16];
            column16.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[16].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridViewColumn column17 = dataGridView1.Columns[17];
            column17.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[17].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridViewColumn column18 = dataGridView1.Columns[18];
            column18.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[18].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridViewColumn column19 = dataGridView1.Columns[19];
            column19.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[19].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridViewColumn column20 = dataGridView1.Columns[20];
            column20.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[20].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridViewColumn column21 = dataGridView1.Columns[21];
            column21.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[21].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridViewColumn column22 = dataGridView1.Columns[22];
            column22.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[22].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewColumn column23 = dataGridView1.Columns[23];
            column23.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[23].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridView1.Columns[23].DefaultCellStyle.SelectionBackColor = Color.Black;
            dataGridView1.Columns[23].DefaultCellStyle.SelectionForeColor = Color.Red;
            //dataGridView1.Columns[23].DefaultCellStyle.BackColor = Color.Black;
            dataGridView1.Columns[23].DefaultCellStyle.ForeColor = Color.Red;

            DataGridViewColumn column24 = dataGridView1.Columns[24];
            column24.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[24].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //	dataGridView1.Columns[24].DefaultCellStyle.SelectionBackColor = Color.Black;
            dataGridView1.Columns[24].DefaultCellStyle.SelectionForeColor = Color.Red;
            //dataGridView1.Columns[24].DefaultCellStyle.BackColor = Color.Black;
            dataGridView1.Columns[24].DefaultCellStyle.ForeColor = Color.Red;
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            if (cbodatecoveredPrint.Text == string.Empty)
            {
                MessageBox.Show("Please select date covered");
                return;
            }
            else
            {
                try
                {
                    report.frmReportSample frm = new report.frmReportSample(this);
                    frm.LoadReport();
                    //frm.ParameterDate();
                    frm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    cn.Close();
                }
            }
        }

        private void btnPalagdaan_Click(object sender, EventArgs e)
        {
            if (cbodatecoveredPrint.Text == string.Empty)
            {
                MessageBox.Show("Please select date covered");
                return;
            }
            else
            {
                try
                {
                    report.frmPalagdaan frm = new report.frmPalagdaan(this);
                    frm.LoadReport1();
                    //frm.ParameterDate();
                    frm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    cn.Close();
                }
            }

        }

        private void btnPalagdaanSaPagtanggap_Click(object sender, EventArgs e)
        {
            if (cbodatecoveredPrint.Text == string.Empty)
            {
                MessageBox.Show("Please select date covered");
                return;
            }
            else
            {
                try
                {
                    report.frmPalagdaanSaPagtanggap frm = new report.frmPalagdaanSaPagtanggap(this);
                    frm.LoadReport();
                    //frm.ParameterDate();
                    frm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    cn.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbodatecoveredPrint.Text == string.Empty)
            {
                MessageBox.Show("Please select date covered");
                return;
            }
            else
            {
                try
                {
                    report.frmPalagdaan frm = new report.frmPalagdaan(this);
                    frm.LoadReportStaff();
                    //frm.ParameterDate();
                    frm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    cn.Close();
                }
            }
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            if (cbodatecoveredPrint.Text == string.Empty)
            {
                MessageBox.Show("Please select date covered");
                return;
            }
            else
            {
                try
                {
                    report.frmReportSample frm = new report.frmReportSample(this);
                    frm.LoadReportSummary();
                    //frm.ParameterDate();
                    frm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    cn.Close();
                }
            }
        }

        private void dataGridView2_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].Visible = false;
            dataGridView2.Columns[2].Visible = false;
            dataGridView2.Columns[32].Visible = false;
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

            //DataGridViewColumn column1 = dataGridView1.Columns[1];
            //column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;


            //DataGridViewColumn column2 = dataGridView1.Columns[2];
            //column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewColumn column3 = dataGridView2.Columns[3];
            column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView2.Columns[3].DefaultCellStyle.ForeColor = Color.Blue;

            DataGridViewColumn column4 = dataGridView2.Columns[4];
            column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridViewColumn column5 = dataGridView2.Columns[5];
            column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dataGridView2.Columns[5].DefaultCellStyle.SelectionBackColor = Color.Black;
            dataGridView2.Columns[5].DefaultCellStyle.SelectionForeColor = Color.Red;
            //dataGridView2.Columns[5].DefaultCellStyle.BackColor = Color.Black;
            dataGridView2.Columns[5].DefaultCellStyle.ForeColor = Color.Red;

            DataGridViewColumn column6 = dataGridView2.Columns[6];
            column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dataGridView2.Columns[6].DefaultCellStyle.SelectionBackColor = Color.Black;
            dataGridView2.Columns[6].DefaultCellStyle.SelectionForeColor = Color.Red;
            //dataGridView2.Columns[6].DefaultCellStyle.BackColor = Color.Black;
            dataGridView2.Columns[6].DefaultCellStyle.ForeColor = Color.Red;

            DataGridViewColumn column7 = dataGridView2.Columns[7];
            column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridViewColumn column8 = dataGridView2.Columns[8];
            column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridViewColumn column9 = dataGridView2.Columns[9];
            column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridViewColumn column10 = dataGridView2.Columns[10];
            column10.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridViewColumn column11 = dataGridView2.Columns[11];
            column11.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridViewColumn column12 = dataGridView2.Columns[12];
            column12.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridViewColumn column13 = dataGridView2.Columns[13];
            column13.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridViewColumn column14 = dataGridView2.Columns[14];
            column14.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dataGridView2.Columns[14].DefaultCellStyle.SelectionBackColor = Color.Black;
            dataGridView2.Columns[14].DefaultCellStyle.SelectionForeColor = Color.Red;
            //dataGridView2.Columns[14].DefaultCellStyle.BackColor = Color.Black;
            dataGridView2.Columns[14].DefaultCellStyle.ForeColor = Color.Red;

            DataGridViewColumn column15 = dataGridView2.Columns[15];
            column15.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dataGridView2.Columns[15].DefaultCellStyle.SelectionBackColor = Color.Black;
            dataGridView2.Columns[15].DefaultCellStyle.SelectionForeColor = Color.Red;
            //dataGridView2.Columns[15].DefaultCellStyle.BackColor = Color.Black;
            dataGridView2.Columns[15].DefaultCellStyle.ForeColor = Color.Red;

            DataGridViewColumn column16 = dataGridView2.Columns[16];
            column16.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[16].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridViewColumn column17 = dataGridView2.Columns[17];
            column17.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[17].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridViewColumn column18 = dataGridView2.Columns[18];
            column18.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[18].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridViewColumn column19 = dataGridView2.Columns[19];
            column19.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[19].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridViewColumn column20 = dataGridView2.Columns[20];
            column20.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[20].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridViewColumn column21 = dataGridView2.Columns[21];
            column21.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[21].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridViewColumn column22 = dataGridView2.Columns[22];
            column22.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[22].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewColumn column23 = dataGridView2.Columns[23];
            column23.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[23].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewColumn column24 = dataGridView2.Columns[24];
            column24.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[24].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewColumn column25 = dataGridView2.Columns[25];
            column25.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[25].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridViewColumn column26 = dataGridView2.Columns[26];
            column26.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[26].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewColumn column27 = dataGridView2.Columns[27];
            column27.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[27].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridViewColumn column28 = dataGridView2.Columns[28];
            column28.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[28].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewColumn column29 = dataGridView2.Columns[29];
            column29.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[29].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


            DataGridViewColumn column30 = dataGridView2.Columns[30];
            column30.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[30].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dataGridView2.Columns[30].DefaultCellStyle.SelectionBackColor = Color.Black;
            dataGridView2.Columns[30].DefaultCellStyle.SelectionForeColor = Color.Red;
            //dataGridView2.Columns[30].DefaultCellStyle.BackColor = Color.Black;
            dataGridView2.Columns[30].DefaultCellStyle.ForeColor = Color.Red;

            DataGridViewColumn column31 = dataGridView2.Columns[31];
            column31.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[31].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dataGridView2.Columns[31].DefaultCellStyle.SelectionBackColor = Color.Black;
            dataGridView2.Columns[31].DefaultCellStyle.SelectionForeColor = Color.Red;
            //dataGridView2.Columns[31].DefaultCellStyle.BackColor = Color.Black;
            dataGridView2.Columns[31].DefaultCellStyle.ForeColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cbodatecoveredPrint.Text == string.Empty)
            {
                MessageBox.Show("Please select date covered");
                return;
            }
            else
            {
                try
                {
                    report.frmReportSample frm = new report.frmReportSample(this);
                    frm.LoadReportService();
                    //frm.ParameterDate();
                    frm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    cn.Close();
                }
            }
        }

        private void btnPayslip_Click(object sender, EventArgs e)
        {
            if (cbodatecoveredPrint.Text == string.Empty)
            {
                MessageBox.Show("Please select date covered");
                return;
            }
            else
            {
                try
                {
                    report.frmPayrollSlip frm = new report.frmPayrollSlip(this);
                    frm.LoadReportPaySlip();
                    //frm.ParameterDate();
                    frm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    cn.Close();
                }
            }
        }

        private void btnPaySlipManual_Click(object sender, EventArgs e)
        {
            if (cbodatecoveredPrint.Text == string.Empty)
            {
                MessageBox.Show("Please select date covered");
                return;
            }
            else
            {
                try
                {
                    report.frmPayrollSlip frm = new report.frmPayrollSlip(this);
                    frm.LoadReportPaySlipManual();
                    //frm.ParameterDate();
                    frm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    cn.Close();
                }
            }
        }

        private void btnOptionToPrint_Click(object sender, EventArgs e)
        {
            if (cbodatecoveredPrint.Text == string.Empty && cboOption.Text == string.Empty)
            {
                MessageBox.Show("Please select 'Date Covered' and 'Option to print'");
                return;
            }
            else if (cbodatecoveredPrint.Text == string.Empty && cboOption.Text != string.Empty)
            {
                MessageBox.Show("Please select date covered");
                return;
            }

            else if (cbodatecoveredPrint.Text != string.Empty && cboOption.Text == string.Empty)
            {
                MessageBox.Show("Please select an option to print");
                return;
            }

            else if (cbodatecoveredPrint.Text != string.Empty && cboOption.Text == "Summary")
            {
                try
                {
                    report.frmReportSample frm = new report.frmReportSample(this);
                    frm.LoadReportSummary();
                    //frm.ParameterDate();
                    frm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    cn.Close();
                }
            }

            else if (cbodatecoveredPrint.Text != string.Empty && cboOption.Text == "Owner's Copy(RFID and Manual Time)")
            {
                try
                {
                    report.frmReportSample frm = new report.frmReportSample(this);
                    frm.LoadReport();
                    //frm.ParameterDate();
                    frm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    cn.Close();
                }
            }

            else if (cbodatecoveredPrint.Text != string.Empty && cboOption.Text == "Palagdaan(Workers)")
            {
                try
                {
                    report.frmPalagdaan frm = new report.frmPalagdaan(this);
                    frm.LoadReport1();
                    //frm.ParameterDate();
                    frm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    cn.Close();
                }
            }

            else if (cbodatecoveredPrint.Text != string.Empty && cboOption.Text == "Palagdaan(Staffs)")
            {
                try
                {
                    report.frmPalagdaan frm = new report.frmPalagdaan(this);
                    frm.LoadReportStaff();
                    //frm.ParameterDate();
                    frm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    cn.Close();
                }
            }

            else if (cbodatecoveredPrint.Text != string.Empty && cboOption.Text == "Palagdaan(Service Manual Time)")
            {
                try
                {
                    report.frmReportSample frm = new report.frmReportSample(this);
                    frm.LoadReportService();
                    //frm.ParameterDate();
                    frm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    cn.Close();
                }
            }

            else if (cbodatecoveredPrint.Text != string.Empty && cboOption.Text == "Paglagdaan sa Pagtanggap")
            {
                try
                {
                    report.frmPalagdaanSaPagtanggap frm = new report.frmPalagdaanSaPagtanggap(this);
                    frm.LoadReport();
                    //frm.ParameterDate();
                    frm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    cn.Close();
                }
            }

            else if (cbodatecoveredPrint.Text != string.Empty && cboOption.Text == "Payslip(RFID Generated)")
            {
                try
                {
                    report.frmPayrollSlip frm = new report.frmPayrollSlip(this);
                    frm.LoadReportPaySlip();
                    //frm.ParameterDate();
                    frm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    cn.Close();
                }
            }

            else if (cbodatecoveredPrint.Text != string.Empty && cboOption.Text == "Payslip(Service Manual Time)")
            {
                try
                {
                    report.frmPayrollSlip frm = new report.frmPayrollSlip(this);
                    frm.LoadReportPaySlipManual();
                    //frm.ParameterDate();
                    frm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    cn.Close();
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dt);
            DV.RowFilter = string.Format("Name LIKE '%{0}%'", txtSearch.Text);
            dataGridView1.DataSource = DV;

            DataView DV1 = new DataView(dt1);
            DV1.RowFilter = string.Format("Name LIKE '%{0}%'", txtSearch.Text);
            dataGridView2.DataSource = DV1;
        }
    }
}






