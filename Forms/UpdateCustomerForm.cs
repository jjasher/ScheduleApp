using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SchedulingApp.DataAccess;

namespace C969.Forms
{
    public partial class UpdateCustomerForm : Form
    {

		private int customerId;
		private string customerName;
		private string address;
		private string phone;
		private string city;
		private string country;


		public UpdateCustomerForm(int id, string name, string address,
						  string phone, string city, string country)
		{
			InitializeComponent();

			customerId = id;
			customerName = name;
			this.address = address;
			this.phone = phone;
			this.city = city;
			this.country = country;

			NameTB.Text = customerName;
			AddressTB.Text = this.address;
			PhoneTB.Text = this.phone;
			CityTB.Text = this.city;
			CountryTB.Text = this.country;

			NameTB.TextChanged += ValidateForm;
			AddressTB.TextChanged += ValidateForm;
			PhoneTB.TextChanged += ValidateForm;
			CityTB.TextChanged += ValidateForm;
			CountryTB.TextChanged += ValidateForm;

			AcceptButton.Enabled = false;
			AcceptButton.Enabled = IsFormValid();
		}

		private void ValidateForm(object sender, EventArgs e)
		{
			AcceptButton.Enabled = IsFormValid();
		}

		// Field validation
		private bool IsFormValid()
		{
			if (string.IsNullOrWhiteSpace(NameTB.Text))
				return false;

			if (string.IsNullOrWhiteSpace(AddressTB.Text))
				return false;

			if (string.IsNullOrWhiteSpace(CityTB.Text))
				return false;

			if (string.IsNullOrWhiteSpace(CountryTB.Text))
				return false;

			if (string.IsNullOrWhiteSpace(PhoneTB.Text))
				return false;

			foreach (char c in PhoneTB.Text)
			{
				if (!char.IsDigit(c) && c != '-')
					return false;
			}

			return true;
		}



		private void UpdateCustomerForm_Load(object sender, EventArgs e)
		{
			NameTB.Text = customerName;
			AddressTB.Text = address;
			PhoneTB.Text = phone;
			CityTB.Text = city;
			CountryTB.Text = country;
		}


		private void CancelButton_Click(object sender, EventArgs e)
        {
			this.Close();
		}

		private void AcceptButton_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(NameTB.Text) ||
				string.IsNullOrWhiteSpace(AddressTB.Text) ||
				string.IsNullOrWhiteSpace(PhoneTB.Text) ||
				string.IsNullOrWhiteSpace(CityTB.Text) ||
				string.IsNullOrWhiteSpace(CountryTB.Text))
			{
				MessageBox.Show("All fields are required.");
				return;
			}

			// Exception handling
			try
			{
				DBConnection.startConnection();

		
				// Get addressId for this customer
				string getAddressQuery =
					"SELECT addressId FROM customer WHERE customerId = @customerId";

				MySqlCommand getAddressCmd =
					new MySqlCommand(getAddressQuery, DBConnection.conn);

				getAddressCmd.Parameters.AddWithValue("@customerId", customerId);

				int addressId = Convert.ToInt32(getAddressCmd.ExecuteScalar());

			
				// Update customer name
				string updateCustomerQuery =
					"UPDATE customer SET customerName = @name, lastUpdate = NOW(), lastUpdateBy = 'system' " +
					"WHERE customerId = @customerId";

				MySqlCommand updateCustomerCmd =
					new MySqlCommand(updateCustomerQuery, DBConnection.conn);

				updateCustomerCmd.Parameters.AddWithValue("@name", NameTB.Text.Trim());
				updateCustomerCmd.Parameters.AddWithValue("@customerId", customerId);

				updateCustomerCmd.ExecuteNonQuery();

				// Update address + phone
				string updateAddressQuery =
					"UPDATE address SET address = @address, phone = @phone, " +
					"lastUpdate = NOW(), lastUpdateBy = 'system' " +
					"WHERE addressId = @addressId";

				MySqlCommand updateAddressCmd =
					new MySqlCommand(updateAddressQuery, DBConnection.conn);

				updateAddressCmd.Parameters.AddWithValue("@address", AddressTB.Text.Trim());
				updateAddressCmd.Parameters.AddWithValue("@phone", PhoneTB.Text.Trim());
				updateAddressCmd.Parameters.AddWithValue("@addressId", addressId);

				updateAddressCmd.ExecuteNonQuery();

				MessageBox.Show("Customer updated successfully.");

				this.Close();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Error updating customer:\n" + ex.Message);
			}
			finally
			{
				DBConnection.closeConnection();
			}
		}

	}
}
