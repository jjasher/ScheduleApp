namespace C969.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.CustomersButton = new System.Windows.Forms.Button();
			this.AppointmentsButton = new System.Windows.Forms.Button();
			this.ReportsButton = new System.Windows.Forms.Button();
			this.LogoutButton = new System.Windows.Forms.Button();
			this.QuitButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// CustomersButton
			// 
			this.CustomersButton.Location = new System.Drawing.Point(335, 89);
			this.CustomersButton.Name = "CustomersButton";
			this.CustomersButton.Size = new System.Drawing.Size(118, 39);
			this.CustomersButton.TabIndex = 0;
			this.CustomersButton.Text = "Customers";
			this.CustomersButton.UseVisualStyleBackColor = true;
			this.CustomersButton.Click += new System.EventHandler(this.CustomersButton_Click);
			// 
			// AppointmentsButton
			// 
			this.AppointmentsButton.Location = new System.Drawing.Point(335, 146);
			this.AppointmentsButton.Name = "AppointmentsButton";
			this.AppointmentsButton.Size = new System.Drawing.Size(118, 39);
			this.AppointmentsButton.TabIndex = 1;
			this.AppointmentsButton.Text = "Appointments";
			this.AppointmentsButton.UseVisualStyleBackColor = true;
			this.AppointmentsButton.Click += new System.EventHandler(this.AppointmentsButton_Click);
			// 
			// ReportsButton
			// 
			this.ReportsButton.Location = new System.Drawing.Point(335, 202);
			this.ReportsButton.Name = "ReportsButton";
			this.ReportsButton.Size = new System.Drawing.Size(118, 39);
			this.ReportsButton.TabIndex = 2;
			this.ReportsButton.Text = "Reports";
			this.ReportsButton.UseVisualStyleBackColor = true;
			this.ReportsButton.Click += new System.EventHandler(this.ReportsButton_Click);
			// 
			// LogoutButton
			// 
			this.LogoutButton.Location = new System.Drawing.Point(51, 388);
			this.LogoutButton.Name = "LogoutButton";
			this.LogoutButton.Size = new System.Drawing.Size(118, 39);
			this.LogoutButton.TabIndex = 3;
			this.LogoutButton.Text = "Logout";
			this.LogoutButton.UseVisualStyleBackColor = true;
			this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
			// 
			// QuitButton
			// 
			this.QuitButton.Location = new System.Drawing.Point(653, 388);
			this.QuitButton.Name = "QuitButton";
			this.QuitButton.Size = new System.Drawing.Size(118, 39);
			this.QuitButton.TabIndex = 4;
			this.QuitButton.Text = "Quit";
			this.QuitButton.UseVisualStyleBackColor = true;
			this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.QuitButton);
			this.Controls.Add(this.LogoutButton);
			this.Controls.Add(this.ReportsButton);
			this.Controls.Add(this.AppointmentsButton);
			this.Controls.Add(this.CustomersButton);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CustomersButton;
        private System.Windows.Forms.Button AppointmentsButton;
        private System.Windows.Forms.Button ReportsButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button QuitButton;
    }
}