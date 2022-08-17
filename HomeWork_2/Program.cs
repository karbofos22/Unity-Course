using System;
using static HomeWork_2.Shooter;

namespace HomeWork_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rpg ragnar = new("Ragnar", 15, 30);
            ragnar.ShowInfo();

            Shooter levelSubBase = new(Weapons.MP5, 3, 1, "Hi-Explosive Bomb", "Infiltrate sub-marine base, steal launch codes and destroy mini-submarine prototype");
            levelSubBase.ShowInfo();

            Strategy abandonedOutpost = new(10, 100, 50, 5, 0);
            abandonedOutpost.ShowInfo();

            Moba game = new();
            game.ShowInfo();

            Puzzle oldCave = new(1, 0, 25, 5);
            oldCave.ShowInfo();
        }
    }
}
