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

            while (hats.Any() && scarfs.Any())
            {
                var currentHat = hats.Peek();
                var currentScarf = scarfs.Peek();

                if (currentHat > currentScarf)
                {
                    var currentSet = currentHat + currentScarf;
                    sets.Add(currentSet);
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
                    hats.Pop();
                    hats.Push(currentHat + 1);
                }
            }

            var maxPriceSet = sets.Max();

            Console.WriteLine($"The most expensive set is: {maxPriceSet}");
            Console.WriteLine(string.Join(" ", sets));
        }
    }
}
