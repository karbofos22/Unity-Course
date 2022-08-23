using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2
{
    internal class Moba
    {
        readonly string[] startingPoint = new string[2] { "Left base", "Right base" };
        readonly string[] teams = new string[2] { "Red team", "White team" };
        readonly string[] winConditions = new string[2] { "Eliminate enemy team", "Control strategic point till time runs out" };
        const int maxPlayersInTeam = 20;
        const int minPlayersInTeam = 5;


        public void ShowInfo()
        {
            Console.WriteLine($"Battle conditions:\n" +
                              $"Minimum players to start session - {minPlayersInTeam}\n" +
                              $"Maximum players during one session - {maxPlayersInTeam}\n" +
                              $"Starting team - {teams[ConditionsGenerator(teams)]}\n" +
                              $"Starting point - {startingPoint[ConditionsGenerator(startingPoint)]}\n" +
                              $"Win conditions - {winConditions[ConditionsGenerator(winConditions)]}\n");
        }

        private int ConditionsGenerator(string[] condition)
        {
            int randomNum;

            Random random = new();
            return randomNum = random.Next(0, condition.Length);
            

        }
        



    }
}
