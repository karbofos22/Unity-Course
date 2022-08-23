using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2
{
    internal class Puzzle
    {
        private int currentLevel;
        const int totalLevels = 100;
        private int foundedShardsAtLevel;
        private int totalShardsAtLevel;
        private int prompt;

        public Puzzle(int currentLevel, int foundedShardsAtLevel, int totalShardsAtLevel, int prompt)
        {
            this.currentLevel = currentLevel;
            this.foundedShardsAtLevel = foundedShardsAtLevel;
            this.totalShardsAtLevel = totalShardsAtLevel;
            this.prompt = prompt;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Game stats:\n" +
                              $"Current level - {currentLevel}\n" +
                              $"Total levels - {totalLevels}\n" +
                              $"Founded shards - {foundedShardsAtLevel}\n" +
                              $"Total shard at level - {totalShardsAtLevel}\n" +
                              $"Prompts left - {prompt}");
        }



    }
}
