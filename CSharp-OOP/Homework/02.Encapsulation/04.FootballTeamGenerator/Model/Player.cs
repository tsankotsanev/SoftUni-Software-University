using System;

namespace _04.FootballTeamGenerator.Model
{
    public class Player
    {
        private string _name;

        public Player(string name, Stats stats)
        {
            Name = name;
            Stats = stats;
        }

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrEmpty(value)||string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException
                        (string.Format(Common.Validator.InvalidName, nameof(_name)));
                }
                _name = value;
            }
        }
        public Stats Stats { get; set; }

        public double Skills => Stats.Average();
    }
}
