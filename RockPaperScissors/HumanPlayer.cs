using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(string name):base(name)
        {

        }
        public override RPS GenerateRPS()
        {
            var choice = int.Parse(Console.ReadLine());
            return (RPS)choice;
        }
    }
}
