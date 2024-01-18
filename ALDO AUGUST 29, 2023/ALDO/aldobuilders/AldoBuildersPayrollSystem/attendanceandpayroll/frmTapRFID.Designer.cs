namespace AldoBuildersPayrollSystem.attendanceandpayroll
{
    partial class frmTapRFID
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            groupBox1 = new GroupBox();
            lbllate = new Label();
            lblNotFound = new Label();
            lblNotAllowed = new Label();
            lblDesignation = new Label();
            lblAssign = new Label();
            lblIdnumber = new Label();
            label20 = new Label();
            label19 = new Label();
            lblMiddlename = new Label();
            lblFirstname = new Label();
            lblLastname = new Label();
            lblDay = new Label();
            lblDate = new Label();
            lbltime = new Label();
            lblMessage = new Label();
            pictureBox2 = new PictureBox();
            txtRFID = new TextBox();
            groupBox2 = new GroupBox();
            label16 = new Label();
            label15 = new Label();
            lblOT_OUT = new Label();
            lblOT_IN = new Label();
            lblPM_OUT = new Label();
            lblPM_IN = new Label();
            lblAM_OUT = new Label();
            lblAM_IN = new Label();
            L6 = new Label();
            L5 = new Label();
            L4 = new Label();
            L3 = new Label();
            L2 = new Label();
            L1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            lblOptions = new Label();
            lblIDNO = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1904, 89);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo12;
            pictureBox1.Location = new Point(17, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(113, 7);
            label1.Name = "label1";
            label1.Size = new Size(1003, 76);
            label1.TabIndex = 1;
            label1.Text = "ALDO BUILDERS INCORPORATED";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 89);
            panel2.Name = "panel2";
            panel2.Size = new Size(1904, 40);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 7);
            label2.Name = "label2";
            label2.Size = new Size(1901, 26);
            label2.TabIndex = 3;
            label2.Text = "Daily Time Record";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbllate);
            groupBox1.Controls.Add(lblNotFound);
            groupBox1.Controls.Add(lblNotAllowed);
            groupBox1.Controls.Add(lblDesignation);
            groupBox1.Controls.Add(lblAssign);
            groupBox1.Controls.Add(lblIdnumber);
            groupBox1.Controls.Add(label20);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(lblMiddlename);
            groupBox1.Controls.Add(lblFirstname);
            groupBox1.Controls.Add(lblLastname);
            groupBox1.Controls.Add(lblDay);
            groupBox1.Controls.Add(lblDate);
            groupBox1.Controls.Add(lbltime);
            groupBox1.Controls.Add(lblMessage);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(txtRFID);
            groupBox1.Location = new Point(436, 145);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1303, 864);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // lbllate
            // 
            lbllate.BackColor = Color.White;
            lbllate.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point);
            lbllate.ForeColor = Color.Red;
            lbllate.Location = new Point(18, 452);
            lbllate.Name = "lbllate";
            lbllate.Size = new Size(530, 83);
            lbllate.TabIndex = 29;
            lbllate.Text = "You're Late";
            lbllate.TextAlign = ContentAlignment.MiddleCenter;
            lbllate.Visible = false;
            // 
            // lblNotFound
            // 
            lblNotFound.Font = new Font("Microsoft Sans Serif", 80.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNotFound.ForeColor = Color.Red;
            lblNotFound.Location = new Point(554, 98);
            lblNotFound.Name = "lblNotFound";
            lblNotFound.Size = new Size(743, 230);
            lblNotFound.TabIndex = 28;
            lblNotFound.TextAlign = ContentAlignment.MiddleCenter;
            lblNotFound.Visible = false;
            // 
            // lblNotAllowed
            // 
            lblNotAllowed.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNotAllowed.ForeColor = Color.Red;
            lblNotAllowed.Location = new Point(18, 555);
            lblNotAllowed.Name = "lblNotAllowed";
            lblNotAllowed.Size = new Size(530, 255);
            lblNotAllowed.TabIndex = 27;
            lblNotAllowed.Text = "....";
            lblNotAllowed.TextAlign = ContentAlignment.MiddleCenter;
            lblNotAllowed.Visible = false;
            // 
            // lblDesignation
            // 
            lblDesignation.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblDesignation.ForeColor = Color.Black;
            lblDesignation.Location = new Point(579, 426);
            lblDesignation.Name = "lblDesignation";
            lblDesignation.Size = new Size(683, 29);
            lblDesignation.TabIndex = 25;
            lblDesignation.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblAssign
            // 
            lblAssign.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblAssign.ForeColor = Color.Black;
            lblAssign.Location = new Point(577, 372);
            lblAssign.Name = "lblAssign";
            lblAssign.Size = new Size(683, 32);
            lblAssign.TabIndex = 24;
            lblAssign.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblIdnumber
            // 
            lblIdnumber.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblIdnumber.ForeColor = Color.Red;
            lblIdnumber.Location = new Point(579, 36);
            lblIdnumber.Name = "lblIdnumber";
            lblIdnumber.Size = new Size(683, 31);
            lblIdnumber.TabIndex = 23;
            lblIdnumber.TextAlign = ContentAlignment.TopCenter;
            // 
            // label20
            // 
            label20.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ForeColor = Color.Green;
            label20.Location = new Point(575, 328);
            label20.Name = "label20";
            label20.Size = new Size(685, 31);
            label20.TabIndex = 22;
            label20.Text = "-----------------------------------------------------";
            label20.TextAlign = ContentAlignment.TopCenter;
            // 
            // label19
            // 
            label19.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ForeColor = Color.Green;
            label19.Location = new Point(577, 67);
            label19.Name = "label19";
            label19.Size = new Size(685, 31);
            label19.TabIndex = 21;
            label19.Text = "-----------------------------------------------------";
            label19.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblMiddlename
            // 
            lblMiddlename.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblMiddlename.ForeColor = Color.Black;
            lblMiddlename.Location = new Point(577, 265);
            lblMiddlename.Name = "lblMiddlename";
            lblMiddlename.Size = new Size(683, 54);
            lblMiddlename.TabIndex = 20;
            lblMiddlename.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblFirstname
            // 
            lblFirstname.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblFirstname.ForeColor = Color.Black;
            lblFirstname.Location = new Point(579, 198);
            lblFirstname.Name = "lblFirstname";
            lblFirstname.Size = new Size(683, 53);
            lblFirstname.TabIndex = 19;
            lblFirstname.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblLastname
            // 
            lblLastname.Font = new Font("Microsoft Sans Serif", 60F, FontStyle.Regular, GraphicsUnit.Point);
            lblLastname.ForeColor = Color.Teal;
            lblLastname.Location = new Point(577, 102);
            lblLastname.Name = "lblLastname";
            lblLastname.Size = new Size(683, 91);
            lblLastname.TabIndex = 18;
            lblLastname.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblDay
            // 
            lblDay.Font = new Font("Microsoft Sans Serif", 39.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDay.ForeColor = Color.DarkSalmon;
            lblDay.Location = new Point(568, 542);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(703, 65);
            lblDay.TabIndex = 17;
            lblDay.Text = "day";
            lblDay.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblDate
            // 
            lblDate.Font = new Font("Microsoft Sans Serif", 39.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDate.ForeColor = Color.DarkSalmon;
            lblDate.Location = new Point(570, 718);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(703, 75);
            lblDate.TabIndex = 16;
            lblDate.Text = "date";
            lblDate.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lbltime
            // 
            lbltime.Font = new Font("Microsoft Sans Serif", 80.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbltime.ForeColor = Color.Lime;
            lbltime.Location = new Point(554, 603);
            lbltime.Name = "lbltime";
            lbltime.Size = new Size(743, 120);
            lbltime.TabIndex = 15;
            lbltime.Text = "time";
            lbltime.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblMessage
            // 
            lblMessage.Font = new Font("Microsoft Sans Serif", 120F, FontStyle.Bold, GraphicsUnit.Point);
            lblMessage.ForeColor = Color.Red;
            lblMessage.Location = new Point(18, 548);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(530, 296);
            lblMessage.TabIndex = 14;
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.download;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.InitialImage = Properties.Resources.download;
            pictureBox2.Location = new Point(18, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(530, 523);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // txtRFID
            // 
            txtRFID.Location = new Point(352, 22);
            txtRFID.Name = "txtRFID";
            txtRFID.Size = new Size(196, 23);
            txtRFID.TabIndex = 26;
            txtRFID.TextChanged += txtRFID_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(lblOT_OUT);
            groupBox2.Controls.Add(lblOT_IN);
            groupBox2.Controls.Add(lblPM_OUT);
            groupBox2.Controls.Add(lblPM_IN);
            groupBox2.Controls.Add(lblAM_OUT);
            groupBox2.Controls.Add(lblAM_IN);
            groupBox2.Controls.Add(L6);
            groupBox2.Controls.Add(L5);
            groupBox2.Controls.Add(L4);
            groupBox2.Controls.Add(L3);
            groupBox2.Controls.Add(L2);
            groupBox2.Controls.Add(L1);
            groupBox2.Location = new Point(25, 327);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(399, 498);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "DTR";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(3, 337);
            label16.Name = "label16";
            label16.Size = new Size(392, 15);
            label16.TabIndex = 13;
            label16.Text = "_____________________________________________________________________________";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(3, 154);
            label15.Name = "label15";
            label15.Size = new Size(392, 15);
            label15.TabIndex = 12;
            label15.Text = "_____________________________________________________________________________";
            // 
            // lblOT_OUT
            // 
            lblOT_OUT.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblOT_OUT.ForeColor = Color.Red;
            lblOT_OUT.Location = new Point(199, 429);
            lblOT_OUT.Name = "lblOT_OUT";
            lblOT_OUT.Size = new Size(189, 40);
            lblOT_OUT.TabIndex = 11;
            lblOT_OUT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOT_IN
            // 
            lblOT_IN.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblOT_IN.ForeColor = Color.Green;
            lblOT_IN.Location = new Point(5, 427);
            lblOT_IN.Name = "lblOT_IN";
            lblOT_IN.Size = new Size(179, 40);
            lblOT_IN.TabIndex = 10;
            lblOT_IN.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPM_OUT
            // 
            lblPM_OUT.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPM_OUT.ForeColor = Color.Red;
            lblPM_OUT.Location = new Point(198, 261);
            lblPM_OUT.Name = "lblPM_OUT";
            lblPM_OUT.Size = new Size(189, 40);
            lblPM_OUT.TabIndex = 9;
            lblPM_OUT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPM_IN
            // 
            lblPM_IN.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPM_IN.ForeColor = Color.Green;
            lblPM_IN.Location = new Point(5, 260);
            lblPM_IN.Name = "lblPM_IN";
            lblPM_IN.Size = new Size(179, 40);
            lblPM_IN.TabIndex = 8;
            lblPM_IN.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAM_OUT
            // 
            lblAM_OUT.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAM_OUT.ForeColor = Color.Red;
            lblAM_OUT.Location = new Point(199, 85);
            lblAM_OUT.Name = "lblAM_OUT";
            lblAM_OUT.Size = new Size(189, 40);
            lblAM_OUT.TabIndex = 7;
            lblAM_OUT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAM_IN
            // 
            lblAM_IN.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAM_IN.ForeColor = Color.Green;
            lblAM_IN.Location = new Point(5, 84);
            lblAM_IN.Name = "lblAM_IN";
            lblAM_IN.Size = new Size(179, 40);
            lblAM_IN.TabIndex = 6;
            lblAM_IN.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // L6
            // 
            L6.AutoSize = true;
            L6.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            L6.Location = new Point(228, 373);
            L6.Name = "L6";
            L6.Size = new Size(123, 40);
            L6.TabIndex = 5;
            L6.Text = "OT OUT";
            // 
            // L5
            // 
            L5.AutoSize = true;
            L5.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            L5.Location = new Point(45, 373);
            L5.Name = "L5";
            L5.Size = new Size(95, 40);
            L5.TabIndex = 4;
            L5.Text = "OT IN";
            // 
            // L4
            // 
            L4.AutoSize = true;
            L4.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            L4.Location = new Point(230, 203);
            L4.Name = "L4";
            L4.Size = new Size(131, 40);
            L4.TabIndex = 3;
            L4.Text = "PM OUT";
            // 
            // L3
            // 
            L3.AutoSize = true;
            L3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            L3.Location = new Point(40, 203);
            L3.Name = "L3";
            L3.Size = new Size(103, 40);
            L3.TabIndex = 2;
            L3.Text = "PM IN";
            // 
            // L2
            // 
            L2.AutoSize = true;
            L2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            L2.Location = new Point(226, 30);
            L2.Name = "L2";
            L2.Size = new Size(133, 40);
            L2.TabIndex = 1;
            L2.Text = "AM OUT";
            // 
            // L1
            // 
            L1.AutoSize = true;
            L1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            L1.Location = new Point(44, 30);
            L1.Name = "L1";
            L1.Size = new Size(105, 40);
            L1.TabIndex = 0;
            L1.Text = "AM IN";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // lblOptions
            // 
            lblOptions.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblOptions.ForeColor = Color.Red;
            lblOptions.Location = new Point(25, 145);
            lblOptions.Name = "lblOptions";
            lblOptions.Size = new Size(399, 179);
            lblOptions.TabIndex = 14;
            lblOptions.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblIDNO
            // 
            lblIDNO.AutoSize = true;
            lblIDNO.Location = new Point(486, 135);
            lblIDNO.Name = "lblIDNO";
            lblIDNO.Size = new Size(38, 15);
            lblIDNO.TabIndex = 15;
            lblIDNO.Text = "label3";
            lblIDNO.Visible = false;
            // 
            // frmTapRFID
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(lblIDNO);
            Controls.Add(lblOptions);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmTapRFID";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label16;
        private Label label15;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private Label lbltime;
        private Label lblDate;
        private Label lblDay;
        private Label label19;
        private Label label20;
        public Label lblAM_IN;
        public Label L6;
        public Label L5;
        public Label L4;
        public Label L3;
        public Label L2;
        public Label L1;
        public Label lblAM_OUT;
        public Label lblOT_OUT;
        public Label lblOT_IN;
        public Label lblPM_OUT;
        public Label lblPM_IN;
        public Label lblMessage;
        public Label lblLastname;
        public Label lblMiddlename;
        public Label lblFirstname;
        public Label lblIdnumber;
        public Label lblDesignation;
        public Label lblAssign;
        public Label lblOptions;
        public TextBox txtRFID;
        private Label lblIDNO;
        private Label lblNotAllowed;
        private Label lblNotFound;
        private Label lbllate;
    }
}