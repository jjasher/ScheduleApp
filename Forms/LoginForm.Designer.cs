namespace C969.Forms
{
    partial class LoginForm
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
			this.UsernameLabel = new System.Windows.Forms.Label();
			this.PasswordLabel = new System.Windows.Forms.Label();
			this.UsernameTB = new System.Windows.Forms.TextBox();
			this.PasswordTB = new System.Windows.Forms.TextBox();
			this.AcceptButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// UsernameLabel
			// 
			this.UsernameLabel.AutoSize = true;
			this.UsernameLabel.Location = new System.Drawing.Point(106, 108);
			this.UsernameLabel.Name = "UsernameLabel";
			this.UsernameLabel.Size = new System.Drawing.Size(83, 20);
			this.UsernameLabel.TabIndex = 0;
			this.UsernameLabel.Text = "Username";
			// 
			// PasswordLabel
			// 
			this.PasswordLabel.AutoSize = true;
			this.PasswordLabel.Location = new System.Drawing.Point(106, 175);
			this.PasswordLabel.Name = "PasswordLabel";
			this.PasswordLabel.Size = new System.Drawing.Size(78, 20);
			this.PasswordLabel.TabIndex = 1;
			this.PasswordLabel.Text = "Password";
			// 
			// UsernameTB
			// 
			this.UsernameTB.Location = new System.Drawing.Point(257, 105);
			this.UsernameTB.Name = "UsernameTB";
			this.UsernameTB.Size = new System.Drawing.Size(263, 26);
			this.UsernameTB.TabIndex = 2;
			// 
			// PasswordTB
			// 
			this.PasswordTB.Location = new System.Drawing.Point(257, 172);
			this.PasswordTB.Name = "PasswordTB";
			this.PasswordTB.Size = new System.Drawing.Size(263, 26);
			this.PasswordTB.TabIndex = 3;
			// 
			// AcceptButton
			// 
			this.AcceptButton.Location = new System.Drawing.Point(257, 244);
			this.AcceptButton.Name = "AcceptButton";
			this.AcceptButton.Size = new System.Drawing.Size(103, 35);
			this.AcceptButton.TabIndex = 4;
			this.AcceptButton.Text = "Accept";
			this.AcceptButton.UseVisualStyleBackColor = true;
			this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
			// 
			// CancelButton
			// 
			this.CancelButton.Location = new System.Drawing.Point(417, 244);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(103, 35);
			this.CancelButton.TabIndex = 5;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.AcceptButton);
			this.Controls.Add(this.PasswordTB);
			this.Controls.Add(this.UsernameTB);
			this.Controls.Add(this.PasswordLabel);
			this.Controls.Add(this.UsernameLabel);
			this.Name = "LoginForm";
			this.Text = "LoginForm";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox UsernameTB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Button CancelButton;
    }
}