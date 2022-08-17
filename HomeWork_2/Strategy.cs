using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2
{
    internal class Strategy
    {
        readonly int workers = 10;
        private int wood;
        private int stone;
        private int money;
        readonly int enemyCount;

        public Strategy(int workers, int wood, int stone, int enemyCount, int money)
        {
            this.workers = workers;
            this.wood = wood;
            this.stone = stone;
            this.enemyCount = enemyCount;
            this.money = money;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Objectives:\n" +
                              $"Rebuild barracks by using provided resources - {wood} wood, {stone} stone.\n" +
                              $"Send your {workers} workers to harwest wood and stone, sell it at market.\n" +
                              $"Use money(currently {money}) to hire 10 soldiers.\n" +
                              $"Kill {enemyCount} werewolves at nothern kingdom border.\n");
        }
    }
}
   
