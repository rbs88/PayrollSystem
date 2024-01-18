using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AldoBuildersPayrollSystem
{
	class DBConnection
	{
		public string GetConnection()
		{
			string cn;
			try
			{
				//cn = @"Data Source=DESKTOP-7KMTC5B;Initial Catalog=barangayculiatdb;Integrated Security=True";
				//cn = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=barangayculiatdb;Integrated Security=True";
				//cn = @"Data Source=KAGAWADCHU-PC\SQLEXPRESS;Initial Catalog=barangayculiatdb;Integrated Security=True";
				cn = @"Data Source=DESKTOP-7KMTC5B;Initial Catalog=payrollsystemfinal;Integrated Security=True";
				//cn = @"Data Source=103.0.0.255,3307;Initial Catalog=payrollsystemfinal;User Id=nel;Password=nel1234";
				//cn = @"Data Source=SERVER\SQLEXPRESS;Initial Catalog=payrollsystemfinal;Integrated Security=True";
				//cn = @"Data Source=SRVR\SQLEXPRESS;Initial Catalog=payrollsystemfinal;Integrated Security=True";
				// cn = @"Data Source=BCPC-VAWC\SQLEXPRESS;Initial Catalog=barangayculiatdb;Integrated Security=True";
				//cn = @"Data Source=192.168.1.1,49170;Initial Catalog=barangayculiatdb;User Id=nel;Password=nels12345";// This Connection string is for Client Machine office
				//cn = @"Data Source=DESKTOP-5DN3RJN\SQLEXPRESS;Initial Catalog=barangayculiatdb;User Id=nel;Password=nels12345";// This Connection string is for Client Machine office   
				return cn;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				//string n;
				//n = "Database Connection Error";
				//MessageBox.Show(n);
				return "You are not connected to server";
			}
		}
	}
}
