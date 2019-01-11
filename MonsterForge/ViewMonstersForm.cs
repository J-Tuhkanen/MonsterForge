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
        private JSONHandler jsonHandler = new JSONHandler();
        
        public ViewMonstersForm()
        {            
            InitializeComponent();

            deleteButton.Enabled = false;
            editButton.Enabled = false;

            FillListView();
        }

        private void FillListView()
        {
            Monster[] monsters = jsonHandler.GetMonsterDataAsArray();

            foreach (Monster monster in monsters)
            {
                ListViewItem newItem = new ListViewItem();

                newItem.Text = monster.Name;
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

            jsonHandler.DeleteObjectByName(selectedItem.Text);
            selectedItem.Remove();
        }

        private void editButton_Click(object sender, EventArgs e)
        {

        }
    }
}
