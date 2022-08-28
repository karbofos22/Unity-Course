using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3
{
    internal class Orc : PlayableCharacter
    {
        readonly bool fearLess = true;
        readonly bool twoHandedWeponsMaster = true;
        readonly string homeLand = "Mount Gundabad";

        public Orc(string name) : base()
        {
            Name = name;
            Strength = 12;
            Agility = 4;
            Endurance = 10;
            Description = DescriptionGenerator();
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Race perks:\n" +
                              "\tFearless - always attacks first\n" +
                              "\tTwo-heanded wepons master - deals increased damage with two-handed weapons");
        }
        protected override string DescriptionGenerator()
        {
            return $"{base.DescriptionGenerator()} orc of {homeLand}";
        }
        protected override int CalcDamageOutput()
        {
            if (twoHandedWeponsMaster)
            {
                base.damageRate = 5;
            }
            return base.CalcDamageOutput();
        }
    }
}
