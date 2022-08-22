using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3
{
    internal abstract class PlayableCharacter
    {
        protected string Name { get; set; }
        protected string Description { get; set; }
        protected int Strength { get; set; }
        protected int Agility { get; set; }
        protected int Endurance { get; set; }



        // Stats modoficators
        protected int damageRate = 3;
        protected int hpRate = 3;
        protected int evadeRate = 3;

        //Additional stuff
        protected string[] words = new[] { "mighty", "fearsome", "tough", "fearsome" };
        protected string[] words1 = new[] { "warrior", "fighter", "battler", "champion" };


        protected virtual int CalcDamageOutput()
        {
            return Strength * damageRate;
        }
        protected virtual int CalcTotalHp()
        {
            return Endurance * hpRate;
        }
        protected virtual int EvadeChance()
        {
            return Agility * evadeRate;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Hero stats:\n" +
                              $"\tName: {Name}\n" +
                              $"\tStrenght: {Strength} (Damage output {CalcDamageOutput()})\n" +
                              $"\tAgility: {Agility} (Evade chance {EvadeChance()}%)\n" +
                              $"\tEndurance: {Endurance} (HP amount {CalcTotalHp()})\n" +
                              $"\tDescription: {Description}");
        }
        protected virtual string DescriptionGenerator()
        {
            Random random = new();
            return $"{words[random.Next(0, words.Length)]} {words1[random.Next(0, words.Length)]}";
        }


    }
}
