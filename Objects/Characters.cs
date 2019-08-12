using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 //STUDENT: Duc Thang ONG
 //ID: 301051523
 //DESCRIPTION: this is the character class
                this is also the
     */

namespace COMP123_S2019_FinalTest.Objects
{
    public class Characters
    {
        // Character Abilities
        public string Strength { get; set; }
        public string Dexterity { get; set; }
        public string Constitution { get; set; }
        public string Intelligence { get; set; }
        public string Wisdom { get; set; }
        public string Charisma { get; set; }

        // Secondary Abilities
        public int ArmourClass { get; set; }
        public int HitPoints { get; set; }

        // Character Class
        public CharacterClass Class { get; set; }
        public int Level { get; set; }

        // Equipment
        List<Item> Inventory;

        // Constructor
        void Character()
        {
            this.Inventory = new List<Item>();
        }
    }
}
