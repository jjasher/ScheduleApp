using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SchedulingApp.DataAccess;

namespace C969.Forms
{
	public partial class CustomersForm : Form
	{
		public CustomersForm()
		{
			InitializeComponent();

			CustomersDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			CustomersDGV.MultiSelect = false;

			LoadCustomers();
		}

		private void LoadCustomers()
		{
			string query =
				"SELECT customer.customerId, customer.customerName, " +
				"address.address, address.phone, city.city, country.country " +
				"FROM customer " +
				"JOIN address ON customer.addressId = address.addressId " +
				"JOIN city ON address.cityId = city.cityId " +
				"JOIN country ON city.countryId = country.countryId";

			try
			{
				DBConnection.startConnection();

				MySqlDataAdapter da = new MySqlDataAdapter(query, DBConnection.conn);
				DataTable dt = new DataTable();
				da.Fill(dt);

				CustomersDGV.DataSource = dt;

				CustomersDGV.Columns["customerId"].HeaderText = "ID";
				CustomersDGV.Columns["customerName"].HeaderText = "Name";
				CustomersDGV.Columns["address"].HeaderText = "Address";
				CustomersDGV.Columns["phone"].HeaderText = "Phone";
				CustomersDGV.Columns["city"].HeaderText = "City";
				CustomersDGV.Columns["country"].HeaderText = "Country";
			}
			catch (MySqlException)
			{
				MessageBox.Show("Error loading customer records.");
			}
			finally
			{
				DBConnection.closeConnection();
			}
		}

		private void ClearCustomerSelection()
		{
			CustomersDGV.ClearSelection();
			CustomersDGV.CurrentCell = null;

			UpdateButton.Enabled = false;
			DeleteButton.Enabled = false;
		}

		private void QuitButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void MainButton_Click(object sender, EventArgs e)
		{
			this.Close();

			MainForm mainForm = new MainForm();
			mainForm.Show();
		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			if (CustomersDGV.CurrentRow == null)
			{
				MessageBox.Show("Please select a customer to delete.");
				return;
			}

			int customerId =
				Convert.ToInt32(CustomersDGV.CurrentRow.Cells["customerId"].Value);

			try
			{
				DBConnection.startConnection();

				// Check for existing appointments
				string checkQuery =
					"SELECT COUNT(*) FROM appointment WHERE customerId = @customerId";

				MySqlCommand checkCmd = new MySqlCommand(checkQuery, DBConnection.conn);
				checkCmd.Parameters.AddWithValue("@customerId", customerId);

				int appointmentCount = Convert.ToInt32(checkCmd.ExecuteScalar());

				if (appointmentCount > 0)
				{
					DialogResult confirm = MessageBox.Show(
						"This customer has existing appointments.\n\n" +
						"Deleting this customer will also delete ALL related appointments.\n\n" +
						"Do you want to continue?",
						"Confirm Delete",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Warning);

					if (confirm != DialogResult.Yes)
					{
						return;
					}

					// Delete appointments first
					string deleteAppointments =
						"DELETE FROM appointment WHERE customerId = @customerId";

					MySqlCommand deleteApptCmd =
						new MySqlCommand(deleteAppointments, DBConnection.conn);

					deleteApptCmd.Parameters.AddWithValue("@customerId", customerId);
					deleteApptCmd.ExecuteNonQuery();
				}

				// Delete customer
				string deleteCustomer =
					"DELETE FROM customer WHERE customerId = @customerId";

				MySqlCommand deleteCustCmd =
					new MySqlCommand(deleteCustomer, DBConnection.conn);

				deleteCustCmd.Parameters.AddWithValue("@customerId", customerId);
				deleteCustCmd.ExecuteNonQuery();

				MessageBox.Show("Customer deleted successfully.");

				LoadCustomers();
				ClearCustomerSelection();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Error deleting customer:\n" + ex.Message);
			}
			finally
			{
				DBConnection.closeConnection();
			}
		}

		private void CustomersDGV_SelectionChanged(object sender, EventArgs e)
		{
			if (CustomersDGV.CurrentRow != null && CustomersDGV.SelectedRows.Count > 0)
			{
				UpdateButton.Enabled = true;
				DeleteButton.Enabled = true;
			}
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			this.Close();

			AddCustomerForm addCustomerForm = new AddCustomerForm();
			addCustomerForm.Show();
		}

		private void UpdateButton_Click(object sender, EventArgs e)
		{
			if (CustomersDGV.CurrentRow == null)
			{
				MessageBox.Show("Please select a customer to update.");
				return;
			}

			int id = Convert.ToInt32(CustomersDGV.CurrentRow.Cells["customerId"].Value);
			string name = CustomersDGV.CurrentRow.Cells["customerName"].Value.ToString();
			string address = CustomersDGV.CurrentRow.Cells["address"].Value.ToString();
			string phone = CustomersDGV.CurrentRow.Cells["phone"].Value.ToString();
			string city = CustomersDGV.CurrentRow.Cells["city"].Value.ToString();
			string country = CustomersDGV.CurrentRow.Cells["country"].Value.ToString();

			UpdateCustomerForm updateForm =
				new UpdateCustomerForm(id, name, address, phone, city, country);

			updateForm.ShowDialog();

			LoadCustomers();
		}
	}
}