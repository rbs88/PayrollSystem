namespace AldoBuildersPayrollSystem.Employee.InActiveMasterlist
{
	partial class frmInactiveMasterList
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
			label3 = new Label();
			label5 = new Label();
			label4 = new Label();
			label2 = new Label();
			txtSearch = new TextBox();
			panel2 = new Panel();
			dataGridView1 = new DataGridView();
			panel3 = new Panel();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(panel3);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(label5);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(txtSearch);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(1174, 97);
			panel1.TabIndex = 0;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
			label3.ForeColor = Color.Crimson;
			label3.Location = new Point(12, 41);
			label3.Name = "label3";
			label3.Size = new Size(327, 40);
			label3.TabIndex = 14;
			label3.Text = "INACTIVE MASTERLIST";
			// 
			// label5
			// 
			label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
			label5.ForeColor = Color.Black;
			label5.Location = new Point(348, 36);
			label5.Name = "label5";
			label5.Size = new Size(190, 45);
			label5.TabIndex = 13;
			label5.Text = "Total Count:";
			// 
			// label4
			// 
			label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			label4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
			label4.ForeColor = Color.Brown;
			label4.Location = new Point(531, 36);
			label4.Name = "label4";
			label4.Size = new Size(261, 45);
			label4.TabIndex = 12;
			label4.Text = "label4";
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.ForeColor = Color.Red;
			label2.Location = new Point(809, 39);
			label2.Name = "label2";
			label2.Size = new Size(96, 15);
			label2.TabIndex = 11;
			label2.Text = "Search Lastname";
			// 
			// txtSearch
			// 
			txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			txtSearch.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			txtSearch.Location = new Point(798, 53);
			txtSearch.Multiline = true;
			txtSearch.Name = "txtSearch";
			txtSearch.Size = new Size(369, 35);
			txtSearch.TabIndex = 10;
			txtSearch.TextChanged += txtSearch_TextChanged;
			// 
			// panel2
			// 
			panel2.BackColor = Color.Salmon;
			panel2.Dock = DockStyle.Bottom;
			panel2.Location = new Point(0, 670);
			panel2.Name = "panel2";
			panel2.Size = new Size(1174, 19);
			panel2.TabIndex = 1;
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
			dataGridView1.Location = new Point(17, 103);
			dataGridView1.MultiSelect = false;
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersVisible = false;
			dataGridView1.RowHeadersWidth = 30;
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView1.Size = new Size(1150, 561);
			dataGridView1.TabIndex = 4;
			dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
			dataGridView1.DataBindingComplete += dataGridView1_DataBindingComplete;
			dataGridView1.RowStateChanged += dataGridView1_RowStateChanged;
			dataGridView1.DoubleClick += dataGridView1_DoubleClick;
			// 
			// panel3
			// 
			panel3.BackColor = Color.Brown;
			panel3.Dock = DockStyle.Top;
			panel3.Location = new Point(0, 0);
			panel3.Name = "panel3";
			panel3.Size = new Size(1174, 10);
			panel3.TabIndex = 15;
			// 
			// frmInactiveMasterList
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(1174, 689);
			Controls.Add(dataGridView1);
			Controls.Add(panel2);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "frmInactiveMasterList";
			Text = "frmInactiveMasterList";
			WindowState = FormWindowState.Maximized;
			Load += frmInactiveMasterList_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Panel panel2;
		private Label label5;
		private Label label4;
		private Label label2;
		private TextBox txtSearch;
		private Label label3;
		private DataGridView dataGridView1;
		private Panel panel3;
	}
}