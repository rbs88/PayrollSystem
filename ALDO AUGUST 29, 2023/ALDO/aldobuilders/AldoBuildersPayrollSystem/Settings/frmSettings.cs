using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AldoBuildersPayrollSystem.Settings
{
	public partial class frmSettings : Form
	{
		private string selectedBackupFilePath = "";
		SqlConnection cn;
		SqlCommand cm;
		SqlDataReader dr;
		DBConnection db = new DBConnection();
		public frmSettings()
		{
			InitializeComponent();
			cn = new SqlConnection(db.GetConnection());
		}

		private void addNewDesignationToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void addNewProjectNameToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void modifyAndAddNewUserToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new login.frmAddUser();
			frm.TopLevel = false;
			panelUserLoad.Controls.Add(frm);
			//frm.LoadRecords();
			//frm.BringToFront();
			//frm.suser1 = suser;
			frm.Show();
		}

		private void restoreDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
		{

			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "Backup Files (*.bak)|*.bak";
				openFileDialog.FilterIndex = 1;
				openFileDialog.RestoreDirectory = true;

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					selectedBackupFilePath = openFileDialog.FileName;
					label1.Text = selectedBackupFilePath;

					// Set your SQL Server connection string
					//string connectionString = @"Data Source=DESKTOP-7KMTC5B;Initial Catalog=payrollsystemfinal;Integrated Security=True";
					//string connectionString = "Server=DESKTOP-7KMTC5B;Database=masterere;Integrated Security=True";
					//string connectionString = "Server=DESKTOP-7KMTC5B;Database=master;User Id=your_username;Password=your_password;";
					string connectionString = "Server=DESKTOP-7KMTC5B;Database=db123;Integrated Security=SSPI;";
					// Set the name for the new database
					string newDatabaseName = "db123";

					try
					{
						string script = $@"
                            USE master;
                            RESTORE DATABASE {newDatabaseName}
                            FROM DISK = N'{selectedBackupFilePath}'
                            WITH REPLACE;";
						
						using (SqlConnection connection = new SqlConnection(connectionString))
						{
							connection.Open();

							using (SqlCommand command = new SqlCommand(script, connection))
							{
								command.ExecuteNonQuery();
								MessageBox.Show("Database restored successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}
	}
}
