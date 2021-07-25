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
            Player player = roster.FirstOrDefault(p => p.Name == name);
            if (player != null)
            {
                roster.Remove(player);
                return true;
            }

            return false;
        }

        public void PromotePlayer(string name)
        {
            Player player = roster.FirstOrDefault(p => p.Name == name && p.Rank != "Member");
            if (player != null)
            {
                player.Rank = "Member";
            }
        }

        public void DemotePlayer(string name)
        {
            Player player = roster.FirstOrDefault(p => p.Name == name && p.Rank != "Trial");
            if (player != null)
            {
                player.Rank = "Trial";
            }
        }

        public char[] KickPlayersByClass(string cClass)
        {
            foreach (var player in cClass)
            {
                cClass.Remove(player);
            }

            return cClass.ToArray();
        }

        public string Report()
        {
            var result = new StringBuilder();
            result.AppendLine($"Players in the guild: {Name}");

            foreach (var player in roster)
            {
                result.AppendLine($"{player.Name}");
            }

            return result.ToString();
        }
    }
}
