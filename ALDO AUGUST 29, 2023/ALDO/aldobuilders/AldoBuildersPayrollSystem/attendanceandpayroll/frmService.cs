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

namespace AldoBuildersPayrollSystem.attendanceandpayroll
{
    public partial class frmService : Form
    {
        SqlConnection cn;
        SqlCommand cm;
        SqlDataReader dr;
        DBConnection db = new DBConnection();

        DataTable dt;

        frmPayrollSummary f;
        public frmService(frmPayrollSummary f)
        {
            InitializeComponent();
            cn = new SqlConnection(db.GetConnection());
            LoadRecords();
            this.f = f;
        }

        public void LoadRecords()
        {
            //Load Records to datagridview
            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT idemployee,idnumber AS ID,FULLNAME,rate AS RATE,ssscontribution AS SSS,philhealthcontribution AS Philhealth,pagibigcontribution AS Pagibig,water AS Water, electricity AS Electricity,Housing,other1Disc AS Other1Desc, other1 AS Other1,other2Disc AS Other2Desc,other2 AS Other2, other3Disc AS Other2Desc, other3 AS Other3,ValeDisc,Vale FROM tblemployee WHERE FULLNAME LIKE '%" + txtSearch.Text + "%' ORDER BY FULLNAME", cn);

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dt);
            DV.RowFilter = string.Format("FULLNAME LIKE '%{0}%'", txtSearch.Text);
            dataGridView1.DataSource = DV;
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;
            dataGridView1.Columns[15].Visible = false;
            dataGridView1.Columns[16].Visible = false;
            dataGridView1.Columns[17].Visible = false;

