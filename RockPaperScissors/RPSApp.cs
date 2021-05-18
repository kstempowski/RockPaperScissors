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
            HumanPlayer player1 = new HumanPlayer(PlayerName());

            bool repeat = true;
            while (repeat)
            {
                bool playerSelect = true;
                while (playerSelect)
                {
                Console.WriteLine("Who would you like to play against? Rocky (rock), or Randy (rand)?");
                string opponent = Console.ReadLine().ToLower();
                    if (opponent == "rock")
                    {
                        RockPlayer rocky = new RockPlayer("Rocky");
                        Console.WriteLine("You chose to play a rock player");
                        Console.WriteLine("Please make a selection: Rock, paper, scissors");
                        string input = Console.ReadLine().ToLower();

                        //Playing Rocky (only throws rock)
                        if (input == RPS.rock.ToString())
                        {
                            Console.WriteLine($"{player1.Name}: {input}");
                            Console.WriteLine($"{ rocky.Name}: rock");
                            Console.WriteLine("Draw");
                        }
                        else if (input == RPS.scissors.ToString())
                        {
                            Console.WriteLine($"{player1.Name}: {input}");
                            Console.WriteLine($"{ rocky.Name}: rock");
                            Console.WriteLine("You Lose");
                        }
                        else if (input == RPS.paper.ToString())
                        {
                            Console.WriteLine($"{player1.Name}: {input}");
                            Console.WriteLine($"{ rocky.Name}: rock");
                            Console.WriteLine("You Win!");
                        }
                        playerSelect = false;
                    }
                    //Playing Randy. Throws a random hand.
                    else if (opponent == "rand")
                    {
                        RandomPlayer randy = new RandomPlayer("Randy");
                        Console.WriteLine("You chose to play a random player");
                        Console.WriteLine("Please make a selection: Rock, paper, scissors");
                        string input = Console.ReadLine().ToLower();

                        if (input == RPS.rock.ToString() && randy.GenerateRPS() == RPS.rock)
                        {
                            Console.WriteLine($"{player1.Name}: {input}");
                            Console.WriteLine($"{randy.Name}: rock");
                            Console.WriteLine("Draw");
                        }
                        else if (input == RPS.scissors.ToString() && randy.GenerateRPS() == RPS.rock)
                        {
                            Console.WriteLine($"{player1.Name}: {input}");
                            Console.WriteLine($"{randy.Name}: rock");
                            Console.WriteLine("You lose...");
                        }
                        else if (input == RPS.paper.ToString() && randy.GenerateRPS() == RPS.rock)
                        {
                            Console.WriteLine($"{player1.Name}: {input}");
                            Console.WriteLine($"{randy.Name}: rock");
                            Console.WriteLine("You Win!");
                        }
                        else if (input == RPS.rock.ToString() && randy.GenerateRPS() == RPS.paper)
                        {
                            Console.WriteLine($"{player1.Name}: {input}");
                            Console.WriteLine($"{randy.Name}: paper");
                            Console.WriteLine("You lose...");
                        }
                        else if (input == RPS.scissors.ToString() && randy.GenerateRPS() == RPS.paper)
                        {
                            Console.WriteLine($"{player1.Name}: {input}");
                            Console.WriteLine($"{randy.Name}: paper");
                            Console.WriteLine("You Win!");
                        }
                        else if (input == RPS.paper.ToString() && randy.GenerateRPS() == RPS.paper)
                        {
                            Console.WriteLine($"{player1.Name}: {input}");
                            Console.WriteLine($"{randy.Name}: paper");
                            Console.WriteLine("Draw");
                        }
                        else if (input == RPS.rock.ToString() && randy.GenerateRPS() == RPS.scissors)
                        {
                            Console.WriteLine($"{player1.Name}: {input}");
                            Console.WriteLine($"{randy.Name}: scissors");
                            Console.WriteLine("You Win!");
                        }
                        else if (input == RPS.scissors.ToString() && randy.GenerateRPS() == RPS.scissors)
                        {
                            Console.WriteLine($"{player1.Name}: {input}");
                            Console.WriteLine($"{randy.Name}: scissors");
                            Console.WriteLine("Draw");
                        }
                        else if (input == RPS.paper.ToString() && randy.GenerateRPS() == RPS.scissors)
                        {
                            Console.WriteLine($"{player1.Name}: {input}");
                            Console.WriteLine($"{randy.Name}: scissors");
                            Console.WriteLine("You lose...");
                        }
                        playerSelect = false;
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid choice. Please choose again");
                        playerSelect = true;
                    }
                }

                Console.WriteLine("Would you like to play again? (y/n)");
                string select = Console.ReadLine().ToLower();

                    if (select == "y")
                    {
                        repeat = true;  
                    }
                    else if (select == "n")
                    {
                        Console.WriteLine("Goodbye!");
                        repeat = false; 
                    }
                    else
                    {
                        Console.WriteLine("You didn't select yes or no. Goodbye.");
                        repeat = false;
                    }
            }
            return players;

            //Method to take in and store the players name.
             static string PlayerName()
            {
                Console.WriteLine("What is your name?");
                string name = Console.ReadLine();
                return name;
            }
        }
    }
}
