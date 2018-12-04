namespace MonsterForge
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.npcNameLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.healthLabel = new System.Windows.Forms.Label();
            this.staminaLabel = new System.Windows.Forms.Label();
            this.manaLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.healthTextBox = new System.Windows.Forms.TextBox();
            this.manaTextBox = new System.Windows.Forms.TextBox();
            this.staminaTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.npcNameTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.habylToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureDatabaseMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.npcListMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.configureJsonMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // npcNameLabel
            // 
            resources.ApplyResources(this.npcNameLabel, "npcNameLabel");
            this.npcNameLabel.Name = "npcNameLabel";
            // 
            // submitButton
            // 
            resources.ApplyResources(this.submitButton, "submitButton");
            this.submitButton.Name = "submitButton";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // resetButton
            // 
            resources.ApplyResources(this.resetButton, "resetButton");
            this.resetButton.Name = "resetButton";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // healthLabel
            // 
            resources.ApplyResources(this.healthLabel, "healthLabel");
            this.healthLabel.Name = "healthLabel";
            // 
            // staminaLabel
            // 
            resources.ApplyResources(this.staminaLabel, "staminaLabel");
            this.staminaLabel.Name = "staminaLabel";
            // 
            // manaLabel
            // 
            resources.ApplyResources(this.manaLabel, "manaLabel");
            this.manaLabel.Name = "manaLabel";
            // 
            // typeLabel
            // 
            resources.ApplyResources(this.typeLabel, "typeLabel");
            this.typeLabel.Name = "typeLabel";
            // 
            // healthTextBox
            // 
            resources.ApplyResources(this.healthTextBox, "healthTextBox");
            this.healthTextBox.Name = "healthTextBox";
            // 
            // manaTextBox
            // 
            resources.ApplyResources(this.manaTextBox, "manaTextBox");
            this.manaTextBox.Name = "manaTextBox";
            // 
            // staminaTextBox
            // 
            resources.ApplyResources(this.staminaTextBox, "staminaTextBox");
            this.staminaTextBox.Name = "staminaTextBox";
            // 
            // typeTextBox
            // 
            resources.ApplyResources(this.typeTextBox, "typeTextBox");
            this.typeTextBox.Name = "typeTextBox";
            // 
            // descriptionTextBox
            // 
            resources.ApplyResources(this.descriptionTextBox, "descriptionTextBox");
            this.descriptionTextBox.Name = "descriptionTextBox";
            // 
            // descriptionLabel
            // 
            resources.ApplyResources(this.descriptionLabel, "descriptionLabel");
            this.descriptionLabel.Name = "descriptionLabel";
            // 
            // npcNameTextBox
            // 
            resources.ApplyResources(this.npcNameTextBox, "npcNameTextBox");
            this.npcNameTextBox.Name = "npcNameTextBox";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.habylToolStripMenuItem,
            this.viewToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // habylToolStripMenuItem
            // 
            this.habylToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configureDatabaseMenuButton,
            this.configureJsonMenuButton});
            this.habylToolStripMenuItem.Name = "habylToolStripMenuItem";
            resources.ApplyResources(this.habylToolStripMenuItem, "habylToolStripMenuItem");
            // 
            // configureDatabaseMenuButton
            // 
            this.configureDatabaseMenuButton.Name = "configureDatabaseMenuButton";
            resources.ApplyResources(this.configureDatabaseMenuButton, "configureDatabaseMenuButton");
            this.configureDatabaseMenuButton.Click += new System.EventHandler(this.configureDatabaseMenuButton_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.npcListMenuButton});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            resources.ApplyResources(this.viewToolStripMenuItem, "viewToolStripMenuItem");
            // 
            // npcListMenuButton
            // 
            this.npcListMenuButton.Name = "npcListMenuButton";
            resources.ApplyResources(this.npcListMenuButton, "npcListMenuButton");
            this.npcListMenuButton.Click += new System.EventHandler(this.npcListMenuButton_Click);
            // 
            // configureJsonMenuButton
            // 
            this.configureJsonMenuButton.Name = "configureJsonMenuButton";
            resources.ApplyResources(this.configureJsonMenuButton, "configureJsonMenuButton");
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.npcNameTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.staminaTextBox);
            this.Controls.Add(this.manaTextBox);
            this.Controls.Add(this.healthTextBox);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.manaLabel);
            this.Controls.Add(this.staminaLabel);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.npcNameLabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label npcNameLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.Label staminaLabel;
        private System.Windows.Forms.Label manaLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.TextBox healthTextBox;
        private System.Windows.Forms.TextBox manaTextBox;
        private System.Windows.Forms.TextBox staminaTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox npcNameTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem habylToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureDatabaseMenuButton;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem npcListMenuButton;
        private System.Windows.Forms.ToolStripMenuItem configureJsonMenuButton;
    }
}

