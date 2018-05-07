using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace MonsterForge
{
    class NPCDatabaseConnection
    {
        private string connectionString;

        public NPCDatabaseConnection()
        {
            string hostAddress  = ".";//ConfigurationManager.AppSettings["hostAddress"];
            string username     = ConfigurationManager.AppSettings["username"];
            string password     = ConfigurationManager.AppSettings["password"];
            string databaseName = ConfigurationManager.AppSettings["databaseName"];
            string tableName    = ConfigurationManager.AppSettings["tableName"];

            connectionString = $"Server={ hostAddress }; Initial Catalog={ databaseName }; Integrated Security=SSPI; Uid={ username }; Pwd={ password };";
        }

        public void sendMonsterDataToDB(string[] npcData)
        {
            using (IDbConnection databaseConnection = new SqlConnection(connectionString))
            {
                databaseConnection.Open();

                string queryString = "INSERT INTO npc(name, health, mana, stamina, type, description) VALUES(@value0, @value1, @value2, @value3, @value4);";             

                SqlCommand cmd = new SqlCommand(queryString, databaseConnection);

                cmd.Parameters.Add("@value0", SqlDbType.VarChar).Value = npcData[0];
                cmd.Parameters.Add("@value1", SqlDbType.VarChar).Value = npcData[1];
                cmd.Parameters.Add("@value2", SqlDbType.VarChar).Value = npcData[2];
                cmd.Parameters.Add("@value3", SqlDbType.VarChar).Value = npcData[3];
                cmd.Parameters.Add("@value4", SqlDbType.VarChar).Value = npcData[4];

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                databaseConnection.Close();
            }

        }

    }
}
