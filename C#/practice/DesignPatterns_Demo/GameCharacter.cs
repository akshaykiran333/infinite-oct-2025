using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Demo
{
    internal class GameCharacter
    {
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public List<string> Skills { get; set; }
        public GameCharacter Clone()
        {
            return new GameCharacter
            {
                Health = this.Health,
                Attack = this.Attack,
                Defense = this.Defense,
                Skills = new List<string>(this.Skills)
            };
        }
        public void ShowInfo(string name)
        {
            Console.WriteLine($"--- {name} ---");
            Console.WriteLine($"Health: {Health}, Attack: {Attack}, Defense: {Defense}");
            Console.WriteLine("Skills: " + string.Join(", ", Skills));
            Console.WriteLine();
        }
    }
}
