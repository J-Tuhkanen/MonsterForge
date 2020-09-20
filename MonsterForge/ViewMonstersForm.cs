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
    public partial class ViewMonstersForm : Form
    {        
        public ViewMonstersForm()
        {            
            InitializeComponent();

            deleteButton.Enabled = false;
            editButton.Enabled = false;

            FillListView();
        }

        private void FillListView(bool clearTable = false)
        {
            SQLHandler sqlHandler = new SQLHandler();
            List<Monster> monsters = sqlHandler.GetMonstersFromDatabase();

            foreach (Monster monster in monsters)
            {
                ListViewItem newItem = new ListViewItem();
                newItem.Text = monster.ID.ToString();
                newItem.SubItems.Add(monster.Name);
                newItem.SubItems.Add(monster.Health.ToString());
                newItem.SubItems.Add(monster.Mana.ToString());
                newItem.SubItems.Add(monster.Stamina.ToString());
                newItem.SubItems.Add(monster.Type);
                newItem.SubItems.Add(monster.Description);

                monsterListView.Items.Add(newItem);
            }
        }

        private void monsterListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Item will be unselected when target changes.
            if(monsterListView.SelectedItems.Count < 1)
            {
                deleteButton.Enabled = false;
                editButton.Enabled = false;
                return;
            }

            deleteButton.Enabled = true;
            editButton.Enabled = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = monsterListView.SelectedItems[0];
            SQLHandler sqlHandler = new SQLHandler();
            sqlHandler.DeleteMonsterFromDatabase(int.Parse(selectedItem.Text));
            selectedItem.Remove();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = monsterListView.SelectedItems[0];
            SQLHandler sqlHandler = new SQLHandler();

            int monsterID = int.Parse(monsterListView.SelectedItems[0].SubItems[0].Text);
            string monsterName = monsterListView.SelectedItems[0].SubItems[1].Text;
            int health = int.Parse(monsterListView.SelectedItems[0].SubItems[2].Text);
            int mana = int.Parse(monsterListView.SelectedItems[0].SubItems[3].Text);
            int stamina = int.Parse(monsterListView.SelectedItems[0].SubItems[4].Text);
            string type = monsterListView.SelectedItems[0].SubItems[5].Text;
            string description = monsterListView.SelectedItems[0].SubItems[6].Text;

            Monster selectedMonster = new Monster(monsterName, health, mana, stamina, type, description, monsterID); 
            
            EditForm editForm = new EditForm(selectedMonster);
        }
    }
}
