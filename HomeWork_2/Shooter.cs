using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2
{
    internal class Shooter
    {
        public enum Weapons
        {
            Beretta,
            Walther,
            MP5,
            P90
        }


        public Weapons weapon;
        readonly int ammoCount;
        readonly int healthPacks;
        protected string additionEquipment;
        protected string missionTarget;
        



        public Shooter(Weapons weapon, int ammoCount, int healthPacks, string additionEquipment, string missionTarget)
        {
            this.weapon = weapon;
            this.ammoCount = ammoCount;
            this.healthPacks = healthPacks;
            this.additionEquipment = additionEquipment;
            this.missionTarget = missionTarget;
        }




        public void ShowInfo()
        {
            Console.WriteLine($"Mission description:\n" +
                              $"{missionTarget}\n" +
                              $"Equipment: {weapon} with silencer and {ammoCount} ammo clips, " +
                              $"{healthPacks} first aid kit(s), {additionEquipment}\n");
        }
    }
}
