namespace AldoBuildersPayrollSystem.attendanceandpayroll
{
    partial class frmUpdateTimeAndHours
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
            btnSave = new Button();
            lblIdPayroll = new Label();
            lblLoginName = new Label();
            lblTodaysdate = new Label();
            txtAddHours = new TextBox();
            lblName = new Label();
            dtLogdate = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            txtReason = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DodgerBlue;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(321, 161);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(271, 35);
            btnSave.TabIndex = 0;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += button1_Click;
            // 
            // lblIdPayroll
            // 
            lblIdPayroll.AutoSize = true;
            lblIdPayroll.Location = new Point(53, 9);
            lblIdPayroll.Name = "lblIdPayroll";
            lblIdPayroll.Size = new Size(53, 15);
            lblIdPayroll.TabIndex = 1;
            lblIdPayroll.Text = "idpayroll";
            lblIdPayroll.Visible = false;
            // 
            // lblLoginName
            // 
            lblLoginName.AutoSize = true;
            lblLoginName.Location = new Point(222, 18);
            lblLoginName.Name = "lblLoginName";
            lblLoginName.Size = new Size(56, 15);
            lblLoginName.TabIndex = 2;
            lblLoginName.Text = "postedby";
            lblLoginName.Visible = false;
            // 
            // lblTodaysdate
            // 
            lblTodaysdate.AutoSize = true;
            lblTodaysdate.Location = new Point(387, 9);
            lblTodaysdate.Name = "lblTodaysdate";
            lblTodaysdate.Size = new Size(65, 15);
            lblTodaysdate.TabIndex = 4;
            lblTodaysdate.Text = "todaysdate";
            lblTodaysdate.Visible = false;
            // 
            // txtAddHours
            // 
            txtAddHours.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddHours.Location = new Point(285, 94);
            txtAddHours.Name = "txtAddHours";
            txtAddHours.Size = new Size(94, 35);
            txtAddHours.TabIndex = 5;
            txtAddHours.TextAlign = HorizontalAlignment.Center;
            txtAddHours.KeyPress += txtAddHours_KeyPress;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(30, 39);
            lblName.Name = "lblName";
            lblName.Size = new Size(62, 25);
            lblName.TabIndex = 6;
            lblName.Text = "Name";
            // 
            // dtLogdate
            // 
            dtLogdate.Enabled = false;
            dtLogdate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtLogdate.Format = DateTimePickerFormat.Short;
            dtLogdate.Location = new Point(32, 95);
            dtLogdate.Name = "dtLogdate";
            dtLogdate.Size = new Size(223, 33);
            dtLogdate.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 81);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 8;
            label1.Text = "Logdate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(300, 81);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 9;
            label2.Text = "AddHours";
            // 
            // txtReason
            // 
            txtReason.Font = new Font("Segoe UI", 13.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtReason.Location = new Point(427, 95);
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(470, 32);
            txtReason.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(431, 81);
            label3.Name = "label3";
            label3.Size = new Size(215, 15);
            label3.TabIndex = 11;
            label3.Text = "Reason of Adding or Reduction of Time";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Brown;
            label4.Location = new Point(641, 9);
            label4.Name = "label4";
            label4.Size = new Size(20, 25);
            label4.TabIndex = 12;
            label4.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(667, 13);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 13;
            label5.Text = "Required Fields";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Brown;
            label6.Location = new Point(404, 95);
            label6.Name = "label6";
            label6.Size = new Size(20, 25);
            label6.TabIndex = 14;
            label6.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Brown;
            label7.Location = new Point(263, 97);
            label7.Name = "label7";
            label7.Size = new Size(20, 25);
            label7.TabIndex = 15;
            label7.Text = "*";
            // 
            // frmUpdateTimeAndHours
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(912, 215);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtReason);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtLogdate);
            Controls.Add(lblName);
            Controls.Add(txtAddHours);
            Controls.Add(lblTodaysdate);
            Controls.Add(lblLoginName);
            Controls.Add(lblIdPayroll);
            Controls.Add(btnSave);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmUpdateTimeAndHours";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Label lblIdPayroll;
        public Label lblLoginName;
        public Label lblTodaysdate;
        public Label lblName;
        public Button btnSave;
        public DateTimePicker dtLogdate;
        public TextBox txtAddHours;
        private Label label1;
        private Label label2;
        public TextBox txtReason;
        private Label label3;
        public Label label4;
        public Label label5;
        public Label label6;
        public Label label7;
    }
}