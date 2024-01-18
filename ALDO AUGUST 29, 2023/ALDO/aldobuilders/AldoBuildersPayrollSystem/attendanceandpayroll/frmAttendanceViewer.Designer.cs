namespace AldoBuildersPayrollSystem.attendanceandpayroll
{
	partial class frmAttendanceViewer
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
			DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle32 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle27 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle28 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle29 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle30 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle31 = new DataGridViewCellStyle();
			panel1 = new Panel();
			lblLoginName = new Label();
			panel2 = new Panel();
			panel3 = new Panel();
			btnClickHere = new Button();
			label5 = new Label();
			cboFullName = new ComboBox();
			label4 = new Label();
			cboAssign = new ComboBox();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			dtTo = new DateTimePicker();
			dtFrom = new DateTimePicker();
			dataGridView1 = new DataGridView();
			Column1 = new DataGridViewTextBoxColumn();
			Column19 = new DataGridViewTextBoxColumn();
			Column2 = new DataGridViewTextBoxColumn();
			Column3 = new DataGridViewTextBoxColumn();
			Column4 = new DataGridViewTextBoxColumn();
			Column5 = new DataGridViewTextBoxColumn();
			Column6 = new DataGridViewTextBoxColumn();
			Column14 = new DataGridViewTextBoxColumn();
			Column7 = new DataGridViewTextBoxColumn();
			Column8 = new DataGridViewTextBoxColumn();
			Column9 = new DataGridViewTextBoxColumn();
			Column15 = new DataGridViewTextBoxColumn();
			Column10 = new DataGridViewTextBoxColumn();
			Column11 = new DataGridViewTextBoxColumn();
			Column12 = new DataGridViewTextBoxColumn();
			Column16 = new DataGridViewTextBoxColumn();
			Column13 = new DataGridViewTextBoxColumn();
			Column18 = new DataGridViewTextBoxColumn();
			Column17 = new DataGridViewTextBoxColumn();
			panel1.SuspendLayout();
			panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(lblLoginName);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(1278, 51);
			panel1.TabIndex = 0;
			// 
			// lblLoginName
			// 
			lblLoginName.AutoSize = true;
			lblLoginName.Location = new Point(900, 19);
			lblLoginName.Name = "lblLoginName";
			lblLoginName.Size = new Size(38, 15);
			lblLoginName.TabIndex = 0;
			lblLoginName.Text = "label6";
			lblLoginName.Visible = false;
			// 
			// panel2
			// 
			panel2.BackColor = Color.Teal;
			panel2.Dock = DockStyle.Top;
			panel2.Location = new Point(0, 51);
			panel2.Name = "panel2";
			panel2.Size = new Size(1278, 10);
			panel2.TabIndex = 1;
			// 
			// panel3
			// 
			panel3.BackColor = Color.White;
			panel3.Controls.Add(btnClickHere);
			panel3.Controls.Add(label5);
			panel3.Controls.Add(cboFullName);
			panel3.Controls.Add(label4);
			panel3.Controls.Add(cboAssign);
			panel3.Controls.Add(label3);
			panel3.Controls.Add(label2);
			panel3.Controls.Add(label1);
			panel3.Controls.Add(dtTo);
			panel3.Controls.Add(dtFrom);
			panel3.Controls.Add(dataGridView1);
			panel3.Dock = DockStyle.Fill;
			panel3.Location = new Point(0, 61);
			panel3.Name = "panel3";
			panel3.Size = new Size(1278, 649);
			panel3.TabIndex = 2;
			// 
			// btnClickHere
			// 
			btnClickHere.FlatAppearance.BorderSize = 0;
			btnClickHere.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
			btnClickHere.FlatStyle = FlatStyle.Flat;
			btnClickHere.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnClickHere.Location = new Point(1147, 23);
			btnClickHere.Name = "btnClickHere";
			btnClickHere.Size = new Size(114, 33);
			btnClickHere.TabIndex = 14;
			btnClickHere.Text = "Click here";
			btnClickHere.UseVisualStyleBackColor = true;
			btnClickHere.Click += button1_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			label5.ForeColor = Color.Black;
			label5.Location = new Point(899, 1);
			label5.Name = "label5";
			label5.Size = new Size(82, 20);
			label5.TabIndex = 13;
			label5.Text = "FULLNAME";
			// 
			// cboFullName
			// 
			cboFullName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			cboFullName.FormattingEnabled = true;
			cboFullName.Items.AddRange(new object[] { "ALL" });
			cboFullName.Location = new Point(737, 23);
			cboFullName.Name = "cboFullName";
			cboFullName.Size = new Size(409, 33);
			cboFullName.TabIndex = 12;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			label4.ForeColor = Color.Black;
			label4.Location = new Point(506, 2);
			label4.Name = "label4";
			label4.Size = new Size(60, 20);
			label4.TabIndex = 11;
			label4.Text = "ASSIGN";
			// 
			// cboAssign
			// 
			cboAssign.DropDownStyle = ComboBoxStyle.DropDownList;
			cboAssign.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			cboAssign.FormattingEnabled = true;
			cboAssign.Location = new Point(351, 23);
			cboAssign.Name = "cboAssign";
			cboAssign.Size = new Size(380, 33);
			cboAssign.TabIndex = 10;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			label3.ForeColor = Color.Red;
			label3.Location = new Point(171, 28);
			label3.Name = "label3";
			label3.Size = new Size(15, 20);
			label3.TabIndex = 9;
			label3.Text = "-";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			label2.ForeColor = Color.Red;
			label2.Location = new Point(231, 4);
			label2.Name = "label2";
			label2.Size = new Size(69, 20);
			label2.TabIndex = 8;
			label2.Text = "DATE-TO";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = Color.Red;
			label1.Location = new Point(42, 4);
			label1.Name = "label1";
			label1.Size = new Size(91, 20);
			label1.TabIndex = 7;
			label1.Text = "DATE-FROM";
			// 
			// dtTo
			// 
			dtTo.CustomFormat = "MM/dd/yyyy";
			dtTo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			dtTo.Format = DateTimePickerFormat.Custom;
			dtTo.Location = new Point(190, 23);
			dtTo.Name = "dtTo";
			dtTo.Size = new Size(155, 33);
			dtTo.TabIndex = 6;
			// 
			// dtFrom
			// 
			dtFrom.CustomFormat = "MM/dd/yyyy";
			dtFrom.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			dtFrom.Format = DateTimePickerFormat.Custom;
			dtFrom.Location = new Point(12, 23);
			dtFrom.Name = "dtFrom";
			dtFrom.Size = new Size(155, 33);
			dtFrom.TabIndex = 5;
			dtFrom.ValueChanged += dtFrom_ValueChanged;
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
			dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle17.BackColor = Color.DarkGreen;
			dataGridViewCellStyle17.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle17.ForeColor = Color.White;
			dataGridViewCellStyle17.SelectionBackColor = Color.DarkGreen;
			dataGridViewCellStyle17.SelectionForeColor = Color.White;
			dataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
			dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
			dataGridView1.ColumnHeadersHeight = 35;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column19, Column2, Column3, Column4, Column5, Column6, Column14, Column7, Column8, Column9, Column15, Column10, Column11, Column12, Column16, Column13, Column18, Column17 });
			dataGridViewCellStyle32.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle32.BackColor = SystemColors.Window;
			dataGridViewCellStyle32.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle32.ForeColor = Color.Black;
			dataGridViewCellStyle32.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle32.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle32.WrapMode = DataGridViewTriState.False;
			dataGridView1.DefaultCellStyle = dataGridViewCellStyle32;
			dataGridView1.EnableHeadersVisualStyles = false;
			dataGridView1.Location = new Point(12, 62);
			dataGridView1.MultiSelect = false;
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersVisible = false;
			dataGridView1.RowHeadersWidth = 30;
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView1.Size = new Size(1254, 560);
			dataGridView1.TabIndex = 4;
			dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
			// 
			// Column1
			// 
			Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			Column1.HeaderText = "NO.";
			Column1.Name = "Column1";
			Column1.ReadOnly = true;
			Column1.Width = 64;
			// 
			// Column19
			// 
			Column19.HeaderText = "idattendancepayroll";
			Column19.Name = "Column19";
			Column19.ReadOnly = true;
			Column19.Visible = false;
			// 
			// Column2
			// 
			Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleCenter;
			Column2.DefaultCellStyle = dataGridViewCellStyle18;
			Column2.HeaderText = "EMPLOYEEID";
			Column2.Name = "Column2";
			Column2.ReadOnly = true;
			Column2.Width = 132;
			// 
			// Column3
			// 
			Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Column3.HeaderText = "NAME";
			Column3.Name = "Column3";
			Column3.ReadOnly = true;
			// 
			// Column4
			// 
			Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle19.Format = "D";
			dataGridViewCellStyle19.NullValue = null;
			Column4.DefaultCellStyle = dataGridViewCellStyle19;
			Column4.HeaderText = "LOGDATE";
			Column4.Name = "Column4";
			Column4.ReadOnly = true;
			Column4.Width = 106;
			// 
			// Column5
			// 
			Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleCenter;
			Column5.DefaultCellStyle = dataGridViewCellStyle20;
			Column5.HeaderText = "AM_IN";
			Column5.Name = "Column5";
			Column5.ReadOnly = true;
			Column5.Width = 85;
			// 
			// Column6
			// 
			Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleCenter;
			Column6.DefaultCellStyle = dataGridViewCellStyle21;
			Column6.HeaderText = "AM_OUT";
			Column6.Name = "Column6";
			Column6.ReadOnly = true;
			Column6.Width = 101;
			// 
			// Column14
			// 
			Column14.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleCenter;
			Column14.DefaultCellStyle = dataGridViewCellStyle22;
			Column14.HeaderText = "TotalHour_AM";
			Column14.Name = "Column14";
			Column14.ReadOnly = true;
			Column14.Width = 141;
			// 
			// Column7
			// 
			dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleCenter;
			Column7.DefaultCellStyle = dataGridViewCellStyle23;
			Column7.HeaderText = "TotalAM";
			Column7.Name = "Column7";
			Column7.ReadOnly = true;
			Column7.Visible = false;
			// 
			// Column8
			// 
			Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleCenter;
			Column8.DefaultCellStyle = dataGridViewCellStyle24;
			Column8.HeaderText = "PM_IN";
			Column8.Name = "Column8";
			Column8.ReadOnly = true;
			Column8.Width = 84;
			// 
			// Column9
			// 
			Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle25.Alignment = DataGridViewContentAlignment.MiddleCenter;
			Column9.DefaultCellStyle = dataGridViewCellStyle25;
			Column9.HeaderText = "PM_OUT";
			Column9.Name = "Column9";
			Column9.ReadOnly = true;
			// 
			// Column15
			// 
			Column15.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleCenter;
			Column15.DefaultCellStyle = dataGridViewCellStyle26;
			Column15.HeaderText = "TotalHour_PM";
			Column15.Name = "Column15";
			Column15.ReadOnly = true;
			Column15.Width = 140;
			// 
			// Column10
			// 
			Column10.HeaderText = "TotalPM";
			Column10.Name = "Column10";
			Column10.ReadOnly = true;
			Column10.Visible = false;
			// 
			// Column11
			// 
			Column11.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle27.Alignment = DataGridViewContentAlignment.MiddleCenter;
			Column11.DefaultCellStyle = dataGridViewCellStyle27;
			Column11.HeaderText = "OT_IN";
			Column11.Name = "Column11";
			Column11.ReadOnly = true;
			Column11.Width = 80;
			// 
			// Column12
			// 
			Column12.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle28.Alignment = DataGridViewContentAlignment.MiddleCenter;
			Column12.DefaultCellStyle = dataGridViewCellStyle28;
			Column12.HeaderText = "OT_OUT";
			Column12.Name = "Column12";
			Column12.ReadOnly = true;
			Column12.Width = 96;
			// 
			// Column16
			// 
			Column16.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle29.Alignment = DataGridViewContentAlignment.MiddleCenter;
			Column16.DefaultCellStyle = dataGridViewCellStyle29;
			Column16.HeaderText = "TotalHour_OT";
			Column16.Name = "Column16";
			Column16.ReadOnly = true;
			Column16.Width = 136;
			// 
			// Column13
			// 
			Column13.HeaderText = "TotalOT";
			Column13.Name = "Column13";
			Column13.ReadOnly = true;
			Column13.Visible = false;
			// 
			// Column18
			// 
			Column18.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle30.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle30.BackColor = Color.FromArgb(64, 64, 64);
			dataGridViewCellStyle30.ForeColor = Color.White;
			dataGridViewCellStyle30.SelectionBackColor = Color.Black;
			dataGridViewCellStyle30.SelectionForeColor = Color.Red;
			Column18.DefaultCellStyle = dataGridViewCellStyle30;
			Column18.HeaderText = "AddHours";
			Column18.Name = "Column18";
			Column18.ReadOnly = true;
			Column18.Width = 110;
			// 
			// Column17
			// 
			Column17.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle31.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle31.BackColor = Color.White;
			dataGridViewCellStyle31.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle31.ForeColor = Color.Black;
			dataGridViewCellStyle31.SelectionBackColor = Color.Black;
			dataGridViewCellStyle31.SelectionForeColor = Color.White;
			Column17.DefaultCellStyle = dataGridViewCellStyle31;
			Column17.HeaderText = "Total_Hours";
			Column17.Name = "Column17";
			Column17.ReadOnly = true;
			Column17.Width = 122;
			// 
			// frmAttendanceViewer
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1278, 710);
			Controls.Add(panel3);
			Controls.Add(panel2);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "frmAttendanceViewer";
			Text = "frmAttendanceViewer";
			WindowState = FormWindowState.Maximized;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Panel panel2;
		private Panel panel3;
		private DataGridView dataGridView1;
		private DateTimePicker dtTo;
		private DateTimePicker dtFrom;
		private Label label3;
		private Label label2;
		private Label label1;
		private Label label4;
		private ComboBox cboAssign;
		private Button btnClickHere;
		private Label label5;
		private ComboBox cboFullName;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column19;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewTextBoxColumn Column4;
		private DataGridViewTextBoxColumn Column5;
		private DataGridViewTextBoxColumn Column6;
		private DataGridViewTextBoxColumn Column14;
		private DataGridViewTextBoxColumn Column7;
		private DataGridViewTextBoxColumn Column8;
		private DataGridViewTextBoxColumn Column9;
		private DataGridViewTextBoxColumn Column15;
		private DataGridViewTextBoxColumn Column10;
		private DataGridViewTextBoxColumn Column11;
		private DataGridViewTextBoxColumn Column12;
		private DataGridViewTextBoxColumn Column16;
		private DataGridViewTextBoxColumn Column13;
		private DataGridViewTextBoxColumn Column18;
		private DataGridViewTextBoxColumn Column17;
		public Label lblLoginName;
	}
}