namespace AldoBuildersPayrollSystem.Dashboard
{
	partial class frmDashboard
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
			DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
			panel1 = new Panel();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			dataGridView1 = new DataGridView();
			Column1 = new DataGridViewTextBoxColumn();
			Column2 = new DataGridViewTextBoxColumn();
			Column3 = new DataGridViewTextBoxColumn();
			label7 = new Label();
			label8 = new Label();
			label9 = new Label();
			label10 = new Label();
			label11 = new Label();
			panel2 = new Panel();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.Navy;
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(1412, 10);
			panel1.TabIndex = 0;
			// 
			// label1
			// 
			label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(43, 46);
			label1.Name = "label1";
			label1.Size = new Size(352, 49);
			label1.TabIndex = 1;
			label1.Text = "0";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label2.ForeColor = Color.DimGray;
			label2.Location = new Point(125, 95);
			label2.Name = "label2";
			label2.Size = new Size(192, 30);
			label2.TabIndex = 2;
			label2.Text = "Active Staff/Worker";
			// 
			// label3
			// 
			label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label3.ForeColor = Color.DimGray;
			label3.Location = new Point(78, 203);
			label3.Name = "label3";
			label3.Size = new Size(279, 74);
			label3.TabIndex = 4;
			label3.Text = "Total Count of Active Worker Who are working today";
			label3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			label4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(78, 163);
			label4.Name = "label4";
			label4.Size = new Size(279, 36);
			label4.TabIndex = 3;
			label4.Text = "0";
			label4.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label5.ForeColor = Color.DimGray;
			label5.Location = new Point(78, 339);
			label5.Name = "label5";
			label5.Size = new Size(279, 74);
			label5.TabIndex = 6;
			label5.Text = "Total Count of Active Worker Who worked Yesterday";
			label5.TextAlign = ContentAlignment.MiddleCenter;
			label5.Click += label5_Click;
			// 
			// label6
			// 
			label6.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
			label6.Location = new Point(78, 299);
			label6.Name = "label6";
			label6.Size = new Size(279, 36);
			label6.TabIndex = 5;
			label6.Text = "0";
			label6.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.AllowUserToResizeColumns = false;
			dataGridView1.AllowUserToResizeRows = false;
			dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			dataGridView1.BackgroundColor = Color.White;
			dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.BackColor = Color.Black;
			dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle6.ForeColor = Color.White;
			dataGridViewCellStyle6.SelectionBackColor = Color.Black;
			dataGridViewCellStyle6.SelectionForeColor = Color.White;
			dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
			dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
			dataGridView1.ColumnHeadersHeight = 35;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
			dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle10.BackColor = SystemColors.Window;
			dataGridViewCellStyle10.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle10.ForeColor = Color.Black;
			dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
			dataGridView1.DefaultCellStyle = dataGridViewCellStyle10;
			dataGridView1.EnableHeadersVisualStyles = false;
			dataGridView1.Location = new Point(61, 441);
			dataGridView1.MultiSelect = false;
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersVisible = false;
			dataGridView1.RowHeadersWidth = 30;
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView1.Size = new Size(313, 276);
			dataGridView1.TabIndex = 7;
			// 
			// Column1
			// 
			Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
			Column1.DefaultCellStyle = dataGridViewCellStyle7;
			Column1.HeaderText = "No.";
			Column1.Name = "Column1";
			Column1.ReadOnly = true;
			Column1.Width = 58;
			// 
			// Column2
			// 
			Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
			Column2.DefaultCellStyle = dataGridViewCellStyle8;
			Column2.HeaderText = "LOGDATE";
			Column2.Name = "Column2";
			Column2.ReadOnly = true;
			// 
			// Column3
			// 
			Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
			Column3.DefaultCellStyle = dataGridViewCellStyle9;
			Column3.HeaderText = "COUNT";
			Column3.Name = "Column3";
			Column3.ReadOnly = true;
			Column3.Width = 87;
			// 
			// label7
			// 
			label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label7.ForeColor = Color.Red;
			label7.Location = new Point(429, 203);
			label7.Name = "label7";
			label7.Size = new Size(279, 74);
			label7.TabIndex = 9;
			label7.Text = "Total Count of Active Worker Who are late today";
			label7.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			label8.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
			label8.Location = new Point(429, 163);
			label8.Name = "label8";
			label8.Size = new Size(279, 36);
			label8.TabIndex = 8;
			label8.Text = "0";
			label8.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label9.ForeColor = Color.IndianRed;
			label9.Location = new Point(464, 95);
			label9.Name = "label9";
			label9.Size = new Size(207, 30);
			label9.TabIndex = 11;
			label9.Text = "Inactive Staff/Worker";
			// 
			// label10
			// 
			label10.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
			label10.ForeColor = Color.Red;
			label10.Location = new Point(405, 45);
			label10.Name = "label10";
			label10.Size = new Size(329, 49);
			label10.TabIndex = 10;
			label10.Text = "0";
			label10.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.ForeColor = SystemColors.ControlDarkDark;
			label11.Location = new Point(63, 426);
			label11.Name = "label11";
			label11.Size = new Size(112, 15);
			label11.TabIndex = 12;
			label11.Text = "Count Work History";
			// 
			// panel2
			// 
			panel2.BackColor = Color.Navy;
			panel2.Dock = DockStyle.Left;
			panel2.Location = new Point(0, 10);
			panel2.Name = "panel2";
			panel2.Size = new Size(10, 742);
			panel2.TabIndex = 13;
			// 
			// frmDashboard
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(1412, 752);
			Controls.Add(panel2);
			Controls.Add(label11);
			Controls.Add(label9);
			Controls.Add(label10);
			Controls.Add(label7);
			Controls.Add(label8);
			Controls.Add(dataGridView1);
			Controls.Add(label5);
			Controls.Add(label6);
			Controls.Add(label3);
			Controls.Add(label4);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "frmDashboard";
			Text = "frmDashboard";
			WindowState = FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private DataGridView dataGridView1;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column3;
		private Label label7;
		private Label label8;
		private Label label9;
		private Label label10;
		private Label label11;
		private Panel panel2;
	}
}