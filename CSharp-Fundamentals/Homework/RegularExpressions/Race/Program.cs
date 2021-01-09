using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var bestPlayers = new Dictionary<string, int>();

            var input = string.Empty;

            var patternNames = @"[A-Za-z]";
            var patternNumbers = @"\d";

            while ((input = Console.ReadLine()) != "end of race")
            {
                var regexNames = new Regex(patternNames);
                var regexNumbers = new Regex(patternNumbers);

                var matchedNames = regexNames.Matches(input);
                var matchedNumbers = regexNumbers.Matches(input);

                var name = string.Empty;
                var kilometers = 0;

                name = BuildTheName(matchedNames, name);
                kilometers = CalculateKilometers(matchedNumbers, kilometers);

                IsPlayerValid(names, bestPlayers, name, kilometers);
            }

            var topThreePlayers = bestPlayers.OrderByDescending(x => x.Value).Take(3).ToDictionary(x => x.Key, y => y.Value);

            var counter = 0;

            foreach (var (key, value) in topThreePlayers)
            {
                counter++;
                switch (counter)
                {
                    case 1:
                        Console.WriteLine($"{counter}st place: {key}");
                        break;
                    case 2:
                        Console.WriteLine($"{counter}nd place: {key}");
                        break;
                    default:
                        Console.WriteLine($"{counter}rd place: {key}");
                        break;
                }
            }
        }

        private static void IsPlayerValid(List<string> listOfNames, Dictionary<string, int> bestPLayers, string name, int kilometers)
        {
            if (listOfNames.Contains(name))
            {
                if (!bestPLayers.ContainsKey(name))
                {
                    bestPLayers[name] = 0;
                }
                bestPLayers[name] += kilometers;

            }
        }

        private static int CalculateKilometers(MatchCollection matchedNumbers, int kilometers)
        {
            foreach (Match digit in matchedNumbers)
            {
                kilometers += int.Parse(digit.Value);
            }

            return kilometers;
        }

        private static string BuildTheName(MatchCollection matchedNames, string name)
        {
            foreach (Match letter in matchedNames)
            {
                name += letter.Value;
            }

            return name;
        }
    }
}