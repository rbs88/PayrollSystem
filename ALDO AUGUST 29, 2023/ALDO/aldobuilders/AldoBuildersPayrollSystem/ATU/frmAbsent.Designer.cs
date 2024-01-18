namespace AldoBuildersPayrollSystem.ATU
{
	partial class frmAbsent
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
			label1 = new Label();
			txtSearch = new TextBox();
			dataGridView1 = new DataGridView();
			dataGridView2 = new DataGridView();
			btnAdd = new Button();
			txtReason = new TextBox();
			txtRemarks = new TextBox();
			dtDateAbsence = new DateTimePicker();
			lblName = new Label();
			idemployee = new Label();
			lblLoginName = new Label();
			idnumber = new Label();
			label3 = new Label();
			label4 = new Label();
			label2 = new Label();
			cboPermission = new ComboBox();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(8, 16);
			label1.Name = "label1";
			label1.Size = new Size(103, 21);
			label1.TabIndex = 16;
			label1.Text = "Search Name";
			// 
			// txtSearch
			// 
			txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			txtSearch.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			txtSearch.Location = new Point(10, 38);
			txtSearch.Name = "txtSearch";
			txtSearch.Size = new Size(330, 33);
			txtSearch.TabIndex = 15;
			txtSearch.TextChanged += txtSearch_TextChanged;
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.AllowUserToResizeColumns = false;
			dataGridView1.AllowUserToResizeRows = false;
			dataGridView1.BackgroundColor = Color.White;
			dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridView1.ColumnHeadersHeight = 30;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = SystemColors.Window;
			dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
			dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
			dataGridView1.EnableHeadersVisualStyles = false;
			dataGridView1.Location = new Point(9, 75);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridView1.RowHeadersVisible = false;
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
			dataGridView1.Size = new Size(330, 631);
			dataGridView1.TabIndex = 14;
			dataGridView1.CellEnter += dataGridView1_CellEnter;
			dataGridView1.DataBindingComplete += dataGridView1_DataBindingComplete;
			// 
			// dataGridView2
			// 
			dataGridView2.AllowUserToAddRows = false;
			dataGridView2.AllowUserToDeleteRows = false;
			dataGridView2.AllowUserToResizeColumns = false;
			dataGridView2.AllowUserToResizeRows = false;
			dataGridView2.BackgroundColor = Color.White;
			dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.Teal;
			dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = Color.White;
			dataGridViewCellStyle2.SelectionBackColor = Color.Teal;
			dataGridViewCellStyle2.SelectionForeColor = Color.White;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			dataGridView2.ColumnHeadersHeight = 30;
			dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = SystemColors.Window;
			dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
			dataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
			dataGridView2.EnableHeadersVisualStyles = false;
			dataGridView2.Location = new Point(347, 148);
			dataGridView2.Name = "dataGridView2";
			dataGridView2.ReadOnly = true;
			dataGridView2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridView2.RowHeadersVisible = false;
			dataGridView2.RowTemplate.Height = 25;
			dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView2.Size = new Size(1145, 558);
			dataGridView2.TabIndex = 17;
			dataGridView2.DataBindingComplete += dataGridView2_DataBindingComplete;
			dataGridView2.RowStateChanged += dataGridView2_RowStateChanged;
			// 
			// btnAdd
			// 
			btnAdd.BackColor = Color.DeepSkyBlue;
			btnAdd.FlatAppearance.BorderSize = 0;
			btnAdd.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
			btnAdd.FlatStyle = FlatStyle.Flat;
			btnAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			btnAdd.Location = new Point(1317, 75);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(85, 68);
			btnAdd.TabIndex = 29;
			btnAdd.Text = "Add";
			btnAdd.UseVisualStyleBackColor = false;
			btnAdd.Click += btnAdd_Click;
			// 
			// txtReason
			// 
			txtReason.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			txtReason.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			txtReason.Location = new Point(496, 75);
			txtReason.Name = "txtReason";
			txtReason.Size = new Size(438, 33);
			txtReason.TabIndex = 31;
			// 
			// txtRemarks
			// 
			txtRemarks.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			txtRemarks.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			txtRemarks.Location = new Point(948, 75);
			txtRemarks.Name = "txtRemarks";
			txtRemarks.Size = new Size(362, 33);
			txtRemarks.TabIndex = 32;
			// 
			// dtDateAbsence
			// 
			dtDateAbsence.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			dtDateAbsence.CustomFormat = "MM/dd/yyyy";
			dtDateAbsence.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			dtDateAbsence.Format = DateTimePickerFormat.Custom;
			dtDateAbsence.Location = new Point(346, 75);
			dtDateAbsence.Name = "dtDateAbsence";
			dtDateAbsence.Size = new Size(137, 33);
			dtDateAbsence.TabIndex = 33;
			// 
			// lblName
			// 
			lblName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblName.Location = new Point(347, 13);
			lblName.Name = "lblName";
			lblName.Size = new Size(1029, 31);
			lblName.TabIndex = 35;
			lblName.Text = "Name";
			lblName.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// idemployee
			// 
			idemployee.AutoSize = true;
			idemployee.Location = new Point(272, 16);
			idemployee.Name = "idemployee";
			idemployee.Size = new Size(69, 15);
			idemployee.TabIndex = 36;
			idemployee.Text = "idemployee";
			idemployee.Visible = false;
			// 
			// lblLoginName
			// 
			lblLoginName.AutoSize = true;
			lblLoginName.Location = new Point(179, 9);
			lblLoginName.Name = "lblLoginName";
			lblLoginName.Size = new Size(56, 15);
			lblLoginName.TabIndex = 37;
			lblLoginName.Text = "postedby";
			lblLoginName.Visible = false;
			// 
			// idnumber
			// 
			idnumber.AutoSize = true;
			idnumber.Location = new Point(368, 16);
			idnumber.Name = "idnumber";
			idnumber.Size = new Size(59, 15);
			idnumber.TabIndex = 38;
			idnumber.Text = "idnumber";
			idnumber.Visible = false;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(351, 56);
			label3.Name = "label3";
			label3.Size = new Size(41, 20);
			label3.TabIndex = 40;
			label3.Text = "Date";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(503, 56);
			label4.Name = "label4";
			label4.Size = new Size(138, 20);
			label4.TabIndex = 41;
			label4.Text = "Reason for absence";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(954, 56);
			label2.Name = "label2";
			label2.Size = new Size(65, 20);
			label2.TabIndex = 43;
			label2.Text = "Remarks";
			// 
			// cboPermission
			// 
			cboPermission.DropDownStyle = ComboBoxStyle.DropDownList;
			cboPermission.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			cboPermission.FormattingEnabled = true;
			cboPermission.Items.AddRange(new object[] { "Yes", "No" });
			cboPermission.Location = new Point(1227, 110);
			cboPermission.Name = "cboPermission";
			cboPermission.Size = new Size(83, 33);
			cboPermission.TabIndex = 44;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			label5.Location = new Point(1070, 116);
			label5.Name = "label5";
			label5.Size = new Size(153, 20);
			label5.TabIndex = 45;
			label5.Text = "Asked for Permission?";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			label6.Location = new Point(345, 123);
			label6.Name = "label6";
			label6.Size = new Size(146, 20);
			label6.TabIndex = 46;
			label6.Text = "Total No. of Absents:";
			// 
			// label7
			// 
			label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label7.ForeColor = Color.Red;
			label7.Location = new Point(489, 120);
			label7.Name = "label7";
			label7.Size = new Size(152, 25);
			label7.TabIndex = 47;
			label7.Text = "0";
			label7.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// frmAbsent
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(1504, 713);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(cboPermission);
			Controls.Add(label2);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(idnumber);
			Controls.Add(lblLoginName);
			Controls.Add(idemployee);
			Controls.Add(lblName);
			Controls.Add(dtDateAbsence);
			Controls.Add(txtRemarks);
			Controls.Add(txtReason);
			Controls.Add(btnAdd);
			Controls.Add(dataGridView2);
			Controls.Add(label1);
			Controls.Add(txtSearch);
			Controls.Add(dataGridView1);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "frmAbsent";
			StartPosition = FormStartPosition.CenterScreen;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox txtSearch;
		private DataGridView dataGridView1;
		private DataGridView dataGridView2;
		private Button btnAdd;
		private TextBox txtReason;
		private TextBox txtRemarks;
		private DateTimePicker dtDateAbsence;
		private Label lblName;
		private Label idemployee;
		private Label idnumber;
		public Label lblLoginName;
		private Label label3;
		private Label label4;
		private Label label2;
		private ComboBox cboPermission;
		private Label label5;
		private Label label6;
		private Label label7;
	}
}