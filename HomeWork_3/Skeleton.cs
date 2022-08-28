using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3
{
    internal class Skeleton : NpcEnemy
    {
        enum SkeletonLoot
        {
            Rusty_sword,
            Gold
        }

        readonly string name = "Skeleton";
        readonly string description = "restless fallen hero";
        bool almostImmortal = true;
        bool stillArmed = true;

        SkeletonLoot loot;

        public Skeleton() : base()
        {
            Name = name;
            HitPower = 3;
            HitChance = 10;
            HpAmount = 20;
            loot = (SkeletonLoot)random.Next(0, 2);
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"\tLoot drops: {loot}\n" +
                              $"\tDescription: {description}");
            Console.WriteLine("Perks:\n" +
                              $"\tAlmost immortal - can be damgaded only with blunt weapons\n" +
                              $"\tStill armed - carries his old and rusty sword");
        }
    }
}
