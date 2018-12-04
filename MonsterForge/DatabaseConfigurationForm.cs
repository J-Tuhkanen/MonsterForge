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
    public partial class DatabaseConfigurationForm : Form
    {
        Configuration applicationConfigurations = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        //These variables will be used to fill the fields with set values when form is opened.
        private string hostAddress  = ConfigurationManager.AppSettings["hostAddress"];
        private string username     = ConfigurationManager.AppSettings["username"];
        private string password     = ConfigurationManager.AppSettings["password"];
        private string databaseName = ConfigurationManager.AppSettings["databaseName"];
        private string tableName    = ConfigurationManager.AppSettings["tableName"];

        //Form Initialization
        public DatabaseConfigurationForm()
        {
            InitializeComponent();
            
            //On init, we fill the fields with current values of configurations file.
            hostAddressTextBox.Text = hostAddress;
            databaseTextBox.Text    = databaseName;
            tablenameTextBox.Text   = tableName;
            usernameTextBox.Text    = username;
            passWordTextBox.Text    = password;
        }

        
        private void saveConfigurationsButton_Click(object sender, EventArgs e)
        {
            applicationConfigurations.AppSettings.Settings["hostAddress"].Value     = hostAddressTextBox.Text;
            applicationConfigurations.AppSettings.Settings["username"].Value        = usernameTextBox.Text;
            applicationConfigurations.AppSettings.Settings["password"].Value        = passWordTextBox.Text;
            applicationConfigurations.AppSettings.Settings["databaseName"].Value    = databaseTextBox.Text;
            applicationConfigurations.AppSettings.Settings["tableName"].Value       = tablenameTextBox.Text;

            //Save the changes
            applicationConfigurations.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(applicationConfigurations.AppSettings.SectionInformation.Name);

            //Close this form
            Close();

            //Note: Changing App.config file manually in any way, will reset the configurations to default.
            //Default configurations can be seen in App.config at all times.
        }
    }
}
