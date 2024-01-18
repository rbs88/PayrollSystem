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

namespace AldoBuildersPayrollSystem.Employee.MasterList
{
    public partial class frmAssignment : Form
    {
        SqlConnection cn;
        SqlCommand cm;
        SqlDataReader dr;
        DBConnection db = new DBConnection();
        frmAddNewEmployee f;
        public frmAssignment(frmAddNewEmployee f)
        {
            InitializeComponent();
            cn = new SqlConnection(db.GetConnection());
            this.f = f;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Save a record to database
            try
            {
                if (MessageBox.Show("ADD NEW RECORD? CLICK YES TO CONFIRM", "Assignment", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblAssignment (Assignment)VALUES(@Assignment)", cn);
                    cm.Parameters.AddWithValue("@Assignment", txtAssignment.Text);


                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("RECORD HAS BEEN SUCCESSFULLY SAVED", "Assignment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    f.LoadAssignmentToCombo();
                }

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Assignment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
