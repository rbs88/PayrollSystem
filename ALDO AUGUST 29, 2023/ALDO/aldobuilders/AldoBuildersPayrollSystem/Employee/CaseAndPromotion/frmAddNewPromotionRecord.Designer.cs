namespace AldoBuildersPayrollSystem.Employee.CaseAndPromotion
{
	partial class frmAddNewPromotionRecord
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
			txtReason = new TextBox();
			txtNewDesignation = new TextBox();
			txtNewRate = new TextBox();
			dtDatePromoted = new DateTimePicker();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			btnSave = new Button();
			lblpostedby = new Label();
			label5 = new Label();
			SuspendLayout();
			// 
			// txtReason
			// 
			txtReason.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			txtReason.Location = new Point(12, 209);
			txtReason.Multiline = true;
			txtReason.Name = "txtReason";
			txtReason.Size = new Size(415, 118);
			txtReason.TabIndex = 0;
			// 
			// txtNewDesignation
			// 
			txtNewDesignation.CharacterCasing = CharacterCasing.Upper;
			txtNewDesignation.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			txtNewDesignation.Location = new Point(12, 94);
			txtNewDesignation.Name = "txtNewDesignation";
			txtNewDesignation.Size = new Size(325, 33);
			txtNewDesignation.TabIndex = 1;
			// 
			// txtNewRate
			// 
			txtNewRate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			txtNewRate.Location = new Point(12, 150);
			txtNewRate.Name = "txtNewRate";
			txtNewRate.Size = new Size(140, 33);
			txtNewRate.TabIndex = 2;
			// 
			// dtDatePromoted
			// 
			dtDatePromoted.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			dtDatePromoted.Format = DateTimePickerFormat.Short;
			dtDatePromoted.Location = new Point(12, 32);
			dtDatePromoted.Name = "dtDatePromoted";
			dtDatePromoted.Size = new Size(140, 33);
			dtDatePromoted.TabIndex = 3;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
			label1.Location = new Point(23, 78);
			label1.Name = "label1";
			label1.Size = new Size(102, 17);
			label1.TabIndex = 4;
			label1.Text = "New Designation";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
			label2.Location = new Point(23, 138);
			label2.Name = "label2";
			label2.Size = new Size(62, 17);
			label2.TabIndex = 5;
			label2.Text = "New Rate";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
			label3.Location = new Point(23, 197);
			label3.Name = "label3";
			label3.Size = new Size(48, 17);
			label3.TabIndex = 6;
			label3.Text = "Reason";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
			label4.Location = new Point(23, 16);
			label4.Name = "label4";
			label4.Size = new Size(92, 17);
			label4.TabIndex = 7;
			label4.Text = "Date Promoted";
			// 
			// btnSave
			// 
			btnSave.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
			btnSave.FlatStyle = FlatStyle.Flat;
			btnSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			btnSave.Location = new Point(249, 345);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(175, 30);
			btnSave.TabIndex = 8;
			btnSave.Text = "Save";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += btnSave_Click;
			// 
			// lblpostedby
			// 
			lblpostedby.AutoSize = true;
			lblpostedby.Location = new Point(269, 58);
			lblpostedby.Name = "lblpostedby";
			lblpostedby.Size = new Size(38, 15);
			lblpostedby.TabIndex = 20;
			lblpostedby.Text = "label5";
			lblpostedby.Visible = false;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(284, 18);
			label5.Name = "label5";
			label5.Size = new Size(38, 15);
			label5.TabIndex = 19;
			label5.Text = "label5";
			label5.Visible = false;
			// 
			// frmAddNewPromotionRecord
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(436, 396);
			Controls.Add(lblpostedby);
			Controls.Add(label5);
			Controls.Add(btnSave);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(dtDatePromoted);
			Controls.Add(txtNewRate);
			Controls.Add(txtNewDesignation);
			Controls.Add(txtReason);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "frmAddNewPromotionRecord";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "PROMOTION";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtReason;
		private TextBox txtNewDesignation;
		private TextBox txtNewRate;
		private DateTimePicker dtDatePromoted;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Button btnSave;
		public Label lblpostedby;
		public Label label5;
	}
}