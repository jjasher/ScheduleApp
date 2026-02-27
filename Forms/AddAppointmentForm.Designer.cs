namespace C969.Forms
{
    partial class AddAppointmentForm
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
			this.CustomerCB = new System.Windows.Forms.ComboBox();
			this.TitleTB = new System.Windows.Forms.TextBox();
			this.CustomerLabel = new System.Windows.Forms.Label();
			this.TitleLabel = new System.Windows.Forms.Label();
			this.DescriptionLabel = new System.Windows.Forms.Label();
			this.DescriptionTB = new System.Windows.Forms.TextBox();
			this.LocationLabel = new System.Windows.Forms.Label();
			this.LocationTB = new System.Windows.Forms.TextBox();
			this.StartDateLabel = new System.Windows.Forms.Label();
			this.StartDTP = new System.Windows.Forms.DateTimePicker();
			this.EndDateLabel = new System.Windows.Forms.Label();
			this.EndDTP = new System.Windows.Forms.DateTimePicker();
			this.AcceptButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.ContactLabel = new System.Windows.Forms.Label();
			this.TypeLabel = new System.Windows.Forms.Label();
			this.ContactTB = new System.Windows.Forms.TextBox();
			this.TypeTB = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// CustomerCB
			// 
			this.CustomerCB.FormattingEnabled = true;
			this.CustomerCB.Location = new System.Drawing.Point(157, 39);
			this.CustomerCB.Name = "CustomerCB";
			this.CustomerCB.Size = new System.Drawing.Size(287, 28);
			this.CustomerCB.TabIndex = 0;
			// 
			// TitleTB
			// 
			this.TitleTB.Location = new System.Drawing.Point(157, 89);
			this.TitleTB.Name = "TitleTB";
			this.TitleTB.Size = new System.Drawing.Size(287, 26);
			this.TitleTB.TabIndex = 1;
			// 
			// CustomerLabel
			// 
			this.CustomerLabel.AutoSize = true;
			this.CustomerLabel.Location = new System.Drawing.Point(48, 42);
			this.CustomerLabel.Name = "CustomerLabel";
			this.CustomerLabel.Size = new System.Drawing.Size(78, 20);
			this.CustomerLabel.TabIndex = 2;
			this.CustomerLabel.Text = "Customer";
			// 
			// TitleLabel
			// 
			this.TitleLabel.AutoSize = true;
			this.TitleLabel.Location = new System.Drawing.Point(48, 92);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new System.Drawing.Size(38, 20);
			this.TitleLabel.TabIndex = 3;
			this.TitleLabel.Text = "Title";
			// 
			// DescriptionLabel
			// 
			this.DescriptionLabel.AutoSize = true;
			this.DescriptionLabel.Location = new System.Drawing.Point(48, 143);
			this.DescriptionLabel.Name = "DescriptionLabel";
			this.DescriptionLabel.Size = new System.Drawing.Size(89, 20);
			this.DescriptionLabel.TabIndex = 4;
			this.DescriptionLabel.Text = "Description";
			// 
			// DescriptionTB
			// 
			this.DescriptionTB.Location = new System.Drawing.Point(157, 137);
			this.DescriptionTB.Multiline = true;
			this.DescriptionTB.Name = "DescriptionTB";
			this.DescriptionTB.Size = new System.Drawing.Size(287, 69);
			this.DescriptionTB.TabIndex = 5;
			// 
			// LocationLabel
			// 
			this.LocationLabel.AutoSize = true;
			this.LocationLabel.Location = new System.Drawing.Point(48, 237);
			this.LocationLabel.Name = "LocationLabel";
			this.LocationLabel.Size = new System.Drawing.Size(70, 20);
			this.LocationLabel.TabIndex = 6;
			this.LocationLabel.Text = "Location";
			// 
			// LocationTB
			// 
			this.LocationTB.Location = new System.Drawing.Point(157, 234);
			this.LocationTB.Name = "LocationTB";
			this.LocationTB.Size = new System.Drawing.Size(287, 26);
			this.LocationTB.TabIndex = 7;
			// 
			// StartDateLabel
			// 
			this.StartDateLabel.AutoSize = true;
			this.StartDateLabel.Location = new System.Drawing.Point(48, 365);
			this.StartDateLabel.Name = "StartDateLabel";
			this.StartDateLabel.Size = new System.Drawing.Size(83, 20);
			this.StartDateLabel.TabIndex = 8;
			this.StartDateLabel.Text = "Start Date";
			// 
			// StartDTP
			// 
			this.StartDTP.CustomFormat = "MM/dd/yyyy hh:mm tt";
			this.StartDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.StartDTP.Location = new System.Drawing.Point(157, 360);
			this.StartDTP.Name = "StartDTP";
			this.StartDTP.ShowUpDown = true;
			this.StartDTP.Size = new System.Drawing.Size(287, 26);
			this.StartDTP.TabIndex = 9;
			// 
			// EndDateLabel
			// 
			this.EndDateLabel.AutoSize = true;
			this.EndDateLabel.Location = new System.Drawing.Point(48, 406);
			this.EndDateLabel.Name = "EndDateLabel";
			this.EndDateLabel.Size = new System.Drawing.Size(77, 20);
			this.EndDateLabel.TabIndex = 10;
			this.EndDateLabel.Text = "End Date";
			// 
			// EndDTP
			// 
			this.EndDTP.CustomFormat = "MM/dd/yyyy hh:mm tt";
			this.EndDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.EndDTP.Location = new System.Drawing.Point(157, 406);
			this.EndDTP.Name = "EndDTP";
			this.EndDTP.ShowUpDown = true;
			this.EndDTP.Size = new System.Drawing.Size(287, 26);
			this.EndDTP.TabIndex = 11;
			// 
			// AcceptButton
			// 
			this.AcceptButton.Location = new System.Drawing.Point(157, 464);
			this.AcceptButton.Name = "AcceptButton";
			this.AcceptButton.Size = new System.Drawing.Size(95, 34);
			this.AcceptButton.TabIndex = 12;
			this.AcceptButton.Text = "Accept";
			this.AcceptButton.UseVisualStyleBackColor = true;
			this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
			// 
			// CancelButton
			// 
			this.CancelButton.Location = new System.Drawing.Point(349, 464);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(95, 34);
			this.CancelButton.TabIndex = 13;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// ContactLabel
			// 
			this.ContactLabel.AutoSize = true;
			this.ContactLabel.Location = new System.Drawing.Point(48, 278);
			this.ContactLabel.Name = "ContactLabel";
			this.ContactLabel.Size = new System.Drawing.Size(65, 20);
			this.ContactLabel.TabIndex = 14;
			this.ContactLabel.Text = "Contact";
			// 
			// TypeLabel
			// 
			this.TypeLabel.AutoSize = true;
			this.TypeLabel.Location = new System.Drawing.Point(48, 317);
			this.TypeLabel.Name = "TypeLabel";
			this.TypeLabel.Size = new System.Drawing.Size(43, 20);
			this.TypeLabel.TabIndex = 15;
			this.TypeLabel.Text = "Type";
			// 
			// ContactTB
			// 
			this.ContactTB.Location = new System.Drawing.Point(157, 275);
			this.ContactTB.Name = "ContactTB";
			this.ContactTB.Size = new System.Drawing.Size(287, 26);
			this.ContactTB.TabIndex = 16;
			// 
			// TypeTB
			// 
			this.TypeTB.Location = new System.Drawing.Point(157, 314);
			this.TypeTB.Name = "TypeTB";
			this.TypeTB.Size = new System.Drawing.Size(287, 26);
			this.TypeTB.TabIndex = 17;
			// 
			// AddAppointmentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(530, 660);
			this.Controls.Add(this.TypeTB);
			this.Controls.Add(this.ContactTB);
			this.Controls.Add(this.TypeLabel);
			this.Controls.Add(this.ContactLabel);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.AcceptButton);
			this.Controls.Add(this.EndDTP);
			this.Controls.Add(this.EndDateLabel);
			this.Controls.Add(this.StartDTP);
			this.Controls.Add(this.StartDateLabel);
			this.Controls.Add(this.LocationTB);
			this.Controls.Add(this.LocationLabel);
			this.Controls.Add(this.DescriptionTB);
			this.Controls.Add(this.DescriptionLabel);
			this.Controls.Add(this.TitleLabel);
			this.Controls.Add(this.CustomerLabel);
			this.Controls.Add(this.TitleTB);
			this.Controls.Add(this.CustomerCB);
			this.Name = "AddAppointmentForm";
			this.Text = "AddAppointmentForm";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CustomerCB;
        private System.Windows.Forms.TextBox TitleTB;
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox DescriptionTB;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.TextBox LocationTB;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.DateTimePicker StartDTP;
        private System.Windows.Forms.Label EndDateLabel;
        private System.Windows.Forms.DateTimePicker EndDTP;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label ContactLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.TextBox ContactTB;
        private System.Windows.Forms.TextBox TypeTB;
    }
}