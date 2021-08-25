using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console
                .ReadLine()
                ?.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var evenOrOdd = Console.ReadLine();

            Predicate<int> checkEven = num => num % 2 == 0;
            Predicate<int> checkOdd = num => num % 2 != 0;

            var num = new List<int>();
            for (var i = number[0]; i <= number[1]; i++)
            {
                switch (evenOrOdd)
                {
                    case "even" when checkEven(i):
                    case "odd" when checkOdd(i):
                        num.Add(i);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", num));
        }
    }
}