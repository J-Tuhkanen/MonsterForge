using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace MonsterForge
{
    public partial class JsonConfigurationForm : Form
    {
        Configuration applicationConfigurations = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        private string jsonFileFolderPath       = ConfigurationManager.AppSettings["jsonFileFolder"];
        private string jsonFileName             = ConfigurationManager.AppSettings["jsonFileName"];

        public JsonConfigurationForm()
        {
            InitializeComponent();

            //On init, fill the fields with current settings.
            jsonFolderPathTextBox.Text  = jsonFileFolderPath;
            jsonFileNameTextBox.Text    = jsonFileName;
            
        }

        private void saveJsonConfigurationButton_Click(object sender, EventArgs e)
        {
            jsonFolderPathTextBox.Text = jsonFolderPathTextBox.Text.Replace("\\", "/");
            applicationConfigurations.AppSettings.Settings["jsonFileFolder"].Value  = jsonFolderPathTextBox.Text;
            applicationConfigurations.AppSettings.Settings["jsonFileName"].Value    = jsonFileNameTextBox.Text;

            // Save the changes
            applicationConfigurations.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(applicationConfigurations.AppSettings.SectionInformation.Name);
            Close();
        }

        private void cancelJsonConfigrationButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
