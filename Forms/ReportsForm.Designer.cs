namespace C969.Forms
{
    partial class ReportsForm
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
			this.ReportsDGV = new System.Windows.Forms.DataGridView();
			this.UserScheduleButton = new System.Windows.Forms.Button();
			this.MainButton = new System.Windows.Forms.Button();
			this.QuitButton = new System.Windows.Forms.Button();
			this.MonthComboBox = new System.Windows.Forms.ComboBox();
			this.TypeComboBox = new System.Windows.Forms.ComboBox();
			this.MonthlyTypeReportButton = new System.Windows.Forms.Button();
			this.DailyCountButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.ReportsDGV)).BeginInit();
			this.SuspendLayout();
			// 
			// ReportsDGV
			// 
			this.ReportsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ReportsDGV.Location = new System.Drawing.Point(422, 54);
			this.ReportsDGV.Name = "ReportsDGV";
			this.ReportsDGV.RowHeadersWidth = 62;
			this.ReportsDGV.RowTemplate.Height = 28;
			this.ReportsDGV.Size = new System.Drawing.Size(760, 285);
			this.ReportsDGV.TabIndex = 0;
			// 
			// UserScheduleButton
			// 
			this.UserScheduleButton.Location = new System.Drawing.Point(75, 200);
			this.UserScheduleButton.Name = "UserScheduleButton";
			this.UserScheduleButton.Size = new System.Drawing.Size(285, 37);
			this.UserScheduleButton.TabIndex = 2;
			this.UserScheduleButton.Text = "User Schedule";
			this.UserScheduleButton.UseVisualStyleBackColor = true;
			this.UserScheduleButton.Click += new System.EventHandler(this.UserScheduleButton_Click);
			// 
			// MainButton
			// 
			this.MainButton.Location = new System.Drawing.Point(15, 375);
			this.MainButton.Name = "MainButton";
			this.MainButton.Size = new System.Drawing.Size(128, 38);
			this.MainButton.TabIndex = 4;
			this.MainButton.Text = "Main";
			this.MainButton.UseVisualStyleBackColor = true;
			this.MainButton.Click += new System.EventHandler(this.MainButton_Click);
			// 
			// QuitButton
			// 
			this.QuitButton.Location = new System.Drawing.Point(1054, 375);
			this.QuitButton.Name = "QuitButton";
			this.QuitButton.Size = new System.Drawing.Size(128, 38);
			this.QuitButton.TabIndex = 5;
			this.QuitButton.Text = "Quit";
			this.QuitButton.UseVisualStyleBackColor = true;
			this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
			// 
			// MonthComboBox
			// 
			this.MonthComboBox.FormattingEnabled = true;
			this.MonthComboBox.Location = new System.Drawing.Point(75, 60);
			this.MonthComboBox.Name = "MonthComboBox";
			this.MonthComboBox.Size = new System.Drawing.Size(121, 28);
			this.MonthComboBox.TabIndex = 6;
			// 
			// TypeComboBox
			// 
			this.TypeComboBox.FormattingEnabled = true;
			this.TypeComboBox.Location = new System.Drawing.Point(266, 60);
			this.TypeComboBox.Name = "TypeComboBox";
			this.TypeComboBox.Size = new System.Drawing.Size(121, 28);
			this.TypeComboBox.TabIndex = 7;
			// 
			// MonthlyTypeReportButton
			// 
			this.MonthlyTypeReportButton.Location = new System.Drawing.Point(75, 108);
			this.MonthlyTypeReportButton.Name = "MonthlyTypeReportButton";
			this.MonthlyTypeReportButton.Size = new System.Drawing.Size(285, 37);
			this.MonthlyTypeReportButton.TabIndex = 8;
			this.MonthlyTypeReportButton.Text = "Month by Type";
			this.MonthlyTypeReportButton.UseVisualStyleBackColor = true;
			this.MonthlyTypeReportButton.Click += new System.EventHandler(this.MonthlyTypeReportButton_Click_1);
			// 
			// DailyCountButton
			// 
			this.DailyCountButton.Location = new System.Drawing.Point(75, 302);
			this.DailyCountButton.Name = "DailyCountButton";
			this.DailyCountButton.Size = new System.Drawing.Size(285, 37);
			this.DailyCountButton.TabIndex = 9;
			this.DailyCountButton.Text = "Daily Appointment Count";
			this.DailyCountButton.UseVisualStyleBackColor = true;
			this.DailyCountButton.Click += new System.EventHandler(this.DailyCountButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 63);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 20);
			this.label1.TabIndex = 10;
			this.label1.Text = "Month:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(202, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 20);
			this.label2.TabIndex = 11;
			this.label2.Text = "Type:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(393, 25);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(104, 20);
			this.label3.TabIndex = 12;
			this.label3.Text = "Reports view:";
			// 
			// ReportsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1203, 425);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.DailyCountButton);
			this.Controls.Add(this.MonthlyTypeReportButton);
			this.Controls.Add(this.TypeComboBox);
			this.Controls.Add(this.MonthComboBox);
			this.Controls.Add(this.QuitButton);
			this.Controls.Add(this.MainButton);
			this.Controls.Add(this.UserScheduleButton);
			this.Controls.Add(this.ReportsDGV);
			this.Name = "ReportsForm";
			this.Text = "ReprotsForm";
			((System.ComponentModel.ISupportInitialize)(this.ReportsDGV)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ReportsDGV;
        private System.Windows.Forms.Button UserScheduleButton;
        private System.Windows.Forms.Button MainButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.ComboBox MonthComboBox;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.Button MonthlyTypeReportButton;
        private System.Windows.Forms.Button DailyCountButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}