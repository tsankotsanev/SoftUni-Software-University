using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FootballTeamGenerator.Model
{
    public class Team
    {
        private List<Player> players;
        private string teamName;
        private int rating;

        private Team()
        {
            players = new List<Player>();
        }
        public Team(string teamName)
          : this()
        {
            TeamName = teamName;
        }
        public string TeamName
        {
            get => teamName;
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException
                        (string.Format(Common.Validator.InvalidName, nameof(teamName)));
                }
                teamName = value;
            }
        }

        public int Rating =>
            players.Count != 0 ? (int)Math.Round(players.Sum(s => s.Skills) / players.Count) : 0;

        public void AddPlayer(Player player) => players.Add(player);

        public void RemovePlayer(string name)
        {
            Player player = null;

            foreach (var item in players)
            {
                if (item.Name == name)
                {
                    player = item;
                }
            }
            if (player == null)
            {
                throw new ArgumentException($"Player {name} is not in {TeamName} team.");
            }
            players.Remove(player);
        }
        public override string ToString()
        {
            return $"{TeamName} - {Rating}";
        }
    }
}
