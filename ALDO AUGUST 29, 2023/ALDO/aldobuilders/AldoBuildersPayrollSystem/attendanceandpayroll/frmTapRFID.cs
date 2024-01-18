using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Reflection.Emit;
using AldoBuildersPayrollSystem.Employee.MasterList;
using System.Threading;

namespace AldoBuildersPayrollSystem.attendanceandpayroll
{
    public partial class frmTapRFID : Form
    {
        SqlConnection cn;
        SqlCommand cm;
        SqlDataReader dr;
        DBConnection db = new DBConnection();
        public frmTapRFID()
        {
            InitializeComponent();
            cn = new SqlConnection(db.GetConnection());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblDate.Text = DateTime.Now.ToString("MMM/dd/yyy");
            lblDay.Text = DateTime.Now.ToString("dddd");
        }

        //public void LoadImageToPictureBox()
        //{

        //	cn.Open();
        //	cm = new SqlCommand("SELECT pictureURL FROM tblemployee WHERE idemployee = @idemployee", cn);
        //	cm.Parameters.AddWithValue("@idemployee", .Text); // replace 1 with the actual ID of the image you want to display
        //	string imageUrl = (string)cm.ExecuteScalar();
        //	// now you have the URL of the image in the 'imageUrl' variable

        //	string imagePath = Path.Combine(Application.StartupPath, imageUrl); // combine the startup path of your application with the image URL
        //	if (File.Exists(imagePath)) // check if the file exists
        //	{
        //		pictureBox1.ImageLocation = imagePath; // display the image in the PictureBox control
        //		cn.Close();
        //	}
        //	else
        //	{
        //		// MessageBox.Show("Image not found."); // display an error message if the file doesn't exist
        //	}
        //	cn.Close();
        //}

        public void AutoLoadTap()
        {

            try
            {
                string workSched = "";
                if (txtRFID.TextLength == 10)
                {
                    cn.Open();
                    cm = new SqlCommand("SELECT * FROM tblemployee WHERE idnumber LIKE @idnumber OR RFID LIKE @RFID", cn);
                    cm.Parameters.AddWithValue("@idnumber", txtRFID.Text);
                    cm.Parameters.AddWithValue("@RFID", txtRFID.Text);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        lblIDNO.Text = dr.GetValue(0).ToString();
                        lblIdnumber.Text = dr.GetValue(1).ToString();
                        lblFirstname.Text = dr.GetValue(3).ToString();
                        lblMiddlename.Text = dr.GetValue(4).ToString();
                        lblLastname.Text = dr.GetValue(5).ToString();
                        lblAssign.Text = dr.GetValue(17).ToString();
                        lblDesignation.Text = dr.GetValue(9).ToString();
                        lblNotFound.Visible = false;

                        dr.Close();
                        cn.Close();

                        cn.Open();
                        cm = new SqlCommand("SELECT pictureURL FROM tblemployee WHERE idemployee = @idemployee", cn);
                        cm.Parameters.AddWithValue("@idemployee", lblIDNO.Text); // replace 1 with the actual ID of the image you want to display
                        string imageUrl = (string)cm.ExecuteScalar();
                        // now you have the URL of the image in the 'imageUrl' variable

                        string imagePath = Path.Combine(Application.StartupPath, imageUrl); // combine the startup path of your application with the image URL
                        if (File.Exists(imagePath)) // check if the file exists
                        {
                            pictureBox2.ImageLocation = imagePath; // display the image in the PictureBox control
                            cn.Close();
                        }
                        else
                        {
                            // MessageBox.Show("Image not found."); // display an error message if the file doesn't exist
                        }

                        cn.Close();

                        if (lblOptions.Text == "AM ONLY")
                        {

                            //lblAM_IN.Text = "";
                            //lblAM_OUT.Text = "";
                            //lblPM_IN.Text = "";
                            //lblPM_OUT.Text = "";
                            //lblOT_IN.Text = "";
                            //lblOT_OUT.Text = "";
                            AttendanceAM(lblIDNO.Text, DateTime.Now.ToString("yyyy-MM-dd"), DateTime.Now.ToString("yyyy-MM-dd"));

                        }

                        else if (lblOptions.Text == "PM ONLY")
                        {
                            AttendancePM(lblIDNO.Text, DateTime.Now.ToString("yyyy-MM-dd"), DateTime.Now.ToString("yyyy-MM-dd"));
                        }

                        else if (lblOptions.Text == "OVERTIME ONLY")
                        {
                            AttendanceOT(lblIDNO.Text, DateTime.Now.ToString("yyyy-MM-dd"), DateTime.Now.ToString("yyyy-MM-dd"));
                        }

                    }
                    else
                    {
                        lblIdnumber.Text = "";
                        lblFirstname.Text = "";
                        lblMiddlename.Text = "";
                        lblLastname.Text = "";
                        lblAM_IN.Text = "";
                        lblAM_OUT.Text = "";
                        lblMessage.Text = "";
                        lblPM_IN.Text = "";
                        lblPM_OUT.Text = "";
                        lblOT_IN.Text = "";
                        lblNotFound.BringToFront();
                        lblNotFound.Visible = true;
                        lblNotFound.Text = "Not Found!";
                        pictureBox2.Image = Properties.Resources.download;
                        lblNotAllowed.Visible = false;
                        txtRFID.Focus();
                        txtRFID.SelectAll();
                        dr.Close();
                        cn.Close();
                    }

                    txtRFID.Focus();
                    txtRFID.SelectAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cn.Close();
            }
        }
        private void txtRFID_TextChanged(object sender, EventArgs e)
        {

            AutoLoadTap();
        }

