namespace AldoBuildersPayrollSystem.Employee.MasterList
{
    partial class frmMainEmployeeLoadRecord
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
            panel1 = new Panel();
            role = new Label();
            lblLoginName = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            txtSearch = new TextBox();
            label1 = new Label();
            txtEmployeeInformationSearch = new TextBox();
            btnAddNew = new Button();
            panel2 = new Panel();
            cboSearchPrint = new ComboBox();
            btnPreview = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(role);
            panel1.Controls.Add(lblLoginName);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtEmployeeInformationSearch);
            panel1.Controls.Add(btnAddNew);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1094, 100);
            panel1.TabIndex = 1;
            // 
            // role
            // 
            role.AutoSize = true;
            role.Location = new Point(579, 27);
            role.Name = "role";
            role.Size = new Size(38, 15);
            role.TabIndex = 11;
            role.Text = "label6";
            role.Visible = false;
            // 
            // lblLoginName
            // 
            lblLoginName.AutoSize = true;
            lblLoginName.Location = new Point(677, 19);
            lblLoginName.Name = "lblLoginName";
            lblLoginName.Size = new Size(38, 15);
            lblLoginName.TabIndex = 10;
            lblLoginName.Text = "label6";
            lblLoginName.Visible = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(268, 42);
            label5.Name = "label5";
            label5.Size = new Size(190, 45);
            label5.TabIndex = 9;
            label5.Text = "Total Count:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Brown;
            label4.Location = new Point(451, 42);
            label4.Name = "label4";
            label4.Size = new Size(261, 45);
            label4.TabIndex = 8;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Lime;
            label3.Location = new Point(8, 16);
            label3.Name = "label3";
            label3.Size = new Size(319, 37);
            label3.TabIndex = 7;
            label3.Text = "EMPLOYEE MASTERLIST";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Navy;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1094, 10);
            panel3.TabIndex = 6;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(727, 45);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 5;
            label2.Text = "Search Lastname";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(718, 59);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(369, 33);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(1622, 12);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 3;
            label1.Text = "Search Lastname";
            // 
            // txtEmployeeInformationSearch
            // 
            txtEmployeeInformationSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtEmployeeInformationSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmployeeInformationSearch.Location = new Point(1607, 18);
            txtEmployeeInformationSearch.Multiline = true;
            txtEmployeeInformationSearch.Name = "txtEmployeeInformationSearch";
            txtEmployeeInformationSearch.Size = new Size(369, 35);
            txtEmployeeInformationSearch.TabIndex = 2;
            // 
            // btnAddNew
            // 
            btnAddNew.BackColor = Color.RoyalBlue;
            btnAddNew.FlatAppearance.BorderSize = 0;
            btnAddNew.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            btnAddNew.FlatStyle = FlatStyle.Flat;
            btnAddNew.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddNew.ForeColor = Color.White;
            btnAddNew.Location = new Point(13, 58);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(167, 36);
            btnAddNew.TabIndex = 1;
            btnAddNew.Text = "ADD NEW EMPLOYEE";
            btnAddNew.UseVisualStyleBackColor = false;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(cboSearchPrint);
            panel2.Controls.Add(btnPreview);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 626);
            panel2.Name = "panel2";
            panel2.Size = new Size(1094, 59);
            panel2.TabIndex = 2;
            // 
            // cboSearchPrint
            // 
            cboSearchPrint.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cboSearchPrint.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSearchPrint.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cboSearchPrint.FormattingEnabled = true;
            cboSearchPrint.Items.AddRange(new object[] { "ALL", "STAFF", "WORKER" });
            cboSearchPrint.Location = new Point(671, 14);
            cboSearchPrint.Name = "cboSearchPrint";
            cboSearchPrint.Size = new Size(282, 33);
            cboSearchPrint.TabIndex = 7;
            // 
            // btnPreview
            // 
            btnPreview.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPreview.BackColor = Color.Green;
            btnPreview.FlatAppearance.BorderSize = 0;
            btnPreview.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            btnPreview.FlatStyle = FlatStyle.Flat;
            btnPreview.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPreview.ForeColor = Color.White;
            btnPreview.Location = new Point(959, 14);
            btnPreview.Name = "btnPreview";
            btnPreview.Size = new Size(126, 33);
            btnPreview.TabIndex = 6;
            btnPreview.Text = "Print Preview";
            btnPreview.UseVisualStyleBackColor = false;
            btnPreview.Click += btnPreview_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Navy;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Navy;
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
            dataGridView1.Location = new Point(3, 100);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 30;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1088, 526);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.DataBindingComplete += dataGridView1_DataBindingComplete;
            dataGridView1.RowStateChanged += dataGridView1_RowStateChanged;
            // 
            // frmMainEmployeeLoadRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 685);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMainEmployeeLoadRecord";
            Text = "frmMainEmployeeLoadRecord";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private TextBox txtSearch;
        private Label label1;
        private TextBox txtEmployeeInformationSearch;
        private Button btnAddNew;
        private Panel panel2;
        private Button btnPreview;
        private DataGridView dataGridView1;
        private Panel panel3;
        private Label label3;
        private Label label4;
        private Label label5;
        public Label lblLoginName;
        public ComboBox cboSearchPrint;
        public Label role;
    }
}