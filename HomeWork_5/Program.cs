using System;
using System.Collections.Generic;

namespace HomeWork_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> characterList = CreateCharacterList();
            ViewCharList(characterList);

            LinkedList<Enemy> enemyList = CreateEnemyList();
            Console.WriteLine();

            PoisonDamageToGroup(enemyList);

        }
        static Dictionary<string, string> CreateCharacterList()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Muzzeal Ironmaul", "Dwarfen Axe");
            dictionary.Add("Gorbag", "Two-handed Headchopper");
            dictionary.Add("Baralgin", "Soldier's Sword");

            return dictionary;
        }
        static void ViewCharList(Dictionary<string, string> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"Hero name: {item.Key}\n" +
                                  $"     weapon: {item.Value}");
            }
        }

        static LinkedList<Enemy> CreateEnemyList()
        {
            Spider spider = new();
            Wolf wolf = new();
            Skeleton skeleton = new();

            LinkedList<Enemy> enemyList = new LinkedList<Enemy>();
            enemyList.AddFirst(spider);
            enemyList.AddFirst(skeleton);
            enemyList.AddFirst(wolf);

            return enemyList;
        }
        static void ViewEnemyList(LinkedList<Enemy> enemyList)
        {
            foreach (var item in enemyList)
            {
                Console.WriteLine($"Enemy name: {item.Name}\n" +
                                  $"        Hp: {item.Hp}");
            }
        }
        static void PoisonDamageToGroup(LinkedList<Enemy> enemyList)
        {
            bool isNotDead = true;
            int poisonDamage = 2;

            while (isNotDead)
            {
                foreach (var item in enemyList)
                {
                    item.TakeDamage(poisonDamage);

                    if (item.Hp == 0)
                    {
                        Console.WriteLine($"{item.Name} is dead");
                        isNotDead = false;
                    }
                    else
                    {
                        Console.WriteLine($"{item.Name} Hp left {item.Hp}");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
