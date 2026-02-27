using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SchedulingApp.DataAccess
{
	public class DBConnection
	{
		public static MySqlConnection conn { get; set; }

		public static void startConnection()
		{
			try
			{
				// Get the connection string from App.config
				string constr = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
				conn = new MySqlConnection(constr);

				conn.Open();

			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}
		public static void closeConnection()
		{
			try
			{
				// Close the connection
				if (conn != null)
				{
					conn.Close();
				}
				conn = null;

			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}
	}
}