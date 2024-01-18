namespace AldoBuildersPayrollSystem.Employee.MasterList
{
    partial class frmAddNewEmployee
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
            label16 = new Label();
            txtPagibig = new TextBox();
            label15 = new Label();
            txtPhilhealthNumber = new TextBox();
            label14 = new Label();
            txtSSSNumber = new TextBox();
            label13 = new Label();
            cboDesignation = new ComboBox();
            btnCancel = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            label12 = new Label();
            cboStatus = new ComboBox();
            label11 = new Label();
            dtDateOut = new MaskedTextBox();
            label10 = new Label();
            dtDateHired = new DateTimePicker();
            label9 = new Label();
            txtOtherInformation = new TextBox();
            btnCaptureImage = new Button();
            btnStarCamera = new Button();
            txtBrowseImage = new Button();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            txtRFID = new TextBox();
            label7 = new Label();
            txtIDNumber = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtAge = new TextBox();
            dtBirthDay = new DateTimePicker();
            txtAddress = new TextBox();
            txtLastName = new TextBox();
            txtMiddleName = new TextBox();
            txtFirstName = new TextBox();
            label17 = new Label();
            cboAssign = new ComboBox();
            label18 = new Label();
            txtPictureURL = new TextBox();
            lblPostedby = new Label();
            lblid = new Label();
            openFileDialog1 = new OpenFileDialog();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            btnUpdate2 = new Button();
            lblLoginName = new Label();
            btnAssignment = new Button();
            btnDesignation = new Button();
            cboCategory = new ComboBox();
            label25 = new Label();
            label26 = new Label();
            role = new Label();
            cboRate = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label16.ForeColor = Color.Tomato;
            label16.Location = new Point(639, 427);
            label16.Name = "label16";
            label16.Size = new Size(53, 15);
            label16.TabIndex = 81;
            label16.Text = "Pag-ibig";
            // 
            // txtPagibig
            // 
            txtPagibig.CharacterCasing = CharacterCasing.Upper;
            txtPagibig.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPagibig.Location = new Point(631, 441);
            txtPagibig.Name = "txtPagibig";
            txtPagibig.Size = new Size(310, 33);
            txtPagibig.TabIndex = 12;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label15.ForeColor = Color.Tomato;
            label15.Location = new Point(321, 427);
            label15.Name = "label15";
            label15.Size = new Size(109, 15);
            label15.TabIndex = 79;
            label15.Text = "Philhealth Number";
            // 
            // txtPhilhealthNumber
            // 
            txtPhilhealthNumber.CharacterCasing = CharacterCasing.Upper;
            txtPhilhealthNumber.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhilhealthNumber.Location = new Point(313, 441);
            txtPhilhealthNumber.Name = "txtPhilhealthNumber";
            txtPhilhealthNumber.Size = new Size(310, 33);
            txtPhilhealthNumber.TabIndex = 11;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label14.ForeColor = Color.Tomato;
            label14.Location = new Point(30, 427);
            label14.Name = "label14";
            label14.Size = new Size(73, 15);
            label14.TabIndex = 77;
            label14.Text = "SSS Number";
            // 
            // txtSSSNumber
            // 
            txtSSSNumber.CharacterCasing = CharacterCasing.Upper;
            txtSSSNumber.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSSSNumber.Location = new Point(22, 441);
            txtSSSNumber.Name = "txtSSSNumber";
            txtSSSNumber.Size = new Size(282, 33);
            txtSSSNumber.TabIndex = 10;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label13.ForeColor = Color.Tomato;
            label13.Location = new Point(31, 348);
            label13.Name = "label13";
            label13.Size = new Size(72, 15);
            label13.TabIndex = 75;
            label13.Text = "Designation";
            // 
            // cboDesignation
            // 
            cboDesignation.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDesignation.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            cboDesignation.FormattingEnabled = true;
            cboDesignation.Location = new Point(23, 363);
            cboDesignation.Name = "cboDesignation";
            cboDesignation.Size = new Size(281, 31);
            cboDesignation.TabIndex = 8;
            cboDesignation.TextChanged += cboDesignation_TextChanged;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Tomato;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(900, 668);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(156, 35);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Brown;
            btnDelete.Enabled = false;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.Red;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(736, 668);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(156, 35);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.RoyalBlue;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(572, 668);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(156, 35);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.RoyalBlue;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(409, 668);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(156, 35);
            btnSave.TabIndex = 18;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label12.ForeColor = Color.Tomato;
            label12.Location = new Point(620, 484);
            label12.Name = "label12";
            label12.Size = new Size(40, 15);
            label12.TabIndex = 69;
            label12.Text = "Status";
            // 
            // cboStatus
            // 
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "ACTIVE", "INACTIVE" });
            cboStatus.Location = new Point(615, 499);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(222, 31);
            cboStatus.TabIndex = 15;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label11.ForeColor = Color.Tomato;
            label11.Location = new Point(856, 489);
            label11.Name = "label11";
            label11.Size = new Size(56, 15);
            label11.TabIndex = 66;
            label11.Text = "Date Out";
            // 
            // dtDateOut
            // 
            dtDateOut.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtDateOut.Location = new Point(850, 499);
            dtDateOut.Mask = "00/00/0000";
            dtDateOut.Name = "dtDateOut";
            dtDateOut.Size = new Size(164, 30);
            dtDateOut.TabIndex = 16;
            dtDateOut.ValidatingType = typeof(DateTime);
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.ForeColor = Color.Tomato;
            label10.Location = new Point(28, 485);
            label10.Name = "label10";
            label10.Size = new Size(66, 15);
            label10.TabIndex = 65;
            label10.Text = "Date Hired";
            // 
            // dtDateHired
            // 
            dtDateHired.CustomFormat = "MM-dd-yyyy";
            dtDateHired.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtDateHired.Format = DateTimePickerFormat.Custom;
            dtDateHired.Location = new Point(23, 499);
            dtDateHired.Name = "dtDateHired";
            dtDateHired.Size = new Size(199, 30);
            dtDateHired.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.Tomato;
            label9.Location = new Point(28, 558);
            label9.Name = "label9";
            label9.Size = new Size(106, 15);
            label9.TabIndex = 63;
            label9.Text = "Other Information";
            // 
            // txtOtherInformation
            // 
            txtOtherInformation.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtOtherInformation.Location = new Point(22, 569);
            txtOtherInformation.Multiline = true;
            txtOtherInformation.Name = "txtOtherInformation";
            txtOtherInformation.Size = new Size(1034, 58);
            txtOtherInformation.TabIndex = 17;
            // 
            // btnCaptureImage
            // 
            btnCaptureImage.BackColor = Color.Tomato;
            btnCaptureImage.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnCaptureImage.FlatStyle = FlatStyle.Flat;
            btnCaptureImage.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCaptureImage.Location = new Point(847, 182);
            btnCaptureImage.Name = "btnCaptureImage";
            btnCaptureImage.Size = new Size(200, 35);
            btnCaptureImage.TabIndex = 24;
            btnCaptureImage.Text = "Click Here to capture image";
            btnCaptureImage.UseVisualStyleBackColor = false;
            btnCaptureImage.Click += btnCaptureImage_Click;
            // 
            // btnStarCamera
            // 
            btnStarCamera.BackColor = Color.Tomato;
            btnStarCamera.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnStarCamera.FlatStyle = FlatStyle.Flat;
            btnStarCamera.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnStarCamera.Location = new Point(847, 141);
            btnStarCamera.Name = "btnStarCamera";
            btnStarCamera.Size = new Size(200, 35);
            btnStarCamera.TabIndex = 23;
            btnStarCamera.Text = "Start Camera";
            btnStarCamera.UseVisualStyleBackColor = false;
            btnStarCamera.TextChanged += btnStarCamera_TextChanged;
            btnStarCamera.Click += btnStarCamera_Click;
            // 
            // txtBrowseImage
            // 
            txtBrowseImage.BackColor = Color.Tomato;
            txtBrowseImage.FlatAppearance.BorderSize = 0;
            txtBrowseImage.FlatAppearance.MouseOverBackColor = Color.Teal;
            txtBrowseImage.FlatStyle = FlatStyle.Flat;
            txtBrowseImage.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBrowseImage.Location = new Point(847, 72);
            txtBrowseImage.Name = "txtBrowseImage";
            txtBrowseImage.Size = new Size(200, 35);
            txtBrowseImage.TabIndex = 22;
            txtBrowseImage.Text = "Browse Image";
            txtBrowseImage.UseVisualStyleBackColor = false;
            txtBrowseImage.Click += txtBrowseImage_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.download;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(512, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(313, 275);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 58;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.Tomato;
            label8.Location = new Point(29, 58);
            label8.Name = "label8";
            label8.Size = new Size(32, 15);
            label8.TabIndex = 57;
            label8.Text = "RFID";
            // 
            // txtRFID
            // 
            txtRFID.CharacterCasing = CharacterCasing.Upper;
            txtRFID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtRFID.ForeColor = Color.Maroon;
            txtRFID.Location = new Point(23, 72);
            txtRFID.Name = "txtRFID";
            txtRFID.Size = new Size(407, 33);
            txtRFID.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.Tomato;
            label7.Location = new Point(29, 9);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 55;
            label7.Text = "ID Number";
            // 
            // txtIDNumber
            // 
            txtIDNumber.CharacterCasing = CharacterCasing.Upper;
            txtIDNumber.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtIDNumber.ForeColor = Color.Brown;
            txtIDNumber.Location = new Point(23, 23);
            txtIDNumber.Name = "txtIDNumber";
            txtIDNumber.Size = new Size(314, 33);
            txtIDNumber.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.Tomato;
            label6.Location = new Point(30, 301);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 53;
            label6.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.Tomato;
            label5.Location = new Point(195, 255);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 52;
            label5.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.Tomato;
            label4.Location = new Point(29, 255);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 51;
            label4.Text = "Birthday";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Tomato;
            label3.Location = new Point(29, 205);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 50;
            label3.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Tomato;
            label2.Location = new Point(30, 155);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 49;
            label2.Text = "Middle Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Tomato;
            label1.Location = new Point(30, 108);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 48;
            label1.Text = "First Name";
            // 
            // txtAge
            // 
            txtAge.BackColor = Color.White;
            txtAge.CharacterCasing = CharacterCasing.Upper;
            txtAge.Enabled = false;
            txtAge.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtAge.Location = new Point(191, 269);
            txtAge.Multiline = true;
            txtAge.Name = "txtAge";
            txtAge.ReadOnly = true;
            txtAge.Size = new Size(82, 30);
            txtAge.TabIndex = 47;
            txtAge.KeyPress += txtAge_KeyPress;
            // 
            // dtBirthDay
            // 
            dtBirthDay.CustomFormat = "MM-dd-yyyy";
            dtBirthDay.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtBirthDay.Format = DateTimePickerFormat.Custom;
            dtBirthDay.Location = new Point(24, 269);
            dtBirthDay.Name = "dtBirthDay";
            dtBirthDay.Size = new Size(161, 30);
            dtBirthDay.TabIndex = 6;
            // 
            // txtAddress
            // 
            txtAddress.CharacterCasing = CharacterCasing.Upper;
            txtAddress.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(24, 315);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(801, 33);
            txtAddress.TabIndex = 7;
            // 
            // txtLastName
            // 
            txtLastName.CharacterCasing = CharacterCasing.Upper;
            txtLastName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(24, 219);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(406, 33);
            txtLastName.TabIndex = 5;
            // 
            // txtMiddleName
            // 
            txtMiddleName.CharacterCasing = CharacterCasing.Upper;
            txtMiddleName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtMiddleName.Location = new Point(24, 169);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(406, 33);
            txtMiddleName.TabIndex = 4;
            // 
            // txtFirstName
            // 
            txtFirstName.CharacterCasing = CharacterCasing.Upper;
            txtFirstName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.Location = new Point(24, 122);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(406, 33);
            txtFirstName.TabIndex = 3;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label17.ForeColor = Color.Tomato;
            label17.Location = new Point(240, 483);
            label17.Name = "label17";
            label17.Size = new Size(42, 15);
            label17.TabIndex = 83;
            label17.Text = "Assign";
            // 
            // cboAssign
            // 
            cboAssign.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAssign.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            cboAssign.FormattingEnabled = true;
            cboAssign.Location = new Point(232, 499);
            cboAssign.Name = "cboAssign";
            cboAssign.Size = new Size(377, 31);
            cboAssign.TabIndex = 14;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label18.ForeColor = Color.Tomato;
            label18.Location = new Point(313, 348);
            label18.Name = "label18";
            label18.Size = new Size(31, 15);
            label18.TabIndex = 85;
            label18.Text = "Rate";
            // 
            // txtPictureURL
            // 
            txtPictureURL.CharacterCasing = CharacterCasing.Upper;
            txtPictureURL.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPictureURL.ForeColor = Color.Brown;
            txtPictureURL.Location = new Point(512, 30);
            txtPictureURL.Multiline = true;
            txtPictureURL.Name = "txtPictureURL";
            txtPictureURL.Size = new Size(313, 33);
            txtPictureURL.TabIndex = 86;
            // 
            // lblPostedby
            // 
            lblPostedby.AutoSize = true;
            lblPostedby.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblPostedby.ForeColor = Color.Tomato;
            lblPostedby.Location = new Point(958, 642);
            lblPostedby.Name = "lblPostedby";
            lblPostedby.Size = new Size(56, 15);
            lblPostedby.TabIndex = 87;
            lblPostedby.Text = "postedby";
            lblPostedby.Visible = false;
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblid.ForeColor = Color.Tomato;
            lblid.Location = new Point(820, 630);
            lblid.Name = "lblid";
            lblid.Size = new Size(17, 15);
            lblid.TabIndex = 88;
            lblid.Text = "id";
            lblid.Visible = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label19.ForeColor = Color.Red;
            label19.Location = new Point(358, 6);
            label19.Name = "label19";
            label19.Size = new Size(88, 15);
            label19.TabIndex = 89;
            label19.Text = "Required Fields";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ForeColor = Color.Tomato;
            label20.Location = new Point(450, 6);
            label20.Name = "label20";
            label20.Size = new Size(18, 22);
            label20.TabIndex = 90;
            label20.Text = "*";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label21.ForeColor = Color.Red;
            label21.Location = new Point(2, 30);
            label21.Name = "label21";
            label21.Size = new Size(18, 22);
            label21.TabIndex = 91;
            label21.Text = "*";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label22.ForeColor = Color.Red;
            label22.Location = new Point(2, 79);
            label22.Name = "label22";
            label22.Size = new Size(18, 22);
            label22.TabIndex = 92;
            label22.Text = "*";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label23.ForeColor = Color.Red;
            label23.Location = new Point(3, 131);
            label23.Name = "label23";
            label23.Size = new Size(18, 22);
            label23.TabIndex = 93;
            label23.Text = "*";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label24.ForeColor = Color.Red;
            label24.Location = new Point(3, 223);
            label24.Name = "label24";
            label24.Size = new Size(18, 22);
            label24.TabIndex = 94;
            label24.Text = "*";
            // 
            // btnUpdate2
            // 
            btnUpdate2.BackColor = Color.RoyalBlue;
            btnUpdate2.FlatAppearance.BorderSize = 0;
            btnUpdate2.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            btnUpdate2.FlatStyle = FlatStyle.Flat;
            btnUpdate2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate2.ForeColor = Color.White;
            btnUpdate2.Location = new Point(571, 668);
            btnUpdate2.Name = "btnUpdate2";
            btnUpdate2.Size = new Size(159, 35);
            btnUpdate2.TabIndex = 95;
            btnUpdate2.Text = "Update";
            btnUpdate2.UseVisualStyleBackColor = false;
            btnUpdate2.Click += btnUpdate2_Click;
            // 
            // lblLoginName
            // 
            lblLoginName.AutoSize = true;
            lblLoginName.Location = new Point(881, 284);
            lblLoginName.Name = "lblLoginName";
            lblLoginName.Size = new Size(44, 15);
            lblLoginName.TabIndex = 96;
            lblLoginName.Text = "label25";
            lblLoginName.Visible = false;
            // 
            // btnAssignment
            // 
            btnAssignment.FlatAppearance.BorderSize = 0;
            btnAssignment.FlatAppearance.MouseOverBackColor = Color.LightSalmon;
            btnAssignment.FlatStyle = FlatStyle.Flat;
            btnAssignment.Location = new Point(232, 530);
            btnAssignment.Name = "btnAssignment";
            btnAssignment.Size = new Size(377, 24);
            btnAssignment.TabIndex = 97;
            btnAssignment.Text = "CLICK HERE TO ADD ASSIGNMENT";
            btnAssignment.UseVisualStyleBackColor = true;
            btnAssignment.Click += btnAssignment_Click;
            // 
            // btnDesignation
            // 
            btnDesignation.FlatAppearance.BorderSize = 0;
            btnDesignation.FlatAppearance.MouseOverBackColor = Color.LightSalmon;
            btnDesignation.FlatStyle = FlatStyle.Flat;
            btnDesignation.Location = new Point(22, 394);
            btnDesignation.Name = "btnDesignation";
            btnDesignation.Size = new Size(282, 22);
            btnDesignation.TabIndex = 98;
            btnDesignation.Text = "CLICK HERE TO ADD DESIGNATION";
            btnDesignation.UseVisualStyleBackColor = true;
            btnDesignation.Click += btnDesignation_Click;
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            cboCategory.FormattingEnabled = true;
            cboCategory.Items.AddRange(new object[] { "STAFF", "WORKER" });
            cboCategory.Location = new Point(22, 644);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(222, 31);
            cboCategory.TabIndex = 99;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label25.ForeColor = Color.Tomato;
            label25.Location = new Point(31, 628);
            label25.Name = "label25";
            label25.Size = new Size(57, 15);
            label25.TabIndex = 100;
            label25.Text = "Category";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label26.ForeColor = Color.Red;
            label26.Location = new Point(3, 649);
            label26.Name = "label26";
            label26.Size = new Size(18, 22);
            label26.TabIndex = 101;
            label26.Text = "*";
            // 
            // role
            // 
            role.AutoSize = true;
            role.Location = new Point(913, 333);
            role.Name = "role";
            role.Size = new Size(44, 15);
            role.TabIndex = 102;
            role.Text = "label25";
            role.Visible = false;
            role.TextChanged += role_TextChanged;
            // 
            // cboRate
            // 
            cboRate.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRate.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            cboRate.FormattingEnabled = true;
            cboRate.Items.AddRange(new object[] { "0" });
            cboRate.Location = new Point(313, 363);
            cboRate.Name = "cboRate";
            cboRate.Size = new Size(155, 31);
            cboRate.TabIndex = 9;
            // 
            // frmAddNewEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1068, 719);
            Controls.Add(cboRate);
            Controls.Add(role);
            Controls.Add(label26);
            Controls.Add(label25);
            Controls.Add(cboCategory);
            Controls.Add(btnDesignation);
            Controls.Add(btnAssignment);
            Controls.Add(lblLoginName);
            Controls.Add(btnUpdate2);
            Controls.Add(label24);
            Controls.Add(label23);
            Controls.Add(label22);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(lblid);
            Controls.Add(lblPostedby);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(cboAssign);
            Controls.Add(label16);
            Controls.Add(txtPagibig);
            Controls.Add(label15);
            Controls.Add(txtPhilhealthNumber);
            Controls.Add(label14);
            Controls.Add(txtSSSNumber);
            Controls.Add(label13);
            Controls.Add(cboDesignation);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(label12);
            Controls.Add(cboStatus);
            Controls.Add(label11);
            Controls.Add(dtDateOut);
            Controls.Add(label10);
            Controls.Add(dtDateHired);
            Controls.Add(label9);
            Controls.Add(txtOtherInformation);
            Controls.Add(btnCaptureImage);
            Controls.Add(btnStarCamera);
            Controls.Add(txtBrowseImage);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(txtRFID);
            Controls.Add(label7);
            Controls.Add(txtIDNumber);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAge);
            Controls.Add(dtBirthDay);
            Controls.Add(txtAddress);
            Controls.Add(txtLastName);
            Controls.Add(txtMiddleName);
            Controls.Add(txtFirstName);
            Controls.Add(txtPictureURL);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmAddNewEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EMPLOYEE";
            FormClosed += frmAddNewEmployee_FormClosed;
            Load += frmAddNewEmployee_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public ComboBox cboDesignation;
        public TextBox txtPagibig;
        public Label lblid;
        public Label label16;
        public Label label15;
        public TextBox txtPhilhealthNumber;
        public Label label14;
        public TextBox txtSSSNumber;
        public Label label13;
        public Label label12;
        public ComboBox cboStatus;
        public Label label11;
        public MaskedTextBox dtDateOut;
        public Label label10;
        public DateTimePicker dtDateHired;
        public Label label9;
        public TextBox txtOtherInformation;
        public Button btnCaptureImage;
        public Button btnStarCamera;
        public Button txtBrowseImage;
        public PictureBox pictureBox1;
        public Label label8;
        public TextBox txtRFID;
        public Label label7;
        public TextBox txtIDNumber;
        public Label label6;
        public Label label5;
        public Label label4;
        public Label label3;
        public Label label2;
        public Label label1;
        public TextBox txtAge;
        public DateTimePicker dtBirthDay;
        public TextBox txtAddress;
        public TextBox txtLastName;
        public TextBox txtMiddleName;
        public TextBox txtFirstName;
        public Label label17;
        public ComboBox cboAssign;
        public Label label18;
        public TextBox txtPictureURL;
        public Label lblPostedby;
        public Button btnCancel;
        public Button btnDelete;
        public Button btnUpdate;
        public Button btnSave;
        private OpenFileDialog openFileDialog1;
        public Label label19;
        public Label label20;
        public Label label21;
        public Label label22;
        public Label label23;
        public Label label24;
        public Button btnUpdate2;
        public Label lblLoginName;
        public ComboBox cboCategory;
        public Label label25;
        public Label label26;
        public Button btnAssignment;
        public Button btnDesignation;
        public Label role;
        public ComboBox cboRate;
    }
}