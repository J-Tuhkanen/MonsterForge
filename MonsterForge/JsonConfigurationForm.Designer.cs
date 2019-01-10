namespace MonsterForge
{
    partial class JsonConfigurationForm
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
            this.jsonFolderPathTextBox = new System.Windows.Forms.TextBox();
            this.jsonFilePathLabel = new System.Windows.Forms.Label();
            this.jsonFileNameLabel = new System.Windows.Forms.Label();
            this.saveJsonConfigurationButton = new System.Windows.Forms.Button();
            this.cancelJsonConfigrationButton = new System.Windows.Forms.Button();
            this.jsonFileNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // jsonFolderPathTextBox
            // 
            this.jsonFolderPathTextBox.Location = new System.Drawing.Point(25, 40);
            this.jsonFolderPathTextBox.Name = "jsonFolderPathTextBox";
            this.jsonFolderPathTextBox.Size = new System.Drawing.Size(200, 20);
            this.jsonFolderPathTextBox.TabIndex = 0;
            // 
            // jsonFilePathLabel
            // 
            this.jsonFilePathLabel.AutoSize = true;
            this.jsonFilePathLabel.Location = new System.Drawing.Point(22, 24);
            this.jsonFilePathLabel.Name = "jsonFilePathLabel";
            this.jsonFilePathLabel.Size = new System.Drawing.Size(80, 13);
            this.jsonFilePathLabel.TabIndex = 1;
            this.jsonFilePathLabel.Text = "JSON file folder";
            // 
            // jsonFileNameLabel
            // 
            this.jsonFileNameLabel.AutoSize = true;
            this.jsonFileNameLabel.Location = new System.Drawing.Point(22, 78);
            this.jsonFileNameLabel.Name = "jsonFileNameLabel";
            this.jsonFileNameLabel.Size = new System.Drawing.Size(80, 13);
            this.jsonFileNameLabel.TabIndex = 3;
            this.jsonFileNameLabel.Text = "JSON file name";
            // 
            // saveJsonConfigurationButton
            // 
            this.saveJsonConfigurationButton.Location = new System.Drawing.Point(25, 139);
            this.saveJsonConfigurationButton.Name = "saveJsonConfigurationButton";
            this.saveJsonConfigurationButton.Size = new System.Drawing.Size(75, 23);
            this.saveJsonConfigurationButton.TabIndex = 4;
            this.saveJsonConfigurationButton.Text = "Save";
            this.saveJsonConfigurationButton.UseVisualStyleBackColor = true;
            this.saveJsonConfigurationButton.Click += new System.EventHandler(this.saveJsonConfigurationButton_Click);
            // 
            // cancelJsonConfigrationButton
            // 
            this.cancelJsonConfigrationButton.Location = new System.Drawing.Point(117, 139);
            this.cancelJsonConfigrationButton.Name = "cancelJsonConfigrationButton";
            this.cancelJsonConfigrationButton.Size = new System.Drawing.Size(75, 23);
            this.cancelJsonConfigrationButton.TabIndex = 5;
            this.cancelJsonConfigrationButton.Text = "Cancel";
            this.cancelJsonConfigrationButton.UseVisualStyleBackColor = true;
            this.cancelJsonConfigrationButton.Click += new System.EventHandler(this.cancelJsonConfigrationButton_Click);
            // 
            // jsonFileNameTextBox
            // 
            this.jsonFileNameTextBox.Location = new System.Drawing.Point(25, 94);
            this.jsonFileNameTextBox.Name = "jsonFileNameTextBox";
            this.jsonFileNameTextBox.Size = new System.Drawing.Size(197, 20);
            this.jsonFileNameTextBox.TabIndex = 6;
            // 
            // JsonConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 174);
            this.Controls.Add(this.jsonFileNameTextBox);
            this.Controls.Add(this.cancelJsonConfigrationButton);
            this.Controls.Add(this.saveJsonConfigurationButton);
            this.Controls.Add(this.jsonFileNameLabel);
            this.Controls.Add(this.jsonFilePathLabel);
            this.Controls.Add(this.jsonFolderPathTextBox);
            this.Name = "JsonConfigurationForm";
            this.Text = "JsonConfigurationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox jsonFolderPathTextBox;
        private System.Windows.Forms.Label jsonFilePathLabel;
        private System.Windows.Forms.Label jsonFileNameLabel;
        private System.Windows.Forms.Button saveJsonConfigurationButton;
        private System.Windows.Forms.Button cancelJsonConfigrationButton;
        private System.Windows.Forms.TextBox jsonFileNameTextBox;
    }
}