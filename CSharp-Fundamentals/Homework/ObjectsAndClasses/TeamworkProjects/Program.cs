using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var teams = new List<Team>();

            for (var i = 1; i <= n; i++)
            {
                var tokens = Console.ReadLine()
                    .Split("-", StringSplitOptions.RemoveEmptyEntries);

                var creatorName = tokens[0];
                var teamName = tokens[1];

                var team = new Team()
                {
                    Creator = creatorName,
                    TeamName = teamName,
                    Members = new List<string>()
                };

                if (teams.All(x => x.TeamName != teamName) && teams.All(x => x.Creator != creatorName))
                {
                    teams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
                }
                else if (teams.Any(x => x.Creator == creatorName))
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                }
                else
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
            }

            var input = Console.ReadLine();

            while (input != "end of assignment")
            {
                var tokens = input
                    .Split("->", StringSplitOptions.RemoveEmptyEntries);

                var member = tokens[0];
                var teamName = tokens[1];

                if (teams.Any(x => x.TeamName == teamName))
                {
                    var indexOfTeam = teams.FindIndex(x => x.TeamName == teamName);

                    if (!teams.Any(x => x.Members.Contains(member)) && teams.All(x => x.Creator != member))
                    {
                        teams[indexOfTeam].Members.Add(member);
                    }
                    else
                    {
                        Console.WriteLine($"Member {member} cannot join team {teamName}!");
                    }
                }
                else
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }

                input = Console.ReadLine();
            }

            var resultTeams = teams
                .Where(x => x.Members.Count > 0)
                .OrderByDescending(x => x.Members.Count)
                .ThenBy(x => x.TeamName)
                .ToList();

            foreach (var team in resultTeams)
            {
                Console.WriteLine(team.TeamName);
                Console.WriteLine($"- {team.Creator}");

                foreach (var member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            var disbandTeams = teams
                .Where(x => x.Members.Count == 0)
                .OrderBy(x => x.TeamName)
                .ToList();

            Console.WriteLine("Teams to disband:");

            foreach (var team in disbandTeams)
            {
                Console.WriteLine(team.TeamName);
            }
        }
    }

    public class Team
    {
        public string TeamName { get; set; }

        public string Creator { get; set; }

        public List<string> Members { get; set; }
    }

}