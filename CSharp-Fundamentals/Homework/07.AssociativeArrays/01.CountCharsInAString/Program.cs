using System;
using System.Collections.Generic;
using System.Linq;

namespace CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            var characters = Console.ReadLine()
                .Where(x => x != ' ')
                .ToList();

            var dictionary = new Dictionary<char, int>();

            foreach (var character in characters)
            {
                if (dictionary.ContainsKey(character))
                {
                    dictionary[character]++;
                }
                else
                {
                    dictionary[character] = 1;
                }
            }

            foreach (var (key, value) in dictionary)
            {
                Console.WriteLine($"{key} -> {value}");
            }
        }
    }
}