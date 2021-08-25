using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Froggy
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console
             .ReadLine()
             ?.Split(", ")
             .Select(int.Parse)
             .ToList();

            var stonesNumber = new Lake(numbers);

            Console.WriteLine(string.Join(", ", stonesNumber));
        }
    }
}
