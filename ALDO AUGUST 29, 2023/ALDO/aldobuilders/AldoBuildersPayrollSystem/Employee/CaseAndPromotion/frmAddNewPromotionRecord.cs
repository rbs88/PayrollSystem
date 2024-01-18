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

namespace AldoBuildersPayrollSystem.Employee.CaseAndPromotion
{
	public partial class frmAddNewPromotionRecord : Form
	{
		SqlConnection cn;
		SqlCommand cm;
		SqlDataReader dr;
		DBConnection db = new DBConnection();
		string _title = "Aldo Builders Incorporated";
		frmMainCaseAndPromotion f;
		public frmAddNewPromotionRecord(frmMainCaseAndPromotion f)
		{
			InitializeComponent();
			cn = new SqlConnection(db.GetConnection());
			this.f = f;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				if (txtNewDesignation.Text == string.Empty || txtNewRate.Text == string.Empty)
				{
					MessageBox.Show("REQUIRED MISSING FIELDS", _title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;

				}
				if (MessageBox.Show("ADD NEW RECORD? CLICK YES TO CONFIRM", _title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					cn.Open();
					cm = new SqlCommand("INSERT INTO tblpromotion (idemployee,datepromoted,rate,designation,reasonofpromotion,postedby)VALUES(@idemployee,@datepromoted,@rate,@designation,@reasonofpromotion,@postedby)", cn);
					cm.Parameters.AddWithValue("@idemployee", label5.Text);
					cm.Parameters.AddWithValue("@datepromoted", DateTime.Parse(dtDatePromoted.Text));
					cm.Parameters.AddWithValue("@designation", txtNewDesignation.Text);
					cm.Parameters.AddWithValue("@rate", txtNewRate.Text);
					cm.Parameters.AddWithValue("@reasonofpromotion", txtReason.Text);
					cm.Parameters.AddWithValue("@postedby", lblpostedby.Text);

					cm.ExecuteNonQuery();
					cn.Close();
					MessageBox.Show("RECORD HAS BEEN SUCCESSFULLY SAVED", _title, MessageBoxButtons.OK, MessageBoxIcon.Information);
					//Clear();
					f.LoadRecords2();
				}
			}
			catch (Exception ex)
			{
				cn.Close();
				MessageBox.Show(ex.Message, _title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
	}
}
