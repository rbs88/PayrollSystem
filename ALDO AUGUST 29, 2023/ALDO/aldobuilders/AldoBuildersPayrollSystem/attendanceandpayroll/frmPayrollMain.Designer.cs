namespace AldoBuildersPayrollSystem.attendanceandpayroll
{
    partial class frmPayrollMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            role = new Label();
            lblLoginName = new Label();
            label1 = new Label();
            panel2 = new Panel();
            menuStrip1 = new MenuStrip();
            iNOUTOPTIONSToolStripMenuItem = new ToolStripMenuItem();
            menuAM_ONLY = new ToolStripMenuItem();
            menuPM_ONLY = new ToolStripMenuItem();
            menuOT_ONLY = new ToolStripMenuItem();
            gENERATEREPORTSToolStripMenuItem = new ToolStripMenuItem();
            vIEWATTENDANCEToolStripMenuItem = new ToolStripMenuItem();
            vIEWSUMMARYToolStripMenuItem = new ToolStripMenuItem();
            aDDDEDUCTIONToolStripMenuItem = new ToolStripMenuItem();
            cREATEDATECOVEREDToolStripMenuItem = new ToolStripMenuItem();
            pAYROLLToolStripMenuItem = new ToolStripMenuItem();
            pAYROLLHISTORYToolStripMenuItem = new ToolStripMenuItem();
            sIGNATORIESToolStripMenuItem = new ToolStripMenuItem();
            dEDUCTIONHISTORYToolStripMenuItem = new ToolStripMenuItem();
            sSSToolStripMenuItem = new ToolStripMenuItem();
            oTHERHISTORYToolStripMenuItem = new ToolStripMenuItem();
            aTUToolStripMenuItem = new ToolStripMenuItem();
            hISTORYToolStripMenuItem = new ToolStripMenuItem();
            absentHistoryToolStripMenuItem = new ToolStripMenuItem();
            tRANSACTIONHISTORYToolStripMenuItem = new ToolStripMenuItem();
            addHoursToolStripMenuItem = new ToolStripMenuItem();
            serviceHoursHistoryToolStripMenuItem = new ToolStripMenuItem();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(role);
            panel1.Controls.Add(lblLoginName);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1283, 52);
            panel1.TabIndex = 0;
            // 
            // role
            // 
            role.AutoSize = true;
            role.Location = new Point(1010, 24);
            role.Name = "role";
            role.Size = new Size(38, 15);
            role.TabIndex = 2;
            role.Text = "label2";
            role.Visible = false;
            role.TextChanged += role_TextChanged;
            // 
            // lblLoginName
            // 
            lblLoginName.AutoSize = true;
            lblLoginName.Location = new Point(888, 14);
            lblLoginName.Name = "lblLoginName";
            lblLoginName.Size = new Size(38, 15);
            lblLoginName.TabIndex = 1;
            lblLoginName.Text = "label2";
            lblLoginName.Visible = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Navy;
            label1.Font = new Font("Rockwell", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.Size = new Size(1277, 45);
            label1.TabIndex = 0;
            label1.Text = "PAYROLL SYSTEM";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(menuStrip1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 52);
            panel2.Name = "panel2";
            panel2.Size = new Size(1283, 33);
            panel2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.Items.AddRange(new ToolStripItem[] { iNOUTOPTIONSToolStripMenuItem, gENERATEREPORTSToolStripMenuItem, pAYROLLToolStripMenuItem, dEDUCTIONHISTORYToolStripMenuItem, aTUToolStripMenuItem, tRANSACTIONHISTORYToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1283, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // iNOUTOPTIONSToolStripMenuItem
            // 
            iNOUTOPTIONSToolStripMenuItem.BackColor = Color.Transparent;
            iNOUTOPTIONSToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuAM_ONLY, menuPM_ONLY, menuOT_ONLY });
            iNOUTOPTIONSToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            iNOUTOPTIONSToolStripMenuItem.Name = "iNOUTOPTIONSToolStripMenuItem";
            iNOUTOPTIONSToolStripMenuItem.Size = new Size(145, 29);
            iNOUTOPTIONSToolStripMenuItem.Text = "IN/OUT OPTIONS";
            iNOUTOPTIONSToolStripMenuItem.Click += iNOUTOPTIONSToolStripMenuItem_Click;
            // 
            // menuAM_ONLY
            // 
            menuAM_ONLY.Name = "menuAM_ONLY";
            menuAM_ONLY.Size = new Size(148, 26);
            menuAM_ONLY.Text = "AM ONLY";
            menuAM_ONLY.Click += menuAM_ONLY_Click;
            // 
            // menuPM_ONLY
            // 
            menuPM_ONLY.Name = "menuPM_ONLY";
            menuPM_ONLY.Size = new Size(148, 26);
            menuPM_ONLY.Text = "PM ONLY";
            menuPM_ONLY.Click += menuPM_ONLY_Click;
            // 
            // menuOT_ONLY
            // 
            menuOT_ONLY.Name = "menuOT_ONLY";
            menuOT_ONLY.Size = new Size(148, 26);
            menuOT_ONLY.Text = "OT ONLY";
            menuOT_ONLY.Click += menuOT_ONLY_Click;
            // 
            // gENERATEREPORTSToolStripMenuItem
            // 
            gENERATEREPORTSToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { vIEWATTENDANCEToolStripMenuItem, vIEWSUMMARYToolStripMenuItem, aDDDEDUCTIONToolStripMenuItem, cREATEDATECOVEREDToolStripMenuItem });
            gENERATEREPORTSToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gENERATEREPORTSToolStripMenuItem.Name = "gENERATEREPORTSToolStripMenuItem";
            gENERATEREPORTSToolStripMenuItem.Size = new Size(198, 29);
            gENERATEREPORTSToolStripMenuItem.Text = "PAYROLL MODIFICATION";
            gENERATEREPORTSToolStripMenuItem.Click += gENERATEREPORTSToolStripMenuItem_Click;
            // 
            // vIEWATTENDANCEToolStripMenuItem
            // 
            vIEWATTENDANCEToolStripMenuItem.Name = "vIEWATTENDANCEToolStripMenuItem";
            vIEWATTENDANCEToolStripMenuItem.Size = new Size(341, 26);
            vIEWATTENDANCEToolStripMenuItem.Text = "VIEW ATTENDANCE AND ADD_HOUR";
            vIEWATTENDANCEToolStripMenuItem.Click += vIEWATTENDANCEToolStripMenuItem_Click;
            // 
            // vIEWSUMMARYToolStripMenuItem
            // 
            vIEWSUMMARYToolStripMenuItem.Name = "vIEWSUMMARYToolStripMenuItem";
            vIEWSUMMARYToolStripMenuItem.Size = new Size(341, 26);
            vIEWSUMMARYToolStripMenuItem.Text = "CREATE PAYROLL";
            vIEWSUMMARYToolStripMenuItem.Click += vIEWSUMMARYToolStripMenuItem_Click;
            // 
            // aDDDEDUCTIONToolStripMenuItem
            // 
            aDDDEDUCTIONToolStripMenuItem.Name = "aDDDEDUCTIONToolStripMenuItem";
            aDDDEDUCTIONToolStripMenuItem.Size = new Size(341, 26);
            aDDDEDUCTIONToolStripMenuItem.Text = "ADD DEDUCTION";
            aDDDEDUCTIONToolStripMenuItem.Click += aDDDEDUCTIONToolStripMenuItem_Click;
            // 
            // cREATEDATECOVEREDToolStripMenuItem
            // 
            cREATEDATECOVEREDToolStripMenuItem.Name = "cREATEDATECOVEREDToolStripMenuItem";
            cREATEDATECOVEREDToolStripMenuItem.Size = new Size(341, 26);
            cREATEDATECOVEREDToolStripMenuItem.Text = "CREATE DATE_COVERED";
            cREATEDATECOVEREDToolStripMenuItem.Click += cREATEDATECOVEREDToolStripMenuItem_Click;
            // 
            // pAYROLLToolStripMenuItem
            // 
            pAYROLLToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pAYROLLHISTORYToolStripMenuItem, sIGNATORIESToolStripMenuItem });
            pAYROLLToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pAYROLLToolStripMenuItem.Name = "pAYROLLToolStripMenuItem";
            pAYROLLToolStripMenuItem.Size = new Size(86, 29);
            pAYROLLToolStripMenuItem.Text = "PAYROLL";
            // 
            // pAYROLLHISTORYToolStripMenuItem
            // 
            pAYROLLHISTORYToolStripMenuItem.Name = "pAYROLLHISTORYToolStripMenuItem";
            pAYROLLHISTORYToolStripMenuItem.Size = new Size(247, 26);
            pAYROLLHISTORYToolStripMenuItem.Text = "PAYROLL FINAL RESULT";
            pAYROLLHISTORYToolStripMenuItem.Click += pAYROLLHISTORYToolStripMenuItem_Click;
            // 
            // sIGNATORIESToolStripMenuItem
            // 
            sIGNATORIESToolStripMenuItem.Name = "sIGNATORIESToolStripMenuItem";
            sIGNATORIESToolStripMenuItem.Size = new Size(247, 26);
            sIGNATORIESToolStripMenuItem.Text = "SIGNATORIES";
            sIGNATORIESToolStripMenuItem.Click += sIGNATORIESToolStripMenuItem_Click;
            // 
            // dEDUCTIONHISTORYToolStripMenuItem
            // 
            dEDUCTIONHISTORYToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sSSToolStripMenuItem, oTHERHISTORYToolStripMenuItem });
            dEDUCTIONHISTORYToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dEDUCTIONHISTORYToolStripMenuItem.Name = "dEDUCTIONHISTORYToolStripMenuItem";
            dEDUCTIONHISTORYToolStripMenuItem.Size = new Size(175, 29);
            dEDUCTIONHISTORYToolStripMenuItem.Text = "DEDUCTION HISTORY";
            // 
            // sSSToolStripMenuItem
            // 
            sSSToolStripMenuItem.Name = "sSSToolStripMenuItem";
            sSSToolStripMenuItem.Size = new Size(194, 26);
            sSSToolStripMenuItem.Text = "HISTORY";
            sSSToolStripMenuItem.Click += sSSToolStripMenuItem_Click;
            // 
            // oTHERHISTORYToolStripMenuItem
            // 
            oTHERHISTORYToolStripMenuItem.Name = "oTHERHISTORYToolStripMenuItem";
            oTHERHISTORYToolStripMenuItem.Size = new Size(194, 26);
            oTHERHISTORYToolStripMenuItem.Text = "OTHER HISTORY";
            oTHERHISTORYToolStripMenuItem.Click += oTHERHISTORYToolStripMenuItem_Click;
            // 
            // aTUToolStripMenuItem
            // 
            aTUToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hISTORYToolStripMenuItem, absentHistoryToolStripMenuItem });
            aTUToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aTUToolStripMenuItem.Name = "aTUToolStripMenuItem";
            aTUToolStripMenuItem.Size = new Size(50, 29);
            aTUToolStripMenuItem.Text = "ATU";
            // 
            // hISTORYToolStripMenuItem
            // 
            hISTORYToolStripMenuItem.Name = "hISTORYToolStripMenuItem";
            hISTORYToolStripMenuItem.Size = new Size(243, 26);
            hISTORYToolStripMenuItem.Text = "Late/Undertime History";
            hISTORYToolStripMenuItem.Click += hISTORYToolStripMenuItem_Click;
            // 
            // absentHistoryToolStripMenuItem
            // 
            absentHistoryToolStripMenuItem.Name = "absentHistoryToolStripMenuItem";
            absentHistoryToolStripMenuItem.Size = new Size(243, 26);
            absentHistoryToolStripMenuItem.Text = "Absent History";
            absentHistoryToolStripMenuItem.Click += absentHistoryToolStripMenuItem_Click;
            // 
            // tRANSACTIONHISTORYToolStripMenuItem
            // 
            tRANSACTIONHISTORYToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addHoursToolStripMenuItem, serviceHoursHistoryToolStripMenuItem });
            tRANSACTIONHISTORYToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tRANSACTIONHISTORYToolStripMenuItem.Name = "tRANSACTIONHISTORYToolStripMenuItem";
            tRANSACTIONHISTORYToolStripMenuItem.Size = new Size(193, 29);
            tRANSACTIONHISTORYToolStripMenuItem.Text = "TRANSACTION HISTORY";
            // 
            // addHoursToolStripMenuItem
            // 
            addHoursToolStripMenuItem.Name = "addHoursToolStripMenuItem";
            addHoursToolStripMenuItem.Size = new Size(230, 26);
            addHoursToolStripMenuItem.Text = "Add Hours History";
            addHoursToolStripMenuItem.Click += addHoursToolStripMenuItem_Click;
            // 
            // serviceHoursHistoryToolStripMenuItem
            // 
            serviceHoursHistoryToolStripMenuItem.Name = "serviceHoursHistoryToolStripMenuItem";
            serviceHoursHistoryToolStripMenuItem.Size = new Size(230, 26);
            serviceHoursHistoryToolStripMenuItem.Text = "Service Hours History";
            serviceHoursHistoryToolStripMenuItem.Click += serviceHoursHistoryToolStripMenuItem_Click;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 85);
            panel3.Name = "panel3";
            panel3.Size = new Size(1283, 631);
            panel3.TabIndex = 2;
            // 
            // frmPayrollMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 716);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip1;
            Name = "frmPayrollMain";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem iNOUTOPTIONSToolStripMenuItem;
        private ToolStripMenuItem menuAM_ONLY;
        private ToolStripMenuItem menuPM_ONLY;
        private ToolStripMenuItem menuOT_ONLY;
        private ToolStripMenuItem gENERATEREPORTSToolStripMenuItem;
        private Panel panel3;
        private ToolStripMenuItem vIEWATTENDANCEToolStripMenuItem;
        private ToolStripMenuItem vIEWSUMMARYToolStripMenuItem;
        private ToolStripMenuItem pAYROLLToolStripMenuItem;
        private ToolStripMenuItem pAYROLLHISTORYToolStripMenuItem;
        private ToolStripMenuItem aDDDEDUCTIONToolStripMenuItem;
        private ToolStripMenuItem dEDUCTIONHISTORYToolStripMenuItem;
        private ToolStripMenuItem sSSToolStripMenuItem;
        private ToolStripMenuItem cREATEDATECOVEREDToolStripMenuItem;
        private ToolStripMenuItem sIGNATORIESToolStripMenuItem;
        public Label lblLoginName;
        private ToolStripMenuItem tRANSACTIONHISTORYToolStripMenuItem;
        private ToolStripMenuItem addHoursToolStripMenuItem;
        public Label role;
        private ToolStripMenuItem oTHERHISTORYToolStripMenuItem;
        private ToolStripMenuItem serviceHoursHistoryToolStripMenuItem;
        private ToolStripMenuItem aTUToolStripMenuItem;
        private ToolStripMenuItem hISTORYToolStripMenuItem;
        private ToolStripMenuItem absentHistoryToolStripMenuItem;
    }
}