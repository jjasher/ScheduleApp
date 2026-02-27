using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx;
using SchedulingApp.DataAccess;

namespace C969.Forms
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
			SetLanguage();
		}

		private void SetLanguage()
		{

			// Determine user’s location
			string language = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;


			// Translate login and error messages
			if (language == "es")
			{
				UsernameLabel.Text = "Usuario";
				PasswordLabel.Text = "Contraseña";
				AcceptButton.Text = "Iniciar sesión";
				CancelButton.Text = "Cancelar";
				this.Text = "Inicio de sesión";
			}
			else
			{
				UsernameLabel.Text = "Username";
				PasswordLabel.Text = "Password";
				AcceptButton.Text = "Login";
				CancelButton.Text = "Cancel";
				this.Text = "Login";
			}
		}

		private bool ValidateForm()
		{
			string language = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;

			if (string.IsNullOrWhiteSpace(UsernameTB.Text))
			{
				MessageBox.Show(language == "es"
					? "El nombre de usuario es obligatorio."
					: "Username is required.");

				UsernameTB.Focus();
				return false;
			}

			if (string.IsNullOrWhiteSpace(PasswordTB.Text))
			{
				MessageBox.Show(language == "es"
					? "La contraseña es obligatoria."
					: "Password is required.");

				PasswordTB.Focus();
				return false;
			}

			return true;
		}

		// Track all login attempts
		private void LogLoginAttempt(string username, bool success)
		{
			try
			{
				string status = success ? "SUCCESS" : "FAILED";
				string logEntry =
					$"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - User: {username} - {status}";

				File.AppendAllText("Login_History.txt", logEntry + Environment.NewLine);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error writing login history:\n" + ex.Message);
			}
		}

		// Checks upcoming appointments for the logged in user
		private void CheckUpcomingAppointments()
		{
			try
			{
				DateTime localNow = DateTime.Now;
				DateTime localFuture = localNow.AddMinutes(15);

				DateTime utcNow = TimeZoneInfo.ConvertTimeToUtc(localNow);
				DateTime utcFuture = TimeZoneInfo.ConvertTimeToUtc(localFuture);

				string query =
					@"SELECT appointmentId, start
					  FROM appointment
					  WHERE userId = @userId
					  AND start BETWEEN @nowUtc AND @futureUtc";

				MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);
				cmd.Parameters.AddWithValue("@userId", Session.LoggedInUserId);
				cmd.Parameters.AddWithValue("@nowUtc", utcNow);
				cmd.Parameters.AddWithValue("@futureUtc", utcFuture);

				MySqlDataReader reader = cmd.ExecuteReader();

				if (reader.Read())
				{
					int appointmentId = reader.GetInt32("appointmentId");
					DateTime utcStart = reader.GetDateTime("start");

					DateTime localStart =
						TimeZoneInfo.ConvertTimeFromUtc(utcStart, TimeZoneInfo.Local);

					MessageBox.Show(
						"You have an appointment within the next 15 minutes.\n\n" +
						"Appointment ID: " + appointmentId + "\n" +
						"Start Time: " + localStart.ToString("g"),
						"Upcoming Appointment",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information);
				}

				reader.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(
					"Error checking upcoming appointments:\n" + ex.Message,
					"Error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
		}

		private void AcceptButton_Click(object sender, EventArgs e)
		{
			if (!ValidateForm())
			{
				return;
			}

			string username = UsernameTB.Text.Trim();
			string password = PasswordTB.Text.Trim();

			string query =
				"SELECT userId FROM user WHERE userName = @username AND password = @password";

			try
			{
				DBConnection.startConnection();

				MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);
				cmd.Parameters.AddWithValue("@username", username);
				cmd.Parameters.AddWithValue("@password", password);

				object result = cmd.ExecuteScalar();


				// Verify correct username and password
				if (result != null)
				{
					Session.LoggedInUserId = Convert.ToInt32(result);

					LogLoginAttempt(username, true);
					CheckUpcomingAppointments();

					MainForm mainForm = new MainForm();
					mainForm.Show();
					this.Hide();
				}
				else
				{
					LogLoginAttempt(username, false);
					MessageBox.Show("Username or password is incorrect.");
				}
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Database error occurred:\n" + ex.Message);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Unexpected error:\n" + ex.Message);
			}
			finally
			{
				DBConnection.closeConnection();
			}
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}