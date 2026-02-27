namespace C969.Forms
{
    partial class UpdateCustomerForm
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
			this.CancelButton = new System.Windows.Forms.Button();
			this.AcceptButton = new System.Windows.Forms.Button();
			this.CountryTB = new System.Windows.Forms.TextBox();
			this.CityTB = new System.Windows.Forms.TextBox();
			this.PhoneTB = new System.Windows.Forms.TextBox();
			this.AddressTB = new System.Windows.Forms.TextBox();
			this.NameTB = new System.Windows.Forms.TextBox();
			this.CountryLabel = new System.Windows.Forms.Label();
			this.CityLabel = new System.Windows.Forms.Label();
			this.PhoneLabel = new System.Windows.Forms.Label();
			this.AddressLabel = new System.Windows.Forms.Label();
			this.NameLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// CancelButton
			// 
			this.CancelButton.Location = new System.Drawing.Point(543, 328);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(88, 34);
			this.CancelButton.TabIndex = 23;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// AcceptButton
			// 
			this.AcceptButton.Location = new System.Drawing.Point(365, 328);
			this.AcceptButton.Name = "AcceptButton";
			this.AcceptButton.Size = new System.Drawing.Size(88, 34);
			this.AcceptButton.TabIndex = 22;
			this.AcceptButton.Text = "Accept";
			this.AcceptButton.UseVisualStyleBackColor = true;
			this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
			// 
			// CountryTB
			// 
			this.CountryTB.Location = new System.Drawing.Point(365, 254);
			this.CountryTB.Name = "CountryTB";
			this.CountryTB.Size = new System.Drawing.Size(266, 26);
			this.CountryTB.TabIndex = 21;
			// 
			// CityTB
			// 
			this.CityTB.Location = new System.Drawing.Point(365, 212);
			this.CityTB.Name = "CityTB";
			this.CityTB.Size = new System.Drawing.Size(266, 26);
			this.CityTB.TabIndex = 20;
			// 
			// PhoneTB
			// 
			this.PhoneTB.Location = new System.Drawing.Point(365, 172);
			this.PhoneTB.Name = "PhoneTB";
			this.PhoneTB.Size = new System.Drawing.Size(266, 26);
			this.PhoneTB.TabIndex = 19;
			// 
			// AddressTB
			// 
			this.AddressTB.Location = new System.Drawing.Point(365, 126);
			this.AddressTB.Name = "AddressTB";
			this.AddressTB.Size = new System.Drawing.Size(266, 26);
			this.AddressTB.TabIndex = 18;
			// 
			// NameTB
			// 
			this.NameTB.Location = new System.Drawing.Point(365, 88);
			this.NameTB.Name = "NameTB";
			this.NameTB.Size = new System.Drawing.Size(266, 26);
			this.NameTB.TabIndex = 17;
			// 
			// CountryLabel
			// 
			this.CountryLabel.AutoSize = true;
			this.CountryLabel.Location = new System.Drawing.Point(169, 257);
			this.CountryLabel.Name = "CountryLabel";
			this.CountryLabel.Size = new System.Drawing.Size(64, 20);
			this.CountryLabel.TabIndex = 16;
			this.CountryLabel.Text = "Country";
			// 
			// CityLabel
			// 
			this.CityLabel.AutoSize = true;
			this.CityLabel.Location = new System.Drawing.Point(169, 215);
			this.CityLabel.Name = "CityLabel";
			this.CityLabel.Size = new System.Drawing.Size(35, 20);
			this.CityLabel.TabIndex = 15;
			this.CityLabel.Text = "City";
			// 
			// PhoneLabel
			// 
			this.PhoneLabel.AutoSize = true;
			this.PhoneLabel.Location = new System.Drawing.Point(169, 175);
			this.PhoneLabel.Name = "PhoneLabel";
			this.PhoneLabel.Size = new System.Drawing.Size(55, 20);
			this.PhoneLabel.TabIndex = 14;
			this.PhoneLabel.Text = "Phone";
			// 
			// AddressLabel
			// 
			this.AddressLabel.AutoSize = true;
			this.AddressLabel.Location = new System.Drawing.Point(169, 129);
			this.AddressLabel.Name = "AddressLabel";
			this.AddressLabel.Size = new System.Drawing.Size(68, 20);
			this.AddressLabel.TabIndex = 13;
			this.AddressLabel.Text = "Address";
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Location = new System.Drawing.Point(169, 88);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(51, 20);
			this.NameLabel.TabIndex = 12;
			this.NameLabel.Text = "Name";
			// 
			// UpdateCustomerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.AcceptButton);
			this.Controls.Add(this.CountryTB);
			this.Controls.Add(this.CityTB);
			this.Controls.Add(this.PhoneTB);
			this.Controls.Add(this.AddressTB);
			this.Controls.Add(this.NameTB);
			this.Controls.Add(this.CountryLabel);
			this.Controls.Add(this.CityLabel);
			this.Controls.Add(this.PhoneLabel);
			this.Controls.Add(this.AddressLabel);
			this.Controls.Add(this.NameLabel);
			this.Name = "UpdateCustomerForm";
			this.Text = "UpdateCustomerForm";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.TextBox CountryTB;
        private System.Windows.Forms.TextBox CityTB;
        private System.Windows.Forms.TextBox PhoneTB;
        private System.Windows.Forms.TextBox AddressTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label NameLabel;
    }
}