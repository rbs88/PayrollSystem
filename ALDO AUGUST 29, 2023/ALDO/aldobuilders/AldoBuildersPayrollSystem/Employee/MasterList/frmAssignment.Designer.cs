namespace AldoBuildersPayrollSystem.Employee.MasterList
{
    partial class frmAssignment
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
            txtAssignment = new TextBox();
            btnSave = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtAssignment
            // 
            txtAssignment.CharacterCasing = CharacterCasing.Upper;
            txtAssignment.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtAssignment.Location = new Point(12, 68);
            txtAssignment.Name = "txtAssignment";
            txtAssignment.Size = new Size(560, 35);
            txtAssignment.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseDownBackColor = Color.DodgerBlue;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(219, 112);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(161, 39);
            btnSave.TabIndex = 1;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(210, 40);
            label1.Name = "label1";
            label1.Size = new Size(182, 25);
            label1.TabIndex = 2;
            label1.Text = "Place of Assignment";
            // 
            // frmAssignment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 214);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(txtAssignment);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "frmAssignment";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAssignment;
        private Button btnSave;
        private Label label1;
    }
}