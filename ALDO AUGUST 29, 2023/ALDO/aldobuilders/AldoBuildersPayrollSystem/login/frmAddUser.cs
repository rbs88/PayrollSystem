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

namespace AldoBuildersPayrollSystem.login
{
	public partial class frmAddUser : Form
	{
		SqlConnection cn;
		SqlCommand cm;
		SqlDataReader dr;
		DBConnection db = new DBConnection();

		DataTable dt;
		public frmAddUser()
		{
			InitializeComponent();
			cn = new SqlConnection(db.GetConnection());

		}

		private void btnShowUser_Click(object sender, EventArgs e)
		{
			LoadRecords();
		}

		//public void LoadRecords()
		//{
		//	//Load Records to datagridview
		//	try
		//	{
		//		cn.Open();
		//		cm = new SqlCommand("SELECT iduser,username as Username,Password,firstname as FIRSTNAME,middlename as MIDDLENAME,lastname as LASTNAME,birthday as BIRTHDAY,age as AGE,address as ADDRESS,designation,rate,sssnumber,philhealth,pagibig,datehired,dateout,status,assign,pictureURL,otherinformation,postedby FROM tblemployee WHERE status = 'ACTIVE' ORDER BY lastname", cn);

		//		SqlDataAdapter sda = new SqlDataAdapter();
		//		sda.SelectCommand = cm;
		//		dt = new DataTable();
		//		sda.Fill(dt);
		//		BindingSource bSource = new BindingSource();
		//		bSource.DataSource = dt;
		//		dataGridView1.DataSource = bSource;
		//		sda.Update(dt);
		//		cn.Close();
		//	}
		//	catch (Exception ex)
		//	{
		//		MessageBox.Show(ex.Message);
		//		cn.Close();
		//	}
		//	// DatagridviewModify();
		//}

		public void LoadRecords()
		{
			dataGridView1.Rows.Clear();
			int i = 0;
			cn.Open();
			//cm = new SqlCommand("SELECT * FROM tbllogin WHERE name LIKE '%" + txtSearch.Text + "%' OR perpetrator LIKE '%" + txtSearch.Text + "%'ORDER BY dateposted", cn);
			cm = new SqlCommand("SELECT * FROM tbllogin ORDER BY name", cn);
			dr = cm.ExecuteReader();
			while (dr.Read())
			{
				i++;
				dataGridView1.Rows.Add(dr["iduser"].ToString(), dr["username"].ToString(), dr["password"].ToString(), dr["name"].ToString(), dr["role"].ToString(), dr["designation"].ToString());

			}
			dr.Close();
			cn.Close();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			string colName = dataGridView1.Columns[e.ColumnIndex].Name;
			if (colName == "colEdit")
			{

				btnSave.Enabled = false;
				btnUpdate.Enabled = true;
				idusername.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
				txtUsername.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
				txtPassword.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
				txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
				cboRole.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
				txtDesignation.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
			}
			if (colName == "colDelete")
			{
				if (MessageBox.Show("YOU WANT TO DELETE THIS RECORD? CLICK YES TO CONFIRM", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					cn.Open();
					cm = new SqlCommand("DELETE FROM tbllogin WHERE iduser = '" + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", cn);
					cm.ExecuteNonQuery();
					cn.Close();
					MessageBox.Show("RECORD HAS BEEN SUCCESSFULL DELETED", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Information);
					LoadRecords();
				}
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				if (txtUsername.Text == string.Empty || txtPassword.Text == string.Empty || txtName.Text == string.Empty || cboRole.Text == string.Empty)
				{
					MessageBox.Show("REQUIRED MISSING FIELDS", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;

				}

				if (txtPassword.Text != txtReTypePassword.Text)
				{
					MessageBox.Show("Password did not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				if (MessageBox.Show("ADD NEW RECORD? CLICK YES TO CONFIRM", "INFORMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					cn.Open();
					cm = new SqlCommand("INSERT INTO tbllogin (username, password, name, role, designation)VALUES(@username, @password, @name, @role, @designation)", cn);
					//cm.Parameters.AddWithValue("@id", txtID.Text);
					cm.Parameters.AddWithValue("@username", txtUsername.Text);
					cm.Parameters.AddWithValue("@password", txtPassword.Text);
					cm.Parameters.AddWithValue("@name", txtName.Text);
					cm.Parameters.AddWithValue("@role", cboRole.Text);
					cm.Parameters.AddWithValue("@designation", txtDesignation.Text);

					cm.ExecuteNonQuery();
					cn.Close();
					MessageBox.Show("RECORD HAS BEEN SUCCESSFULLY SAVED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Clear();
					LoadRecords();
				}
			}
			catch (Exception ex)
			{
				cn.Close();
				MessageBox.Show(ex.Message, "Add User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		public void Clear()
		{
			txtUsername.Clear();
			txtPassword.Clear();
			txtReTypePassword.Clear();
			txtName.Clear();
			cboRole.ResetText();
			txtDesignation.Clear();
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkPassword.Checked)
			{
				txtPassword.PasswordChar = '\0'; // Show actual characters
			}
			else
			{
				txtPassword.PasswordChar = '#'; // Hide characters
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			try
			{

				if (txtPassword.Text != txtReTypePassword.Text)
				{
					MessageBox.Show("Password did not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				cn.Open();
				cm = new SqlCommand("UPDATE tbllogin SET username=@username, password = @password, name = @name, role = @role, designation = @designation WHERE iduser = @iduser", cn);
				cm.Parameters.AddWithValue("@iduser", idusername.Text);
				cm.Parameters.AddWithValue("@username", txtUsername.Text);
				cm.Parameters.AddWithValue("@password", txtPassword.Text);
				cm.Parameters.AddWithValue("@name", txtName.Text);
				cm.Parameters.AddWithValue("@role", cboRole.Text);
				cm.Parameters.AddWithValue("@designation", txtDesignation.Text);

				cm.ExecuteNonQuery();
				cn.Close();
				MessageBox.Show("Records has been successfully changed!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadRecords();

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			Clear();
			btnSave.Enabled = true;
			btnUpdate.Enabled = false;

		}
	}
}
