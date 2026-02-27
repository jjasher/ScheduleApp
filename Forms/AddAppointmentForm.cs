using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SchedulingApp.DataAccess;

namespace C969.Forms
{
	public partial class AddAppointmentForm : Form
	{
		public AddAppointmentForm()
		{
			InitializeComponent();
			LoadCustomers();
		}

		private void LoadCustomers()
		{
			try
			{
				DBConnection.startConnection();

				string query = "SELECT customerId, customerName FROM customer";
				MySqlDataAdapter da = new MySqlDataAdapter(query, DBConnection.conn);

				DataTable dt = new DataTable();
				da.Fill(dt);

				CustomerCB.DataSource = dt;
				CustomerCB.DisplayMember = "customerName";
				CustomerCB.ValueMember = "customerId";
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Error loading customers:\n" + ex.Message);
			}
			finally
			{
				DBConnection.closeConnection();
			}
		}


		// Prevent overlapping appointments
		private bool HasOverlappingAppointment(DateTime newStartUtc, DateTime newEndUtc)
		{
			try
			{
				string query =
					"SELECT COUNT(*) FROM appointment " +
					"WHERE userId = @userId " +
					"AND start < @newEnd " +
					"AND end > @newStart";

				MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);
				cmd.Parameters.AddWithValue("@userId", Session.LoggedInUserId);
				cmd.Parameters.AddWithValue("@newStart", newStartUtc);
				cmd.Parameters.AddWithValue("@newEnd", newEndUtc);

				int count = Convert.ToInt32(cmd.ExecuteScalar());
				return count > 0;
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Error checking overlapping appointments:\n" + ex.Message);
				return true;
			}
		}

		// Business hours validation
		private bool IsWithinBusinessHours(DateTime localStart, DateTime localEnd)
		{
			TimeSpan businessStart = new TimeSpan(9, 0, 0);
			TimeSpan businessEnd = new TimeSpan(17, 0, 0);

			if (localStart.TimeOfDay < businessStart || localEnd.TimeOfDay > businessEnd)
			{
				MessageBox.Show(
					"Appointments must be scheduled between 9:00 AM and 5:00 PM.",
					"Business Hours Violation",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning);

				return false;
			}

			if (localEnd <= localStart)
			{
				MessageBox.Show(
					"End time must be after start time.",
					"Invalid Time Range",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning);

				return false;
			}

			return true;
		}

		private void AcceptButton_Click(object sender, EventArgs e)
		{
			try
			{
				DBConnection.startConnection();

				int customerId = Convert.ToInt32(CustomerCB.SelectedValue);

				DateTime localStart = StartDTP.Value;
				DateTime localEnd = EndDTP.Value;

				if (!IsWithinBusinessHours(localStart, localEnd))
				{
					return;
				}

				DateTime utcStart = TimeZoneInfo.ConvertTimeToUtc(localStart);
				DateTime utcEnd = TimeZoneInfo.ConvertTimeToUtc(localEnd);

				if (HasOverlappingAppointment(utcStart, utcEnd))
				{
					MessageBox.Show(
						"This appointment overlaps with an existing appointment.",
						"Scheduling Conflict",
						MessageBoxButtons.OK,
						MessageBoxIcon.Warning);
					return;
				}

				string query =
					"INSERT INTO appointment " +
					"(customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy) " +
					"VALUES (@customerId, @userId, @title, @description, @location, @contact, @type, @url, @start, @end, NOW(), @createdBy, NOW(), @updatedBy)";

				MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);

				cmd.Parameters.AddWithValue("@customerId", customerId);
				cmd.Parameters.AddWithValue("@userId", Session.LoggedInUserId);
				cmd.Parameters.AddWithValue("@title", TitleTB.Text.Trim());
				cmd.Parameters.AddWithValue("@description", DescriptionTB.Text.Trim());
				cmd.Parameters.AddWithValue("@location", LocationTB.Text.Trim());
				cmd.Parameters.AddWithValue("@contact", ContactTB.Text.Trim());
				cmd.Parameters.AddWithValue("@type", TypeTB.Text.Trim());
				cmd.Parameters.AddWithValue("@url", "");
				cmd.Parameters.AddWithValue("@start", utcStart);
				cmd.Parameters.AddWithValue("@end", utcEnd);
				cmd.Parameters.AddWithValue("@createdBy", "system");
				cmd.Parameters.AddWithValue("@updatedBy", "system");

				cmd.ExecuteNonQuery();

				MessageBox.Show("Appointment added successfully.");
				this.Close();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Error adding appointment:\n" + ex.Message);
			}
			finally
			{
				DBConnection.closeConnection();
			}
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}