        public void AttendanceAM(string idemployee, string date1, string date2)
        {
            try
            {
                string _AMtimein = "";
                string _AMtimeout = "";
                string _PMtimein = "";
                string _PMtimeout = "";

                TimeSpan DefaultValue = TimeSpan.Parse("00:00:00");
                TimeSpan ForLate = TimeSpan.Parse("07:00:00");
                TimeSpan ForLate1 = TimeSpan.Parse("07:01:00");

                TimeSpan FromTime = TimeSpan.Parse("11:31:00");
                TimeSpan ToTime = TimeSpan.Parse("12:30:00");

                TimeSpan AllowedTime = TimeSpan.Parse("9:00:00"); // before 9:00:00 allowed to time in
                TimeSpan AllowedToTime = TimeSpan.Parse("11:30:00");
                TimeSpan AllowedToTime2 = TimeSpan.Parse("10:30:00");

                TimeSpan now = DateTime.Now.TimeOfDay;

                int cid = 0;
                cn.Open();
                cm = new SqlCommand("SELECT idattendancepayroll,am_in,am_out,pm_in,pm_out,OT_IN,OT_OUT FROM tblAttendancePayroll WHERE idemployee=@idemployee AND(logdate BETWEEN @date1 and @date2)", cn);
                cm.Parameters.AddWithValue("@idemployee", idemployee);
                cm.Parameters.AddWithValue("@date1", date1);
                cm.Parameters.AddWithValue("@date2", date2);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {

                    TimeSpan timeSpan = (TimeSpan)dr["am_in"]; // 13:00 (1:00 PM)
                    string period = timeSpan.Hours < 12 ? "AM" : "PM"; // Determine AM or PM
                    int displayHours = timeSpan.Hours % 12; // Convert to 12-hour format
                    if (displayHours == 0)
                    {
                        displayHours = 12; // Handle 12 AM and 12 PM
                    }
                    _AMtimein = $"{displayHours}:{timeSpan.Minutes:00} {period}";

                    //	_AMtimein = dr["am_in"].ToString();

                    TimeSpan timeSpan1 = (TimeSpan)dr["am_out"]; // 13:00 (1:00 PM)
                    string period1 = timeSpan1.Hours < 12 ? "AM" : "PM"; // Determine AM or PM
                    int displayHours1 = timeSpan1.Hours % 12; // Convert to 12-hour format
                    if (displayHours1 == 0)
                    {
                        displayHours1 = 12; // Handle 12 AM and 12 PM
                    }

                    _AMtimeout = $"{displayHours1}:{timeSpan1.Minutes:00} {period1}";
                    //_AMtimeout = dr["am_out"].ToString();


                    _PMtimein = dr["pm_in"].ToString();
                    _PMtimeout = dr["pm_out"].ToString();

                    cid = int.Parse(dr["idattendancepayroll"].ToString());
                }
                dr.Close();
                cn.Close();

                //if (cid == 0 && _PMtimein == "" && now < AllowedTime)
                if (cid == 0 && _PMtimein == "" && (now >= ForLate1 && now < AllowedTime))
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblAttendancePayroll(idemployee,logdate,am_in,am_out,pm_in,pm_out,OT_IN,OT_OUT)VALUES(@idemployee,@logdate,@am_in,@am_out,@pm_in,@pm_out,@OT_IN,@OT_OUT)", cn);
                    cm.Parameters.AddWithValue("@idemployee", idemployee);
                    cm.Parameters.AddWithValue("@logdate", date1);
                    cm.Parameters.AddWithValue("@am_in", DateTime.Now.ToShortTimeString());
                    cm.Parameters.AddWithValue("@am_out", DefaultValue);
                    cm.Parameters.AddWithValue("@pm_in", DefaultValue);
                    cm.Parameters.AddWithValue("@pm_out", DefaultValue);
                    cm.Parameters.AddWithValue("@OT_IN", DefaultValue);
                    cm.Parameters.AddWithValue("@OT_OUT", DefaultValue);
                    //cm.Parameters.AddWithValue("@SHIFT", workSched);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    lblMessage.ForeColor = Color.Green;
                    lblMessage.BringToFront();
                    lblMessage.Text = "IN";
                    lbllate.Visible = true;
                    lbllate.ForeColor = Color.Red;
                    lbllate.Text = "You're late.";
                    lblAM_IN.Text = DateTime.Now.ToShortTimeString();
                    //label11.ForeColor = Color.Green;

                }

                else if (cid == 0 && _PMtimein == "" && (now <= ForLate && now < AllowedTime))
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblAttendancePayroll(idemployee,logdate,am_in,am_out,pm_in,pm_out,OT_IN,OT_OUT)VALUES(@idemployee,@logdate,@am_in,@am_out,@pm_in,@pm_out,@OT_IN,@OT_OUT)", cn);
                    cm.Parameters.AddWithValue("@idemployee", idemployee);
                    cm.Parameters.AddWithValue("@logdate", date1);
                    cm.Parameters.AddWithValue("@am_in", DateTime.Now.ToShortTimeString());
                    cm.Parameters.AddWithValue("@am_out", DefaultValue);
                    cm.Parameters.AddWithValue("@pm_in", DefaultValue);
                    cm.Parameters.AddWithValue("@pm_out", DefaultValue);
                    cm.Parameters.AddWithValue("@OT_IN", DefaultValue);
                    cm.Parameters.AddWithValue("@OT_OUT", DefaultValue);
                    //cm.Parameters.AddWithValue("@SHIFT", workSched);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    lblMessage.ForeColor = Color.Green;
                    lblMessage.BringToFront();
                    lblMessage.Text = "IN";
                    //lbllate.Visible = true;
                    //lbllate.ForeColor = Color.Red;
                    //lbllate.Text = "You're late.";
                    lblAM_IN.Text = DateTime.Now.ToShortTimeString();
                    //label11.ForeColor = Color.Green;

                }

