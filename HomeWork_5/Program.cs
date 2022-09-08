using System;
using System.Collections.Generic;

namespace HomeWork_5
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Dictionary<string, PlayableCharacter> characterList = CreateCharacterList();
            ViewCharList(characterList);

            LinkedList<Enemy> enemyList = CreateEnemyList();
            Console.WriteLine();

            PoisonDamageToGroup(enemyList);
            PoisonDamageResult(enemyList);

        }
        static Dictionary<string, PlayableCharacter> CreateCharacterList()
        {
            Dictionary<string, PlayableCharacter> dictionary = new Dictionary<string, PlayableCharacter>();
            Dwarf dwarf = new();
            Orc orc = new();
            Human human = new();

            dictionary.Add(dwarf.Name, dwarf);
            dictionary.Add(orc.Name, orc);
            dictionary.Add(human.Name, human);

            return dictionary;
        }
        static void ViewCharList(Dictionary<string, PlayableCharacter> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"Hero name: {item.Key}({item.Value.ToString().Substring(11)})");
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
        static void PoisonDamageResult(LinkedList<Enemy> enemyList)
        {
            foreach (var item in enemyList)
            {
                if (item.Hp <= 0)
                {
                    Console.WriteLine($"{item.Name} was killed");
                }
                else if (item.Hp > 0)
                {
                    Console.WriteLine($"{item.Name} survived with {item.Hp} hp left");
                }
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
