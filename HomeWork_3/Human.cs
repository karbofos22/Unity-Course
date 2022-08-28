using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3
{
    internal class Human : PlayableCharacter
    {
        readonly bool mercenary = true;
        readonly bool quickLegs = true;
        readonly string homeLand = "Numenor";

        public Human(string name) : base()
        {
            Name = name;
            Strength = 5;
            Agility = 6;
            Endurance = 8;
            Description = DescriptionGenerator();
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Race perks:\n" +
                              "\tMercenary - gets additional quests at tavern\n" +
                              "\tQiuck legs - a skilled fighter dodges blows instead of taking them");
        }
        protected override string DescriptionGenerator()
        {
            return $"{base.DescriptionGenerator()} human of {homeLand}";
        }
        protected override int EvadeChance()
        {
            if (quickLegs)
            {
                base.evadeRate = 5;
            }
            return base.EvadeChance();
        }



    }
}
