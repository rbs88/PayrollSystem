namespace AldoBuildersPayrollSystem.login
{
	partial class frmAddUser
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
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUser));
			txtUsername = new TextBox();
			txtPassword = new TextBox();
			txtName = new TextBox();
			cboRole = new ComboBox();
			btnSave = new Button();
			btnUpdate = new Button();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			txtDesignation = new TextBox();
			dataGridView1 = new DataGridView();
			iduser = new DataGridViewTextBoxColumn();
			Column1 = new DataGridViewTextBoxColumn();
			Column2 = new DataGridViewTextBoxColumn();
			Column3 = new DataGridViewTextBoxColumn();
			Column4 = new DataGridViewTextBoxColumn();
			Column5 = new DataGridViewTextBoxColumn();
			colEdit = new DataGridViewImageColumn();
			colDelete = new DataGridViewImageColumn();
			btnShowUser = new Button();
			label8 = new Label();
			txtReTypePassword = new TextBox();
			label9 = new Label();
			label10 = new Label();
			label11 = new Label();
			label12 = new Label();
			label13 = new Label();
			label14 = new Label();
			label15 = new Label();
			checkPassword = new CheckBox();
			idusername = new Label();
			btnClear = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// txtUsername
			// 
			txtUsername.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			txtUsername.ForeColor = Color.Black;
			txtUsername.Location = new Point(664, 141);
			txtUsername.Multiline = true;
			txtUsername.Name = "txtUsername";
			txtUsername.Size = new Size(373, 40);
			txtUsername.TabIndex = 0;
			// 
			// txtPassword
			// 
			txtPassword.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			txtPassword.ForeColor = Color.Black;
			txtPassword.Location = new Point(664, 203);
			txtPassword.Multiline = true;
			txtPassword.Name = "txtPassword";
			txtPassword.PasswordChar = '#';
			txtPassword.Size = new Size(373, 40);
			txtPassword.TabIndex = 1;
			// 
			// txtName
			// 
			txtName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			txtName.ForeColor = Color.Black;
			txtName.Location = new Point(664, 327);
			txtName.Multiline = true;
			txtName.Name = "txtName";
			txtName.Size = new Size(373, 40);
			txtName.TabIndex = 2;
			// 
			// cboRole
			// 
			cboRole.DropDownStyle = ComboBoxStyle.DropDownList;
			cboRole.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			cboRole.FormattingEnabled = true;
			cboRole.Items.AddRange(new object[] { "Owner", "Administrator", "User" });
			cboRole.Location = new Point(664, 388);
			cboRole.Name = "cboRole";
			cboRole.Size = new Size(373, 38);
			cboRole.TabIndex = 3;
			// 
			// btnSave
			// 
			btnSave.BackColor = Color.RoyalBlue;
			btnSave.Enabled = false;
			btnSave.FlatAppearance.BorderSize = 0;
			btnSave.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
			btnSave.FlatStyle = FlatStyle.Flat;
			btnSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			btnSave.Location = new Point(667, 510);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(118, 37);
			btnSave.TabIndex = 5;
			btnSave.Text = "Save";
			btnSave.UseVisualStyleBackColor = false;
			btnSave.Click += btnSave_Click;
			// 
			// btnUpdate
			// 
			btnUpdate.BackColor = Color.DarkCyan;
			btnUpdate.Enabled = false;
			btnUpdate.FlatAppearance.BorderSize = 0;
			btnUpdate.FlatAppearance.MouseOverBackColor = Color.LightBlue;
			btnUpdate.FlatStyle = FlatStyle.Flat;
			btnUpdate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			btnUpdate.Location = new Point(791, 510);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(117, 37);
			btnUpdate.TabIndex = 6;
			btnUpdate.Text = "Update";
			btnUpdate.UseVisualStyleBackColor = false;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.ForeColor = Color.Tomato;
			label2.Location = new Point(671, 126);
			label2.Name = "label2";
			label2.Size = new Size(60, 15);
			label2.TabIndex = 8;
			label2.Text = "Username";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.ForeColor = Color.Tomato;
			label3.Location = new Point(671, 188);
			label3.Name = "label3";
			label3.Size = new Size(57, 15);
			label3.TabIndex = 9;
			label3.Text = "Password";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.ForeColor = Color.Tomato;
			label4.Location = new Point(671, 312);
			label4.Name = "label4";
			label4.Size = new Size(39, 15);
			label4.TabIndex = 10;
			label4.Text = "Name";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.ForeColor = Color.Tomato;
			label5.Location = new Point(673, 372);
			label5.Name = "label5";
			label5.Size = new Size(27, 15);
			label5.TabIndex = 11;
			label5.Text = "role";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.ForeColor = Color.Tomato;
			label6.Location = new Point(673, 415);
			label6.Name = "label6";
			label6.Size = new Size(0, 15);
			label6.TabIndex = 12;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.ForeColor = Color.Tomato;
			label7.Location = new Point(671, 432);
			label7.Name = "label7";
			label7.Size = new Size(70, 15);
			label7.TabIndex = 13;
			label7.Text = "Designation";
			// 
			// txtDesignation
			// 
			txtDesignation.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			txtDesignation.ForeColor = Color.Black;
			txtDesignation.Location = new Point(664, 447);
			txtDesignation.Multiline = true;
			txtDesignation.Name = "txtDesignation";
			txtDesignation.Size = new Size(373, 40);
			txtDesignation.TabIndex = 14;
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.AllowUserToResizeColumns = false;
			dataGridView1.AllowUserToResizeRows = false;
			dataGridView1.BackgroundColor = Color.White;
			dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = Color.Teal;
			dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle4.ForeColor = Color.White;
			dataGridViewCellStyle4.SelectionBackColor = Color.Teal;
			dataGridViewCellStyle4.SelectionForeColor = Color.White;
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
			dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			dataGridView1.ColumnHeadersHeight = 30;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { iduser, Column1, Column2, Column3, Column4, Column5, colEdit, colDelete });
			dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = SystemColors.Window;
			dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
			dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
			dataGridView1.EnableHeadersVisualStyles = false;
			dataGridView1.Location = new Point(204, 142);
			dataGridView1.MultiSelect = false;
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersVisible = false;
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView1.Size = new Size(410, 405);
			dataGridView1.TabIndex = 15;
			dataGridView1.CellContentClick += dataGridView1_CellContentClick;
			// 
			// iduser
			// 
			iduser.HeaderText = "iduser";
			iduser.Name = "iduser";
			iduser.ReadOnly = true;
			iduser.Visible = false;
			// 
			// Column1
			// 
			Column1.HeaderText = "Username";
			Column1.Name = "Column1";
			Column1.ReadOnly = true;
			Column1.Visible = false;
			// 
			// Column2
			// 
			Column2.HeaderText = "Password";
			Column2.Name = "Column2";
			Column2.ReadOnly = true;
			Column2.Visible = false;
			// 
			// Column3
			// 
			Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Column3.HeaderText = "Name";
			Column3.Name = "Column3";
			Column3.ReadOnly = true;
			// 
			// Column4
			// 
			Column4.HeaderText = "Role";
			Column4.Name = "Column4";
			Column4.ReadOnly = true;
			// 
			// Column5
			// 
			Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			Column5.HeaderText = "Designation";
			Column5.Name = "Column5";
			Column5.ReadOnly = true;
			Column5.Visible = false;
			// 
			// colEdit
			// 
			colEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			colEdit.HeaderText = "";
			colEdit.Image = Properties.Resources.Edit_16x16;
			colEdit.Name = "colEdit";
			colEdit.ReadOnly = true;
			colEdit.Resizable = DataGridViewTriState.True;
			colEdit.SortMode = DataGridViewColumnSortMode.Automatic;
			colEdit.Width = 18;
			// 
			// colDelete
			// 
			colDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.ForeColor = Color.White;
			dataGridViewCellStyle5.NullValue = resources.GetObject("dataGridViewCellStyle5.NullValue");
			colDelete.DefaultCellStyle = dataGridViewCellStyle5;
			colDelete.HeaderText = "";
			colDelete.Image = (Image)resources.GetObject("colDelete.Image");
			colDelete.Name = "colDelete";
			colDelete.ReadOnly = true;
			colDelete.Resizable = DataGridViewTriState.True;
			colDelete.SortMode = DataGridViewColumnSortMode.Automatic;
			colDelete.Width = 18;
			// 
			// btnShowUser
			// 
			btnShowUser.BackColor = Color.RoyalBlue;
			btnShowUser.FlatAppearance.BorderSize = 0;
			btnShowUser.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
			btnShowUser.FlatStyle = FlatStyle.Flat;
			btnShowUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnShowUser.Location = new Point(204, 98);
			btnShowUser.Name = "btnShowUser";
			btnShowUser.Size = new Size(410, 37);
			btnShowUser.TabIndex = 16;
			btnShowUser.Text = "Click here to show user/admin";
			btnShowUser.UseVisualStyleBackColor = false;
			btnShowUser.Click += btnShowUser_Click;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.ForeColor = Color.Tomato;
			label8.Location = new Point(671, 250);
			label8.Name = "label8";
			label8.Size = new Size(102, 15);
			label8.TabIndex = 18;
			label8.Text = "Re-Type Password";
			// 
			// txtReTypePassword
			// 
			txtReTypePassword.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			txtReTypePassword.ForeColor = Color.Black;
			txtReTypePassword.Location = new Point(664, 265);
			txtReTypePassword.Multiline = true;
			txtReTypePassword.Name = "txtReTypePassword";
			txtReTypePassword.PasswordChar = '#';
			txtReTypePassword.Size = new Size(373, 40);
			txtReTypePassword.TabIndex = 17;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			label9.ForeColor = Color.Tomato;
			label9.Location = new Point(899, 67);
			label9.Name = "label9";
			label9.Size = new Size(98, 17);
			label9.TabIndex = 20;
			label9.Text = "Required Fields";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label10.ForeColor = Color.Red;
			label10.Location = new Point(1001, 69);
			label10.Name = "label10";
			label10.Size = new Size(17, 21);
			label10.TabIndex = 21;
			label10.Text = "*";
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label11.ForeColor = Color.Red;
			label11.Location = new Point(641, 151);
			label11.Name = "label11";
			label11.Size = new Size(17, 21);
			label11.TabIndex = 22;
			label11.Text = "*";
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label12.ForeColor = Color.Red;
			label12.Location = new Point(641, 213);
			label12.Name = "label12";
			label12.Size = new Size(17, 21);
			label12.TabIndex = 23;
			label12.Text = "*";
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label13.ForeColor = Color.Red;
			label13.Location = new Point(641, 275);
			label13.Name = "label13";
			label13.Size = new Size(17, 21);
			label13.TabIndex = 24;
			label13.Text = "*";
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label14.ForeColor = Color.Red;
			label14.Location = new Point(641, 337);
			label14.Name = "label14";
			label14.Size = new Size(17, 21);
			label14.TabIndex = 25;
			label14.Text = "*";
			// 
			// label15
			// 
			label15.AutoSize = true;
			label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label15.ForeColor = Color.Red;
			label15.Location = new Point(641, 398);
			label15.Name = "label15";
			label15.Size = new Size(17, 21);
			label15.TabIndex = 26;
			label15.Text = "*";
			// 
			// checkPassword
			// 
			checkPassword.AutoSize = true;
			checkPassword.Location = new Point(1043, 216);
			checkPassword.Name = "checkPassword";
			checkPassword.Size = new Size(15, 14);
			checkPassword.TabIndex = 27;
			checkPassword.UseVisualStyleBackColor = true;
			checkPassword.CheckedChanged += checkBox1_CheckedChanged;
			// 
			// idusername
			// 
			idusername.AutoSize = true;
			idusername.ForeColor = Color.Tomato;
			idusername.Location = new Point(856, 563);
			idusername.Name = "idusername";
			idusername.Size = new Size(17, 15);
			idusername.TabIndex = 28;
			idusername.Text = "id";
			idusername.Visible = false;
			// 
			// btnClear
			// 
			btnClear.FlatAppearance.BorderSize = 0;
			btnClear.FlatAppearance.MouseOverBackColor = Color.Green;
			btnClear.FlatStyle = FlatStyle.Flat;
			btnClear.Location = new Point(856, 108);
			btnClear.Name = "btnClear";
			btnClear.Size = new Size(181, 27);
			btnClear.TabIndex = 29;
			btnClear.Text = "Click here to add new user";
			btnClear.UseVisualStyleBackColor = true;
			btnClear.Click += btnClear_Click;
			// 
			// frmAddUser
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Control;
			ClientSize = new Size(1082, 650);
			Controls.Add(btnClear);
			Controls.Add(idusername);
			Controls.Add(checkPassword);
			Controls.Add(label15);
			Controls.Add(label14);
			Controls.Add(label13);
			Controls.Add(label12);
			Controls.Add(label11);
			Controls.Add(label10);
			Controls.Add(label9);
			Controls.Add(label8);
			Controls.Add(txtReTypePassword);
			Controls.Add(btnShowUser);
			Controls.Add(dataGridView1);
			Controls.Add(label7);
			Controls.Add(txtDesignation);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(btnUpdate);
			Controls.Add(btnSave);
			Controls.Add(cboRole);
			Controls.Add(txtName);
			Controls.Add(txtPassword);
			Controls.Add(txtUsername);
			FormBorderStyle = FormBorderStyle.None;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "frmAddUser";
			StartPosition = FormStartPosition.CenterScreen;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtUsername;
		private TextBox txtPassword;
		private TextBox txtName;
		private ComboBox cboRole;
		private Button btnSave;
		private Button btnUpdate;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private TextBox txtDesignation;
		private DataGridView dataGridView1;
		private Button btnShowUser;
		private Label label8;
		private TextBox txtReTypePassword;
		private Label label9;
		private Label label10;
		private Label label11;
		private Label label12;
		private Label label13;
		private Label label14;
		private Label label15;
		private CheckBox checkPassword;
		private DataGridViewTextBoxColumn iduser;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewTextBoxColumn Column4;
		private DataGridViewTextBoxColumn Column5;
		private DataGridViewImageColumn colEdit;
		private DataGridViewImageColumn colDelete;
		private Label idusername;
		private Button btnClear;
	}
}