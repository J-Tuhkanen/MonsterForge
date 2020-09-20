using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonsterForge
{
    public partial class EditForm : Form
    {
        private Monster selectedMonster;

        public EditForm(Monster monster)
        {
            InitializeComponent();
            selectedMonster = monster;
            nameTextBox.Text = monster.Name;
            healthTextBox.Text = monster.Health.ToString();
            manaTextBox.Text = monster.Mana.ToString();
            staminaTextBox.Text = monster.Stamina.ToString();
            descriptionTextBox.Text = monster.Description;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            SQLHandler sqlHandler = new SQLHandler();
            sqlHandler.UpdateMonsterInDatabase(selectedMonster);
            this.Close();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            selectedMonster.Name = nameTextBox.Text;
        }

        private void staminaTextBox_TextChanged(object sender, EventArgs e)
        {
            selectedMonster.Stamina = int.Parse(staminaTextBox.Text);
        }

        private void healthTextBox_TextChanged(object sender, EventArgs e)
        {
            selectedMonster.Health = int.Parse(healthTextBox.Text);
        }

        private void manaTextBox_TextChanged(object sender, EventArgs e)
        {
            selectedMonster.Mana = int.Parse(manaTextBox.Text);
        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            selectedMonster.Description = descriptionTextBox.Text;
        }
    }
}
