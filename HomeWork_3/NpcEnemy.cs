using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3
{
   

    internal abstract class NpcEnemy
    {

        protected string Name { get; set; }
        protected int HitPower { get; set; }
        protected int HitChance { get; set; }
        protected int HpAmount { get; set; }

        public Random random = new();
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Enemy stats:\n" +
                              $"\tName: {Name}\n" +
                              $"\tHit power: {HitPower} (Damage to player)\n" +
                              $"\tHit chance: {HitChance} (Chance to land hit on player)\n" +
                              $"\tEndurance: {HpAmount} (HP amount)");
        }
    }
}
