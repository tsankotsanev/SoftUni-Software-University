using System;
using System.Linq;
using System.Collections.Generic;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyElements = new Dictionary<string, int>();

            keyElements["fragments"] = 0;
            keyElements["motes"] = 0;
            keyElements["shards"] = 0;

            var junkElements = new Dictionary<string, int>();

            var isWinner = false;

            while (isWinner != true)
            {
                var tokens = Console.ReadLine()
                    .ToLower()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (var i = 0; i < tokens.Length; i += 2)
                {
                    var type = tokens[i + 1];
                    var quantity = int.Parse(tokens[i]);

                    if (keyElements.ContainsKey(type))
                    {
                        keyElements[type] += quantity;

                        if (keyElements["motes"] >= 250)
                        {
                            Console.WriteLine("Dragonwrath obtained!");
                            keyElements["motes"] -= 250;
                            isWinner = true;
                            break;
                        }
                        if (keyElements["fragments"] >= 250)
                        {
                            Console.WriteLine("Valanyr obtained!");
                            keyElements["fragments"] -= 250;
                            isWinner = true;
                            break;
                        }
                        if (keyElements["shards"] >= 250)
                        {
                            Console.WriteLine("Shadowmourne obtained!");
                            keyElements["shards"] -= 250;
                            isWinner = true;
                            break;
                        }
                    }
                    else
                    {
                        if (junkElements.ContainsKey(type))
                        {
                            junkElements[type] += quantity;
                        }
                        else
                        {
                            junkElements[type] = quantity;
                        }
                    }
                }

            }

            foreach (var (key, value) in keyElements
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{key}: {value}");
            }

            foreach (var (key, value) in junkElements.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{key}: {value}");
            }
        }
    }
}