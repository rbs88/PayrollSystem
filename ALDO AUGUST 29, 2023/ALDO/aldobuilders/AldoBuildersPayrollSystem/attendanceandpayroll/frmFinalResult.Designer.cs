namespace AldoBuildersPayrollSystem.attendanceandpayroll
{
    partial class frmFinalResult
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            cboDateCovered = new ComboBox();
            label1 = new Label();
            btnClickhere = new Button();
            groupBox1 = new GroupBox();
            label6 = new Label();
            btnOptionToPrint = new Button();
            cboOption = new ComboBox();
            label3 = new Label();
            cbodatecoveredPrint = new ComboBox();
            panel1 = new Panel();
            label2 = new Label();
            lblLoginName = new Label();
            dataGridView2 = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.DarkGreen;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkGreen;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(12, 128);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 30;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1449, 435);
            dataGridView1.TabIndex = 16;
            dataGridView1.DataBindingComplete += dataGridView1_DataBindingComplete;
            // 
            // cboDateCovered
            // 
            cboDateCovered.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDateCovered.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cboDateCovered.FormattingEnabled = true;
            cboDateCovered.Location = new Point(119, 75);
            cboDateCovered.Name = "cboDateCovered";
            cboDateCovered.Size = new Size(282, 33);
            cboDateCovered.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(13, 80);
            label1.Name = "label1";
            label1.Size = new Size(104, 21);
            label1.TabIndex = 18;
            label1.Text = "Date Covered";
            // 
            // btnClickhere
            // 
            btnClickhere.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            btnClickhere.FlatStyle = FlatStyle.Flat;
            btnClickhere.Location = new Point(407, 76);
            btnClickhere.Name = "btnClickhere";
            btnClickhere.Size = new Size(146, 31);
            btnClickhere.TabIndex = 20;
            btnClickhere.Text = "Click Here to search";
            btnClickhere.UseVisualStyleBackColor = true;
            btnClickhere.Click += btnClickhere_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnOptionToPrint);
            groupBox1.Controls.Add(cboOption);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cbodatecoveredPrint);
            groupBox1.Location = new Point(13, 632);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1448, 94);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "PRINT OPTION";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(447, 26);
            label6.Name = "label6";
            label6.Size = new Size(114, 17);
            label6.TabIndex = 33;
            label6.Text = "OPTION TO PRINT";
            // 
            // btnOptionToPrint
            // 
            btnOptionToPrint.BackColor = Color.DeepSkyBlue;
            btnOptionToPrint.FlatAppearance.BorderSize = 0;
            btnOptionToPrint.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            btnOptionToPrint.FlatStyle = FlatStyle.Flat;
            btnOptionToPrint.Location = new Point(676, 45);
            btnOptionToPrint.Name = "btnOptionToPrint";
            btnOptionToPrint.Size = new Size(160, 33);
            btnOptionToPrint.TabIndex = 28;
            btnOptionToPrint.Text = "Click Here to printpreview";
            btnOptionToPrint.UseVisualStyleBackColor = false;
            btnOptionToPrint.Click += btnOptionToPrint_Click;
            // 
            // cboOption
            // 
            cboOption.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cboOption.DropDownStyle = ComboBoxStyle.DropDownList;
            cboOption.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cboOption.FormattingEnabled = true;
            cboOption.Items.AddRange(new object[] { "Summary", "Owner's Copy(RFID and Manual Time)", "Palagdaan(Workers)", "Palagdaan(Staffs)", "Palagdaan(Service Manual Time)", "Paglagdaan sa Pagtanggap", "Payslip(RFID Generated)", "Payslip(Service Manual Time)" });
            cboOption.Location = new Point(330, 45);
            cboOption.Name = "cboOption";
            cboOption.Size = new Size(341, 33);
            cboOption.TabIndex = 32;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(116, 24);
            label3.Name = "label3";
            label3.Size = new Size(99, 17);
            label3.TabIndex = 24;
            label3.Text = "DATE COVERED";
            // 
            // cbodatecoveredPrint
            // 
            cbodatecoveredPrint.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cbodatecoveredPrint.DropDownStyle = ComboBoxStyle.DropDownList;
            cbodatecoveredPrint.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbodatecoveredPrint.FormattingEnabled = true;
            cbodatecoveredPrint.Location = new Point(18, 45);
            cbodatecoveredPrint.Name = "cbodatecoveredPrint";
            cbodatecoveredPrint.Size = new Size(296, 33);
            cbodatecoveredPrint.TabIndex = 24;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1473, 20);
            panel1.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Tomato;
            label2.Location = new Point(13, 28);
            label2.Name = "label2";
            label2.Size = new Size(147, 30);
            label2.TabIndex = 23;
            label2.Text = "FINAL RESULT";
            // 
            // lblLoginName
            // 
            lblLoginName.AutoSize = true;
            lblLoginName.Location = new Point(730, 28);
            lblLoginName.Name = "lblLoginName";
            lblLoginName.Size = new Size(38, 15);
            lblLoginName.TabIndex = 24;
            lblLoginName.Text = "label4";
            lblLoginName.Visible = false;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.DarkGreen;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkGreen;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView2.ColumnHeadersHeight = 35;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.Location = new Point(12, 590);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 30;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(1449, 38);
            dataGridView2.TabIndex = 25;
            dataGridView2.DataBindingComplete += dataGridView2_DataBindingComplete;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(13, 110);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 26;
            label4.Text = "RFID Generated Time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(12, 574);
            label5.Name = "label5";
            label5.Size = new Size(121, 15);
            label5.TabIndex = 27;
            label5.Text = "Service(Manual Time)";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(1090, 74);
            label7.Name = "label7";
            label7.Size = new Size(96, 15);
            label7.TabIndex = 29;
            label7.Text = "Search Lastname";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(1090, 90);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(369, 33);
            txtSearch.TabIndex = 28;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // frmFinalResult
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1473, 738);
            Controls.Add(label7);
            Controls.Add(txtSearch);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dataGridView2);
            Controls.Add(lblLoginName);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(btnClickhere);
            Controls.Add(label1);
            Controls.Add(cboDateCovered);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmFinalResult";
            Text = "frmFinalResult";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button btnClickhere;
        private GroupBox groupBox1;
        private Panel panel1;
        private Label label2;
        public ComboBox cboDateCovered;
        private Label label3;
        public ComboBox cbodatecoveredPrint;
        public Label lblLoginName;
        private DataGridView dataGridView2;
        public Label label4;
        public Label label5;
        public ComboBox cboOption;
        private Button btnOptionToPrint;
        private Label label6;
        private Label label7;
        private TextBox txtSearch;
    }
}