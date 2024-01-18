namespace AldoBuildersPayrollSystem.Employee.MasterList
{
    partial class frmDesignation
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
            label1 = new Label();
            btnSave = new Button();
            txtDesignation = new TextBox();
            txtRate = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(16, 58);
            label1.Name = "label1";
            label1.Size = new Size(113, 25);
            label1.TabIndex = 5;
            label1.Text = "Designation";
            // 
            // btnSave
            // 
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseDownBackColor = Color.DodgerBlue;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(81, 141);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(346, 36);
            btnSave.TabIndex = 4;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtDesignation
            // 
            txtDesignation.CharacterCasing = CharacterCasing.Upper;
            txtDesignation.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDesignation.Location = new Point(16, 86);
            txtDesignation.Name = "txtDesignation";
            txtDesignation.Size = new Size(311, 35);
            txtDesignation.TabIndex = 3;
            // 
            // txtRate
            // 
            txtRate.CharacterCasing = CharacterCasing.Upper;
            txtRate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtRate.Location = new Point(351, 86);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(121, 35);
            txtRate.TabIndex = 6;
            txtRate.KeyPress += txtRate_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(351, 58);
            label2.Name = "label2";
            label2.Size = new Size(49, 25);
            label2.TabIndex = 7;
            label2.Text = "Rate";
            // 
            // frmDesignation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 208);
            Controls.Add(label2);
            Controls.Add(txtRate);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(txtDesignation);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmDesignation";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSave;
        private TextBox txtDesignation;
        private TextBox txtRate;
        private Label label2;
    }
}