using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            RPSApp.Players();
            
            
            Console.WriteLine("Please make a selection: Rock, paper, scissors (r,p,s)");

            RandomPlayer randy = new RandomPlayer("");
            HumanPlayer player1 = new HumanPlayer("");

            player1.GenerateRPS();
            randy.GenerateRPS();

            if (player1.GenerateRPS() == RPS.rock && randy.GenerateRPS() == RPS.rock)
            {
                Console.WriteLine("Draw");
            }
            else if (player1.GenerateRPS() == RPS.scissors && randy.GenerateRPS() == RPS.rock)
            {
                Console.WriteLine("You Lose");
            }
            else if (player1.GenerateRPS() == RPS.paper && randy.GenerateRPS() == RPS.rock)
            {
                Console.WriteLine("You Win!");
            }

        }
    }
}
