using System;

namespace HomeWork_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dwarf dwarfPlayer = new("Muzzeal Ironmaul");
            dwarfPlayer.ShowInfo();
            Console.WriteLine();

            Orc orcPlayer = new("Gorbag");
            orcPlayer.ShowInfo();
            Console.WriteLine();

            Human humanPlayer = new("Baralgin");
            humanPlayer.ShowInfo();
            Console.WriteLine();

            Wolf wolf = new();
            wolf.ShowInfo();
            Console.WriteLine();

            Spider spider = new();
            spider.ShowInfo();
            Console.WriteLine();

            Skeleton skeleton = new();
            skeleton.ShowInfo();

        }
    }
}
