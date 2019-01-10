using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterForge
{
    class Monster // Template class for monster data.
    {
        public Monster(string name, int health, int mana, int stamina, string type, string description)
        {
            Name = name;
            Health = health;
            Mana = mana;
            Stamina = stamina;
            Type = type;
            Description = description;
        }

        public string Name          { get; set; }
        public int Health           { get; set; }
        public int Mana             { get; set; }
        public int Stamina          { get; set; }
        public string Type          { get; set; }
        public string Description   { get; set; }
    }
}
