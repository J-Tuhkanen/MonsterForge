namespace MonsterForge
{
    partial class EditForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.staminaTextBox = new System.Windows.Forms.TextBox();
            this.stamineLabel = new System.Windows.Forms.Label();
            this.manaLabel = new System.Windows.Forms.Label();
            this.healthLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.manaTextBox = new System.Windows.Forms.TextBox();
            this.healthTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(20, 30);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // staminaTextBox
            // 
            this.staminaTextBox.Location = new System.Drawing.Point(93, 117);
            this.staminaTextBox.Name = "staminaTextBox";
            this.staminaTextBox.Size = new System.Drawing.Size(157, 20);
            this.staminaTextBox.TabIndex = 1;
            this.staminaTextBox.TextChanged += new System.EventHandler(this.staminaTextBox_TextChanged);
            // 
            // stamineLabel
            // 
            this.stamineLabel.AutoSize = true;
            this.stamineLabel.Location = new System.Drawing.Point(20, 120);
            this.stamineLabel.Name = "stamineLabel";
            this.stamineLabel.Size = new System.Drawing.Size(45, 13);
            this.stamineLabel.TabIndex = 2;
            this.stamineLabel.Text = "Stamina";
            // 
            // manaLabel
            // 
            this.manaLabel.AutoSize = true;
            this.manaLabel.Location = new System.Drawing.Point(20, 90);
            this.manaLabel.Name = "manaLabel";
            this.manaLabel.Size = new System.Drawing.Size(34, 13);
            this.manaLabel.TabIndex = 3;
            this.manaLabel.Text = "Mana";
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.Location = new System.Drawing.Point(20, 60);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(38, 13);
            this.healthLabel.TabIndex = 4;
            this.healthLabel.Text = "Health";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(20, 150);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 5;
            this.descriptionLabel.Text = "Description";
            // 
            // manaTextBox
            // 
            this.manaTextBox.Location = new System.Drawing.Point(93, 87);
            this.manaTextBox.Name = "manaTextBox";
            this.manaTextBox.Size = new System.Drawing.Size(157, 20);
            this.manaTextBox.TabIndex = 6;
            this.manaTextBox.TextChanged += new System.EventHandler(this.manaTextBox_TextChanged);
            // 
            // healthTextBox
            // 
            this.healthTextBox.Location = new System.Drawing.Point(93, 57);
            this.healthTextBox.Name = "healthTextBox";
            this.healthTextBox.Size = new System.Drawing.Size(157, 20);
            this.healthTextBox.TabIndex = 7;
            this.healthTextBox.TextChanged += new System.EventHandler(this.healthTextBox_TextChanged);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(93, 147);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(157, 20);
            this.descriptionTextBox.TabIndex = 8;
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.descriptionTextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(93, 27);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(157, 20);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(23, 206);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 9;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(121, 206);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 263);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.healthTextBox);
            this.Controls.Add(this.manaTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.manaLabel);
            this.Controls.Add(this.stamineLabel);
            this.Controls.Add(this.staminaTextBox);
            this.Controls.Add(this.nameLabel);
            this.Name = "EditForm";
            this.Text = "Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox staminaTextBox;
        private System.Windows.Forms.Label stamineLabel;
        private System.Windows.Forms.Label manaLabel;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox manaTextBox;
        private System.Windows.Forms.TextBox healthTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
    }
}