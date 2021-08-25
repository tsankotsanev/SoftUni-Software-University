using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var charsDictionary = new Dictionary<char, int>();

            foreach (var letter in input)
            {
                if (!charsDictionary.ContainsKey(letter))
                {
                    charsDictionary.Add(letter, 0);
                }
                charsDictionary[letter]++;
            }
            foreach (var (key, value) in charsDictionary.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{key}: {value} time/s ");
            }
        }
    }
}