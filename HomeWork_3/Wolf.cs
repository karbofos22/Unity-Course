using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3
{
    internal class Wolf : NpcEnemy
    {
        enum WolfLoot
        {
            Wolf_Pelt,
            Wolf_Heart
        }


        readonly string name = "Wolf";
        readonly string description = "strong and tireless forest hunter";
        bool callPack = true;

        WolfLoot loot;

        public Wolf() : base()
        {
            Name = name;
            HitPower = 4;
            HitChance = 5;
            HpAmount = 35;
            loot = (WolfLoot)random.Next(0,2);
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"\tLoot drops: {loot}\n" +
                              $"\tDescription: {description}");
            Console.WriteLine("Perks:\n" +
                              "\tCall pack - summons 2 wolves");
        }
    }
}
