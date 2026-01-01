using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Demo
{
    internal class GameCharacterMain
    {
        static void Main(string[] args)
        {
            GameCharacter warriorPrototype = new GameCharacter
            {
                Health = 100,
                Attack = 20,
                Defense = 15,
                Skills = new List<string> { "Slash", "Block" }
            };

            GameCharacter warrior1 = warriorPrototype.Clone();
            GameCharacter warrior2 = warriorPrototype.Clone();

            warrior2.Skills.Add("Power Strike");

            warriorPrototype.ShowInfo("Base Warrior Prototype");
            warrior1.ShowInfo("Warrior Unit 1");
            warrior2.ShowInfo("Warrior Unit 2");
        }
    }
}

