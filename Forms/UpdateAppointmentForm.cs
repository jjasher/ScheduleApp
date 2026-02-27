using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SchedulingApp.DataAccess;

namespace C969.Forms
{
	public partial class UpdateAppointmentForm : Form
	{
		private int appointmentId;

		public UpdateAppointmentForm(
			int id,
			int customerId,
			string title,
			string description,
			string location,
			string contact,
			string type,
			DateTime startLocal,
			DateTime endLocal)
		{
			InitializeComponent();

			appointmentId = id;

			LoadCustomers();

			CustomerCB.SelectedValue = customerId;
			TitleTB.Text = title;
			DescriptionTB.Text = description;
			LocationTB.Text = location;
			ContactTB.Text = contact;
			TypeTB.Text = type;
			StartDTP.Value = startLocal;
			EndDTP.Value = endLocal;

			AcceptButton.Enabled = false;

			HookValidationEvents();
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

		private void HookValidationEvents()
		{
			TitleTB.TextChanged += ValidateForm;
			DescriptionTB.TextChanged += ValidateForm;
			LocationTB.TextChanged += ValidateForm;
			ContactTB.TextChanged += ValidateForm;
			TypeTB.TextChanged += ValidateForm;
			StartDTP.ValueChanged += ValidateForm;
			EndDTP.ValueChanged += ValidateForm;
		}

		private void ValidateForm(object sender, EventArgs e)
		{
			AcceptButton.Enabled =
				!string.IsNullOrWhiteSpace(TitleTB.Text) &&
				!string.IsNullOrWhiteSpace(DescriptionTB.Text) &&
				!string.IsNullOrWhiteSpace(LocationTB.Text) &&
				!string.IsNullOrWhiteSpace(ContactTB.Text) &&
				!string.IsNullOrWhiteSpace(TypeTB.Text) &&
				EndDTP.Value > StartDTP.Value;
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
					"AND end > @newStart " +
					"AND appointmentId != @appointmentId";

				MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);
				cmd.Parameters.AddWithValue("@userId", Session.LoggedInUserId);
				cmd.Parameters.AddWithValue("@newStart", newStartUtc);
				cmd.Parameters.AddWithValue("@newEnd", newEndUtc);
				cmd.Parameters.AddWithValue("@appointmentId", appointmentId);

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

			if (localStart.TimeOfDay < businessStart ||
				localEnd.TimeOfDay > businessEnd)
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
					"UPDATE appointment SET " +
					"customerId = @customerId, " +
					"title = @title, " +
					"description = @description, " +
					"location = @location, " +
					"contact = @contact, " +
					"type = @type, " +
					"start = @start, " +
					"end = @end, " +
					"lastUpdate = NOW(), " +
					"lastUpdateBy = @updatedBy " +
					"WHERE appointmentId = @appointmentId";

				MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);

				cmd.Parameters.AddWithValue("@customerId", CustomerCB.SelectedValue);
				cmd.Parameters.AddWithValue("@title", TitleTB.Text.Trim());
				cmd.Parameters.AddWithValue("@description", DescriptionTB.Text.Trim());
				cmd.Parameters.AddWithValue("@location", LocationTB.Text.Trim());
				cmd.Parameters.AddWithValue("@contact", ContactTB.Text.Trim());
				cmd.Parameters.AddWithValue("@type", TypeTB.Text.Trim());
				cmd.Parameters.AddWithValue("@start", utcStart);
				cmd.Parameters.AddWithValue("@end", utcEnd);
				cmd.Parameters.AddWithValue("@updatedBy", "system");
				cmd.Parameters.AddWithValue("@appointmentId", appointmentId);

				cmd.ExecuteNonQuery();

				MessageBox.Show("Appointment updated successfully.");
				this.Close();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Error updating appointment:\n" + ex.Message);
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