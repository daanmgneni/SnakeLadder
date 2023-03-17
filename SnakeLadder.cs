using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLeaderProblem
{
    internal class SnakeLeaderCode
    {
        public const int CaseOfNoPlay = 0;
        public const int CaseOfLadder = 1;
        public const int CaseOfSnake = 2;
        public static void call()
        {
            Console.WriteLine("Start the Snake and Ladder Game");
            Console.WriteLine("Single Player at Start Position 0");
            Random random = new Random();
            int RollDice = random.Next(1, 6);
            Console.WriteLine("Player 1 rolls the die and get: " + RollDice);
            Random random1 = new Random();
            int option = random1.Next(3);
            int position = 0;
            switch (option)
            {
                case CaseOfNoPlay:

                    {
                        Console.WriteLine("NO PLAY" + position);
                        Console.WriteLine("player stay in same position");
                        break;
                    }

                case CaseOfLadder:
                    {
                        Console.WriteLine("LADDER" + (RollDice + position));
                        Console.WriteLine("player move ahead" + RollDice);
                        break;
                    }

                case CaseOfSnake:
                    {
                        Console.WriteLine("SNAKE" + (RollDice + position));
                        Console.WriteLine("Player moves behind by: " + RollDice);
                        break;
                    }
            }
        }
    }
}
