namespace C969.Forms
{
    partial class AddCustomerForm
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
			this.NameLabel = new System.Windows.Forms.Label();
			this.AddressLabel = new System.Windows.Forms.Label();
			this.PhoneLabel = new System.Windows.Forms.Label();
			this.CityLabel = new System.Windows.Forms.Label();
			this.CountryLabel = new System.Windows.Forms.Label();
			this.NameTB = new System.Windows.Forms.TextBox();
			this.AddressTB = new System.Windows.Forms.TextBox();
			this.PhoneTB = new System.Windows.Forms.TextBox();
			this.CityTB = new System.Windows.Forms.TextBox();
			this.CountryTB = new System.Windows.Forms.TextBox();
			this.AcceptButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Location = new System.Drawing.Point(102, 52);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(51, 20);
			this.NameLabel.TabIndex = 0;
			this.NameLabel.Text = "Name";
			// 
			// AddressLabel
			// 
			this.AddressLabel.AutoSize = true;
			this.AddressLabel.Location = new System.Drawing.Point(102, 93);
			this.AddressLabel.Name = "AddressLabel";
			this.AddressLabel.Size = new System.Drawing.Size(68, 20);
			this.AddressLabel.TabIndex = 1;
			this.AddressLabel.Text = "Address";
			// 
			// PhoneLabel
			// 
			this.PhoneLabel.AutoSize = true;
			this.PhoneLabel.Location = new System.Drawing.Point(102, 139);
			this.PhoneLabel.Name = "PhoneLabel";
			this.PhoneLabel.Size = new System.Drawing.Size(55, 20);
			this.PhoneLabel.TabIndex = 2;
			this.PhoneLabel.Text = "Phone";
			// 
			// CityLabel
			// 
			this.CityLabel.AutoSize = true;
			this.CityLabel.Location = new System.Drawing.Point(102, 179);
			this.CityLabel.Name = "CityLabel";
			this.CityLabel.Size = new System.Drawing.Size(35, 20);
			this.CityLabel.TabIndex = 3;
			this.CityLabel.Text = "City";
			// 
			// CountryLabel
			// 
			this.CountryLabel.AutoSize = true;
			this.CountryLabel.Location = new System.Drawing.Point(102, 221);
			this.CountryLabel.Name = "CountryLabel";
			this.CountryLabel.Size = new System.Drawing.Size(64, 20);
			this.CountryLabel.TabIndex = 4;
			this.CountryLabel.Text = "Country";
			// 
			// NameTB
			// 
			this.NameTB.Location = new System.Drawing.Point(298, 52);
			this.NameTB.Name = "NameTB";
			this.NameTB.Size = new System.Drawing.Size(266, 26);
			this.NameTB.TabIndex = 5;
			// 
			// AddressTB
			// 
			this.AddressTB.Location = new System.Drawing.Point(298, 90);
			this.AddressTB.Name = "AddressTB";
			this.AddressTB.Size = new System.Drawing.Size(266, 26);
			this.AddressTB.TabIndex = 6;
			// 
			// PhoneTB
			// 
			this.PhoneTB.Location = new System.Drawing.Point(298, 136);
			this.PhoneTB.Name = "PhoneTB";
			this.PhoneTB.Size = new System.Drawing.Size(266, 26);
			this.PhoneTB.TabIndex = 7;
			// 
			// CityTB
			// 
			this.CityTB.Location = new System.Drawing.Point(298, 176);
			this.CityTB.Name = "CityTB";
			this.CityTB.Size = new System.Drawing.Size(266, 26);
			this.CityTB.TabIndex = 8;
			// 
			// CountryTB
			// 
			this.CountryTB.Location = new System.Drawing.Point(298, 218);
			this.CountryTB.Name = "CountryTB";
			this.CountryTB.Size = new System.Drawing.Size(266, 26);
			this.CountryTB.TabIndex = 9;
			// 
			// AcceptButton
			// 
			this.AcceptButton.Location = new System.Drawing.Point(298, 292);
			this.AcceptButton.Name = "AcceptButton";
			this.AcceptButton.Size = new System.Drawing.Size(88, 34);
			this.AcceptButton.TabIndex = 10;
			this.AcceptButton.Text = "Accept";
			this.AcceptButton.UseVisualStyleBackColor = true;
			this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
			// 
			// CancelButton
			// 
			this.CancelButton.Location = new System.Drawing.Point(476, 292);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(88, 34);
			this.CancelButton.TabIndex = 11;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// AddCustomerForm
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
			this.Name = "AddCustomerForm";
			this.Text = "AddCustomerForm";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox AddressTB;
        private System.Windows.Forms.TextBox PhoneTB;
        private System.Windows.Forms.TextBox CityTB;
        private System.Windows.Forms.TextBox CountryTB;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Button CancelButton;
    }
}