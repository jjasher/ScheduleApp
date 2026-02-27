using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SchedulingApp.DataAccess;

namespace C969.Forms
{
    public partial class AppointmentForm : Form
    {
        private bool dayViewActive = false;
        private DateTime selectedDay;

        public AppointmentForm()
        {
            InitializeComponent();
            rbAll.Checked = true;
            LoadAppointments();
        }

        private void LoadAppointments()
        {
            try
            {
                DBConnection.startConnection();

                DateTime today = DateTime.Now.Date;
                MySqlCommand cmd;

                // Day view
                if (dayViewActive)
                {
                    DateTime localStart = selectedDay;
                    DateTime localEnd = selectedDay.AddDays(1);

                    DateTime utcStart = TimeZoneInfo.ConvertTimeToUtc(localStart);
                    DateTime utcEnd = TimeZoneInfo.ConvertTimeToUtc(localEnd);

                    string query =
                        "SELECT appointmentId, customerId, userId, title, description, location, contact, type, start, end " +
                        "FROM appointment WHERE start >= @start AND start < @end";

                    cmd = new MySqlCommand(query, DBConnection.conn);
                    cmd.Parameters.AddWithValue("@start", utcStart);
                    cmd.Parameters.AddWithValue("@end", utcEnd);
                }

                // All view
                else if (rbAll.Checked)
                {
                    string query =
                        "SELECT appointmentId, customerId, userId, title, description, location, contact, type, start, end " +
                        "FROM appointment";

                    cmd = new MySqlCommand(query, DBConnection.conn);
                }

                // Week/Month view
                else
                {
                    DateTime localStart;
                    DateTime localEnd;

                    if (rbWeek.Checked)
                    {
                        int diff = today.DayOfWeek - DayOfWeek.Monday;
                        if (diff < 0)
                        {
                            diff += 7;
                        }

                        localStart = today.AddDays(-diff);
                        localEnd = localStart.AddDays(7);
                    }
                    else
                    {
                        localStart = new DateTime(today.Year, today.Month, 1);
                        localEnd = localStart.AddMonths(1);
                    }

                    DateTime utcStart = TimeZoneInfo.ConvertTimeToUtc(localStart);
                    DateTime utcEnd = TimeZoneInfo.ConvertTimeToUtc(localEnd);

                    string query =
                        "SELECT appointmentId, customerId, userId, title, description, location, contact, type, start, end " +
                        "FROM appointment WHERE start >= @start AND start < @end";

                    cmd = new MySqlCommand(query, DBConnection.conn);
                    cmd.Parameters.AddWithValue("@start", utcStart);
                    cmd.Parameters.AddWithValue("@end", utcEnd);
                }

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    DateTime utcStart = Convert.ToDateTime(row["start"]);
                    DateTime utcEnd = Convert.ToDateTime(row["end"]);

                    row["start"] = TimeZoneInfo.ConvertTimeFromUtc(utcStart, TimeZoneInfo.Local);
                    row["end"] = TimeZoneInfo.ConvertTimeFromUtc(utcEnd, TimeZoneInfo.Local);
                }

                AppointmentsDGV.DataSource = dt;
                AppointmentsDGV.ClearSelection();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error loading appointments:\n" + ex.Message);
            }
            finally
            {
                DBConnection.closeConnection();
            }
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAll.Checked)
            {
                dayViewActive = false;
                LoadAppointments();
            }
        }

        private void rbWeek_CheckedChanged(object sender, EventArgs e)
        {
            if (rbWeek.Checked)
            {
                dayViewActive = false;
                LoadAppointments();
            }
        }

        private void rbMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMonth.Checked)
            {
                dayViewActive = false;
                LoadAppointments();
            }
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddAppointmentForm addForm = new AddAppointmentForm();
            addForm.ShowDialog();
            LoadAppointments();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (AppointmentsDGV.CurrentRow == null)
            {
                MessageBox.Show("Please select an appointment to update.");
                return;
            }

            DataGridViewRow row = AppointmentsDGV.CurrentRow;

            int appointmentId = Convert.ToInt32(row.Cells["appointmentId"].Value);
            int customerId = Convert.ToInt32(row.Cells["customerId"].Value);
            string title = row.Cells["title"].Value.ToString();
            string description = row.Cells["description"].Value?.ToString() ?? "";
            string location = row.Cells["location"].Value?.ToString() ?? "";
            string contact = row.Cells["contact"].Value?.ToString() ?? "";
            string type = row.Cells["type"].Value?.ToString() ?? "";
            DateTime start = Convert.ToDateTime(row.Cells["start"].Value);
            DateTime end = Convert.ToDateTime(row.Cells["end"].Value);

            UpdateAppointmentForm updateForm = new UpdateAppointmentForm(
                appointmentId, customerId, title, description, location, contact, type, start, end);

            updateForm.ShowDialog();
            LoadAppointments();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (AppointmentsDGV.CurrentRow == null)
            {
                MessageBox.Show("Please select an appointment to delete.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Delete appointment? This cannot be undone.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                int appointmentId = Convert.ToInt32(
                    AppointmentsDGV.CurrentRow.Cells["appointmentId"].Value);

                DBConnection.startConnection();

                string query = "DELETE FROM appointment WHERE appointmentId = @appointmentId";
                MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);
                cmd.Parameters.AddWithValue("@appointmentId", appointmentId);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Appointment deleted successfully.");
                LoadAppointments();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1451)
                {
                    MessageBox.Show(
                        "This appointment cannot be deleted because it is linked to another record.",
                        "Delete Blocked",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error deleting appointment:\n" + ex.Message);
                }
            }
            finally
            {
                DBConnection.closeConnection();
            }
        }

        private void AppointmentCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            dayViewActive = true;
            selectedDay = e.Start.Date;

            rbAll.Checked = false;
            rbWeek.Checked = false;
            rbMonth.Checked = false;

            LoadAppointments();
        }
    }
}