using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    class RPSApp
    {
        
        public static List<Player> Players()
        {

            List<Player> players = new List<Player> { };

            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("Who would you like to play against? Rock Player (rock), or Random Player (rand)?");
                string opponent = Console.ReadLine().ToLower();

                if (opponent == "rock")
                {
                    RockPlayer rocky = new RockPlayer("Rocky");
                    Console.WriteLine("You chose to play a rock player");
                    repeat = false;
                }
                else if (opponent == "rand")
                {
                    
                    RandomPlayer randy = new RandomPlayer("Randy");
                    Console.WriteLine("You chose to play a random player");
                    repeat = false;
                }
                else
                {
                    Console.WriteLine("That is not a valid choice. Please choose again");
                    repeat = true;

                }  
            }
            return players;
        }
        public static string PlayerName()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            return name;
        }
    }
}
