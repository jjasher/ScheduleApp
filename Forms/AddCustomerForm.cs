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
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();

			AcceptButton.Enabled = false;

			NameTB.TextChanged += ValidateForm;
			AddressTB.TextChanged += ValidateForm;
			PhoneTB.TextChanged += ValidateForm;
			CityTB.TextChanged += ValidateForm;
			CountryTB.TextChanged += ValidateForm;
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

			// Phone validation (digits and dashes only)
			if (string.IsNullOrWhiteSpace(PhoneTB.Text))
				return false;

			foreach (char c in PhoneTB.Text)
			{
				if (!char.IsDigit(c) && c != '-')
					return false;
			}

			return true;
		}

		private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            CustomersForm customersForm = new CustomersForm();
            customersForm.Show();
		}

        private void AcceptButton_Click(object sender, EventArgs e)
        {
			// Exception handling
			try
			{
				DBConnection.startConnection();

				// Country
				string countryQuery = "SELECT countryId FROM country WHERE country = @country";
				MySqlCommand countryCmd = new MySqlCommand(countryQuery, DBConnection.conn);
				countryCmd.Parameters.AddWithValue("@country", CountryTB.Text.Trim());

				object countryResult = countryCmd.ExecuteScalar();
				int countryId;

				if (countryResult == null)
				{
					string insertCountry =
						"INSERT INTO country (country, createDate, createdBy, lastUpdate, lastUpdateBy) " +
						"VALUES (@country, NOW(), 'system', NOW(), 'system')";
					MySqlCommand insertCountryCmd = new MySqlCommand(insertCountry, DBConnection.conn);
					insertCountryCmd.Parameters.AddWithValue("@country", CountryTB.Text.Trim());
					insertCountryCmd.ExecuteNonQuery();

					countryId = (int)insertCountryCmd.LastInsertedId;
				}
				else
				{
					countryId = Convert.ToInt32(countryResult);
				}

				// City
				string cityQuery = "SELECT cityId FROM city WHERE city = @city AND countryId = @countryId";
				MySqlCommand cityCmd = new MySqlCommand(cityQuery, DBConnection.conn);
				cityCmd.Parameters.AddWithValue("@city", CityTB.Text.Trim());
				cityCmd.Parameters.AddWithValue("@countryId", countryId);

				object cityResult = cityCmd.ExecuteScalar();
				int cityId;

				if (cityResult == null)
				{
					string insertCity =
						"INSERT INTO city (city, countryId, createDate, createdBy, lastUpdate, lastUpdateBy) " +
						"VALUES (@city, @countryId, NOW(), 'system', NOW(), 'system')";
					MySqlCommand insertCityCmd = new MySqlCommand(insertCity, DBConnection.conn);
					insertCityCmd.Parameters.AddWithValue("@city", CityTB.Text.Trim());
					insertCityCmd.Parameters.AddWithValue("@countryId", countryId);
					insertCityCmd.ExecuteNonQuery();

					cityId = (int)insertCityCmd.LastInsertedId;
				}
				else
				{
					cityId = Convert.ToInt32(cityResult);
				}

				// Address
				string addressQuery =
					"INSERT INTO address (address, address2, postalCode, phone, cityId, createDate, createdBy, lastUpdate, lastUpdateBy) " +
					"VALUES (@address, '', '00000', @phone, @cityId, NOW(), 'system', NOW(), 'system')";
				MySqlCommand addressCmd = new MySqlCommand(addressQuery, DBConnection.conn);
				addressCmd.Parameters.AddWithValue("@address", AddressTB.Text.Trim());
				addressCmd.Parameters.AddWithValue("@phone", PhoneTB.Text.Trim());
				addressCmd.Parameters.AddWithValue("@cityId", cityId);
				addressCmd.ExecuteNonQuery();

				int addressId = (int)addressCmd.LastInsertedId;

				// Customer
				string customerQuery =
					"INSERT INTO customer (customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy) " +
					"VALUES (@name, @addressId, 1, NOW(), 'system', NOW(), 'system')";
				MySqlCommand customerCmd = new MySqlCommand(customerQuery, DBConnection.conn);
				customerCmd.Parameters.AddWithValue("@name", NameTB.Text.Trim());
				customerCmd.Parameters.AddWithValue("@addressId", addressId);
				customerCmd.ExecuteNonQuery();

				MessageBox.Show("Customer added successfully.");

				this.Close();
				CustomersForm CustomersForm = new CustomersForm();
				CustomersForm.Show();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Error adding customer:\n" + ex.Message);
			}
			finally
			{
				DBConnection.closeConnection();
			}
		}
    }
}
