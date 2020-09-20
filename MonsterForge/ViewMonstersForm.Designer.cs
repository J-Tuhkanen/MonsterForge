namespace MonsterForge
{
    partial class ViewMonstersForm
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
            this.monsterListView = new System.Windows.Forms.ListView();
            this.healthColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.manaColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.staminaHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.typeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descriptionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // monsterListView
            // 
            this.monsterListView.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.monsterListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.nameColumn,
            this.healthColumn,
            this.manaColumn,
            this.staminaHeader,
            this.typeHeader,
            this.descriptionHeader});
            this.monsterListView.FullRowSelect = true;
            this.monsterListView.HideSelection = false;
            this.monsterListView.Location = new System.Drawing.Point(24, 25);
            this.monsterListView.Name = "monsterListView";
            this.monsterListView.Size = new System.Drawing.Size(744, 298);
            this.monsterListView.TabIndex = 0;
            this.monsterListView.UseCompatibleStateImageBehavior = false;
            this.monsterListView.View = System.Windows.Forms.View.Details;
            this.monsterListView.SelectedIndexChanged += new System.EventHandler(this.monsterListView_SelectedIndexChanged);
            // 
            // healthColumn
            // 
            this.healthColumn.Text = "Health";
            this.healthColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // manaColumn
            // 
            this.manaColumn.Text = "Mana";
            this.manaColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // staminaHeader
            // 
            this.staminaHeader.Text = "Stamina";
            this.staminaHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // typeHeader
            // 
            this.typeHeader.Text = "Type";
            this.typeHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.typeHeader.Width = 100;
            // 
            // descriptionHeader
            // 
            this.descriptionHeader.Text = "Description";
            this.descriptionHeader.Width = 257;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(24, 342);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(105, 342);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // ID
            // 
            this.ID.Tag = "ID";
            this.ID.Text = "ID";
            this.ID.Width = 50;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Name";
            this.nameColumn.Width = 150;
            // 
            // ViewMonstersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.monsterListView);
            this.Name = "ViewMonstersForm";
            this.Text = "DatabaseView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView monsterListView;
        private System.Windows.Forms.ColumnHeader healthColumn;
        private System.Windows.Forms.ColumnHeader manaColumn;
        private System.Windows.Forms.ColumnHeader staminaHeader;
        private System.Windows.Forms.ColumnHeader typeHeader;
        private System.Windows.Forms.ColumnHeader descriptionHeader;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader nameColumn;
    }
}