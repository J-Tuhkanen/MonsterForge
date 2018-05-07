using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MonsterForge
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();            
        }
        // Buttons and their actions
        private void resetButton_Click(object sender, EventArgs e)
        {
            emptyAllFields();           
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            NPCDatabaseConnection npcConn = new NPCDatabaseConnection();
            npcConn.sendMonsterDataToDB(getAllFieldsData());

            //After sending data to the database, empty the fields since the values are already saved.
            emptyAllFields();
        }        

        private void emptyAllFields()
        {
            npcNameTextBox.Text     = "";
            healthTextBox.Text      = "";
            staminaTextBox.Text     = "";
            manaTextBox.Text        = "";
            typeTextBox.Text        = "";
            descriptionTextBox.Text = "";
        }

        //Gets all the data from the fields and returns them.
        private string[] getAllFieldsData()
        {
            return new string[]
            {
                npcNameTextBox.Text,
                healthTextBox.Text,
                staminaTextBox.Text,
                manaTextBox.Text,
                typeTextBox.Text,
                descriptionTextBox.Text
            };
        }

        private void configureDatabaseMenuButton_Click(object sender, EventArgs e)
        {
            DatabaseConfigurationForm dbConfigurationsForm = new DatabaseConfigurationForm();
            dbConfigurationsForm.Show();

        }

        private void npcListMenuButton_Click(object sender, EventArgs e)
        {
            ViewMonstersForm monstersView = new ViewMonstersForm();
            monstersView.Show();
        }
    }
}
