namespace MonsterForge
{
    partial class DatabaseConfigurationForm
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
            this.saveConfigurationsButton = new System.Windows.Forms.Button();
            this.hostAddressTextBox = new System.Windows.Forms.TextBox();
            this.hostAddressLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.databaseTextBox = new System.Windows.Forms.TextBox();
            this.tableLabel = new System.Windows.Forms.Label();
            this.tablenameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passWordTextBox = new System.Windows.Forms.TextBox();
            this.cancelConfigurationsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveConfigurationsButton
            // 
            this.saveConfigurationsButton.Location = new System.Drawing.Point(43, 224);
            this.saveConfigurationsButton.Name = "saveConfigurationsButton";
            this.saveConfigurationsButton.Size = new System.Drawing.Size(75, 23);
            this.saveConfigurationsButton.TabIndex = 0;
            this.saveConfigurationsButton.Text = "Save";
            this.saveConfigurationsButton.UseVisualStyleBackColor = true;
            this.saveConfigurationsButton.Click += new System.EventHandler(this.SaveConfigurationsButton_Click);
            // 
            // hostAddressTextBox
            // 
            this.hostAddressTextBox.Location = new System.Drawing.Point(40, 51);
            this.hostAddressTextBox.Name = "hostAddressTextBox";
            this.hostAddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.hostAddressTextBox.TabIndex = 1;
            // 
            // hostAddressLabel
            // 
            this.hostAddressLabel.AutoSize = true;
            this.hostAddressLabel.Location = new System.Drawing.Point(40, 32);
            this.hostAddressLabel.Name = "hostAddressLabel";
            this.hostAddressLabel.Size = new System.Drawing.Size(70, 13);
            this.hostAddressLabel.TabIndex = 2;
            this.hostAddressLabel.Text = "Host Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Database";
            // 
            // databaseTextBox
            // 
            this.databaseTextBox.Location = new System.Drawing.Point(40, 103);
            this.databaseTextBox.Name = "databaseTextBox";
            this.databaseTextBox.Size = new System.Drawing.Size(100, 20);
            this.databaseTextBox.TabIndex = 3;
            // 
            // tableLabel
            // 
            this.tableLabel.AutoSize = true;
            this.tableLabel.Location = new System.Drawing.Point(40, 142);
            this.tableLabel.Name = "tableLabel";
            this.tableLabel.Size = new System.Drawing.Size(65, 13);
            this.tableLabel.TabIndex = 6;
            this.tableLabel.Text = "Table Name";
            // 
            // tablenameTextBox
            // 
            this.tablenameTextBox.Location = new System.Drawing.Point(40, 161);
            this.tablenameTextBox.Name = "tablenameTextBox";
            this.tablenameTextBox.Size = new System.Drawing.Size(100, 20);
            this.tablenameTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Username";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(197, 51);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password";
            // 
            // passWordTextBox
            // 
            this.passWordTextBox.Location = new System.Drawing.Point(197, 103);
            this.passWordTextBox.Name = "passWordTextBox";
            this.passWordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passWordTextBox.TabIndex = 9;
            // 
            // cancelConfigurationsButton
            // 
            this.cancelConfigurationsButton.Location = new System.Drawing.Point(139, 224);
            this.cancelConfigurationsButton.Name = "cancelConfigurationsButton";
            this.cancelConfigurationsButton.Size = new System.Drawing.Size(75, 23);
            this.cancelConfigurationsButton.TabIndex = 11;
            this.cancelConfigurationsButton.Text = "Cancel";
            this.cancelConfigurationsButton.UseVisualStyleBackColor = true;
            this.cancelConfigurationsButton.Click += new System.EventHandler(this.cancelConfigurationsButton_Click);
            // 
            // DatabaseConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 281);
            this.Controls.Add(this.cancelConfigurationsButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passWordTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.tableLabel);
            this.Controls.Add(this.tablenameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.databaseTextBox);
            this.Controls.Add(this.hostAddressLabel);
            this.Controls.Add(this.hostAddressTextBox);
            this.Controls.Add(this.saveConfigurationsButton);
            this.Name = "DatabaseConfigurationForm";
            this.Text = "Database Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveConfigurationsButton;
        private System.Windows.Forms.TextBox hostAddressTextBox;
        private System.Windows.Forms.Label hostAddressLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox databaseTextBox;
        private System.Windows.Forms.Label tableLabel;
        private System.Windows.Forms.TextBox tablenameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passWordTextBox;
        private System.Windows.Forms.Button cancelConfigurationsButton;
    }
}