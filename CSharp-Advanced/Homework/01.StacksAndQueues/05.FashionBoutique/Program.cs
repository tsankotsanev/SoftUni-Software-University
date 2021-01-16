using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            var clothesInput = Console
                .ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var clothes = new Stack<int>(clothesInput);

            var rackCapacity = int.Parse(Console.ReadLine());
            var currentRackCapacity = rackCapacity;
            var racksCount = 1;

            while (clothes.Any())
            {
                var currentClothing = clothes.Pop();

                currentRackCapacity -= currentClothing;

                if (currentRackCapacity < 0)
                {
                    racksCount++;
                    currentRackCapacity = rackCapacity - currentClothing;
                }
            }

            Console.WriteLine(racksCount);
        }
    }
}