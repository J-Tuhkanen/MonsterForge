using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Configuration;
using System.Windows.Forms;

namespace MonsterForge
{
    class JSONHandler
    {
        // Declare configurations into a variable(s) from App.config
        private Configuration applicationConfigurations = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        private string jsonFileName                     = ConfigurationManager.AppSettings["jsonFileName"];
        private string jsonFileFolderPath               = ConfigurationManager.AppSettings["jsonFileFolder"];
        private string jsonFullPath;

        public JSONHandler()
        { 
            //Check if last character of folder path is a slash, if not, add it.
            if (jsonFileFolderPath.Substring(jsonFileFolderPath.Length - 1, 1) != "\\" || jsonFileFolderPath.Substring(jsonFileFolderPath.Length - 1, 1) != "/")
            {
                jsonFileFolderPath += "/";
            }

            jsonFullPath = jsonFileFolderPath + jsonFileName + ".json";
        }

        private void CheckIfFileExists()
        {
            // If file doesn't exist. This function creates a file and writes an empty json object in it.
            if(!File.Exists(jsonFullPath))
            {
                JObject emptyInitJsonObject = new JObject();
                File.WriteAllText(jsonFullPath, emptyInitJsonObject.ToString());                
            }
        }

        // Function returns file content as JObject.
        private JObject GetMonsterDataFromJson()
        {
            return JsonConvert.DeserializeObject<JObject>(File.ReadAllText(jsonFullPath));
        }

        private void WriteJsonIntoAFile(string fileContent)
        {
            CheckIfFileExists();

            File.WriteAllText(jsonFullPath, fileContent);
        }

        // Function accissible outside this class.
        public void DeleteObjectByName(string objectName)
        {
            JObject npcData = GetMonsterDataFromJson();

            try
            {
                npcData.Property(objectName).Remove();
                WriteJsonIntoAFile(npcData.ToString());
            }

            // Object by the given name was not found.
            catch (NullReferenceException nullEx)
            {
                MessageBox.Show(nullEx.Message);
            }
        }

        // Take the monster as argument and send it to a writing 
        public void WriteMonsterIntoAFile(Monster monster)
        {
            JObject monsterData = new JObject();
            monsterData = GetMonsterDataFromJson();

            // Convert the object into a JArray. Parse removes slashes.
            monsterData[monster.Name] = JObject.Parse(JsonConvert.SerializeObject(monster));

            WriteJsonIntoAFile(monsterData.ToString());
        } 

        public Monster[] GetMonsterDataAsArray()
        {
            JObject monsters = GetMonsterDataFromJson();
            List<Monster> monstersArray = new List<Monster>();

            foreach(var monster in monsters)
            {
                monstersArray.Add(new Monster(
                    monsters[monster.Key]["Name"].ToString(),
                    int.Parse(monsters[monster.Key]["Health"].ToString()),
                    int.Parse(monsters[monster.Key]["Mana"].ToString()),
                    int.Parse(monsters[monster.Key]["Stamina"].ToString()),
                    monsters[monster.Key]["Type"].ToString(),
                    monsters[monster.Key]["Description"].ToString()
                ));
            }
            return monstersArray.ToArray();
        }
    }
}