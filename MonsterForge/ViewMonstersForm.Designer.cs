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
            this.SuspendLayout();
            // 
            // monsterListView
            // 
            this.monsterListView.Location = new System.Drawing.Point(24, 25);
            this.monsterListView.Name = "monsterListView";
            this.monsterListView.Size = new System.Drawing.Size(744, 298);
            this.monsterListView.TabIndex = 0;
            this.monsterListView.UseCompatibleStateImageBehavior = false;
            // 
            // ViewMonstersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.monsterListView);
            this.Name = "ViewMonstersForm";
            this.Text = "DatabaseView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView monsterListView;
    }
}