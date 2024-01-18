namespace AldoBuildersPayrollSystem.Home
{
	partial class frmHome
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
			panel2 = new Panel();
			panel3 = new Panel();
			panel1 = new Panel();
			pictureBox1 = new PictureBox();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// panel2
			// 
			panel2.Controls.Add(pictureBox1);
			panel2.Controls.Add(panel1);
			panel2.Controls.Add(panel3);
			panel2.Dock = DockStyle.Fill;
			panel2.Location = new Point(0, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(936, 649);
			panel2.TabIndex = 2;
			// 
			// panel3
			// 
			panel3.BackColor = Color.Navy;
			panel3.Dock = DockStyle.Left;
			panel3.Location = new Point(0, 0);
			panel3.Name = "panel3";
			panel3.Size = new Size(10, 649);
			panel3.TabIndex = 0;
			// 
			// panel1
			// 
			panel1.BackColor = Color.Navy;
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(10, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(926, 11);
			panel1.TabIndex = 2;
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = Color.White;
			pictureBox1.Dock = DockStyle.Fill;
			pictureBox1.Image = Properties.Resources.Screenshot__287_;
			pictureBox1.Location = new Point(10, 11);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(926, 638);
			pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox1.TabIndex = 3;
			pictureBox1.TabStop = false;
			// 
			// frmHome
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(936, 649);
			Controls.Add(panel2);
			FormBorderStyle = FormBorderStyle.None;
			Name = "frmHome";
			Text = "frmHome";
			WindowState = FormWindowState.Maximized;
			panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion
		private Panel panel2;
		private Panel panel3;
		private PictureBox pictureBox1;
		private Panel panel1;
	}
}