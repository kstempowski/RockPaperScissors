using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    public class RockPlayer : Player
    {

        public RockPlayer(string name): base(name)
        {
           
        }
        public override RPS GenerateRPS()
        {
            return RPS.rock;
        }
    }
}
