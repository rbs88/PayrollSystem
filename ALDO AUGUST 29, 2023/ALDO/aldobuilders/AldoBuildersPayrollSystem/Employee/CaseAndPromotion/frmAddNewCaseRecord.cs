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


namespace AldoBuildersPayrollSystem.Employee.CaseAndPromotion
{
    public partial class frmAddNewCaseRecord : Form
    {
        SqlConnection cn;
        SqlCommand cm;
        SqlDataReader dr;
        DBConnection db = new DBConnection();
        string _title = "Aldo Builders Incorporated";
        frmMainCaseAndPromotion f;
        public frmAddNewCaseRecord(frmMainCaseAndPromotion f)
        {
            InitializeComponent();
            cn = new SqlConnection(db.GetConnection());
            this.f = f;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCaseType.Text == string.Empty || txtCaseReason.Text == string.Empty)
                {
                    MessageBox.Show("REQUIRED MISSING FIELDS", _title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
                if (MessageBox.Show("ADD NEW RECORD? CLICK YES TO CONFIRM", _title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblcase (idemployee,datecase,type,reason,postedby)VALUES(@idemployee,@datecase,@type,@reason,@postedby)", cn);
                    cm.Parameters.AddWithValue("@idemployee", label1.Text);
                    cm.Parameters.AddWithValue("@datecase", DateTime.Parse(dtCasePosted.Text));
                    cm.Parameters.AddWithValue("@type", txtCaseType.Text);
                    cm.Parameters.AddWithValue("@reason", txtCaseReason.Text);
                    cm.Parameters.AddWithValue("@postedby", lblpostedby.Text);

                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("RECORD HAS BEEN SUCCESSFULLY SAVED", _title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Clear();
                    f.LoadRecords1();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, _title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
