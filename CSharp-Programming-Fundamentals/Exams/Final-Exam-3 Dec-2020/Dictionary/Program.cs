using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var heroes = new Dictionary<string, Dictionary<string, string>>();

            var command = Console.ReadLine();

            while (command != "End")
            {
                var tokens = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var action = tokens[0];
                var hero = tokens[1];
                var spell = tokens[2];

                switch (action)
                {
                    case "Enroll":
                        if (heroes.ContainsKey(hero))
                        {
                            Console.WriteLine($"{hero} is already enrolled");
                        }
                        else
                        {
                            heroes.Add(hero, new Dictionary<string, string>
                            {
                                {"spell", null}
                            });
                        }
                        break;
                    case "Learn":
                        if ()
                        {
                            
                        }

                        if (heroes.ContainsKey(hero))
                        {
                            heroes[hero]["Spell"] += "|" + spell;
                        }
                        else
                        {
                            heroes.Add(hero, new Dictionary<string, string>
                            {
                                {"email", email}
                            });
                        }

                        break;
                    case "Delete":
                        if (heroes.ContainsKey(hero))
                        {
                            heroes.Remove(hero);
                        }
                        else
                        {
                            Console.WriteLine($"{hero} not found!");
                        }

                        break;
                }

                command = Console.ReadLine();
            }
            heroes = heroes
                .OrderByDescending(e => e.Value.Count)
                .ThenBy(u => u.Key)
                .ToDictionary(k => k.Key, v => v.Value);

            Console.WriteLine($"Users count: {heroes.Count}");

            foreach (var user in heroes
)
            {
                Console.WriteLine($"{user.Key}");
                heroes[user.Key]["email"]
                    .Split("|", StringSplitOptions.RemoveEmptyEntries)
                    .Select(e => "- " + e)
                    .ToList()
                    .ForEach(Console.WriteLine);
            }
        }
    }
}