            DataGridViewColumn column1 = dataGridView1.Columns[1];
            column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewColumn column2 = dataGridView1.Columns[2];
            column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;


        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            lblidemployee.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            lblidnumber.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            lblName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            rate.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            SSS.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            Philhealth.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            Pagibig.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            Water.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            Electricity.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            Housing.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            Other1Desc.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            Other1.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            Other2Desc.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            Other2.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            Other3Desc.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            Other3.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            ValeDesc.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
            Vale.Text = dataGridView1.CurrentRow.Cells[17].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMon.Text == string.Empty || txtTue.Text == string.Empty || txtWed.Text == string.Empty || txtThu.Text == string.Empty || txtFri.Text == string.Empty || txtSat.Text == string.Empty || txtSun.Text == string.Empty || TxtReason.Text == string.Empty)
                {
                    MessageBox.Show("REQUIRED MISSING FIELDS 'Please fill in'", "Service Time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtMon.Text == "0" && txtTue.Text == "0" && txtWed.Text == "0" && txtThu.Text == "0" && txtFri.Text == "0" && txtSat.Text == "0" && txtSun.Text == "0")
                {
                    MessageBox.Show("NO DATA SHOULD ADDED  'You should be added hour/s", "Service Time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("ADD NEW RECORD? CLICK YES TO CONFIRM", "Add Service", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblService (idemployee,IDNumber,Name,Date_Covered,RatePerDay,Mon,Tue,Wed,Thu,Fri,Sat,Sun,SSS,Philhealth,Pagibig,Water,Electricity,Housing,Other1Desc,Other1,Other2Desc,Other2,Other3Desc,Other3,ValeDesc,Vale,Postedby)VALUES(@idemployee,@IDNumber,@Name,@Date_Covered,@RatePerDay,@Mon,@Tue,@Wed,@Thu,@Fri,@Sat,@Sun,@SSS,@Philhealth,@Pagibig,@Water,@Electricity,@Housing,@Other1Desc,@Other1,@Other2Desc,@Other2,@Other3Desc,@Other3,@ValeDesc,@Vale,@Postedby)", cn);
                    cm.Parameters.AddWithValue("@idemployee", lblidemployee.Text);
                    cm.Parameters.AddWithValue("@IDNumber", lblidnumber.Text);
                    cm.Parameters.AddWithValue("@Name", lblName.Text);
                    cm.Parameters.AddWithValue("@Date_Covered", lblDateCovered.Text);
                    cm.Parameters.AddWithValue("@RatePerDay", rate.Text);
                    cm.Parameters.AddWithValue("@Mon", txtMon.Text);
                    cm.Parameters.AddWithValue("@Tue", txtTue.Text);
                    cm.Parameters.AddWithValue("@Wed", txtWed.Text);
                    cm.Parameters.AddWithValue("@Thu", txtThu.Text);
                    cm.Parameters.AddWithValue("@Fri", txtFri.Text);
                    cm.Parameters.AddWithValue("@Sat", txtSat.Text);
                    cm.Parameters.AddWithValue("@Sun", txtSun.Text);
                    cm.Parameters.AddWithValue("@SSS", txtSun.Text);
                    cm.Parameters.AddWithValue("@Philhealth", Philhealth.Text);
                    cm.Parameters.AddWithValue("@Pagibig", Pagibig.Text);
                    cm.Parameters.AddWithValue("@Water", Water.Text);
                    cm.Parameters.AddWithValue("@Electricity", Electricity.Text);
                    cm.Parameters.AddWithValue("@Housing", Housing.Text);
                    cm.Parameters.AddWithValue("@Other1Desc", Other1Desc.Text);
                    cm.Parameters.AddWithValue("@Other1", Other1.Text);
                    cm.Parameters.AddWithValue("@Other2Desc", Other2Desc.Text);
                    cm.Parameters.AddWithValue("@Other2", Other2.Text);
                    cm.Parameters.AddWithValue("@Other3Desc", Other3Desc.Text);
                    cm.Parameters.AddWithValue("@Other3", Other3.Text);
                    cm.Parameters.AddWithValue("@ValeDesc", ValeDesc.Text);
                    cm.Parameters.AddWithValue("@Vale", Vale.Text);
                    cm.Parameters.AddWithValue("@Postedby", lblLoginName.Text);
                    cm.ExecuteNonQuery();
                    f.LoadRecordsService();
                    cn.Close();
                    MessageBox.Show("RECORD HAS BEEN SUCCESSFULLY SAVED", "Add Service", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Clear();
                    //f.LoadRecords1();

                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblCreatedServiceHistory (idemployee,IDNumber,Name,Date_Covered,Mon,Tue,Wed,Thu,Fri,Sat,Sun,Date_Posted,Posted_by,Reason)VALUES(@idemployee,@IDNumber,@Name,@Date_Covered,@Mon,@Tue,@Wed,@Thu,@Fri,@Sat,@Sun,@Date_Posted,@Posted_by,@Reason)", cn);
                    cm.Parameters.AddWithValue("@idemployee", lblidemployee.Text);
                    cm.Parameters.AddWithValue("@IDNumber", lblidnumber.Text);
                    cm.Parameters.AddWithValue("@Name", lblName.Text);
                    cm.Parameters.AddWithValue("@Date_Covered", lblDateCovered.Text);
                    cm.Parameters.AddWithValue("@Mon", txtMon.Text);
                    cm.Parameters.AddWithValue("@Tue", txtTue.Text);
                    cm.Parameters.AddWithValue("@Wed", txtWed.Text);
                    cm.Parameters.AddWithValue("@Thu", txtThu.Text);
                    cm.Parameters.AddWithValue("@Fri", txtFri.Text);
                    cm.Parameters.AddWithValue("@Sat", txtSat.Text);
                    cm.Parameters.AddWithValue("@Sun", txtSun.Text);
                    cm.Parameters.AddWithValue("@Date_Posted", DateTime.Now.ToShortDateString());
                    cm.Parameters.AddWithValue("@Posted_by", lblLoginName.Text);
                    cm.Parameters.AddWithValue("@Reason", TxtReason.Text);
                    cm.ExecuteNonQuery();
                    //  MessageBox.Show("RECORD HAS BEEN SUCCESSFULLY UPDATED", "Add/Minus Hours", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.Close();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Add Service", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void txtMon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || (e.KeyChar == '-') || (e.KeyChar == '.') || char.IsControl(e.KeyChar));
        }

        private void txtTue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || (e.KeyChar == '-') || (e.KeyChar == '.') || char.IsControl(e.KeyChar));
        }

        private void txtWed_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || (e.KeyChar == '-') || (e.KeyChar == '.') || char.IsControl(e.KeyChar));
        }

        private void txtThu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || (e.KeyChar == '-') || (e.KeyChar == '.') || char.IsControl(e.KeyChar));
        }

        private void txtFri_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || (e.KeyChar == '-') || (e.KeyChar == '.') || char.IsControl(e.KeyChar));
        }

        private void txtSat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || (e.KeyChar == '-') || (e.KeyChar == '.') || char.IsControl(e.KeyChar));
        }

        private void txtSun_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || (e.KeyChar == '-') || (e.KeyChar == '.') || char.IsControl(e.KeyChar));
        }
    }
}
