using System;
using System.Collections.Generic;
using System.Linq;

namespace ThirdProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            var heroes = new Dictionary<string, Dictionary<string, string>>();

            var command = "";

            while ((command = Console.ReadLine()) != "End")
            {
                var splitCommand = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var action = splitCommand[0];
                var hero = splitCommand[1];

                switch (action)
                {
                    case "Enroll":
                        if (heroes.ContainsKey(hero))
                        {
                            Console.WriteLine($"{hero} is already enrolled.");
                        }
                        else
                        {
                            heroes.Add(hero, new Dictionary<string, string>
                            {
                                {"spell", ""}
                            });
                        }
                        break;
                    case "Learn":
                        var spell = splitCommand[2];

                        if (heroes.ContainsKey(hero))
                        {
                            if (heroes[hero].ContainsValue(spell))
                            {
                                Console.WriteLine($"{hero} has already learnt {spell}.");
                                continue;
                            }
                            if (heroes[hero]["spell"] == "")
                            {
                                heroes[hero]["spell"] = spell;
                            }
                            else
                            {
                                heroes.Add(hero, new Dictionary<string, string>
                                {
                                    {"spell", spell}
                                });
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{hero} doesn't exist.");
                        }
                        break;
                    case "Unlearn":
                        var spellName = splitCommand[2];

                        if (heroes.ContainsKey(hero))
                        {
                            if (heroes[hero]["spell"].Contains(spellName))
                            {
                                var startIndex = heroes[hero]["spell"].IndexOf(spellName[0]);
                                var length = spellName.Length;

                                heroes[hero]["spell"] = heroes[hero]["spell"].Remove(startIndex, length);
                            }
                            else
                            {
                                Console.WriteLine($"{hero} doesn't know {spellName}.");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{hero} doesn't exist.");
                        }
                        break;
                }

            }
            heroes = heroes
                .OrderByDescending(e => e.Value.Count)
                .ThenBy(u => u.Key)
                .ToDictionary(k => k.Key, v => v.Value);

            Console.WriteLine("Heroes:");

            foreach (var hero in heroes
)
            {
                Console.WriteLine($"== {hero.Key}: {string.Join(", ", hero.Value["spell"])}");
            }
        }
    }
}
