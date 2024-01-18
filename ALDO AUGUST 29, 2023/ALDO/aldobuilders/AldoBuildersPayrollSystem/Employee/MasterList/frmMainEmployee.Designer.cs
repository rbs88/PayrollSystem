namespace AldoBuildersPayrollSystem.Employee.MasterList
{
	partial class frmMainEmployee
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
			panel1 = new Panel();
			role = new Label();
			lblLoginName = new Label();
			btnInactiveMasterlist = new Button();
			btnCaseAndPromotion = new Button();
			btnMasterList = new Button();
			panelEmployeeMain = new Panel();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.White;
			panel1.Controls.Add(role);
			panel1.Controls.Add(lblLoginName);
			panel1.Controls.Add(btnInactiveMasterlist);
			panel1.Controls.Add(btnCaseAndPromotion);
			panel1.Controls.Add(btnMasterList);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(1107, 51);
			panel1.TabIndex = 0;
			// 
			// role
			// 
			role.AutoSize = true;
			role.Location = new Point(685, 15);
			role.Name = "role";
			role.Size = new Size(38, 15);
			role.TabIndex = 6;
			role.Text = "label1";
			role.Visible = false;
			// 
			// lblLoginName
			// 
			lblLoginName.AutoSize = true;
			lblLoginName.Location = new Point(880, 15);
			lblLoginName.Name = "lblLoginName";
			lblLoginName.Size = new Size(38, 15);
			lblLoginName.TabIndex = 5;
			lblLoginName.Text = "label1";
			lblLoginName.Visible = false;
			// 
			// btnInactiveMasterlist
			// 
			btnInactiveMasterlist.BackColor = Color.Navy;
			btnInactiveMasterlist.Dock = DockStyle.Left;
			btnInactiveMasterlist.FlatAppearance.BorderSize = 0;
			btnInactiveMasterlist.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
			btnInactiveMasterlist.FlatStyle = FlatStyle.Flat;
			btnInactiveMasterlist.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			btnInactiveMasterlist.ForeColor = Color.White;
			btnInactiveMasterlist.Location = new Point(402, 0);
			btnInactiveMasterlist.Name = "btnInactiveMasterlist";
			btnInactiveMasterlist.Size = new Size(167, 51);
			btnInactiveMasterlist.TabIndex = 4;
			btnInactiveMasterlist.Text = "Employee Inactive Masterlist";
			btnInactiveMasterlist.UseVisualStyleBackColor = false;
			btnInactiveMasterlist.Click += btnInactiveMasterlist_Click;
			// 
			// btnCaseAndPromotion
			// 
			btnCaseAndPromotion.BackColor = Color.Navy;
			btnCaseAndPromotion.Dock = DockStyle.Left;
			btnCaseAndPromotion.FlatAppearance.BorderSize = 0;
			btnCaseAndPromotion.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
			btnCaseAndPromotion.FlatStyle = FlatStyle.Flat;
			btnCaseAndPromotion.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			btnCaseAndPromotion.ForeColor = Color.White;
			btnCaseAndPromotion.Location = new Point(167, 0);
			btnCaseAndPromotion.Name = "btnCaseAndPromotion";
			btnCaseAndPromotion.Size = new Size(235, 51);
			btnCaseAndPromotion.TabIndex = 3;
			btnCaseAndPromotion.Text = "Employee Case and Promotion";
			btnCaseAndPromotion.UseVisualStyleBackColor = false;
			btnCaseAndPromotion.Click += btnCaseAndPromotion_Click;
			// 
			// btnMasterList
			// 
			btnMasterList.BackColor = Color.Navy;
			btnMasterList.Dock = DockStyle.Left;
			btnMasterList.FlatAppearance.BorderSize = 0;
			btnMasterList.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
			btnMasterList.FlatStyle = FlatStyle.Flat;
			btnMasterList.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			btnMasterList.ForeColor = Color.White;
			btnMasterList.Location = new Point(0, 0);
			btnMasterList.Name = "btnMasterList";
			btnMasterList.Size = new Size(167, 51);
			btnMasterList.TabIndex = 2;
			btnMasterList.Text = "Employee Active Masterlist";
			btnMasterList.UseVisualStyleBackColor = false;
			btnMasterList.Click += btnAddNew_Click;
			// 
			// panelEmployeeMain
			// 
			panelEmployeeMain.BackColor = Color.White;
			panelEmployeeMain.Dock = DockStyle.Fill;
			panelEmployeeMain.Location = new Point(0, 51);
			panelEmployeeMain.Name = "panelEmployeeMain";
			panelEmployeeMain.Size = new Size(1107, 631);
			panelEmployeeMain.TabIndex = 1;
			// 
			// frmMainEmployee
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1107, 682);
			Controls.Add(panelEmployeeMain);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "frmMainEmployee";
			WindowState = FormWindowState.Maximized;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Button btnMasterList;
		private Panel panelEmployeeMain;
		private Button btnCaseAndPromotion;
		private Button btnInactiveMasterlist;
		public Label lblLoginName;
		public Label role;
	}
}