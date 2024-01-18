using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using AForge.Video;
using AForge.Video.DirectShow;
using System.IO;
using System.Drawing.Imaging;
using AldoBuildersPayrollSystem.Employee.InActiveMasterlist;
using Microsoft.ReportingServices.Diagnostics.Internal;
using System.Collections;

namespace AldoBuildersPayrollSystem.Employee.MasterList
{
    public partial class frmAddNewEmployee : Form
    {
        VideoCaptureDevice videoDevice = null;
        SqlConnection cn;
        SqlCommand cm;
        SqlDataReader dr;
        DBConnection db = new DBConnection();
        frmMainEmployeeLoadRecord f;
        frmInactiveMasterList B;
        DataTable dt;

        string _title = "Aldo Builders";
        public frmAddNewEmployee(frmMainEmployeeLoadRecord f, frmInactiveMasterList B)
        {
            InitializeComponent();
            cn = new SqlConnection(db.GetConnection());
            LoadAssignmentToCombo();
            LoadDesignationToCombo();
            this.f = f;
            this.B = B;
        }
        public void LoadAssignmentToCombo()
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT Assignment FROM tblAssignment ORDER BY Assignment", cn);
                dr = cm.ExecuteReader();

                // Clear existing items in the ComboBox, if any
                cboAssign.Items.Clear();

