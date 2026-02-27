namespace C969.Forms
{
    partial class CustomersForm
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
			this.CustomersDGV = new System.Windows.Forms.DataGridView();
			this.AddButton = new System.Windows.Forms.Button();
			this.UpdateButton = new System.Windows.Forms.Button();
			this.DeleteButton = new System.Windows.Forms.Button();
			this.MainButton = new System.Windows.Forms.Button();
			this.QuitButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.CustomersDGV)).BeginInit();
			this.SuspendLayout();
			// 
			// CustomersDGV
			// 
			this.CustomersDGV.AllowUserToAddRows = false;
			this.CustomersDGV.AllowUserToDeleteRows = false;
			this.CustomersDGV.AllowUserToResizeColumns = false;
			this.CustomersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.CustomersDGV.Location = new System.Drawing.Point(42, 33);
			this.CustomersDGV.Name = "CustomersDGV";
			this.CustomersDGV.ReadOnly = true;
			this.CustomersDGV.RowHeadersWidth = 62;
			this.CustomersDGV.RowTemplate.Height = 28;
			this.CustomersDGV.Size = new System.Drawing.Size(1052, 210);
			this.CustomersDGV.TabIndex = 0;
			this.CustomersDGV.SelectionChanged += new System.EventHandler(this.CustomersDGV_SelectionChanged);
			// 
			// AddButton
			// 
			this.AddButton.Location = new System.Drawing.Point(102, 271);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(119, 35);
			this.AddButton.TabIndex = 1;
			this.AddButton.Text = "Add";
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// UpdateButton
			// 
			this.UpdateButton.Location = new System.Drawing.Point(227, 271);
			this.UpdateButton.Name = "UpdateButton";
			this.UpdateButton.Size = new System.Drawing.Size(119, 35);
			this.UpdateButton.TabIndex = 2;
			this.UpdateButton.Text = "Update";
			this.UpdateButton.UseVisualStyleBackColor = true;
			this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
			// 
			// DeleteButton
			// 
			this.DeleteButton.Location = new System.Drawing.Point(352, 271);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(119, 35);
			this.DeleteButton.TabIndex = 3;
			this.DeleteButton.Text = "Delete";
			this.DeleteButton.UseVisualStyleBackColor = true;
			this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// MainButton
			// 
			this.MainButton.Location = new System.Drawing.Point(42, 419);
			this.MainButton.Name = "MainButton";
			this.MainButton.Size = new System.Drawing.Size(119, 35);
			this.MainButton.TabIndex = 4;
			this.MainButton.Text = "Main";
			this.MainButton.UseVisualStyleBackColor = true;
			this.MainButton.Click += new System.EventHandler(this.MainButton_Click);
			// 
			// QuitButton
			// 
			this.QuitButton.Location = new System.Drawing.Point(975, 419);
			this.QuitButton.Name = "QuitButton";
			this.QuitButton.Size = new System.Drawing.Size(119, 35);
			this.QuitButton.TabIndex = 5;
			this.QuitButton.Text = "Quit";
			this.QuitButton.UseVisualStyleBackColor = true;
			this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
			// 
			// CustomersForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1137, 466);
			this.Controls.Add(this.QuitButton);
			this.Controls.Add(this.MainButton);
			this.Controls.Add(this.DeleteButton);
			this.Controls.Add(this.UpdateButton);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.CustomersDGV);
			this.Name = "CustomersForm";
			this.Text = "CustomersForm";
			((System.ComponentModel.ISupportInitialize)(this.CustomersDGV)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomersDGV;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button MainButton;
        private System.Windows.Forms.Button QuitButton;
    }
}