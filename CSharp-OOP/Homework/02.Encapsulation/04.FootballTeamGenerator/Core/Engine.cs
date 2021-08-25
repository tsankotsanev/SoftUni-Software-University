using System;
using System.Collections.Generic;
using System.Linq;
using _04.FootballTeamGenerator.Model;

namespace _04.FootballTeamGenerator.Core
{
    public class Engine
    {
        public void Run()
        {
            var teams = new List<Team>();

            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                try
                {
                    string[] dataPlayer;
                    string currentCommand, teamName, playerName;

                    SplitInput(command, out dataPlayer, out currentCommand, out teamName, out playerName);

                    switch (currentCommand)
                    {
                        case "Team":
                            var team = MakeTeam(teams, teamName);
                            break;

                        case "Add":
                            Add(teams, dataPlayer, teamName, out playerName, out team);
                            break;

                        case "Remove":
                            Remove(teams, dataPlayer, teamName, out playerName, out team);
                            break;

                        case "Rating":
                            GiveRating(teams, teamName);
                            break;
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static void SplitInput(string command, out string[] dataPlayer, out string currentCommand, out string teamName, out string playerName)
        {
            dataPlayer = command
              .Split(";")
              .ToArray();

            currentCommand = dataPlayer[0];
            teamName = dataPlayer[1];
            playerName = string.Empty;
        }

        private static Team MakeTeam(List<Team> teams, string teamName)
        {
            var team = new Team(teamName);
            teams.Add(team);
            return team;
        }

        private static void GiveRating(List<Team> teams, string teamName)
        {
            if (teams.All(n => n.TeamName != teamName))
            {
                throw new ArgumentException(string.Format(Common.Validator.InvalidTeamName, teamName));
            }

            foreach (var item in teams)
            {
                if (item.TeamName == teamName)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }

        private static void Remove(List<Team> teams, string[] dataPlayer, string teamName, out string playerName, out Team team)
        {
            playerName = dataPlayer[2];

            team = teams.FirstOrDefault(x => x.TeamName == teamName);

            team.RemovePlayer(playerName);
        }

        private static void Add(List<Team> teams, string[] dataPlayer, string teamName, out string playerName, out Team team)
        {
            playerName = dataPlayer[2];
            if (teams.All(n => n.TeamName != teamName))
            {
                throw new ArgumentException
                    (string.Format(Common.Validator.InvalidTeamName, teamName));
            }

            var endurance = int.Parse(dataPlayer[3]);
            var sprint = int.Parse(dataPlayer[4]);
            var dribble = int.Parse(dataPlayer[5]);
            var passing = int.Parse(dataPlayer[6]);
            var shooting = int.Parse(dataPlayer[7]);

            var stats = new Stats(endurance, sprint, dribble, passing, shooting);

            var player = new Player(playerName, stats);

            team = teams.FirstOrDefault(x => x.TeamName == teamName);

            team?.AddPlayer(player);
        }
    }
}
