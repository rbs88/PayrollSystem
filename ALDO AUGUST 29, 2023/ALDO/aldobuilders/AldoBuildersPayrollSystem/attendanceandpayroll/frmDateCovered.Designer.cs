namespace AldoBuildersPayrollSystem.attendanceandpayroll
{
	partial class frmDateCovered
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
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDateCovered));
			dataGridView1 = new DataGridView();
			btnSave = new Button();
			dtFrom = new DateTimePicker();
			dtTo = new DateTimePicker();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			Column3 = new DataGridViewTextBoxColumn();
			Column1 = new DataGridViewTextBoxColumn();
			colDelete = new DataGridViewImageColumn();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.AllowUserToOrderColumns = true;
			dataGridView1.AllowUserToResizeColumns = false;
			dataGridView1.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = SystemColors.Control;
			dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column3, Column1, colDelete });
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = SystemColors.Window;
			dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
			dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
			dataGridView1.Location = new Point(12, 12);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridView1.RowHeadersVisible = false;
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView1.Size = new Size(318, 323);
			dataGridView1.TabIndex = 0;
			dataGridView1.CellContentClick += dataGridView1_CellContentClick;
			// 
			// btnSave
			// 
			btnSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			btnSave.Location = new Point(362, 162);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(288, 34);
			btnSave.TabIndex = 1;
			btnSave.Text = "SAVE";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += btnSave_Click;
			// 
			// dtFrom
			// 
			dtFrom.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			dtFrom.CustomFormat = "MM/dd/yyyy";
			dtFrom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			dtFrom.Format = DateTimePickerFormat.Custom;
			dtFrom.Location = new Point(336, 103);
			dtFrom.Name = "dtFrom";
			dtFrom.Size = new Size(157, 29);
			dtFrom.TabIndex = 2;
			dtFrom.ValueChanged += dtFrom_ValueChanged;
			// 
			// dtTo
			// 
			dtTo.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			dtTo.CustomFormat = "MM/dd/yyyy";
			dtTo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			dtTo.Format = DateTimePickerFormat.Custom;
			dtTo.Location = new Point(512, 103);
			dtTo.Name = "dtTo";
			dtTo.Size = new Size(157, 29);
			dtTo.TabIndex = 3;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.ForeColor = Color.Red;
			label1.Location = new Point(395, 85);
			label1.Name = "label1";
			label1.Size = new Size(40, 15);
			label1.TabIndex = 4;
			label1.Text = "FROM";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.ForeColor = Color.Red;
			label2.Location = new Point(567, 85);
			label2.Name = "label2";
			label2.Size = new Size(21, 15);
			label2.TabIndex = 5;
			label2.Text = "TO";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.ForeColor = Color.Red;
			label3.Location = new Point(497, 111);
			label3.Name = "label3";
			label3.Size = new Size(12, 15);
			label3.TabIndex = 6;
			label3.Text = "-";
			// 
			// Column3
			// 
			Column3.HeaderText = "idDateCovered";
			Column3.Name = "Column3";
			Column3.ReadOnly = true;
			Column3.Visible = false;
			// 
			// Column1
			// 
			Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
			Column1.DefaultCellStyle = dataGridViewCellStyle2;
			Column1.HeaderText = "DATE_COVERED";
			Column1.Name = "Column1";
			Column1.ReadOnly = true;
			// 
			// colDelete
			// 
			colDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			colDelete.HeaderText = "";
			colDelete.Image = (Image)resources.GetObject("colDelete.Image");
			colDelete.Name = "colDelete";
			colDelete.ReadOnly = true;
			colDelete.Resizable = DataGridViewTriState.True;
			colDelete.SortMode = DataGridViewColumnSortMode.Automatic;
			colDelete.Width = 19;
			// 
			// frmDateCovered
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(679, 347);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(dtTo);
			Controls.Add(dtFrom);
			Controls.Add(btnSave);
			Controls.Add(dataGridView1);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "frmDateCovered";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "DATE COVERED";
			Load += frmDateCovered_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridView1;
		private Button btnSave;
		private DateTimePicker dtFrom;
		private DateTimePicker dtTo;
		private Label label1;
		private Label label2;
		private Label label3;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewImageColumn colDelete;
	}
}