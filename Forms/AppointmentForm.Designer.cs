namespace C969.Forms
{
    partial class AppointmentForm
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
			this.QuitButton = new System.Windows.Forms.Button();
			this.MainButton = new System.Windows.Forms.Button();
			this.DeleteButton = new System.Windows.Forms.Button();
			this.UpdateButton = new System.Windows.Forms.Button();
			this.AddButton = new System.Windows.Forms.Button();
			this.AppointmentsDGV = new System.Windows.Forms.DataGridView();
			this.rbAll = new System.Windows.Forms.RadioButton();
			this.rbWeek = new System.Windows.Forms.RadioButton();
			this.rbMonth = new System.Windows.Forms.RadioButton();
			this.AppointmentCalendar = new System.Windows.Forms.MonthCalendar();
			((System.ComponentModel.ISupportInitialize)(this.AppointmentsDGV)).BeginInit();
			this.SuspendLayout();
			// 
			// QuitButton
			// 
			this.QuitButton.Location = new System.Drawing.Point(1117, 409);
			this.QuitButton.Name = "QuitButton";
			this.QuitButton.Size = new System.Drawing.Size(119, 35);
			this.QuitButton.TabIndex = 11;
			this.QuitButton.Text = "Quit";
			this.QuitButton.UseVisualStyleBackColor = true;
			this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
			// 
			// MainButton
			// 
			this.MainButton.Location = new System.Drawing.Point(31, 409);
			this.MainButton.Name = "MainButton";
			this.MainButton.Size = new System.Drawing.Size(119, 35);
			this.MainButton.TabIndex = 10;
			this.MainButton.Text = "Main";
			this.MainButton.UseVisualStyleBackColor = true;
			this.MainButton.Click += new System.EventHandler(this.MainButton_Click);
			// 
			// DeleteButton
			// 
			this.DeleteButton.Location = new System.Drawing.Point(1117, 307);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(119, 35);
			this.DeleteButton.TabIndex = 9;
			this.DeleteButton.Text = "Delete";
			this.DeleteButton.UseVisualStyleBackColor = true;
			this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// UpdateButton
			// 
			this.UpdateButton.Location = new System.Drawing.Point(992, 307);
			this.UpdateButton.Name = "UpdateButton";
			this.UpdateButton.Size = new System.Drawing.Size(119, 35);
			this.UpdateButton.TabIndex = 8;
			this.UpdateButton.Text = "Update";
			this.UpdateButton.UseVisualStyleBackColor = true;
			this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
			// 
			// AddButton
			// 
			this.AddButton.Location = new System.Drawing.Point(867, 307);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(119, 35);
			this.AddButton.TabIndex = 7;
			this.AddButton.Text = "Add";
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// AppointmentsDGV
			// 
			this.AppointmentsDGV.AllowUserToAddRows = false;
			this.AppointmentsDGV.AllowUserToDeleteRows = false;
			this.AppointmentsDGV.AllowUserToResizeColumns = false;
			this.AppointmentsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.AppointmentsDGV.Location = new System.Drawing.Point(355, 32);
			this.AppointmentsDGV.Name = "AppointmentsDGV";
			this.AppointmentsDGV.ReadOnly = true;
			this.AppointmentsDGV.RowHeadersWidth = 62;
			this.AppointmentsDGV.RowTemplate.Height = 28;
			this.AppointmentsDGV.Size = new System.Drawing.Size(881, 256);
			this.AppointmentsDGV.TabIndex = 6;
			// 
			// rbAll
			// 
			this.rbAll.AutoSize = true;
			this.rbAll.Location = new System.Drawing.Point(364, 312);
			this.rbAll.Name = "rbAll";
			this.rbAll.Size = new System.Drawing.Size(51, 24);
			this.rbAll.TabIndex = 12;
			this.rbAll.TabStop = true;
			this.rbAll.Text = "All";
			this.rbAll.UseVisualStyleBackColor = true;
			this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
			// 
			// rbWeek
			// 
			this.rbWeek.AutoSize = true;
			this.rbWeek.Location = new System.Drawing.Point(434, 312);
			this.rbWeek.Name = "rbWeek";
			this.rbWeek.Size = new System.Drawing.Size(132, 24);
			this.rbWeek.TabIndex = 13;
			this.rbWeek.TabStop = true;
			this.rbWeek.Text = "Current Week";
			this.rbWeek.UseVisualStyleBackColor = true;
			this.rbWeek.CheckedChanged += new System.EventHandler(this.rbWeek_CheckedChanged);
			// 
			// rbMonth
			// 
			this.rbMonth.AutoSize = true;
			this.rbMonth.Location = new System.Drawing.Point(572, 312);
			this.rbMonth.Name = "rbMonth";
			this.rbMonth.Size = new System.Drawing.Size(136, 24);
			this.rbMonth.TabIndex = 14;
			this.rbMonth.TabStop = true;
			this.rbMonth.Text = "Current Month";
			this.rbMonth.UseVisualStyleBackColor = true;
			this.rbMonth.CheckedChanged += new System.EventHandler(this.rbMonth_CheckedChanged);
			// 
			// AppointmentCalendar
			// 
			this.AppointmentCalendar.Location = new System.Drawing.Point(7, 35);
			this.AppointmentCalendar.MaxSelectionCount = 1;
			this.AppointmentCalendar.Name = "AppointmentCalendar";
			this.AppointmentCalendar.TabIndex = 15;
			this.AppointmentCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.AppointmentCalendar_DateSelected);
			// 
			// AppointmentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1260, 488);
			this.Controls.Add(this.AppointmentCalendar);
			this.Controls.Add(this.rbMonth);
			this.Controls.Add(this.rbWeek);
			this.Controls.Add(this.rbAll);
			this.Controls.Add(this.QuitButton);
			this.Controls.Add(this.MainButton);
			this.Controls.Add(this.DeleteButton);
			this.Controls.Add(this.UpdateButton);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.AppointmentsDGV);
			this.Name = "AppointmentForm";
			this.Text = "AppointmentForm";
			((System.ComponentModel.ISupportInitialize)(this.AppointmentsDGV)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button MainButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView AppointmentsDGV;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.RadioButton rbWeek;
        private System.Windows.Forms.RadioButton rbMonth;
        private System.Windows.Forms.MonthCalendar AppointmentCalendar;
    }
}