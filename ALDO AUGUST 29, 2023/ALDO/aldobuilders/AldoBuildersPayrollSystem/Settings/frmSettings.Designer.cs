namespace AldoBuildersPayrollSystem.Settings
{
	partial class frmSettings
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
			label1 = new Label();
			panel2 = new Panel();
			menuStrip1 = new MenuStrip();
			modifyAndAddNewUserToolStripMenuItem = new ToolStripMenuItem();
			restoreDatabaseToolStripMenuItem = new ToolStripMenuItem();
			panelUserLoad = new Panel();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.LightGray;
			panel1.Controls.Add(label1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(1207, 32);
			panel1.TabIndex = 0;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = SystemColors.ControlDarkDark;
			label1.Location = new Point(427, 3);
			label1.Name = "label1";
			label1.Size = new Size(353, 26);
			label1.TabIndex = 5;
			label1.Text = "name";
			label1.TextAlign = ContentAlignment.MiddleRight;
			// 
			// panel2
			// 
			panel2.Controls.Add(menuStrip1);
			panel2.Dock = DockStyle.Top;
			panel2.Location = new Point(0, 32);
			panel2.Name = "panel2";
			panel2.Size = new Size(1207, 31);
			panel2.TabIndex = 1;
			// 
			// menuStrip1
			// 
			menuStrip1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			menuStrip1.Items.AddRange(new ToolStripItem[] { modifyAndAddNewUserToolStripMenuItem, restoreDatabaseToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(1207, 28);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// modifyAndAddNewUserToolStripMenuItem
			// 
			modifyAndAddNewUserToolStripMenuItem.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			modifyAndAddNewUserToolStripMenuItem.Name = "modifyAndAddNewUserToolStripMenuItem";
			modifyAndAddNewUserToolStripMenuItem.Size = new Size(189, 24);
			modifyAndAddNewUserToolStripMenuItem.Text = "Modify and add new user";
			modifyAndAddNewUserToolStripMenuItem.Click += modifyAndAddNewUserToolStripMenuItem_Click;
			// 
			// restoreDatabaseToolStripMenuItem
			// 
			restoreDatabaseToolStripMenuItem.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			restoreDatabaseToolStripMenuItem.Name = "restoreDatabaseToolStripMenuItem";
			restoreDatabaseToolStripMenuItem.Size = new Size(138, 24);
			restoreDatabaseToolStripMenuItem.Text = "Restore Database";
			restoreDatabaseToolStripMenuItem.Click += restoreDatabaseToolStripMenuItem_Click;
			// 
			// panelUserLoad
			// 
			panelUserLoad.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			panelUserLoad.Location = new Point(0, 63);
			panelUserLoad.Name = "panelUserLoad";
			panelUserLoad.Size = new Size(1207, 612);
			panelUserLoad.TabIndex = 2;
			// 
			// frmSettings
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1207, 675);
			Controls.Add(panelUserLoad);
			Controls.Add(panel2);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			MainMenuStrip = menuStrip1;
			Name = "frmSettings";
			Text = "frmSettings";
			WindowState = FormWindowState.Maximized;
			panel1.ResumeLayout(false);
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Panel panel2;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem modifyAndAddNewUserToolStripMenuItem;
		private Panel panelUserLoad;
		private ToolStripMenuItem restoreDatabaseToolStripMenuItem;
		public Label label1;
	}
}