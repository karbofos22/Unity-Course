using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3
{
    internal class Dwarf : PlayableCharacter
    {
        readonly bool ironHead = true;
        readonly bool stoneSkin = true;
        readonly string homeLand = "Grey Mountains";


        public Dwarf(string name) : base()
        {
            Name = name;
            Strength = 7;
            Agility = 2;
            Endurance = 15;
            Description = DescriptionGenerator();
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Race perks:\n" +
                              "\tIron head - cant be confused or knocked out\n" +
                              "\tStone skin - permanent work in the mine hardens you");

        }
        protected override string DescriptionGenerator()
        {
            return $"{base.DescriptionGenerator()} dwarf of {homeLand}";
        }
        protected override int CalcTotalHp()
        {
            if (stoneSkin)
            {
                base.hpRate = 5;
            }
            return base.CalcTotalHp();
        }

    }
}
