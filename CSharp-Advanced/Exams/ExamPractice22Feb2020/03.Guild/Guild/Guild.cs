using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        private List<Player> roster;

        public Guild(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            roster = new List<Player>();
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count => roster.Count;

        public void AddPlayer(Player player)
        {
            if (roster.Count < Capacity)
            {
                roster.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            var player = roster.FirstOrDefault(p => p.Name == name);
            if (player != null)
            {
                roster.Remove(player);
                return true;
            }

            return false;
        }

        public void PromotePlayer(string name)
        {
            var player = roster.FirstOrDefault(p => p.Name == name);
            if (player != null)
            {
                player.Rank = "Member";
            }
        }

        public void DemotePlayer(string name)
        {
            var player = roster.FirstOrDefault(p => p.Name == name && p.Rank != "Trial");
            if (player != null)
            {
                player.Rank = "Trial";
            }
        }

        public Player[] KickPlayersByClass(string playerClass)
        {
            var kickedPlayers = roster
                .Where(p => p.Class == playerClass)
                .ToArray();

            roster = roster
                .Where(p => p.Class != playerClass)
                .ToList();

            return kickedPlayers;
        }

        public string Report()
        {
            var result = $"Players in the guild: {Name}";

            foreach (var player in roster)
            {
                result += Environment.NewLine + player;
            }

            return result;
        }
    }
}
