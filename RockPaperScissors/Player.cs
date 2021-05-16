using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    public abstract class Player
    {
        public string Name { get; set; }

        public Player(string name)
        {
            Name = name;
        }

        public virtual RPS GenerateRPS()
        {
            if (Name == "rock")
            {
                return RPS.rock;
            }
            else if (Name == "paper")
            {
                return RPS.paper;
            }
            else
            {
                return RPS.scissors;
            }
        }
    }
}
