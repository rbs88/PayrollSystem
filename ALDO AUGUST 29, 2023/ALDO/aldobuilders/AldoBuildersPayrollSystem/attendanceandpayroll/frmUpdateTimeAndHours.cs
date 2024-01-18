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
    public partial class frmUpdateTimeAndHours : Form
    {
        SqlConnection cn;
        SqlCommand cm;
        SqlDataReader dr;
        DBConnection db = new DBConnection();
        public frmUpdateTimeAndHours()
        {
            InitializeComponent();
            cn = new SqlConnection(db.GetConnection());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAddHours.Text == string.Empty || txtReason.Text == string.Empty)
                {
                    MessageBox.Show("REQUIRED MISSING FIELDS 'AddHours or Reason Fields are empty'", "Add/Minus Hours", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtAddHours.Text == "0")
                {
                    MessageBox.Show("NO DATA SHOULD ADDED 'Please fill in the field for extra hour/s", "ADD/Minus Hours", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("UPDATE THIS RECORD? CLICK YES TO CONFIRM", "Add/Minus Hours", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    //UPDATE RECORDS
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblAttendancePayroll SET AddHours = @AddHours WHERE idattendancepayroll = @idattendancepayroll AND logdate = @logdate", cn);
                    cm.Parameters.AddWithValue("@idattendancepayroll", lblIdPayroll.Text);
                    cm.Parameters.AddWithValue("@AddHours", txtAddHours.Text);
                    cm.Parameters.AddWithValue("@logdate", dtLogdate.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblAddHours (Name,Logdate,AddHours,ModifiedBy,DateModified,Reason)VALUES(@Name,@Logdate,@AddHours,@ModifiedBy,@DateModified,@Reason)", cn);
                    cm.Parameters.AddWithValue("@Name", lblName.Text);
                    cm.Parameters.AddWithValue("@Logdate", dtLogdate.Text);
                    cm.Parameters.AddWithValue("@AddHours", txtAddHours.Text);
                    cm.Parameters.AddWithValue("@ModifiedBy", lblLoginName.Text);
                    cm.Parameters.AddWithValue("@DateModified", DateTime.Now.ToShortDateString());
                    cm.Parameters.AddWithValue("@Reason", txtReason.Text);
                    cm.ExecuteNonQuery();
                    MessageBox.Show("RECORD HAS BEEN SUCCESSFULLY UPDATED", "Add/Minus Hours", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.Close();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Add/Minus Hours", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtAddHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || (e.KeyChar == '-') || (e.KeyChar == '.') || char.IsControl(e.KeyChar));
        }
    }
}
