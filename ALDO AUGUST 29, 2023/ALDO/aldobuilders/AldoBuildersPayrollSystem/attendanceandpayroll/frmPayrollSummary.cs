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
using Microsoft.ReportingServices.Diagnostics.Internal;
using System.Xml.Linq;

namespace AldoBuildersPayrollSystem.attendanceandpayroll
{
    public partial class frmPayrollSummary : Form
    {
        DataTable dt;
        DataTable dt1;
        SqlConnection cn;
        SqlCommand cm;
        SqlDataReader dr;
        DBConnection db = new DBConnection();
        public frmPayrollSummary()
        {
            InitializeComponent();
            cn = new SqlConnection(db.GetConnection());
            dtTo.Value = dtFrom.Value.AddDays(5);
            //	LoadRecordsService();
            //LoadRecords();
        }

        public void LoadRecords()
        {
            try
            {
                cn.Open();
                //  cm = new SqlCommand("SELECT * FROM PayrollComputation WHERE logdate >= @StartDate  AND logdate <= @EndDate ORDER BY Name, Logdate", cn);
                cm = new SqlCommand("SELECT CONCAT(lastname,', ',firstname,' ',middlename) as NAME,idnumber as EMPLOYEEID,logdate as LOGDATE,DateCovered,am_in AS AM_IN,am_out AS AM_OUT,TotalAM,pm_in AS PM_IN,pm_out as PM_OUT,TotalPM,OT_IN,OT_OUT,TotalOT,CalAM,CalPM,CalOT,AddHours,Total_Hours,status FROM tblAttendancePayroll INNER JOIN tblemployee ON tblAttendancePayroll.idemployee=tblemployee.idemployee WHERE(cast(logdate as datetime) BETWEEN '" + dtFrom.Text + "' AND '" + dtTo.Text + "') AND status='ACTIVE' ORDER BY NAME,logdate", cn);
                cm.Parameters.AddWithValue("@StartDate", dtFrom.Text);
                cm.Parameters.AddWithValue("@EndDate", dtTo.Text);

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

        public void LoadRecordsService()
        {
            try
            {
                cn.Open();
                //  cm = new SqlCommand("SELECT * FROM PayrollComputation WHERE logdate >= @StartDate  AND logdate <= @EndDate ORDER BY Name, Logdate", cn);
                cm = new SqlCommand("SELECT * from tblService WHERE Date_Covered = @StartDateAndEND ORDER BY Name", cn);
                cm.Parameters.AddWithValue("@StartDateAndEND", dtFrom.Text + " - " + dtTo.Text);

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

        public void LoadRecordSummary()
        {
            try
            {
                cn.Open();
                //  cm = new SqlCommand("SELECT * FROM PayrollComputation WHERE logdate >= @StartDate  AND logdate <= @EndDate ORDER BY Name, Logdate", cn);
                cm = new SqlCommand("SELECT * from PayrollComputation WHERE Date_Covered = @StartDateAndEND AND Status ='ACTIVE' ORDER BY NAME", cn);
                cm.Parameters.AddWithValue("@StartDateAndEND", dtFrom.Text + " - " + dtTo.Text);
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


        public void UpdateDateCovered()
        {
            string updateSql = "UPDATE tblAttendancePayroll SET DateCovered = @DateCovered  WHERE(cast(logdate as datetime) BETWEEN '" + dtFrom.Text + "' AND '" + dtTo.Text + "')";
            cn.Open();
            using (SqlCommand command = new SqlCommand(updateSql, cn))
            {
                // Set the new value you want to update all rows with
                command.Parameters.AddWithValue("@DateCovered", dtFrom.Text + " - " + dtTo.Text);

                int rowsAffected = command.ExecuteNonQuery();

                Console.WriteLine($"Updated {rowsAffected} rows.");
            }
            cn.Close();
            //LoadRecords();
            LoadRecordSummary();
            //LoadRecordsService();
        }

        private void btnClickHere_Click(object sender, EventArgs e)
        {
            //LoadRecords();
            UpdateDateCovered();
        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            dtTo.Value = dtFrom.Value.AddDays(5);
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
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

            DataGridViewColumn column1 = dataGridView1.Columns[1];
            column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;


            DataGridViewColumn column2 = dataGridView1.Columns[2];
            column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewColumn column3 = dataGridView1.Columns[3];
            column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridViewColumn column4 = dataGridView1.Columns[4];
            column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridViewColumn column5 = dataGridView1.Columns[5];
            column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridViewColumn column6 = dataGridView1.Columns[6];
            column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridViewColumn column7 = dataGridView1.Columns[7];
            column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridViewColumn column8 = dataGridView1.Columns[8];
            column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

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
        }

        public void CopyDataFromDatagridview()
        {
            //try
            //{
            //	cn.Open();
            //	if (MessageBox.Show("Are you sure that the payroll with the selected date coverage is final now? CLICK YES TO CONFIRM", "Create Payroll", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //	{
            //		foreach (DataGridViewRow row in dataGridView1.Rows)
            //		{
            //			if (!row.IsNewRow)
            //			{

            //				//Retrieve values from DataGridView cells
            //				string column1Value = row.Cells["ID"].Value.ToString();
            //				string column2Value = row.Cells["Name"].Value.ToString();
            //				string column22Value = row.Cells["Date_Covered"].Value.ToString();
            //				string column3Value = row.Cells["RatePerDay"].Value.ToString();
            //				string column4Value = row.Cells["RatePerHour"].Value.ToString();
            //				string column5Value = row.Cells["AddHour"].Value.ToString();
            //				string column6Value = row.Cells["TotalHours"].Value.ToString();
            //				string column7Value = row.Cells["Gross"].Value.ToString();
            //				string column8Value = row.Cells["SSS"].Value.ToString();
            //				string column9Value = row.Cells["Philhealth"].Value.ToString();
            //				string column10Value = row.Cells["Pagibig"].Value.ToString();
            //				string column11Value = row.Cells["Water"].Value.ToString();
            //				string column12Value = row.Cells["Electricity"].Value.ToString();
            //				string column13Value = row.Cells["Housingbill"].Value.ToString();
            //				string column14Value = row.Cells["Other1Disc"].Value.ToString();
            //				string column15Value = row.Cells["Other1"].Value.ToString();
            //				string column16Value = row.Cells["Other2Disc"].Value.ToString();
            //				string column17Value = row.Cells["Other2"].Value.ToString();
            //				string column18Value = row.Cells["Other3Disc"].Value.ToString();
            //				string column19Value = row.Cells["Other3"].Value.ToString();
            //				string column20Value = row.Cells["TotalDeduction"].Value.ToString();
            //				string column21Value = row.Cells["Net"].Value.ToString();
            //				string column23Value = row.Cells["Category"].Value.ToString();

            //				// Add more columns as needed

            //				// Build and execute the SQL INSERT statement
            //				string insertQuery = $"INSERT INTO tblPayroll (ID, Name, Date_Covered, RatePerDay, RatePerHour, AddHour, TotalHours, Gross, SSS, Philhealth, Pagibig, Water, Electricity, Housingbill, Other1Desc, Other1, Other2Desc, Other2, Other3Desc, Other3,TotalDeduction, Net, Category) VALUES (@ID, @Name, @Date_Covered, @RatePerDay, @RatePerHour, @AddHour, @TotalHours, @Gross, @SSS, @Philhealth, @Pagibig, @Water, @Electricity, @Housingbill, @Other1Desc, @Other1, @Other2Desc, @Other2, @Other3Desc, @Other3, @TotalDeduction, @Net, @Category)";
            //				using (SqlCommand command = new SqlCommand(insertQuery, cn))
            //				{
            //					command.Parameters.AddWithValue("@ID", column1Value);
            //					command.Parameters.AddWithValue("@Name", column2Value);
            //					command.Parameters.AddWithValue("@Date_Covered", column22Value);
            //					command.Parameters.AddWithValue("@RatePerDay", column3Value);
            //					command.Parameters.AddWithValue("@RatePerHour", column4Value);
            //					command.Parameters.AddWithValue("@AddHour", column5Value);
            //					command.Parameters.AddWithValue("@TotalHours", column6Value);
            //					command.Parameters.AddWithValue("@Gross", column7Value);
            //					command.Parameters.AddWithValue("@SSS", column8Value);
            //					command.Parameters.AddWithValue("@Philhealth", column9Value);
            //					command.Parameters.AddWithValue("@Pagibig", column10Value);
            //					command.Parameters.AddWithValue("@Water", column11Value);
            //					command.Parameters.AddWithValue("@Electricity", column12Value);
            //					command.Parameters.AddWithValue("@Housingbill", column13Value);
            //					command.Parameters.AddWithValue("@Other1Desc", column14Value);
            //					command.Parameters.AddWithValue("@Other1", column15Value);
            //					command.Parameters.AddWithValue("@Other2Desc", column16Value);
            //					command.Parameters.AddWithValue("@Other2", column17Value);
            //					command.Parameters.AddWithValue("@Other3Desc", column18Value);
            //					command.Parameters.AddWithValue("@Other3", column19Value);
            //					command.Parameters.AddWithValue("@TotalDeduction", column20Value);
            //					command.Parameters.AddWithValue("@Net", column21Value);
            //					command.Parameters.AddWithValue("@Category", column23Value);
            //					command.ExecuteNonQuery();
            //				}
            //			}
            //		}
            //		MessageBox.Show("Data copied to SQL Server table successfully!");
            //	}

            //	cn.Close();

            //}
            //catch (Exception ex)
            //{
            //	MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //	cn.Close();
            //}

            try
            {
                cn.Open();
                bool foundDuplicate = false;
                string datecovered1 = dtFrom.Text + " - " + dtTo.Text;
                if (IsRecordAlreadyExists(datecovered1))
                {
                    foundDuplicate = true;
                    MessageBox.Show("NOT ALLOWED, DateCovered already exists. ", "Duplicate DateCovered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the loop if a duplicate is found							     	
                }
                if (MessageBox.Show("Are you sure that the payroll with the selected date coverage is final now? CLICK YES TO CONFIRM", "Create Payroll", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //bool foundDuplicate = false;
                    //string datecovered1 = dtFrom.Text + " - " + dtTo.Text;
                    //if (IsRecordAlreadyExists(datecovered1))
                    //{
                    //	foundDuplicate = true;
                    //	MessageBox.Show("NOT ALLOWED, DateCovered already exists. ", "Duplicate DateCovered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //	return; // Exit the loop if a duplicate is found							     	
                    //}
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            // Retrieve values from DataGridView cells
                            string column1Value = row.Cells["ID"].Value.ToString();
                            string column2Value = row.Cells["Name"].Value.ToString();
                            string column22Value = row.Cells["Date_Covered"].Value.ToString();
                            string column3Value = row.Cells["RatePerDay"].Value.ToString();
                            string column4Value = row.Cells["RatePerHour"].Value.ToString();
                            string column5Value = row.Cells["AddHour"].Value.ToString();
                            string column6Value = row.Cells["TotalHours"].Value.ToString();
                            string column7Value = row.Cells["Gross"].Value.ToString();
                            string column8Value = row.Cells["SSS"].Value.ToString();
                            string column9Value = row.Cells["Philhealth"].Value.ToString();
                            string column10Value = row.Cells["Pagibig"].Value.ToString();
                            string column11Value = row.Cells["Water"].Value.ToString();
                            string column12Value = row.Cells["Electricity"].Value.ToString();
                            string column13Value = row.Cells["Housingbill"].Value.ToString();
                            string column14Value = row.Cells["Other1Disc"].Value.ToString();
                            string column15Value = row.Cells["Other1"].Value.ToString();
                            string column16Value = row.Cells["Other2Disc"].Value.ToString();
                            string column17Value = row.Cells["Other2"].Value.ToString();
                            string column18Value = row.Cells["Other3Disc"].Value.ToString();
                            string column19Value = row.Cells["Other3"].Value.ToString();
                            string column20Value = row.Cells["TotalDeduction"].Value.ToString();
                            string column21Value = row.Cells["Net"].Value.ToString();
                            string column23Value = row.Cells["Category"].Value.ToString();

                            // Add more columns as needed

                            // Check if a record with the same values already exists in the database

                            //else
                            //{
                            // Build and execute the SQL INSERT statement
                            string insertQuery = $"INSERT INTO tblPayroll (ID, Name, Date_Covered, RatePerDay, RatePerHour, AddHour, TotalHours, Gross, SSS, Philhealth, Pagibig, Water, Electricity, Housingbill, Other1Desc, Other1, Other2Desc, Other2, Other3Desc, Other3,TotalDeduction, Net, Category) VALUES (@ID, @Name, @Date_Covered, @RatePerDay, @RatePerHour, @AddHour, @TotalHours, @Gross, @SSS, @Philhealth, @Pagibig, @Water, @Electricity, @Housingbill, @Other1Desc, @Other1, @Other2Desc, @Other2, @Other3Desc, @Other3, @TotalDeduction, @Net, @Category)";
                            using (SqlCommand command = new SqlCommand(insertQuery, cn))
                            {
                                command.Parameters.AddWithValue("@ID", column1Value);
                                command.Parameters.AddWithValue("@Name", column2Value);
                                command.Parameters.AddWithValue("@Date_Covered", column22Value);
                                command.Parameters.AddWithValue("@RatePerDay", column3Value);
                                command.Parameters.AddWithValue("@RatePerHour", column4Value);
                                command.Parameters.AddWithValue("@AddHour", column5Value);
                                command.Parameters.AddWithValue("@TotalHours", column6Value);
                                command.Parameters.AddWithValue("@Gross", column7Value);
                                command.Parameters.AddWithValue("@SSS", column8Value);
                                command.Parameters.AddWithValue("@Philhealth", column9Value);
                                command.Parameters.AddWithValue("@Pagibig", column10Value);
                                command.Parameters.AddWithValue("@Water", column11Value);
                                command.Parameters.AddWithValue("@Electricity", column12Value);
                                command.Parameters.AddWithValue("@Housingbill", column13Value);
                                command.Parameters.AddWithValue("@Other1Desc", column14Value);
                                command.Parameters.AddWithValue("@Other1", column15Value);
                                command.Parameters.AddWithValue("@Other2Desc", column16Value);
                                command.Parameters.AddWithValue("@Other2", column17Value);
                                command.Parameters.AddWithValue("@Other3Desc", column18Value);
                                command.Parameters.AddWithValue("@Other3", column19Value);
                                command.Parameters.AddWithValue("@TotalDeduction", column20Value);
                                command.Parameters.AddWithValue("@Net", column21Value);
                                command.Parameters.AddWithValue("@Category", column23Value);
                                command.ExecuteNonQuery();
                            }
                            //}						
                        }
                    }
                    if (foundDuplicate)
                    {
                        MessageBox.Show("Data already exists in SQL Server table. No new data inserted.", "Duplicate Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Payroll w/ selected datecovered successfully created !");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }

        private bool IsRecordAlreadyExists(string dateCovered)
        {

            string selectQuery = "SELECT COUNT(*) FROM tblPayroll WHERE Date_Covered = @Date_Covered";

            using (SqlConnection connection = new SqlConnection(cn.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {

                    command.Parameters.AddWithValue("@Date_Covered", dateCovered);

                    connection.Open();
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0; // Return true if a record with the same values exists
                }
            }
        }

        private void btnFinalResult_Click(object sender, EventArgs e)
        {
            CopyDataFromDatagridview();
        }

        private void dtTo_ValueChanged(object sender, EventArgs e)
        {
            UpdateDateCovered();
            LoadRecordsService();
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            var frm = new attendanceandpayroll.frmService(this);
            frm.lblDateCovered.Text = dtFrom.Text + " - " + dtTo.Text;
            frm.lblLoginName.Text = lblLoginName.Text;
            //frm.btnUpdate.Enabled = false;
            frm.ShowDialog();
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

            DataGridViewColumn column4 = dataGridView2.Columns[4];
            column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridViewColumn column5 = dataGridView2.Columns[5];
            column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridViewColumn column6 = dataGridView2.Columns[6];
            column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

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

            DataGridViewColumn column15 = dataGridView2.Columns[15];
            column15.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

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

            DataGridViewColumn column31 = dataGridView2.Columns[31];
            column31.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[31].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Delete Record
            if (MessageBox.Show("YOU WANT TO DELETE THIS RECORD? CLICK YES TO CONFIRM", "Service Time", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cm = new SqlCommand("DELETE FROM tblService WHERE idService = '" + dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", cn);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("RECORD HAS BEEN SUCCESSFULLY DELETED", "Service Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRecordsService();
                //this.Close();			
            }
            //'" + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "'"
        }
    }
}
