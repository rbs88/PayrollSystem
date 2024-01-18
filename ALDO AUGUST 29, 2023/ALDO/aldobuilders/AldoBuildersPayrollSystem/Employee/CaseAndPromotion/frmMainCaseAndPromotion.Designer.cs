namespace AldoBuildersPayrollSystem.Employee.CaseAndPromotion
{
	partial class frmMainCaseAndPromotion
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
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
			panel1 = new Panel();
			panel5 = new Panel();
			label3 = new Label();
			panel2 = new Panel();
			dataGridView1 = new DataGridView();
			panel3 = new Panel();
			label2 = new Label();
			txtSearch = new TextBox();
			panel4 = new Panel();
			lblLoginName = new Label();
			id = new Label();
			panel6 = new Panel();
			dataGridView2 = new DataGridView();
			label5 = new Label();
			label1 = new Label();
			btnAddNewPromotion = new Button();
			txtReasonPromotion = new TextBox();
			panel7 = new Panel();
			label6 = new Label();
			label4 = new Label();
			btnAddNewCase = new Button();
			txtCaseReason = new TextBox();
			dataGridView3 = new DataGridView();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			panel3.SuspendLayout();
			panel4.SuspendLayout();
			panel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
			panel7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(panel5);
			panel1.Controls.Add(label3);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(1342, 63);
			panel1.TabIndex = 0;
			// 
			// panel5
			// 
			panel5.BackColor = Color.Teal;
			panel5.Dock = DockStyle.Top;
			panel5.Location = new Point(0, 0);
			panel5.Name = "panel5";
			panel5.Size = new Size(1342, 10);
			panel5.TabIndex = 9;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
			label3.ForeColor = Color.Lime;
			label3.Location = new Point(13, 16);
			label3.Name = "label3";
			label3.Size = new Size(272, 32);
			label3.TabIndex = 8;
			label3.Text = "CASE AND PROMOTION";
			// 
			// panel2
			// 
			panel2.Controls.Add(dataGridView1);
			panel2.Controls.Add(panel3);
			panel2.Dock = DockStyle.Left;
			panel2.Location = new Point(0, 63);
			panel2.Name = "panel2";
			panel2.Size = new Size(410, 662);
			panel2.TabIndex = 1;
			// 
			// dataGridView1
			// 
			dataGridView1.AllowDrop = true;
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.AllowUserToResizeColumns = false;
			dataGridView1.AllowUserToResizeRows = false;
			dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dataGridView1.BackgroundColor = Color.White;
			dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = Color.Teal;
			dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = Color.Teal;
			dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dataGridView1.ColumnHeadersHeight = 30;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = SystemColors.Window;
			dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
			dataGridView1.EnableHeadersVisualStyles = false;
			dataGridView1.Location = new Point(7, 60);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersVisible = false;
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView1.Size = new Size(397, 591);
			dataGridView1.TabIndex = 1;
			dataGridView1.CellClick += dataGridView1_CellClick;
			dataGridView1.CellEnter += dataGridView1_CellEnter;
			dataGridView1.DataBindingComplete += dataGridView1_DataBindingComplete;
			// 
			// panel3
			// 
			panel3.BackColor = Color.White;
			panel3.BorderStyle = BorderStyle.FixedSingle;
			panel3.Controls.Add(label2);
			panel3.Controls.Add(txtSearch);
			panel3.Dock = DockStyle.Top;
			panel3.Location = new Point(0, 0);
			panel3.Name = "panel3";
			panel3.Size = new Size(410, 53);
			panel3.TabIndex = 0;
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.ForeColor = Color.Red;
			label2.Location = new Point(15, 2);
			label2.Name = "label2";
			label2.Size = new Size(96, 15);
			label2.TabIndex = 7;
			label2.Text = "Search Lastname";
			// 
			// txtSearch
			// 
			txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			txtSearch.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			txtSearch.Location = new Point(6, 11);
			txtSearch.Multiline = true;
			txtSearch.Name = "txtSearch";
			txtSearch.Size = new Size(396, 35);
			txtSearch.TabIndex = 6;
			txtSearch.TextChanged += txtSearch_TextChanged;
			// 
			// panel4
			// 
			panel4.Controls.Add(lblLoginName);
			panel4.Controls.Add(id);
			panel4.Dock = DockStyle.Top;
			panel4.Location = new Point(410, 63);
			panel4.Name = "panel4";
			panel4.Size = new Size(932, 53);
			panel4.TabIndex = 2;
			// 
			// lblLoginName
			// 
			lblLoginName.AutoSize = true;
			lblLoginName.Location = new Point(267, 12);
			lblLoginName.Name = "lblLoginName";
			lblLoginName.Size = new Size(38, 15);
			lblLoginName.TabIndex = 1;
			lblLoginName.Text = "label7";
			lblLoginName.Visible = false;
			// 
			// id
			// 
			id.AutoSize = true;
			id.Location = new Point(61, 13);
			id.Name = "id";
			id.Size = new Size(16, 15);
			id.TabIndex = 0;
			id.Text = "...";
			id.Visible = false;
			// 
			// panel6
			// 
			panel6.BackColor = Color.White;
			panel6.BorderStyle = BorderStyle.FixedSingle;
			panel6.Controls.Add(dataGridView2);
			panel6.Controls.Add(label5);
			panel6.Controls.Add(label1);
			panel6.Controls.Add(btnAddNewPromotion);
			panel6.Controls.Add(txtReasonPromotion);
			panel6.Dock = DockStyle.Left;
			panel6.Location = new Point(410, 116);
			panel6.Name = "panel6";
			panel6.Size = new Size(460, 609);
			panel6.TabIndex = 3;
			// 
			// dataGridView2
			// 
			dataGridView2.AllowUserToAddRows = false;
			dataGridView2.AllowUserToDeleteRows = false;
			dataGridView2.AllowUserToResizeColumns = false;
			dataGridView2.AllowUserToResizeRows = false;
			dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			dataGridView2.BackgroundColor = Color.White;
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = Color.Teal;
			dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = Color.Teal;
			dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
			dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			dataGridView2.ColumnHeadersHeight = 35;
			dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = SystemColors.Window;
			dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
			dataGridView2.DefaultCellStyle = dataGridViewCellStyle4;
			dataGridView2.EnableHeadersVisualStyles = false;
			dataGridView2.Location = new Point(11, 44);
			dataGridView2.Name = "dataGridView2";
			dataGridView2.ReadOnly = true;
			dataGridView2.RowHeadersVisible = false;
			dataGridView2.RowTemplate.Height = 25;
			dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView2.Size = new Size(436, 334);
			dataGridView2.TabIndex = 15;
			dataGridView2.CellEnter += dataGridView2_CellEnter_1;
			dataGridView2.DataBindingComplete += dataGridView2_DataBindingComplete_1;
			// 
			// label5
			// 
			label5.Anchor = AnchorStyles.Bottom;
			label5.AutoSize = true;
			label5.BackColor = Color.Transparent;
			label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			label5.ForeColor = Color.DarkGreen;
			label5.Location = new Point(23, 385);
			label5.Name = "label5";
			label5.Size = new Size(149, 20);
			label5.TabIndex = 11;
			label5.Text = "Reason of Promotion";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = Color.Lime;
			label1.Location = new Point(225, 6);
			label1.Name = "label1";
			label1.Size = new Size(153, 32);
			label1.TabIndex = 10;
			label1.Text = "PROMOTION";
			// 
			// btnAddNewPromotion
			// 
			btnAddNewPromotion.BackColor = Color.RoyalBlue;
			btnAddNewPromotion.FlatAppearance.BorderSize = 0;
			btnAddNewPromotion.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
			btnAddNewPromotion.FlatStyle = FlatStyle.Flat;
			btnAddNewPromotion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			btnAddNewPromotion.ForeColor = Color.White;
			btnAddNewPromotion.Location = new Point(11, 6);
			btnAddNewPromotion.Name = "btnAddNewPromotion";
			btnAddNewPromotion.Size = new Size(159, 34);
			btnAddNewPromotion.TabIndex = 2;
			btnAddNewPromotion.Text = "ADD NEW PROMOTION";
			btnAddNewPromotion.UseVisualStyleBackColor = false;
			btnAddNewPromotion.Click += btnAddNewPromotion_Click;
			// 
			// txtReasonPromotion
			// 
			txtReasonPromotion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			txtReasonPromotion.BackColor = Color.White;
			txtReasonPromotion.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			txtReasonPromotion.ForeColor = Color.Red;
			txtReasonPromotion.Location = new Point(11, 409);
			txtReasonPromotion.Multiline = true;
			txtReasonPromotion.Name = "txtReasonPromotion";
			txtReasonPromotion.Size = new Size(435, 188);
			txtReasonPromotion.TabIndex = 1;
			// 
			// panel7
			// 
			panel7.BackColor = Color.White;
			panel7.BorderStyle = BorderStyle.FixedSingle;
			panel7.Controls.Add(label6);
			panel7.Controls.Add(label4);
			panel7.Controls.Add(btnAddNewCase);
			panel7.Controls.Add(txtCaseReason);
			panel7.Controls.Add(dataGridView3);
			panel7.Dock = DockStyle.Left;
			panel7.Location = new Point(870, 116);
			panel7.Name = "panel7";
			panel7.Size = new Size(460, 609);
			panel7.TabIndex = 4;
			// 
			// label6
			// 
			label6.Anchor = AnchorStyles.Bottom;
			label6.AutoSize = true;
			label6.BackColor = Color.Transparent;
			label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			label6.ForeColor = Color.Red;
			label6.Location = new Point(29, 386);
			label6.Name = "label6";
			label6.Size = new Size(57, 20);
			label6.TabIndex = 12;
			label6.Text = "Reason";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
			label4.ForeColor = Color.Lime;
			label4.Location = new Point(248, 6);
			label4.Name = "label4";
			label4.Size = new Size(69, 32);
			label4.TabIndex = 14;
			label4.Text = "CASE";
			// 
			// btnAddNewCase
			// 
			btnAddNewCase.BackColor = Color.RoyalBlue;
			btnAddNewCase.FlatAppearance.BorderSize = 0;
			btnAddNewCase.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
			btnAddNewCase.FlatStyle = FlatStyle.Flat;
			btnAddNewCase.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			btnAddNewCase.ForeColor = Color.White;
			btnAddNewCase.Location = new Point(12, 5);
			btnAddNewCase.Name = "btnAddNewCase";
			btnAddNewCase.Size = new Size(113, 34);
			btnAddNewCase.TabIndex = 13;
			btnAddNewCase.Text = "ADD NEW CASE";
			btnAddNewCase.UseVisualStyleBackColor = false;
			btnAddNewCase.Click += btnAddNewCase_Click;
			// 
			// txtCaseReason
			// 
			txtCaseReason.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			txtCaseReason.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			txtCaseReason.ForeColor = Color.Red;
			txtCaseReason.Location = new Point(11, 409);
			txtCaseReason.Multiline = true;
			txtCaseReason.Name = "txtCaseReason";
			txtCaseReason.Size = new Size(435, 187);
			txtCaseReason.TabIndex = 12;
			// 
			// dataGridView3
			// 
			dataGridView3.AllowUserToAddRows = false;
			dataGridView3.AllowUserToDeleteRows = false;
			dataGridView3.AllowUserToResizeColumns = false;
			dataGridView3.AllowUserToResizeRows = false;
			dataGridView3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			dataGridView3.BackgroundColor = Color.White;
			dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = Color.Teal;
			dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = Color.Teal;
			dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
			dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			dataGridView3.ColumnHeadersHeight = 35;
			dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = SystemColors.Window;
			dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
			dataGridView3.DefaultCellStyle = dataGridViewCellStyle6;
			dataGridView3.EnableHeadersVisualStyles = false;
			dataGridView3.Location = new Point(11, 44);
			dataGridView3.Name = "dataGridView3";
			dataGridView3.ReadOnly = true;
			dataGridView3.RowHeadersVisible = false;
			dataGridView3.RowTemplate.Height = 25;
			dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView3.Size = new Size(436, 334);
			dataGridView3.TabIndex = 11;
			dataGridView3.CellEnter += dataGridView3_CellEnter;
			dataGridView3.CellStateChanged += dataGridView3_CellStateChanged;
			dataGridView3.DataBindingComplete += dataGridView3_DataBindingComplete;
			// 
			// frmMainCaseAndPromotion
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1342, 725);
			Controls.Add(panel7);
			Controls.Add(panel6);
			Controls.Add(panel4);
			Controls.Add(panel2);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "frmMainCaseAndPromotion";
			Text = "frmMainCaseAndPromotion";
			WindowState = FormWindowState.Maximized;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			panel4.ResumeLayout(false);
			panel4.PerformLayout();
			panel6.ResumeLayout(false);
			panel6.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
			panel7.ResumeLayout(false);
			panel7.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Label label3;
		private Panel panel2;
		private Panel panel3;
		private Label label2;
		private TextBox txtSearch;
		private Panel panel4;
		private Panel panel5;
		private Panel panel6;
		private Panel panel7;
		private TextBox txtReasonPromotion;
		private Button btnAddNewPromotion;
		private Label label1;
		private Label label4;
		private Button btnAddNewCase;
		private TextBox txtCaseReason;
		private DataGridView dataGridView3;
		private Label label5;
		private Label label6;
		private DataGridView dataGridView1;
		private Label id;
		public Label lblLoginName;
		private DataGridView dataGridView2;
	}
}