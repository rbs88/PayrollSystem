namespace AldoBuildersPayrollSystem
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			pictureBox1 = new PictureBox();
			label1 = new Label();
			panel1 = new Panel();
			role = new Label();
			lblLoginName = new Label();
			loginName = new Label();
			panel2 = new Panel();
			btnDashboard = new Button();
			btnSettings = new Button();
			btnPayroll = new Button();
			btnEmployee = new Button();
			btnHome = new Button();
			panel3 = new Panel();
			btnBackup = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.logo12;
			pictureBox1.Location = new Point(0, 0);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(172, 127);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 1;
			pictureBox1.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Stencil", 36F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = Color.Green;
			label1.Location = new Point(182, 32);
			label1.Name = "label1";
			label1.Size = new Size(751, 57);
			label1.TabIndex = 0;
			label1.Text = "ALDO BUILDERS INCORPORATED";
			// 
			// panel1
			// 
			panel1.BackColor = Color.White;
			panel1.Controls.Add(role);
			panel1.Controls.Add(lblLoginName);
			panel1.Controls.Add(loginName);
			panel1.Controls.Add(pictureBox1);
			panel1.Controls.Add(label1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(1341, 127);
			panel1.TabIndex = 1;
			// 
			// role
			// 
			role.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			role.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			role.ForeColor = SystemColors.ControlDarkDark;
			role.Location = new Point(563, 89);
			role.Name = "role";
			role.Size = new Size(353, 26);
			role.TabIndex = 4;
			role.Text = "name";
			role.TextAlign = ContentAlignment.MiddleRight;
			role.Visible = false;
			// 
			// lblLoginName
			// 
			lblLoginName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			lblLoginName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblLoginName.ForeColor = SystemColors.ControlDarkDark;
			lblLoginName.Location = new Point(976, 24);
			lblLoginName.Name = "lblLoginName";
			lblLoginName.Size = new Size(353, 26);
			lblLoginName.TabIndex = 3;
			lblLoginName.Text = "name";
			lblLoginName.TextAlign = ContentAlignment.MiddleRight;
			lblLoginName.Visible = false;
			// 
			// loginName
			// 
			loginName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			loginName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			loginName.ForeColor = Color.Gray;
			loginName.Location = new Point(881, 89);
			loginName.Name = "loginName";
			loginName.Size = new Size(452, 26);
			loginName.TabIndex = 2;
			loginName.Text = "name";
			loginName.TextAlign = ContentAlignment.MiddleRight;
			// 
			// panel2
			// 
			panel2.BackColor = Color.White;
			panel2.Controls.Add(btnBackup);
			panel2.Controls.Add(btnDashboard);
			panel2.Controls.Add(btnSettings);
			panel2.Controls.Add(btnPayroll);
			panel2.Controls.Add(btnEmployee);
			panel2.Controls.Add(btnHome);
			panel2.Dock = DockStyle.Left;
			panel2.ForeColor = Color.White;
			panel2.Location = new Point(0, 127);
			panel2.Name = "panel2";
			panel2.Size = new Size(190, 536);
			panel2.TabIndex = 2;
			// 
			// btnDashboard
			// 
			btnDashboard.BackColor = Color.White;
			btnDashboard.Dock = DockStyle.Bottom;
			btnDashboard.Enabled = false;
			btnDashboard.FlatAppearance.BorderSize = 0;
			btnDashboard.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
			btnDashboard.FlatStyle = FlatStyle.Flat;
			btnDashboard.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			btnDashboard.ForeColor = Color.Black;
			btnDashboard.Image = Properties.Resources.dashboard1;
			btnDashboard.Location = new Point(0, 436);
			btnDashboard.Name = "btnDashboard";
			btnDashboard.Size = new Size(190, 50);
			btnDashboard.TabIndex = 5;
			btnDashboard.Text = "Dashboard";
			btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
			btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnDashboard.UseVisualStyleBackColor = false;
			btnDashboard.Click += btnDashboard_Click;
			// 
			// btnSettings
			// 
			btnSettings.BackColor = Color.White;
			btnSettings.Dock = DockStyle.Bottom;
			btnSettings.Enabled = false;
			btnSettings.FlatAppearance.BorderSize = 0;
			btnSettings.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
			btnSettings.FlatStyle = FlatStyle.Flat;
			btnSettings.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			btnSettings.ForeColor = Color.Black;
			btnSettings.Image = Properties.Resources.Settings_32x32;
			btnSettings.Location = new Point(0, 486);
			btnSettings.Name = "btnSettings";
			btnSettings.Size = new Size(190, 50);
			btnSettings.TabIndex = 4;
			btnSettings.Text = " Settings";
			btnSettings.TextAlign = ContentAlignment.MiddleLeft;
			btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnSettings.UseVisualStyleBackColor = false;
			btnSettings.Click += btnSettings_Click;
			// 
			// btnPayroll
			// 
			btnPayroll.Dock = DockStyle.Top;
			btnPayroll.Enabled = false;
			btnPayroll.FlatAppearance.BorderSize = 0;
			btnPayroll.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
			btnPayroll.FlatStyle = FlatStyle.Flat;
			btnPayroll.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			btnPayroll.ForeColor = Color.Black;
			btnPayroll.Image = Properties.Resources.payroll;
			btnPayroll.Location = new Point(0, 200);
			btnPayroll.Name = "btnPayroll";
			btnPayroll.Size = new Size(190, 100);
			btnPayroll.TabIndex = 2;
			btnPayroll.Text = "Payroll System";
			btnPayroll.TextImageRelation = TextImageRelation.ImageAboveText;
			btnPayroll.UseVisualStyleBackColor = true;
			btnPayroll.Click += btnPayroll_Click;
			// 
			// btnEmployee
			// 
			btnEmployee.Dock = DockStyle.Top;
			btnEmployee.Enabled = false;
			btnEmployee.FlatAppearance.BorderSize = 0;
			btnEmployee.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
			btnEmployee.FlatStyle = FlatStyle.Flat;
			btnEmployee.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			btnEmployee.ForeColor = Color.Black;
			btnEmployee.Image = Properties.Resources.employee;
			btnEmployee.Location = new Point(0, 100);
			btnEmployee.Name = "btnEmployee";
			btnEmployee.Size = new Size(190, 100);
			btnEmployee.TabIndex = 1;
			btnEmployee.Text = "Employee";
			btnEmployee.TextImageRelation = TextImageRelation.ImageAboveText;
			btnEmployee.UseVisualStyleBackColor = true;
			btnEmployee.Click += btnEmployee_Click;
			// 
			// btnHome
			// 
			btnHome.Dock = DockStyle.Top;
			btnHome.Enabled = false;
			btnHome.FlatAppearance.BorderSize = 0;
			btnHome.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
			btnHome.FlatStyle = FlatStyle.Flat;
			btnHome.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			btnHome.ForeColor = Color.Black;
			btnHome.Image = Properties.Resources.home;
			btnHome.Location = new Point(0, 0);
			btnHome.Name = "btnHome";
			btnHome.Size = new Size(190, 100);
			btnHome.TabIndex = 0;
			btnHome.Text = "Home";
			btnHome.TextImageRelation = TextImageRelation.ImageAboveText;
			btnHome.UseVisualStyleBackColor = true;
			btnHome.Click += btnHome_Click;
			// 
			// panel3
			// 
			panel3.Dock = DockStyle.Fill;
			panel3.Location = new Point(190, 127);
			panel3.Name = "panel3";
			panel3.Size = new Size(1151, 536);
			panel3.TabIndex = 3;
			// 
			// btnBackup
			// 
			btnBackup.BackColor = Color.White;
			btnBackup.Dock = DockStyle.Bottom;
			btnBackup.Enabled = false;
			btnBackup.FlatAppearance.BorderSize = 0;
			btnBackup.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
			btnBackup.FlatStyle = FlatStyle.Flat;
			btnBackup.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point);
			btnBackup.ForeColor = Color.Black;
			btnBackup.Image = Properties.Resources.dbbackup1;
			btnBackup.Location = new Point(0, 386);
			btnBackup.Name = "btnBackup";
			btnBackup.Size = new Size(190, 50);
			btnBackup.TabIndex = 6;
			btnBackup.Text = "Back-up DB";
			btnBackup.TextAlign = ContentAlignment.MiddleLeft;
			btnBackup.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnBackup.UseVisualStyleBackColor = false;
			btnBackup.Click += btnBackup_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1341, 663);
			Controls.Add(panel3);
			Controls.Add(panel2);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			WindowState = FormWindowState.Maximized;
			FormClosed += Form1_FormClosed;
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private PictureBox pictureBox1;
		private Label label1;
		private Panel panel1;
		private Panel panel2;
		private Panel panel3;
		public Button btnSettings;
		public Button btnPayroll;
		public Button btnEmployee;
		public Button btnHome;
		public Button btnDashboard;
		public Label loginName;
		public Label lblLoginName;
		public Label role;
		public Button btnBackup;
	}
}