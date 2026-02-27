using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {
			CustomersForm CustomersForm = new CustomersForm();
			CustomersForm.Show();
			this.Hide();
		}

        private void QuitButton_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void AppointmentsButton_Click(object sender, EventArgs e)
        {
            AppointmentForm AppointmentsForm = new AppointmentForm();
            AppointmentsForm.Show();
            this.Hide();
        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            ReportsForm ReportsForm = new ReportsForm();
            ReportsForm.Show();
            this.Hide();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
			LoginForm loginForm = new LoginForm();
			loginForm.Show();

            this.Close();
		}
    }
}
