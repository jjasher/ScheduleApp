using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SchedulingApp.DataAccess;

namespace C969.Forms
{
	public partial class ReportsForm : Form
	{
		public ReportsForm()
		{
			InitializeComponent();
			LoadMonthDropdown();
			LoadTypeDropdown();
		}

		// Load appointment data
		private List<Appointment> GetAppointments()
		{
			List<Appointment> appointments = new List<Appointment>();

			try
			{
				DBConnection.startConnection();

				string query =
					"SELECT appointmentId, userId, type, start FROM appointment";

				MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);
				MySqlDataReader reader = cmd.ExecuteReader();

				while (reader.Read())
				{
					appointments.Add(new Appointment
					{
						AppointmentId = Convert.ToInt32(reader["appointmentId"]),
						UserId = Convert.ToInt32(reader["userId"]),
						Type = reader["type"].ToString(),
						Start = TimeZoneInfo.ConvertTimeFromUtc(
							Convert.ToDateTime(reader["start"]),
							TimeZoneInfo.Local)
					});
				}

				reader.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading appointments:\n" + ex.Message);
			}
			finally
			{
				DBConnection.closeConnection();
			}

			return appointments;
		}

		// Populate dropdowns
		private void LoadMonthDropdown()
		{
			MonthComboBox.Items.Clear();

			for (int i = 1; i <= 12; i++)
			{
				MonthComboBox.Items.Add(
					CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i));
			}
		}

		private void LoadTypeDropdown()
		{
			var appointments = GetAppointments();

			var types =
				appointments
				.Select(a => a.Type)
				.Distinct()
				.OrderBy(t => t)
				.ToList();

			TypeComboBox.Items.Clear();
			TypeComboBox.Items.AddRange(types.ToArray());
		}

		private void MonthlyTypeReportButton_Click_1(object sender, EventArgs e)
		{
			if (MonthComboBox.SelectedItem == null || TypeComboBox.SelectedItem == null)
			{
				MessageBox.Show("Please select both a month and appointment type.");
				return;
			}

			string selectedMonth = MonthComboBox.SelectedItem.ToString();
			string selectedType = TypeComboBox.SelectedItem.ToString();

			int monthNumber =
				DateTime.ParseExact(
					selectedMonth,
					"MMMM",
					CultureInfo.CurrentCulture).Month;

			var appointments = GetAppointments();

			// Lambda Expression used for first report to simplify the code and make it more readable. It filters the appointments based on the selected month and type, then counts the matching records.
			int count =
				appointments
				.Where(a =>
					a.Start.Month == monthNumber &&
					a.Type == selectedType)
				.Count();

			var result = new List<object>
			{
				new
				{
					Month = selectedMonth,
					Type = selectedType,
					TotalAppointments = count
				}
			};

			ReportsDGV.DataSource = result;
		}
		private void UserScheduleButton_Click(object sender, EventArgs e)
		{
			var appointments = GetAppointments();
			// Lambda expressions used here to help sort by UserId first and then by Start time. The Select statement projects the data into an anonymous type with only the relevant fields for the report.
			var report =
				appointments
				.OrderBy(a => a.UserId)
				.ThenBy(a => a.Start)
				.Select(a => new
				{
					UserId = a.UserId,
					AppointmentId = a.AppointmentId,
					Type = a.Type,
					Start = a.Start
				})
				.ToList();

			ReportsDGV.DataSource = report;
		}

		private void DailyCountButton_Click(object sender, EventArgs e)
		{
			var appointments = GetAppointments();

			// Lambda expressions are used here to group the appointments by date, count the number of appointments for each date, and then order the results by date. The Select statement creates an anonymous type with the date and appointment count for each group. 
			var report =
				appointments
				.GroupBy(a => a.Start.Date)
				.Select(g => new
				{
					Date = g.Key.ToShortDateString(),
					AppointmentCount = g.Count()
				})
				.OrderBy(r => DateTime.Parse(r.Date))
				.ToList();

			ReportsDGV.DataSource = report;
		}
		private void MainButton_Click(object sender, EventArgs e)
		{
			this.Close();

			MainForm mainForm = new MainForm();
			mainForm.Show();
		}

		private void QuitButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

        
    }
}