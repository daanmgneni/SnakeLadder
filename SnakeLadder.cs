using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLeaderProblem
{
    internal class SnakeLeaderCode
    {
        public static void call()
        {
            Console.WriteLine("Start the Snake and Ladder Game");
            Console.WriteLine("Single Player at Start Position 0");
            Random random = new Random();
            int RollDice = random.Next(1, 6);
            Console.WriteLine("Player 1 rolls the die and get: " + RollDice);
        }
    }
}
