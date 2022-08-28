using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3
{
    internal class Spider : NpcEnemy
    {
        enum SpiderLoot
        {
            Venom_gland,
            Web
        }

        readonly string name = "Spider";
        readonly string description = "eight-legged cave-stalker";
        bool venomBite = true;
        readonly int venomDamage = 2;

        SpiderLoot loot;

        public Spider() : base()
        {
            Name = name;
            HitPower = 3;
            HitChance = 10;
            HpAmount = 20;
            loot = (SpiderLoot)random.Next(0, 2);
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"\tLoot drops: {loot}\n" +
                              $"\tDescription: {description}");
            Console.WriteLine("Perks:\n" +
                              $"\tVenom bite - poisons player for 2 two turns.{venomDamage} damage for each turn");
        }
    }
}
