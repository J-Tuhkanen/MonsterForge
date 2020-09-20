using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterForge
{
    class SQLHandler
    {
        string provider = ConfigurationManager.AppSettings["provider"];
        string connectionString = ConfigurationManager.AppSettings["connectionString"];
        DbProviderFactory factory;

        public SQLHandler()
        {
            this.factory = DbProviderFactories.GetFactory(this.provider);
        }

        // Adds monster into the database.
        public void AddNewMonster(Monster monster)
        {
            using (DbConnection connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();

                DbCommand command = factory.CreateCommand();

                command.Connection = connection;
                command.CommandText = $"INSERT INTO MonsterTable (Name, Health, Mana, Stamina, Type, Description) " +
                    $"VALUES('{monster.Name}', {monster.Health} ,{monster.Mana},{monster.Stamina},'{monster.Type}','{monster.Description}')";

                command.ExecuteNonQuery();
            }
        }

        public List<Monster> GetMonstersFromDatabase()
        {
            using (DbConnection connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();

                DbCommand command = factory.CreateCommand();

                command.Connection = connection;
                command.CommandText = "SELECT * FROM MonsterTable";

                List<Monster> monsterCollection = new List<Monster>();

                using (DbDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Console.WriteLine(dataReader["Name"]);
                        monsterCollection.Add(new Monster(                            
                            (string)dataReader["Name"], 
                            (int)dataReader["Health"],
                            (int)dataReader["Mana"],
                            (int)dataReader["Stamina"],
                            (string)dataReader["Type"],
                            (string)dataReader["Description"],
                            (int)dataReader["Id"]));
                    }
                }

                return monsterCollection;
            }
        }

        public void DeleteMonsterFromDatabase(int ID)
        {
            using (DbConnection connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();

                DbCommand command = factory.CreateCommand();

                command.Connection = connection;
                command.CommandText = $"DELETE FROM MonsterTable WHERE Id={ID}";

                command.ExecuteNonQuery();
            }
        }

        public void UpdateMonsterInDatabase(Monster monster)
        {
            using (DbConnection connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();

                DbCommand command = factory.CreateCommand();

                command.Connection = connection;

                command.CommandText = $"UPDATE MonsterTable SET " +
                    $"Name='{monster.Name}'," +
                    $"Health={monster.Health}," +
                    $"Mana={monster.Mana}," +
                    $"Stamina={monster.Stamina}," +
                    $"Type='{monster.Type}'," +
                    $"Description='{monster.Description}' WHERE ID={monster.ID};";

                command.ExecuteNonQuery();
            }
        }
    }
}
