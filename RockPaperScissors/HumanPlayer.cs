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
            int number = int.Parse(Console.ReadLine());
            string choice = Enum.GetName(typeof(RPS), number);
            return choice;

        }
    }
}
