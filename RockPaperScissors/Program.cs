using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            HumanPlayer player1 = new HumanPlayer(RPSApp.PlayerName());
            RandomPlayer randy = new RandomPlayer("Randy");
            RockPlayer rocky = new RockPlayer("Rocky");
            RPSApp.Players();
            bool repeat = true;

            while (repeat)
            {

                Console.WriteLine("Please make a selection: Rock, paper, scissors");
                string input = Console.ReadLine().ToLower();


                player1.GenerateRPS();
                randy.GenerateRPS();
                rocky.GenerateRPS();

                //Playing agains Randy (randomly picks what to play)
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
                    Console.WriteLine("You Lose");
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
                    Console.WriteLine($"{player1}: {input}");
                    Console.WriteLine($"{randy.Name}: scissors");
                    Console.WriteLine("You Win!");
                }
                else if (input == RPS.scissors.ToString() && randy.GenerateRPS() == RPS.scissors)
                {
                    Console.WriteLine($"{player1}: {input}");
                    Console.WriteLine($"{randy.Name}: scissors");
                    Console.WriteLine("Draw");
                }
                else if (input == RPS.paper.ToString() && randy.GenerateRPS() == RPS.scissors)
                {
                    Console.WriteLine($"{player1}: {input}");
                    Console.WriteLine($"{randy.Name}: scissors");
                    Console.WriteLine("You lose...");
                }


                ////Playing Rocky (only throws rock)
                else if (input == RPS.rock.ToString() && rocky.GenerateRPS() == RPS.rock)
                {
                    Console.WriteLine($"{player1.Name}: {input}");
                    Console.WriteLine($"{ rocky.Name}: rock");
                    Console.WriteLine("Draw");
                }
                else if (input == RPS.scissors.ToString() && rocky.GenerateRPS() == RPS.rock)
                {
                    Console.WriteLine($"{player1}: {input}");
                    Console.WriteLine($"{ rocky.Name}: rock");
                    Console.WriteLine("You Lose");
                }
                else if (input == RPS.paper.ToString() && rocky.GenerateRPS() == RPS.rock)
                {
                    Console.WriteLine($"{player1}: {input}");
                    Console.WriteLine($"{ rocky.Name}: rock");
                    Console.WriteLine("You Win!");

                }
                Console.WriteLine("Would you like to play again? (y/n)");
                string select = Console.ReadLine().ToLower();

                if (select == "y")
                {
                    repeat = true;
                }
                else
                {
                    Console.WriteLine("Goodbye!");
                    repeat = false;
                }
            }

        }
    }
}


    

