using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringNumbers = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToList();

            var numbers = new List<int>();

            foreach (var number in stringNumbers)
            {
                numbers.AddRange(number.Split(new[] { " " }
                        , StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList()
                );
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}