                // Iterate through the data and add it to the ComboBox
                while (dr.Read())
                {
                    cboAssign.Items.Add(dr["Assignment"].ToString());
                }

                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cn.Close();
            }
        }

        public void LoadDesignationToCombo()
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT Designation,rate FROM tblDesignation ORDER BY Designation,rate", cn);
                dr = cm.ExecuteReader();

                // Clear existing items in the ComboBox, if any
                cboDesignation.Items.Clear();

                // Iterate through the data and add it to the ComboBox
                while (dr.Read())
                {
                    cboDesignation.Items.Add(dr["Designation"].ToString());
                    cboRate.Items.Add(dr["rate"].ToString());
                }

                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cn.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Save a record to database
            try
            {
                if (txtFirstName.Text == string.Empty || txtLastName.Text == string.Empty || txtRFID.Text == string.Empty || txtIDNumber.Text == string.Empty || cboCategory.Text == string.Empty)
                {
                    MessageBox.Show("REQUIRED MISSING FIELDS", _title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
                if (MessageBox.Show("ADD NEW RECORD? CLICK YES TO CONFIRM", _title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblemployee (idnumber,RFID,firstname,middlename,lastname,birthday,address,designation,rate,sssnumber,philhealth,pagibig,datehired,dateout,status,assign,pictureURL,otherinformation,postedby,Category)VALUES(@idnumber,@RFID,@firstname,@middlename,@lastname,@birthday,@address,@designation,@rate,@sssnumber,@philhealth,@pagibig,@datehired,@dateout,@status,@assign,@pictureURL,@otherinformation,@postedby,@Category)", cn);
                    cm.Parameters.AddWithValue("@idnumber", txtIDNumber.Text);
                    cm.Parameters.AddWithValue("@RFID", txtRFID.Text);
                    cm.Parameters.AddWithValue("@firstname", txtFirstName.Text);
                    cm.Parameters.AddWithValue("@middlename", txtMiddleName.Text);
                    cm.Parameters.AddWithValue("@lastname", txtLastName.Text);
                    cm.Parameters.AddWithValue("@birthday", DateTime.Parse(dtBirthDay.Text));
                    //cm.Parameters.AddWithValue("@age", txtCivilStatus.Text);
                    cm.Parameters.AddWithValue("@address", txtAddress.Text);
                    cm.Parameters.AddWithValue("@designation", cboDesignation.Text);
                    cm.Parameters.AddWithValue("@rate", cboRate.Text);
                    cm.Parameters.AddWithValue("@sssnumber", txtSSSNumber.Text);
                    cm.Parameters.AddWithValue("@philhealth", txtPhilhealthNumber.Text);
                    cm.Parameters.AddWithValue("@pagibig", txtPagibig.Text);
                    cm.Parameters.AddWithValue("@datehired", DateTime.Parse(dtDateHired.Text));
                    cm.Parameters.AddWithValue("@dateout", dtDateOut.Text);
                    cm.Parameters.AddWithValue("@status", cboStatus.Text);
                    cm.Parameters.AddWithValue("@assign", cboAssign.Text);
                    cm.Parameters.AddWithValue("@pictureURL", txtPictureURL.Text);
                    cm.Parameters.AddWithValue("@otherinformation", txtOtherInformation.Text);
                    cm.Parameters.AddWithValue("@postedby", lblLoginName.Text);
                    cm.Parameters.AddWithValue("@Category", cboCategory.Text);

                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("RECORD HAS BEEN SUCCESSFULLY SAVED", _title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    f.LoadRecords();
                }

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, _title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        public void LoadImageToPictureBox()
        {

            cn.Open();
            cm = new SqlCommand("SELECT pictureURL FROM tblemployee WHERE idemployee = @idemployee", cn);
            cm.Parameters.AddWithValue("@idemployee", lblid.Text); // replace 1 with the actual ID of the image you want to display
            string imageUrl = (string)cm.ExecuteScalar();
            // now you have the URL of the image in the 'imageUrl' variable

            string imagePath = Path.Combine(Application.StartupPath, imageUrl); // combine the startup path of your application with the image URL
            if (File.Exists(imagePath)) // check if the file exists
            {
                pictureBox1.ImageLocation = imagePath; // display the image in the PictureBox control
                cn.Close();
            }
            else
            {
                // MessageBox.Show("Image not found."); // display an error message if the file doesn't exist
            }
            cn.Close();
        }

        private void Clear()
        {

            txtIDNumber.Clear();
            txtRFID.Clear();
            txtFirstName.Clear();
            txtMiddleName.Clear();
            txtLastName.Clear();
            txtAge.Clear();
            txtAddress.Clear();
            cboDesignation.ResetText();
            cboRate.ResetText();
            txtSSSNumber.Clear();
            txtPhilhealthNumber.Clear();
            txtPagibig.Clear();
            dtDateOut.Clear();
            cboStatus.ResetText();
            cboAssign.ResetText();
            txtPictureURL.Clear();
            txtOtherInformation.Clear();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Delete Record
            if (MessageBox.Show("YOU WANT TO DELETE THIS RECORD? CLICK YES TO CONFIRM", _title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cm = new SqlCommand("DELETE FROM tblemployee WHERE idemployee = '" + lblid.Text + "'", cn);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("RECORD HAS BEEN SUCCESSFULL DELETED", _title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                f.LoadRecords();
                // Clear();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateRecord();
            f.LoadRecords();
        }

        public void UpdateRecord()
        {
            try
            {

                if (MessageBox.Show("UPDATE THIS RECORD? CLICK YES TO CONFIRM", _title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    //UPDATE RECORDS
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblemployee SET idnumber = @idnumber, RFID =@RFID, firstname=@firstname, middlename=@middlename, lastname =@lastname, birthday=@birthday, age=@age, address=@address, designation=@designation, rate=@rate, sssnumber=@sssnumber, philhealth=@philhealth, pagibig=@pagibig, datehired=@datehired, dateout=@dateout, status=@status, assign=@assign, pictureURL=@pictureURL, otherinformation=@otherinformation, postedby=@postedby, Category=@Category WHERE idemployee = @idemployee", cn);
                    cm.Parameters.AddWithValue("@idemployee", lblid.Text);
                    cm.Parameters.AddWithValue("@idnumber", txtIDNumber.Text);
                    cm.Parameters.AddWithValue("@RFID", txtRFID.Text);
                    cm.Parameters.AddWithValue("@firstname", txtFirstName.Text);
                    cm.Parameters.AddWithValue("@middlename", txtMiddleName.Text);
                    cm.Parameters.AddWithValue("@lastname", txtLastName.Text);
                    cm.Parameters.AddWithValue("@birthday", DateTime.Parse(dtBirthDay.Text));
                    cm.Parameters.AddWithValue("@age", txtAge.Text);
                    cm.Parameters.AddWithValue("@address", txtAddress.Text);
                    cm.Parameters.AddWithValue("@designation", cboDesignation.Text);
                    cm.Parameters.AddWithValue("@rate", cboRate.Text);
                    cm.Parameters.AddWithValue("@sssnumber", txtSSSNumber.Text);
                    cm.Parameters.AddWithValue("@philhealth", txtPhilhealthNumber.Text);
                    cm.Parameters.AddWithValue("@pagibig", txtPagibig.Text);
                    cm.Parameters.AddWithValue("@datehired", DateTime.Parse(dtDateHired.Text));
                    cm.Parameters.AddWithValue("@dateout", dtDateOut.Text);
                    cm.Parameters.AddWithValue("@status", cboStatus.Text);
                    cm.Parameters.AddWithValue("@assign", cboAssign.Text);
                    cm.Parameters.AddWithValue("@pictureURL", txtPictureURL.Text);
                    cm.Parameters.AddWithValue("@otherinformation", txtOtherInformation.Text);
                    cm.Parameters.AddWithValue("@postedby", lblLoginName.Text);
                    cm.Parameters.AddWithValue("@Category", cboCategory.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("RECORD HAS BEEN SUCCESSFULLY UPDATED", _title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    //Clear();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, _title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cboRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void videoDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //Update the PictureBox control with the latest captured image
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        public void EnableAndDisableCapture()
        {
            if (btnStarCamera.Text == "Start Camera")
            {
                btnCaptureImage.Enabled = false;
            }
            else
            {
                btnCaptureImage.Enabled = true;
            }
        }

        private void btnStarCamera_Click(object sender, EventArgs e)
        {
            if (videoDevice == null)
            {
                // Get the first video capture device found
                FilterInfoCollection videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                if (videoDevices.Count > 0)
                {
                    videoDevice = new VideoCaptureDevice(videoDevices[0].MonikerString);
                    videoDevice.NewFrame += new NewFrameEventHandler(videoDevice_NewFrame);
                    videoDevice.Start();
                    btnStarCamera.Text = "Stop Camera";
                }
            }
            else
            {
                videoDevice.SignalToStop();
                videoDevice.WaitForStop();
                videoDevice = null;
                btnStarCamera.Text = "Start Camera";
            }
        }

        private void btnCaptureImage_Click(object sender, EventArgs e)
        {
            // string filePath;
            // Create a new bitmap from the PictureBox control
            Bitmap bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            pictureBox1.DrawToBitmap(bitmap, pictureBox1.ClientRectangle);

            videoDevice.SignalToStop();
            videoDevice.WaitForStop();
            videoDevice = null;
            btnStarCamera.Text = "Start Camera";

            if (MessageBox.Show("SAVE IMAGE? CLICK YES TO CONFIRM", "Barangay Certificate", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Save the bitmap to a file in a folder
                string folderPath = "C:\\Images\\";
                // string folderPath = @"\\DESKTOP-7KMTC5B\Images";
                //string folderPath = @"\\192.168.1.1\Images";
                string fileName = Guid.NewGuid().ToString() + ".jpg";
                string filePath = Path.Combine(folderPath, fileName);
                bitmap.Save(filePath, ImageFormat.Jpeg);
                txtPictureURL.Text = filePath;

                MessageBox.Show("Image saved to " + filePath + " and URL saved to SQL Server database");

                //videoDevice.SignalToStop();
                //videoDevice.WaitForStop();
                //videoDevice = null;
                //btnCamera.Text = "Start Camera";
            }
        }

        private void txtBrowseImage_Click(object sender, EventArgs e)
        {

            try
            {
                openFileDialog1.Filter = "Image files (*.png) |*.png|(*.jpg)|*.jpg|(*.gif)|*.gif";
                openFileDialog1.ShowDialog();
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);

                Bitmap bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
                pictureBox1.DrawToBitmap(bitmap, pictureBox1.ClientRectangle);


                //	if (MessageBox.Show("SAVE IMAGE? CLICK YES TO CONFIRM", "Barangay Certificate", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                //	{
                // Save the bitmap to a file in a folder
                string folderPath = "C:\\Images\\";
                // string folderPath = @"\\DESKTOP-7KMTC5B\Images";
                //string folderPath = @"\\192.168.1.1\Images";
                string fileName = Guid.NewGuid().ToString() + ".jpg";
                string filePath = Path.Combine(folderPath, fileName);
                bitmap.Save(filePath, ImageFormat.Jpeg);
                txtPictureURL.Text = filePath;

                //	MessageBox.Show("Image saved to " + filePath + " and URL saved to SQL Server database");
                //}
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            //try
            //{
            //	OpenFileDialog open = new OpenFileDialog();
            //	open.InitialDirectory = "C:\\";
            //	open.Filter = "Image Files(*.jpg)|*.jpg";
            //	//open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png; *.ico)|*.jpg; *.jpeg; *.gif; *.bmp; *.png; *.ico";
            //	//open.Filter = "Word Documents|*.docx;*.doc|Excel Worksheets|*.xlsx;*.xls|PowerPoint Presentations|*.pptx;*.ppt" + "|Office Files|*.docx;*.xlsx;*.pptx;*.doc;*.xls;*.ppt";
            //	// open.Filter = "Office Files|*.docx;*.xlsx;*.pptx;*.doc;*.xls;*.ppt;*.pdf" + "|Word Documents|*.docx;*.doc|Excel Worksheets|*.xlsx;*.xls|PowerPoint Presentations|*.pptx;*.ppt";
            //	open.FilterIndex = 1;

            //	if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //	{
            //		if (open.CheckFileExists)
            //		{
            //			// string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 0));
            //			// string paths = Application.StartupPath + @"Images";
            //			// string paths = "//ADMIN-PC/Image";
            //			// string paths = db.CentralizedPathsSave();
            //			// string paths = "//SSVR/OFS$"; // Save to Server
            //			string paths = "C:\\Images";
            //			string CorrectFilename = System.IO.Path.GetFileName(open.FileName);
            //			System.IO.File.Copy(open.FileName, paths + "\\Images\\" + CorrectFilename);
            //			//pictureBox.Image = new Bitmap(open.FileName);
            //			txtPictureURL.Text = "\\" + "\\Images\\" + "\\" + CorrectFilename;
            //			//  MessageBox.Show("Files ready to backup");
            //		}
            //		//  }
            //	}
            //}
            //catch (Exception)
            //{
            //	MessageBox.Show("File already exists.'Rename your file'", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

        }

        private void frmAddNewEmployee_Load(object sender, EventArgs e)
        {
            EnableAndDisableCapture();
        }

        private void frmAddNewEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (videoDevice == null)
            {
                // Get the first video capture device found
                FilterInfoCollection videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                if (videoDevices.Count > 0)
                {
                    videoDevice = new VideoCaptureDevice(videoDevices[0].MonikerString);
                    videoDevice.NewFrame += new NewFrameEventHandler(videoDevice_NewFrame);
                    videoDevice.Stop();
                    btnStarCamera.Text = "Stop Camera";
                }
            }
            else
            {
                videoDevice.SignalToStop();
                videoDevice.WaitForStop();
                videoDevice = null;
                btnStarCamera.Text = "Start Camera";
            }
        }

        private void btnStarCamera_TextChanged(object sender, EventArgs e)
        {
            if (btnStarCamera.Text == "Start Camera")
            {
                btnCaptureImage.Enabled = false;
            }
            else
            {
                btnCaptureImage.Enabled = true;
            }
        }

        private void btnUpdate2_Click(object sender, EventArgs e)
        {
            UpdateRecord();
            B.LoadRecords();
        }

        private void btnAssignment_Click(object sender, EventArgs e)
        {
            var frm = new MasterList.frmAssignment(this);
            frm.ShowDialog();
        }

        private void btnDesignation_Click(object sender, EventArgs e)
        {
            var frm = new MasterList.frmDesignation(this);
            frm.ShowDialog();
        }

        private void role_TextChanged(object sender, EventArgs e)
        {
            if (role.Text == "Administrator")
            {
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
            }
            else if (role.Text == "Owner")
            {
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
            }
        }

        private void cboDesignation_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
