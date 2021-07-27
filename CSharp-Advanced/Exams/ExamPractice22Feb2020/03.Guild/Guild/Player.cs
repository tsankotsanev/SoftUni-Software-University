
using System;
using System.Collections.Generic;
using System.Text;

namespace Guild
{
    public class Player
    {

        public Player(string name, string playerClass)
        {
            Name = name;
            Class = playerClass;
        }

        public string Name { get; set; }
        public string Class { get; set; }
        public string Rank { get; set; } = "Trial";
        public string Description { get; set; } = "n/a";

        public override string ToString()
        {
            return $"Player {Name}: {Class}\r\n" +
                   $"Rank: {Rank}\r\n" +
                   $"Description: {Description}";
        }
    }
}
