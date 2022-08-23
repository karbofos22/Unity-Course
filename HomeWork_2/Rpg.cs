using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2
{
    internal class Rpg
    {
        protected string name;
        protected int strength;
        private int hitPower;
        protected int endurance;
        private int healthPoints;

        public Rpg(string name, int strength, int endurance)
        {
            this.name = name;
            this.strength = strength;
            this.endurance = endurance;
        }

        private void CalculateStats()
        {
            hitPower = strength * 2;
            healthPoints = endurance * 3;
        }
        public void ShowInfo()
        {
            CalculateStats();
            Console.WriteLine($"Your character {name} stats:\n" +
                              $"\t{strength} strength points, which gives him a {hitPower} amount of damage output.\n" +
                              $"\t{endurance} endurance points, this is a {healthPoints} total healpoints to withstand attacks.\n");
        }
    }
}
