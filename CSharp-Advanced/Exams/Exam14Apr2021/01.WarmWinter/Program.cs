using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.WarmWinter
{
    class Program
    {
        static void Main(string[] args)
        {
            var hats = new Stack<int>(Console
                .ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray());

            var scarfs = new Queue<int>(Console
                .ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray());

            var sets = new List<int>();
            var maxPriceSet = int.MinValue;s
            var incrementation = 0;

            while (hats.Any() && scarfs.Any())
            {
                var currentScarf = scarfs.Peek();
                var currentHat = hats.Peek() + incrementation;
                var combined = currentHat + currentScarf;
                incrementation = 0;

                if (currentHat > currentScarf)
                {
                    sets.Add(combined);
                    if (maxPriceSet < combined)
                    {
                        maxPriceSet = combined;
                    }

                    hats.Pop();
                    scarfs.Dequeue();
                }
                else if (currentHat < currentScarf)
                {
                    hats.Pop();
                }
                else
                {
                    scarfs.Dequeue();
                    incrementation++;
                }

            }

            Console.WriteLine($"The most expensive set is: {maxPriceSet}");
            Console.WriteLine(string.Join(" ", sets));
        }
    }
}