using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (var i = 0; i < n; i++)
            {
                var input = Console
                    .ReadLine()
                    ?.Split(" -> ")
                    .ToArray();
                var color = input[0];

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());

                }

                var clothes = input[1]
                    .Split(",");

                foreach (var item in clothes)
                {
                    if (!wardrobe[color].ContainsKey(item))
                    {
                        wardrobe[color][item] = 0;
                    }
                    wardrobe[color][item]++;
                }
            }
            var checkItem = Console
                .ReadLine()
                ?.Split(" ")
                .ToArray();
            var colorCheck = checkItem[0];
            var itemCheck = checkItem[1];

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes: ");

                foreach (var (key, value) in color.Value)
                {
                    var found = string.Empty;

                    if (color.Key == colorCheck && key == itemCheck)
                    {
                        found = " (found!)";
                    }

                    Console.WriteLine($"* {key} - {value}{found}");
                }
            }
        }
    }
}