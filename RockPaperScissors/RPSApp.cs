﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    class RPSApp
    {
        
        public static void Players()
        {
         Console.WriteLine("What is your name?");
         List<Player> players = new List<Player> { };
         HumanPlayer player1 = new HumanPlayer(Console.ReadLine());
         RockPlayer rocky = new RockPlayer("Rocky");
         RandomPlayer randy = new RandomPlayer("Randy");


            players.Add(player1);

            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("Who would you like to play against? Rock Player (rock), or Random Player (rand)?");
                string opponent = Console.ReadLine().ToLower();

                if (opponent == "rock")
                {
                    players.Add(rocky);
                    Console.WriteLine("You chose to play a rock player");
                    repeat = false;
                }
                else if (opponent == "rand")
                {
                    players.Add(randy);
                    Console.WriteLine("You chose to play a random player");
                    repeat = false;
                }
                else
                {
                    Console.WriteLine("That is not a valid choice. Please choose again");
                    repeat = true;

                }
            }
            Console.WriteLine("Choose rock, paper, or scissors (r,p,s)");
            

            
        }
    }
}