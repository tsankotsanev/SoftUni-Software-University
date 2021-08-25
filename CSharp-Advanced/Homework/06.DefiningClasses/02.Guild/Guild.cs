using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Guild
{
    public class Guild
    {
        public Guild(string nameGuild, int capacity)
        {
            NameGuild = nameGuild;
            Capacity = capacity;
            roster = new List<Player>();
        }

        private List<Player> roster;


        public string NameGuild { get; set; }
        public int Capacity { get; set; }

        public void AddPlayer(Player player)
        {
            if (roster.Count < this.Capacity)
            {
                roster.Add(player);
            }
        }
        public bool RemovePlayer(string name)
        {
            if (roster.Any(x => x.Name == name))
            {
                roster.RemoveAll(x => x.Name == name);
                return true;
            }
            return false;
        }
        public void PromotePlayer(string name)
        {

            if (roster.Any(x => x.Name == name && x.Rank != "Member"))
            {
                roster.Find(x => x.Name == name).Rank = "Member";
            }
        }
        public void DemotePlayer(string name)
        {
            if (roster.Any(x => x.Name == name && x.Rank != "Trial"))
            {
                roster.Find(x => x.Name == name).Rank = "Trial";
            }
        }
        public Player[] KickPlayersByClass(string @class)
        {
            Player[] arr = roster.Where(x => x.Class == @class).ToArray();
            roster = roster.Where(x => x.Class != @class).ToList();

            return arr;
        }
        public int Count => this.roster.Count;

        public string Report()
        {

            var sb = new StringBuilder();

            sb.AppendLine($"Players in the guild: {NameGuild}");

            foreach (var player in roster)
            {
                sb.AppendLine($"Player {player.Name}: {player.Class}");
                sb.AppendLine($"Rank: {player.Rank}");
                sb.AppendLine($"Description: {player.Description}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
