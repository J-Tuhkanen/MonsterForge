using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace MonsterForge
{
    class NPCDatabaseConnection
    {
        private string connectionString;

        private string hostAddress  = ConfigurationManager.AppSettings["hostAddress"];
        private string username     = ConfigurationManager.AppSettings["username"];
        private string password     = ConfigurationManager.AppSettings["password"];
        private string databaseName = ConfigurationManager.AppSettings["databaseName"];
        private string tableName    = ConfigurationManager.AppSettings["tableName"];

        public NPCDatabaseConnection()
        {
            connectionString = $"Server={ hostAddress }; Database={ databaseName }; Uid={ username }; Pwd={ password };";
        }

        private void sendMonsterDataToDB()
        {
            using (SqlConnection databaseConnection = new SqlConnection(connectionString))
            {
                
            }
        }

    }
}
