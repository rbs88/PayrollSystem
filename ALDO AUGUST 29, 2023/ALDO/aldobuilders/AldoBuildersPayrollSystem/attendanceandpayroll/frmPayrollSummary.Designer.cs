namespace AldoBuildersPayrollSystem.attendanceandpayroll
{
    partial class frmPayrollSummary
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
            panel2 = new Panel();
            panel1 = new Panel();
            label4 = new Label();
            panel3 = new Panel();
            label5 = new Label();
            btnAddService = new Button();
            dataGridView2 = new DataGridView();
            lblLoginName = new Label();
            btnFinalResult = new Button();
            button1 = new Button();
            btnClickHere = new Button();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dtTo = new DateTimePicker();
            dtFrom = new DateTimePicker();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(1442, 10);
            panel2.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1442, 68);
            panel1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(18, 23);
            label4.Name = "label4";
            label4.Size = new Size(181, 37);
            label4.TabIndex = 0;
            label4.Text = "Create Payroll";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(btnAddService);
            panel3.Controls.Add(dataGridView2);
            panel3.Controls.Add(lblLoginName);
            panel3.Controls.Add(btnFinalResult);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(btnClickHere);
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(dtTo);
            panel3.Controls.Add(dtFrom);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 78);
            panel3.Name = "panel3";
            panel3.Size = new Size(1442, 817);
            panel3.TabIndex = 4;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(16, 793);
            label5.Name = "label5";
            label5.Size = new Size(177, 19);
            label5.TabIndex = 23;
            label5.Text = "Note: Double click to delete";
            // 
            // btnAddService
            // 
            btnAddService.BackColor = Color.DeepSkyBlue;
            btnAddService.FlatAppearance.BorderSize = 0;
            btnAddService.FlatAppearance.MouseDownBackColor = Color.Black;
            btnAddService.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnAddService.FlatStyle = FlatStyle.Flat;
            btnAddService.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddService.ForeColor = Color.Black;
            btnAddService.Location = new Point(16, 534);
            btnAddService.Name = "btnAddService";
            btnAddService.Size = new Size(153, 31);
            btnAddService.TabIndex = 22;
            btnAddService.Text = "ADD SERVICE TIME";
            btnAddService.UseVisualStyleBackColor = false;
            btnAddService.Click += btnAddService_Click;
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.DarkGreen;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkGreen;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.Location = new Point(15, 567);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 30;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(1415, 225);
            dataGridView2.TabIndex = 21;
            dataGridView2.CellDoubleClick += dataGridView2_CellDoubleClick;
            dataGridView2.DataBindingComplete += dataGridView2_DataBindingComplete;
            // 
            // lblLoginName
            // 
            lblLoginName.AutoSize = true;
            lblLoginName.Location = new Point(596, 47);
            lblLoginName.Name = "lblLoginName";
            lblLoginName.Size = new Size(38, 15);
            lblLoginName.TabIndex = 20;
            lblLoginName.Text = "label5";
            lblLoginName.Visible = false;
            // 
            // btnFinalResult
            // 
            btnFinalResult.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFinalResult.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            btnFinalResult.FlatStyle = FlatStyle.Flat;
            btnFinalResult.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnFinalResult.ForeColor = Color.Red;
            btnFinalResult.Location = new Point(855, 6);
            btnFinalResult.Name = "btnFinalResult";
            btnFinalResult.Size = new Size(575, 38);
            btnFinalResult.TabIndex = 19;
            btnFinalResult.Text = "Click only here if the  payroll w/ selected date_covered are final";
            btnFinalResult.UseVisualStyleBackColor = true;
            btnFinalResult.Click += btnFinalResult_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(12, 11);
            button1.Name = "button1";
            button1.Size = new Size(351, 33);
            button1.TabIndex = 18;
            button1.Text = "Select Payroll Date Covered";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnClickHere
            // 
            btnClickHere.FlatAppearance.BorderSize = 0;
            btnClickHere.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            btnClickHere.FlatStyle = FlatStyle.Flat;
            btnClickHere.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClickHere.Location = new Point(354, 63);
            btnClickHere.Name = "btnClickHere";
            btnClickHere.Size = new Size(168, 33);
            btnClickHere.TabIndex = 16;
            btnClickHere.Text = "Click here to Create";
            btnClickHere.UseVisualStyleBackColor = true;
            btnClickHere.Visible = false;
            btnClickHere.Click += btnClickHere_Click;
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.DarkGreen;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkGreen;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeight = 35;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(15, 102);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 30;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1415, 424);
            dataGridView1.TabIndex = 15;
            dataGridView1.DataBindingComplete += dataGridView1_DataBindingComplete;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(174, 68);
            label3.Name = "label3";
            label3.Size = new Size(15, 20);
            label3.TabIndex = 14;
            label3.Text = "-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(234, 47);
            label2.Name = "label2";
            label2.Size = new Size(59, 17);
            label2.TabIndex = 13;
            label2.Text = "DATE-TO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(52, 47);
            label1.Name = "label1";
            label1.Size = new Size(79, 17);
            label1.TabIndex = 12;
            label1.Text = "DATE-FROM";
            // 
            // dtTo
            // 
            dtTo.CustomFormat = "MM/dd/yyyy";
            dtTo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtTo.Format = DateTimePickerFormat.Custom;
            dtTo.Location = new Point(193, 63);
            dtTo.Name = "dtTo";
            dtTo.Size = new Size(155, 33);
            dtTo.TabIndex = 11;
            dtTo.ValueChanged += dtTo_ValueChanged;
            // 
            // dtFrom
            // 
            dtFrom.CustomFormat = "MM/dd/yyyy";
            dtFrom.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtFrom.Format = DateTimePickerFormat.Custom;
            dtFrom.Location = new Point(15, 63);
            dtFrom.Name = "dtFrom";
            dtFrom.Size = new Size(155, 33);
            dtFrom.TabIndex = 10;
            dtFrom.ValueChanged += dtFrom_ValueChanged;
            // 
            // frmPayrollSummary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1442, 895);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPayrollSummary";
            Text = "frmPayrollSummary";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtTo;
        private DateTimePicker dtFrom;
        private DataGridView dataGridView1;
        private Button btnClickHere;
        private Label label4;
        private Button button1;
        private Button btnFinalResult;
        public Label lblLoginName;
        private Button btnAddService;
        private DataGridView dataGridView2;
        public Label label5;
    }
}