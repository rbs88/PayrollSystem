using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AldoBuildersPayrollSystem.attendanceandpayroll
{
    public partial class frmPayrollMain : Form
    {
        public frmPayrollMain()
        {
            InitializeComponent();
        }

        private void menuAM_ONLY_Click(object sender, EventArgs e)
        {
            var frm = new attendanceandpayroll.frmTapRFID();
            frm.lblOptions.Text = "AM ONLY";
            frm.lblPM_IN.ForeColor = Color.LightGray;
            frm.lblPM_OUT.ForeColor = Color.LightGray;
            frm.lblOT_IN.ForeColor = Color.LightGray;
            frm.lblOT_OUT.ForeColor = Color.LightGray;
            frm.L3.ForeColor = Color.LightGray;
            frm.L4.ForeColor = Color.LightGray;
            frm.L5.ForeColor = Color.LightGray;
            frm.L6.ForeColor = Color.LightGray;
            frm.ShowDialog();
        }



        private void menuPM_ONLY_Click(object sender, EventArgs e)
        {
            var frm = new attendanceandpayroll.frmTapRFID();
            frm.lblOptions.Text = "PM ONLY";
            frm.lblAM_IN.ForeColor = Color.LightGray;
            frm.lblAM_OUT.ForeColor = Color.LightGray;
            frm.lblOT_IN.ForeColor = Color.LightGray;
            frm.lblOT_OUT.ForeColor = Color.LightGray;
            frm.L1.ForeColor = Color.LightGray;
            frm.L2.ForeColor = Color.LightGray;
            frm.L5.ForeColor = Color.LightGray;
            frm.L6.ForeColor = Color.LightGray;
            frm.ShowDialog();
        }

        private void menuOT_ONLY_Click(object sender, EventArgs e)
        {
            var frm = new attendanceandpayroll.frmTapRFID();
            frm.lblOptions.Text = "OVERTIME ONLY";
            frm.lblAM_IN.ForeColor = Color.LightGray;
            frm.lblAM_OUT.ForeColor = Color.LightGray;
            frm.lblPM_IN.ForeColor = Color.LightGray;
            frm.lblPM_OUT.ForeColor = Color.LightGray;
            frm.L1.ForeColor = Color.LightGray;
            frm.L2.ForeColor = Color.LightGray;
            frm.L3.ForeColor = Color.LightGray;
            frm.L4.ForeColor = Color.LightGray;
            frm.ShowDialog();
        }

        private void gENERATEREPORTSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void iNOUTOPTIONSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vIEWATTENDANCEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new attendanceandpayroll.frmAttendanceViewer();
            frm.TopLevel = false;
            panel3.Controls.Add(frm);
            frm.lblLoginName.Text = lblLoginName.Text;
            //frm.LoadRecords();
            //frm.BringToFront();
            //frm.suser1 = suser;
            frm.Show();
        }

        private void vIEWSUMMARYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new attendanceandpayroll.frmPayrollSummary();
            frm.TopLevel = false;
            frm.lblLoginName.Text = lblLoginName.Text;
            panel3.Controls.Add(frm);
            //frm.LoadRecords();
            //frm.BringToFront();
            //frm.suser1 = suser;
            frm.Show();
        }

        private void aDDDEDUCTIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new attendanceandpayroll.frmDeduction();
            frm.TopLevel = false;
            //frm.lblLoginName.Text = lblLoginName.Text;
            panel3.Controls.Add(frm);
            //frm.LoadRecords();
            //frm.BringToFront();
            //frm.suser1 = suser;
            frm.Show();
        }

        private void cREATEDATECOVEREDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new attendanceandpayroll.frmDateCovered();
            frm.ShowDialog();
        }

        private void pAYROLLHISTORYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new attendanceandpayroll.frmFinalResult();
            frm.TopLevel = false;
            frm.lblLoginName.Text = lblLoginName.Text;
            panel3.Controls.Add(frm);
            //frm.LoadRecords();
            //frm.BringToFront();
            //frm.suser1 = suser;
            frm.Show();
        }

        private void sIGNATORIESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new attendanceandpayroll.frmSignatories();
            frm.ShowDialog();
        }

        private void addHoursHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addHoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new TransactionHistory.frmAddHours();
            frm.ShowDialog();
        }

        private void role_TextChanged(object sender, EventArgs e)
        {
            if (role.Text == "Administrator")
            {
                tRANSACTIONHISTORYToolStripMenuItem.Visible = true;
            }
            else if (role.Text == "Owner")
            {
                tRANSACTIONHISTORYToolStripMenuItem.Visible = true;
            }
            else
            {
                tRANSACTIONHISTORYToolStripMenuItem.Visible = false;
            }
        }

        private void oTHER3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sSSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new DeductionHistory.frmDeduction();
            frm.ShowDialog();
        }

        private void oTHERHISTORYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new DeductionHistory.frmOtherDeduction();
            frm.ShowDialog();
        }

        private void serviceHoursHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new TransactionHistory.frmCreatingServiceHistory();
            frm.ShowDialog();
        }

        private void hISTORYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new ATU.frmATU();
            frm.ShowDialog();
        }

        private void absentHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new ATU.frmAbsent();
            frm.lblLoginName.Text = lblLoginName.Text;
            frm.ShowDialog();
        }
    }
}
