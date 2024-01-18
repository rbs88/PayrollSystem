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
    public partial class frmDesignation : Form
    {
        SqlConnection cn;
        SqlCommand cm;
        SqlDataReader dr;
        DBConnection db = new DBConnection();
        frmAddNewEmployee f;
        public frmDesignation(frmAddNewEmployee f)
        {
            InitializeComponent();
            cn = new SqlConnection(db.GetConnection());
            this.f = f;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("ADD NEW RECORD? CLICK YES TO CONFIRM", "Assignment", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblDesignation (Designation,rate)VALUES(@Designation,@rate)", cn);
                    cm.Parameters.AddWithValue("@Designation", txtDesignation.Text);
                    cm.Parameters.AddWithValue("@rate", txtRate.Text);

                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("RECORD HAS BEEN SUCCESSFULLY SAVED", "Designation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    f.LoadDesignationToCombo();
                }

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Designation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
