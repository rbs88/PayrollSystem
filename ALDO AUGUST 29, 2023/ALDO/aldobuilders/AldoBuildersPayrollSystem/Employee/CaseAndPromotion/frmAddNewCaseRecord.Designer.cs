namespace AldoBuildersPayrollSystem.Employee.CaseAndPromotion
{
    partial class frmAddNewCaseRecord
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dtCasePosted = new DateTimePicker();
            txtCaseType = new TextBox();
            txtCaseReason = new TextBox();
            btnSave = new Button();
            label1 = new Label();
            lblpostedby = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(31, 29);
            label4.Name = "label4";
            label4.Size = new Size(34, 17);
            label4.TabIndex = 15;
            label4.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(31, 168);
            label3.Name = "label3";
            label3.Size = new Size(78, 17);
            label3.TabIndex = 14;
            label3.Text = "Case Reason";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(31, 96);
            label2.Name = "label2";
            label2.Size = new Size(34, 17);
            label2.TabIndex = 13;
            label2.Text = "Type";
            // 
            // dtCasePosted
            // 
            dtCasePosted.CustomFormat = "MM-dd-yyyy";
            dtCasePosted.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtCasePosted.Format = DateTimePickerFormat.Custom;
            dtCasePosted.Location = new Point(20, 44);
            dtCasePosted.Name = "dtCasePosted";
            dtCasePosted.Size = new Size(140, 33);
            dtCasePosted.TabIndex = 1;
            // 
            // txtCaseType
            // 
            txtCaseType.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCaseType.Location = new Point(21, 112);
            txtCaseType.Multiline = true;
            txtCaseType.Name = "txtCaseType";
            txtCaseType.Size = new Size(325, 37);
            txtCaseType.TabIndex = 2;
            // 
            // txtCaseReason
            // 
            txtCaseReason.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCaseReason.Location = new Point(20, 179);
            txtCaseReason.Multiline = true;
            txtCaseReason.Name = "txtCaseReason";
            txtCaseReason.Size = new Size(415, 159);
            txtCaseReason.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(257, 344);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(175, 30);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(272, 33);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 17;
            label1.Text = "label1";
            label1.Visible = false;
            // 
            // lblpostedby
            // 
            lblpostedby.AutoSize = true;
            lblpostedby.Location = new Point(257, 73);
            lblpostedby.Name = "lblpostedby";
            lblpostedby.Size = new Size(38, 15);
            lblpostedby.TabIndex = 18;
            lblpostedby.Text = "label5";
            lblpostedby.Visible = false;
            // 
            // frmAddNewCaseRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(444, 395);
            Controls.Add(lblpostedby);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtCasePosted);
            Controls.Add(txtCaseType);
            Controls.Add(txtCaseReason);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmAddNewCaseRecord";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CASE";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dtCasePosted;
        private TextBox txtCaseType;
        private TextBox txtCaseReason;
        private Button btnSave;
        public Label label1;
        public Label lblpostedby;
    }
}