                //Kung nakapag-in at gustong i verify kung nakapag in na ito || effected only before on or before 9:00AM
                else if (_AMtimein != "00:00:00" && now <= AllowedTime)
                {
                    lblNotAllowed.Visible = true;
                    lblNotAllowed.BringToFront();
                    lblNotAllowed.Text = " Nakapag Time-in kana";
                    lblAM_IN.Text = _AMtimein;
                }

                else if (cid == 0 && _AMtimein == "" && (now > AllowedTime && now < AllowedToTime2))
                {
                    lblNotAllowed.Visible = true;
                    lblNotAllowed.BringToFront();
                    lblNotAllowed.Text = "Not Allowed to time-in, Lagpas na alas 9:00AM, sa hapon na pwede mag time-in.";
                }

                else if (cid == 0 && _AMtimein == "" && now > AllowedToTime)
                {
                    lblNotAllowed.Visible = true;
                    lblNotAllowed.BringToFront();
                    lblNotAllowed.Text = "NO TIME-IN (Makipagkita sa checker)";
                }

                //For Out Only it only effect from 9:00:00am to 12:30PM
                else if (_AMtimein != "00:00:00" && _AMtimeout == "12:00 AM" && (now > AllowedTime && now < ToTime))
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblAttendancePayroll set am_out=@am_out  WHERE idattendancepayroll = @idattendancepayroll", cn);
                    cm.Parameters.AddWithValue("@am_out", DateTime.Now.ToShortTimeString());
                    cm.Parameters.AddWithValue("@idattendancepayroll", cid);
                    //cm.Parameters.AddWithValue("@SHIFT", workSched);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.BringToFront();
                    lblMessage.Text = "OUT";
                    lblAM_IN.Text = _AMtimein;
                    lblAM_OUT.Text = DateTime.Now.ToShortTimeString();
                }

