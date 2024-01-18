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


namespace AldoBuildersPayrollSystem.login
{
	public partial class frmLogin : Form
	{
		SqlConnection cn;
		SqlCommand cm;
		SqlDataReader dr;
		DBConnection db = new DBConnection();
		//	bool isactive;
		int idtbl;

		Form1 frm = new Form1();

		public frmLogin()
		{
			InitializeComponent();
			cn = new SqlConnection(db.GetConnection());
			this.KeyPreview = true;
		}

		private void btnEmployee_Click(object sender, EventArgs e)
		{

		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			txtUsername.Clear();
			txtPassword.Clear();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("EXIT APPLICATION?", "CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void frmLogin_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnLogin_Click(sender, e);
			}
			if (e.KeyCode == Keys.Escape)
			{
				if (MessageBox.Show("EXIT APPLICATION?", "CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					Application.Exit();
				}
			}
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{


			string _pass = "";
			string _username = "";
			string _role = "";
			string _name = "";
			string _section = "";
			string _designation = "";

			try
			{
				bool found = false;
				cn.Open();
				cm = new SqlCommand("SELECT * FROM tbllogin WHERE username = @username AND password = @password", cn);
				cm.Parameters.AddWithValue("@username", txtUsername.Text);
				cm.Parameters.AddWithValue("@password", txtPassword.Text);
				dr = cm.ExecuteReader();
				dr.Read();
				if (dr.HasRows)
				{
					found = true;
					idtbl = int.Parse(dr["iduser"].ToString());
					_username = dr["username"].ToString();
					_role = dr["role"].ToString();
					_name = dr["name"].ToString();
					//	_section = dr["section"].ToString();
					_designation = dr["designation"].ToString();
					_pass = dr["password"].ToString();
					//	isactive = bool.Parse(dr["isactive"].ToString());
				}
				else
				{
					found = false;

				}
				dr.Close();
				cn.Close();

				if (found == true)
				{
					//if (isactive == false)
					//{
					//	MessageBox.Show("Account is inactive. Unable to login", "Inactive Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					//	return;
					//}

					if (_role == "Owner")
					{
						MessageBox.Show("Welcome " + _name + "!", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
						txtPassword.Clear();
						txtUsername.Clear();
						this.Hide();

						//frm.lblName.Text = _name;
						//frm.lblUsername.Text = _username;
						//frm.lblPassword.Text = _pass;
						//frm.lblRole.Text = _role;
						frm.lblLoginName.Text = _name;
						frm.loginName.Text = "Logged in: " + _name;
						frm.lblLoginName.Text = _name;
						frm.role.Text = _role;
						frm.btnSettings.Enabled = true;
						frm.btnDashboard.Enabled = true;
						frm.btnBackup.Enabled = true;
						frm.btnHome.Enabled = true;
						frm.btnEmployee.Enabled = true;
						frm.btnPayroll.Enabled = true;
						frm.ShowDialog();
					}

					else if (_role == "Administrator")
					{

						MessageBox.Show("Welcome " + _name + "!", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
						txtPassword.Clear();
						txtUsername.Clear();
						this.Hide();

						//frm.lblName.Text = _name;
						//frm.lblUsername.Text = _username;
						//frm.lblPassword.Text = _pass;
						//frm.lblRole.Text = _role;
						frm.loginName.Text = "Logged in: " + _name;
						frm.lblLoginName.Text = _name;
						frm.role.Text = _role;
						frm.btnDashboard.Enabled = true;
						frm.btnBackup.Enabled = true;
						frm.btnHome.Enabled = true;
						frm.btnEmployee.Enabled = true;
						frm.btnPayroll.Enabled = true;
						frm.ShowDialog();

					}

					else if (_role == "User")
					{
						MessageBox.Show("Welcome " + _name + "!", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
						txtPassword.Clear();
						txtUsername.Clear();
						this.Hide();

						frm.loginName.Text = "Logged in: " + _name;
						frm.lblLoginName.Text = _name;
						frm.role.Text = _role;
						frm.btnHome.Enabled = true;
						frm.btnEmployee.Enabled = true;
						frm.btnBackup.Enabled = true;
						frm.btnPayroll.Enabled = true;
						frm.btnDashboard.Enabled = true;
						//LoadImage();
						frm.ShowDialog();

					}
					else
					{
						MessageBox.Show("Invalid username or password!", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
				}
				else
				{
					MessageBox.Show("Invalid username or password!", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			catch (Exception ex)
			{
				cn.Close();
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

		}

		private void frmLogin_Load(object sender, EventArgs e)
		{

		}
	}
}
