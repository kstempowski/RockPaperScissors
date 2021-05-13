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

        public abstract RPS GenerateRPS();
       
       
    }
}