                else if (_AMtimein != "00:00:00" && _AMtimeout != "12:00 AM" && (now > AllowedTime && now < ToTime))
                {
                    lblNotAllowed.Visible = true;
                    lblNotAllowed.BringToFront();
                    lblNotAllowed.Text = " Nakapag Time-out kana";
                    lblAM_IN.Text = _AMtimein;
                    lblAM_OUT.Text = _AMtimeout;
                }

                else
                {
                    lblNotAllowed.Visible = true;
                    lblNotAllowed.BringToFront();
                    lblNotAllowed.Text = "Not Allowed, Please check the time frame!";
                }
            }

            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void AttendancePM(string idemployee, string date1, string date2)

        {
            try
            {
                string _AMtimein = "";
                string _AMtimeout = "";
                string _PMtimein = "";
                string _PMtimeout = "";

                TimeSpan defaultValueTime = TimeSpan.Parse("00:00:00");
                TimeSpan TimePM_IN = TimeSpan.Parse("12:00:00");
                TimeSpan TimePM_OUT = TimeSpan.Parse("23:00:00");


                TimeSpan TimeTWO = TimeSpan.Parse("19:00:00");

                TimeSpan TimeValidate = TimeSpan.Parse("14:00:00");

                TimeSpan now = DateTime.Now.TimeOfDay;

                int cid = 0;
                cn.Open();
                cm = new SqlCommand("SELECT idattendancepayroll,am_in,am_out,pm_in,pm_out FROM tblAttendancePayroll WHERE idemployee=@idemployee AND(logdate BETWEEN @date1 and @date2)", cn);
                cm.Parameters.AddWithValue("@idemployee", idemployee);
                cm.Parameters.AddWithValue("@date1", date1);
                cm.Parameters.AddWithValue("@date2", date2);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {

                    TimeSpan timeSpan = (TimeSpan)dr["am_in"]; // 13:00 (1:00 PM)
                    string period = timeSpan.Hours < 12 ? "AM" : "PM"; // Determine AM or PM
                    int displayHours = timeSpan.Hours % 12; // Convert to 12-hour format
                    if (displayHours == 0)
                    {
                        displayHours = 12; // Handle 12 AM and 12 PM
                    }
                    _AMtimein = $"{displayHours}:{timeSpan.Minutes:00} {period}";

                    //_AMtimein = dr["am_in"].ToString();

                    TimeSpan timeSpan1 = (TimeSpan)dr["am_out"]; // 13:00 (1:00 PM)
                    string period1 = timeSpan1.Hours < 12 ? "AM" : "PM"; // Determine AM or PM
                    int displayHours1 = timeSpan1.Hours % 12; // Convert to 12-hour format
                    if (displayHours1 == 0)
                    {
                        displayHours1 = 12; // Handle 12 AM and 12 PM
                    }
                    _AMtimeout = $"{displayHours1}:{timeSpan1.Minutes:00} {period1}";

                    //_AMtimeout = dr["am_out"].ToString();

                    //_AMtimeout = dr["am_out"].ToString();

                    TimeSpan timeSpan2 = (TimeSpan)dr["pm_in"]; // 13:00 (1:00 PM)
                    string period2 = timeSpan2.Hours < 12 ? "AM" : "PM"; // Determine AM or PM
                    int displayHours2 = timeSpan2.Hours % 12; // Convert to 12-hour format
                    if (displayHours2 == 0)
                    {
                        displayHours2 = 12; // Handle 12 AM and 12 PM
                    }
                    _PMtimein = $"{displayHours2}:{timeSpan2.Minutes:00} {period2}";

                    //	_PMtimein = dr["pm_in"].ToString();


                    TimeSpan timeSpan3 = (TimeSpan)dr["pm_out"]; // 13:00 (1:00 PM)
                    string period3 = timeSpan3.Hours < 12 ? "AM" : "PM"; // Determine AM or PM
                    int displayHours3 = timeSpan3.Hours % 12; // Convert to 12-hour format
                    if (displayHours3 == 0)
                    {
                        displayHours3 = 12; // Handle 12 AM and 12 PM
                    }
                    _PMtimeout = $"{displayHours3}:{timeSpan3.Minutes:00} {period3}";

                    //_PMtimeout = dr["pm_out"].ToString();


                    cid = int.Parse(dr["idattendancepayroll"].ToString());
                }
                dr.Close();
                cn.Close();

                if (cid == 0 && (now >= TimePM_IN && now <= TimeValidate))
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblAttendancePayroll(idemployee,logdate,am_in,am_out,pm_in,pm_out,OT_IN,OT_OUT)VALUES(@idemployee,@logdate,@am_in,@am_out,@pm_in,@pm_out,@OT_IN,@OT_OUT)", cn);
                    cm.Parameters.AddWithValue("@idemployee", idemployee);
                    cm.Parameters.AddWithValue("@logdate", date1);
                    cm.Parameters.AddWithValue("@am_in", defaultValueTime);
                    cm.Parameters.AddWithValue("@am_out", defaultValueTime);
                    cm.Parameters.AddWithValue("@pm_in", DateTime.Now.ToShortTimeString());
                    cm.Parameters.AddWithValue("@pm_out", defaultValueTime);
                    cm.Parameters.AddWithValue("@OT_IN", defaultValueTime);
                    cm.Parameters.AddWithValue("@OT_OUT", defaultValueTime);

                    cm.ExecuteNonQuery();
                    cn.Close();
                    lblMessage.ForeColor = Color.Green;
                    lblMessage.BringToFront();
                    lblMessage.Text = "IN";
                    lblAM_IN.Text = _AMtimein;
                    lblAM_OUT.Text = _AMtimeout;
                    lblPM_IN.Text = DateTime.Now.ToShortTimeString();

                }

                //update PM TIME IN(note: Ito ay bago mag 2:00pm only)
                else if (_PMtimein == "12:00 AM" && (now >= TimePM_IN && now <= TimeValidate))
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblAttendancePayroll set pm_in=@pm_in  WHERE idattendancepayroll = @idattendancepayroll", cn);
                    cm.Parameters.AddWithValue("@pm_in", DateTime.Now.ToShortTimeString());
                    cm.Parameters.AddWithValue("@idattendancepayroll", cid);
                    //cm.Parameters.AddWithValue("@SHIFT", workSched);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    lblMessage.ForeColor = Color.Green;
                    lblMessage.BringToFront();
                    lblMessage.Text = "IN";
                    lblAM_IN.Text = _AMtimein;
                    lblAM_OUT.Text = _AMtimeout;
                    lblPM_IN.Text = DateTime.Now.ToShortTimeString();
                }

                //Nakapag -in na pero gustong magverify kung naka-In naba tagalog(note: ito ay hanggang 14:00:00 PM only)
                else if (_PMtimein != "12:00 AM" && _PMtimeout == "12:00 AM" && (now >= TimePM_IN && now <= TimeValidate))
                {
                    lblNotAllowed.Visible = true;
                    lblNotAllowed.BringToFront();
                    lblNotAllowed.Text = " Nakapag PM Time-in kana";
                    lblAM_IN.Text = _AMtimein;
                    lblAM_OUT.Text = _AMtimeout;
                    lblPM_IN.Text = _PMtimein;
                }

                //For PM out only ( from 14:00 PM to 19:00 PM)
                else if (_PMtimein != "12:00 AM" && _PMtimeout == "12:00 AM" && (now > TimeValidate && now <= TimePM_OUT))
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblAttendancePayroll set pm_out=@pm_out  WHERE idattendancepayroll = @idattendancepayroll", cn);
                    cm.Parameters.AddWithValue("@pm_out", DateTime.Now.ToShortTimeString());
                    cm.Parameters.AddWithValue("@idattendancepayroll", cid);
                    //cm.Parameters.AddWithValue("@SHIFT", workSched);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.BringToFront();
                    lblMessage.Text = "OUT";
                    lblAM_IN.Text = _AMtimein;
                    lblAM_OUT.Text = _AMtimeout;
                    lblPM_IN.Text = _PMtimein;
                    lblPM_OUT.Text = DateTime.Now.ToShortTimeString();
                }

                else if (_PMtimein != "12:00 AM" && _PMtimeout != "12:00 AM" && (now >= TimePM_IN && now <= TimePM_OUT))
                {
                    lblNotAllowed.Visible = true;
                    lblNotAllowed.BringToFront();
                    lblNotAllowed.Text = " Nakapag PM Time-out kana";
                    lblAM_IN.Text = _AMtimein;
                    lblAM_OUT.Text = _AMtimeout;
                    lblPM_IN.Text = _PMtimein;
                    lblPM_OUT.Text = _PMtimeout;
                }

                else
                {
                    lblNotAllowed.Visible = true;
                    lblNotAllowed.BringToFront();
                    lblNotAllowed.Text = "Not Allowed, Please check the time frame!";
                }
            }

            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        public void AttendanceOT(string idemployee, string date1, string date2)

        {
            try
            {
                string _AMtimein = "";
                string _AMtimeout = "";
                string _PMtimein = "";
                string _PMtimeout = "";
                string _OTtimein = "";
                string _OTtimeout = "";


                TimeSpan OTTimeINValidation = TimeSpan.Parse("16:00:00");
                TimeSpan OTTimeINUntilValidation = TimeSpan.Parse("23:30:00");
                TimeSpan OTTimeOUTValidation = TimeSpan.Parse("19:30:00");
                TimeSpan OTTimeoutFromValidation = TimeSpan.Parse("18:00:00");
                TimeSpan ValidateIFAlreadyIN = TimeSpan.Parse("18:30:00");


                TimeSpan now = DateTime.Now.TimeOfDay;

                int cid = 0;
                cn.Open();
                cm = new SqlCommand("SELECT idattendancepayroll,am_in,am_out,pm_in,pm_out,OT_IN,OT_OUT FROM tblAttendancePayroll WHERE idemployee=@idemployee AND(logdate BETWEEN @date1 and @date2)", cn);
                cm.Parameters.AddWithValue("@idemployee", idemployee);
                cm.Parameters.AddWithValue("@date1", date1);
                cm.Parameters.AddWithValue("@date2", date2);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {

                    TimeSpan timeSpan = (TimeSpan)dr["am_in"]; // 13:00 (1:00 PM)
                    string period = timeSpan.Hours < 12 ? "AM" : "PM"; // Determine AM or PM
                    int displayHours = timeSpan.Hours % 12; // Convert to 12-hour format
                    if (displayHours == 0)
                    {
                        displayHours = 12; // Handle 12 AM and 12 PM
                    }
                    _AMtimein = $"{displayHours}:{timeSpan.Minutes:00} {period}";

                    //	_AMtimein = dr["am_in"].ToString();

                    TimeSpan timeSpan1 = (TimeSpan)dr["am_out"]; // 13:00 (1:00 PM)
                    string period1 = timeSpan1.Hours < 12 ? "AM" : "PM"; // Determine AM or PM
                    int displayHours1 = timeSpan1.Hours % 12; // Convert to 12-hour format
                    if (displayHours1 == 0)
                    {
                        displayHours1 = 12; // Handle 12 AM and 12 PM
                    }
                    _AMtimeout = $"{displayHours1}:{timeSpan1.Minutes:00} {period1}";

                    //	_AMtimeout = dr["am_out"].ToString();

                    //	_AMtimeout = dr["am_out"].ToString();

                    TimeSpan timeSpan2 = (TimeSpan)dr["pm_in"]; // 13:00 (1:00 PM)
                    string period2 = timeSpan2.Hours < 12 ? "AM" : "PM"; // Determine AM or PM
                    int displayHours2 = timeSpan2.Hours % 12; // Convert to 12-hour format
                    if (displayHours2 == 0)
                    {
                        displayHours2 = 12; // Handle 12 AM and 12 PM
                    }
                    _PMtimein = $"{displayHours2}:{timeSpan2.Minutes:00} {period2}";

                    //_PMtimein = dr["pm_in"].ToString();

                    TimeSpan timeSpan3 = (TimeSpan)dr["pm_out"]; // 13:00 (1:00 PM)
                    string period3 = timeSpan3.Hours < 12 ? "AM" : "PM"; // Determine AM or PM
                    int displayHours3 = timeSpan3.Hours % 12; // Convert to 12-hour format
                    if (displayHours3 == 0)
                    {
                        displayHours3 = 12; // Handle 12 AM and 12 PM
                    }
                    _PMtimeout = $"{displayHours3}:{timeSpan3.Minutes:00} {period3}";

                    //	_PMtimeout = dr["pm_out"].ToString();



                    TimeSpan timeSpan4 = (TimeSpan)dr["OT_IN"]; // 13:00 (1:00 PM)
                    string period4 = timeSpan4.Hours < 12 ? "AM" : "PM"; // Determine AM or PM
                    int displayHours4 = timeSpan4.Hours % 12; // Convert to 12-hour format
                    if (displayHours4 == 0)
                    {
                        displayHours4 = 12; // Handle 12 AM and 12 PM
                    }
                    _OTtimein = $"{displayHours4}:{timeSpan4.Minutes:00} {period4}";

                    //_OTtimein = dr["OT_IN"].ToString();


                    TimeSpan timeSpan5 = (TimeSpan)dr["OT_OUT"]; // 13:00 (1:00 PM)
                    string period5 = timeSpan5.Hours < 12 ? "AM" : "PM"; // Determine AM or PM
                    int displayHours5 = timeSpan5.Hours % 12; // Convert to 12-hour format
                    if (displayHours5 == 0)
                    {
                        displayHours5 = 12; // Handle 12 AM and 12 PM
                    }
                    _OTtimeout = $"{displayHours5}:{timeSpan5.Minutes:00} {period5}";
                    //_OTtimeout = dr["OT_OUT"].ToString();

                    cid = int.Parse(dr["idattendancepayroll"].ToString());
                }
                dr.Close();
                cn.Close();


                if (_PMtimeout != "12:00 AM" && _OTtimein == "12:00 AM" && (now >= OTTimeINValidation && now <= OTTimeINUntilValidation))
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblAttendancePayroll set OT_IN=@OT_IN  WHERE idattendancepayroll = @idattendancepayroll", cn);
                    cm.Parameters.AddWithValue("@OT_IN", DateTime.Now.ToShortTimeString());
                    cm.Parameters.AddWithValue("@idattendancepayroll", cid);
                    //cm.Parameters.AddWithValue("@SHIFT", workSched);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    lblMessage.ForeColor = Color.Green;
                    lblMessage.BringToFront();
                    lblMessage.Text = "IN";
                    lblAM_IN.Text = _AMtimein;
                    lblAM_OUT.Text = _AMtimeout;
                    lblPM_IN.Text = _PMtimein;
                    lblPM_OUT.Text = _PMtimeout;
                    lblOT_IN.Text = DateTime.Now.ToShortTimeString();
                }

                else if (_OTtimein != "12:00 AM" && _OTtimeout == "12:00 AM" && (now >= OTTimeINValidation && now <= ValidateIFAlreadyIN))
                {
                    lblNotAllowed.Visible = true;
                    lblNotAllowed.BringToFront();
                    lblNotAllowed.Text = " Nakapag OT Time-in kana";
                    lblAM_IN.Text = _AMtimein;
                    lblAM_OUT.Text = _AMtimeout;
                    lblPM_IN.Text = _PMtimein;
                    lblPM_OUT.Text = _PMtimeout;
                    lblOT_IN.Text = _OTtimein;
                }

                else if (_OTtimein != "12:00 AM" && _OTtimeout == "12:00 AM" && (now >= OTTimeoutFromValidation && now <= OTTimeINUntilValidation))
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblAttendancePayroll set OT_OUT=@OT_OUT  WHERE idattendancepayroll = @idattendancepayroll", cn);
                    cm.Parameters.AddWithValue("@OT_OUT", DateTime.Now.ToShortTimeString());
                    cm.Parameters.AddWithValue("@idattendancepayroll", cid);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.BringToFront();
                    lblMessage.Text = "OUT";
                    lblAM_IN.Text = _AMtimein;
                    lblAM_OUT.Text = _AMtimeout;
                    lblPM_IN.Text = _PMtimein;
                    lblPM_OUT.Text = _PMtimeout;
                    lblOT_IN.Text = _OTtimein;
                    lblOT_OUT.Text = DateTime.Now.ToShortTimeString();
                }

                else if (_OTtimein != "12:00 AM" && _OTtimeout != "12:00 AM" && (now >= OTTimeoutFromValidation && now <= OTTimeINUntilValidation))
                {
                    lblNotAllowed.Visible = true;
                    lblNotAllowed.BringToFront();
                    lblNotAllowed.Text = " Nakapag OT Time-out kana";
                    lblAM_IN.Text = _AMtimein;
                    lblAM_OUT.Text = _AMtimeout;
                    lblPM_IN.Text = _PMtimein;
                    lblPM_OUT.Text = _PMtimeout;
                    lblOT_IN.Text = _OTtimein;
                    lblOT_OUT.Text = _OTtimeout;
                }

                else
                {
                    lblNotAllowed.Visible = true;
                    lblNotAllowed.BringToFront();
                    lblNotAllowed.Text = "Please check allowed time to IN or OUT";
                }
            }

            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
