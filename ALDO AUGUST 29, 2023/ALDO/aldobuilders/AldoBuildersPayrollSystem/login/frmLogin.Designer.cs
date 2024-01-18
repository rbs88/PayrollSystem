namespace AldoBuildersPayrollSystem.login
{
	partial class frmLogin
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
			txtUsername = new TextBox();
			btnLogin = new Button();
			txtPassword = new TextBox();
			btnCancel = new Button();
			btnExit = new Button();
			label1 = new Label();
			pictureBox1 = new PictureBox();
			label2 = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// txtUsername
			// 
			txtUsername.Font = new Font("Segoe UI", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
			txtUsername.Location = new Point(23, 148);
			txtUsername.Name = "txtUsername";
			txtUsername.Size = new Size(299, 38);
			txtUsername.TabIndex = 0;
			// 
			// btnLogin
			// 
			btnLogin.BackColor = Color.RoyalBlue;
			btnLogin.FlatAppearance.BorderSize = 0;
			btnLogin.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
			btnLogin.FlatStyle = FlatStyle.Flat;
			btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnLogin.ForeColor = Color.Black;
			btnLogin.Location = new Point(23, 263);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(299, 39);
			btnLogin.TabIndex = 3;
			btnLogin.Text = "Login";
			btnLogin.UseVisualStyleBackColor = false;
			btnLogin.Click += btnLogin_Click;
			// 
			// txtPassword
			// 
			txtPassword.Font = new Font("Segoe UI", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
			txtPassword.Location = new Point(23, 206);
			txtPassword.Name = "txtPassword";
			txtPassword.PasswordChar = '#';
			txtPassword.Size = new Size(299, 38);
			txtPassword.TabIndex = 2;
			// 
			// btnCancel
			// 
			btnCancel.BackColor = Color.Teal;
			btnCancel.FlatAppearance.BorderSize = 0;
			btnCancel.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
			btnCancel.FlatStyle = FlatStyle.Flat;
			btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnCancel.ForeColor = Color.Black;
			btnCancel.Location = new Point(23, 308);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(299, 39);
			btnCancel.TabIndex = 4;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = false;
			btnCancel.Click += btnCancel_Click;
			// 
			// btnExit
			// 
			btnExit.BackColor = Color.Brown;
			btnExit.FlatAppearance.BorderSize = 0;
			btnExit.FlatAppearance.MouseOverBackColor = Color.Red;
			btnExit.FlatStyle = FlatStyle.Flat;
			btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnExit.ForeColor = Color.Black;
			btnExit.Location = new Point(23, 353);
			btnExit.Name = "btnExit";
			btnExit.Size = new Size(299, 39);
			btnExit.TabIndex = 5;
			btnExit.Text = "Exit";
			btnExit.UseVisualStyleBackColor = false;
			btnExit.Click += btnExit_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = Color.Green;
			label1.Location = new Point(34, 132);
			label1.Name = "label1";
			label1.Size = new Size(67, 17);
			label1.TabIndex = 6;
			label1.Text = "Username";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.logo11;
			pictureBox1.Location = new Point(110, 12);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(132, 115);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 7;
			pictureBox1.TabStop = false;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			label2.ForeColor = Color.Green;
			label2.Location = new Point(34, 190);
			label2.Name = "label2";
			label2.Size = new Size(64, 17);
			label2.TabIndex = 8;
			label2.Text = "Password";
			// 
			// frmLogin
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(346, 414);
			Controls.Add(label2);
			Controls.Add(pictureBox1);
			Controls.Add(label1);
			Controls.Add(btnExit);
			Controls.Add(btnCancel);
			Controls.Add(txtPassword);
			Controls.Add(btnLogin);
			Controls.Add(txtUsername);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			Name = "frmLogin";
			StartPosition = FormStartPosition.CenterScreen;
			Load += frmLogin_Load;
			KeyDown += frmLogin_KeyDown;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtUsername;
		private Button btnLogin;
		private TextBox txtPassword;
		private Button btnCancel;
		private Button btnExit;
		private Label label1;
		private PictureBox pictureBox1;
		private Label label2;
	}
}