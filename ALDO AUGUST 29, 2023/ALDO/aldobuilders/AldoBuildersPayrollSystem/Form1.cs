using Microsoft.VisualBasic.Logging;
using System.Data.SqlClient;


namespace AldoBuildersPayrollSystem
{
	public partial class Form1 : Form
	{
		SqlConnection cn;
		SqlCommand cm;
		SqlDataReader dr;
		DBConnection db = new DBConnection();
		public Form1()
		{
			InitializeComponent();
			cn = new SqlConnection(db.GetConnection());
			Home();
		}

		private void btnEmployee_Click(object sender, EventArgs e)

		{
			var frm = new Employee.MasterList.frmMainEmployee();
			frm.lblLoginName.Text = lblLoginName.Text;
			frm.role.Text = role.Text;
			frm.ShowDialog();
		}

		private void btnPayroll_Click(object sender, EventArgs e)
		{
			var frm = new attendanceandpayroll.frmPayrollMain();
			frm.lblLoginName.Text = lblLoginName.Text;
			frm.role.Text = role.Text;
			frm.ShowDialog();
		}

		private void btnSettings_Click(object sender, EventArgs e)
		{
			var frm = new Settings.frmSettings();
			frm.TopLevel = false;
			panel3.Controls.Add(frm);
			//frm.LoadRecords();
			//frm.BringToFront();
			//frm.suser1 = suser	
			frm.Show();
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			var frm = new login.frmLogin();
			this.Close();
			frm.Show();
		}

		private void btnDashboard_Click(object sender, EventArgs e)
		{
			var frm = new Dashboard.frmDashboard();
			frm.TopLevel = false;
			panel3.Controls.Add(frm);
			//frm.LoadRecords();
			//frm.BringToFront();
			//frm.suser1 = suser;
			frm.Show();
		}

		private void btnHome_Click(object sender, EventArgs e)
		{
			Home();
		}

		private void Home()
		{
			var frm = new Home.frmHome();
			frm.TopLevel = false;
			panel3.Controls.Add(frm);
			//frm.LoadRecords();
			//frm.BringToFront();
			//frm.suser1 = suser;
			frm.Show();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Home();
		}

		private void btnBackup_Click(object sender, EventArgs e)
		{
			//string connectionString = "Server=your_server_name;Database=your_database_name;User Id=your_username;Password=your_password;";

			try
			{
				// Generate a unique backup file name with the current date and time
				string backupFileName = $"C:\\AldoReport\\Payrollsystemfinal{DateTime.Now: MM-dd-yyyy--HH-mm-ss}.bak";

				// Create a SqlConnection
				using (SqlConnection connection = new SqlConnection(cn.ConnectionString))
				{
					connection.Open();

					// Specify the backup query
					string backupQuery = $"BACKUP DATABASE Payrollsystemfinal TO DISK = '{backupFileName}'";

					// Create a SqlCommand with the backup query and the SqlConnection
					using (SqlCommand command = new SqlCommand(backupQuery, connection))
					{
						// Execute the backup query
						command.ExecuteNonQuery();
						MessageBox.Show($"Database backup completed successfully. Backup file: {backupFileName}");
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error: " + ex.Message);
			}
		}		
	}
}