using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AldoBuildersPayrollSystem.Employee.MasterList
{
	public partial class frmMainEmployee : Form
	{
		public frmMainEmployee()
		{
			InitializeComponent();
		}

		private void btnAddNew_Click(object sender, EventArgs e)
		{
			var frm = new Employee.MasterList.frmMainEmployeeLoadRecord();
			frm.TopLevel = false;
			frm.lblLoginName.Text = lblLoginName.Text;
			frm.role.Text = role.Text;
			panelEmployeeMain.Controls.Add(frm);
			//frm.LoadRecords();
			//frm.BringToFront();
			//frm.suser1 = suser;
			frm.Show();
		}

		private void btnCaseAndPromotion_Click(object sender, EventArgs e)
		{
			var frm = new Employee.CaseAndPromotion.frmMainCaseAndPromotion();
			frm.TopLevel = false;
			frm.lblLoginName.Text = lblLoginName.Text;
			panelEmployeeMain.Controls.Add(frm);
			//frm.LoadRecords();
			//frm.BringToFront();
			//frm.suser1 = suser;
			frm.Show();
		}

		private void btnInactiveMasterlist_Click(object sender, EventArgs e)
		{
			var frm = new Employee.InActiveMasterlist.frmInactiveMasterList();
			frm.TopLevel = false;
			panelEmployeeMain.Controls.Add(frm);
			frm.Show();

		}
	}
}
