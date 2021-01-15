using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            var clothes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var orderedClothes = new Stack<int>(clothes);
            var rackCapacity = int.Parse(Console.ReadLine());
            var clothesValues = 0;
            var racksCount = 1;

            while (orderedClothes.Count != 0)
            {
                var currentClothing = orderedClothes.Peek();

                if (clothesValues + currentClothing < rackCapacity)
                {
                    clothesValues += currentClothing;
                    orderedClothes.Pop();
                }
                else
                {
                    racksCount++;
                    clothesValues = 0;
                }
            }

            Console.WriteLine(racksCount);
        }
    }
}