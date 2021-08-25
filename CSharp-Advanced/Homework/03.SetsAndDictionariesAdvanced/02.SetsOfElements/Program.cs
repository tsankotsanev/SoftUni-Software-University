using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var lengths = Console
                .ReadLine()
                ?.Split()
                .Select(int.Parse)
                .ToArray();

            var first = new HashSet<int>();
            var second = new HashSet<int>();


            for (var k = 0; k < lengths[0]; k++)
            {
                var num = int.Parse(Console.ReadLine());

                first.Add(num);
            }

            for (var l = 0; l < lengths[1]; l++)
            {
                var num = int.Parse(Console.ReadLine());

                second.Add(num);
            }

            foreach (var num in first.Where(num => second.Contains(num)))
            {
                Console.Write($"{num} ");
            }
        }
    }
}