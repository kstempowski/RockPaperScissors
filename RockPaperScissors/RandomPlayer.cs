using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    class RandomPlayer : Player
    {
        public RandomPlayer (string name):base(name)
        {

        }
        public override RPS GenerateRPS()
        {
            var rand = new Random();
            var choice = (RPS)rand.Next(3);
            return choice;
        }
    }
}
