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
        public const int MaxPosition = 100;
        public static void call()
        {
            Console.WriteLine("Start the Snake and Ladder Game");
            Console.WriteLine("Single Player at Start Position 0");
            Console.WriteLine(" ");
            int position = 0;


            while (position != MaxPosition)
            { 

            Random random = new Random();
            int RollDice = random.Next(1, 6);
            Console.WriteLine("Player 1 rolls the die and get: " + RollDice);
            Random random1 = new Random();
            int option = random1.Next(3);



                switch (option)
                {
                    case CaseOfNoPlay:

                        {
                            Console.WriteLine("option NO PLAY selected " + position);
                            Console.WriteLine("player stay in same position");

                            break;
                        }

                    case CaseOfLadder:
                        {
                            Console.WriteLine("option LADDER selected " + (RollDice + position));
                            Console.WriteLine("player move ahead" + RollDice);
                            position = RollDice + position;
                            break;
                        }

                    case CaseOfSnake:
                        {
                            Console.WriteLine("option SNAKE selected " + (RollDice + position));
                            Console.WriteLine("Player moves behind by: " + RollDice);
                            position = position - RollDice;
                            break;
                        }
                }
                     
                 if (position < 0)
                  {
                     position = 0;
                     Console.WriteLine("plyer1 have to restart the game from position:"+position);
                  }
                 if (position > 100)
                 {
                    position = position - RollDice;
                    Console.WriteLine("Your chance is skip stay on same position:" + position);
                 }
                Console.WriteLine("current position of the player is:" + position);
                        Console.WriteLine(" ");
               
            }
            Console.WriteLine("!!!!*****!!!!!Player1 reach the winning position!!!!*****!!!!!");
        }
    }
}
