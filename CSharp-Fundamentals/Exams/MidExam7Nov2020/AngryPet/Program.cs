using System;
using System.Collections.Generic;
using System.Linq;

namespace AngryPet
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceRatings = Console.ReadLine()
                .Split(" ",
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var entryPointIndex = int.Parse(Console.ReadLine());
            var itemType = Console.ReadLine();
            var ratingType = Console.ReadLine();

            var entryPoint = priceRatings[entryPointIndex];

            var finalRatings = new List<int>();

            if (itemType == "cheap")
            {
                if (ratingType == "positive")
                {
                    finalRatings = priceRatings
                    .Where(e => e > 0 && e < entryPoint)
                    .ToList();
                }
                else if (ratingType == "negative")
                {
                    finalRatings = priceRatings
                    .Where(e => e < 0 && e < entryPoint)
                    .ToList();
                }
                else
                {
                    finalRatings = priceRatings
                    .Where(e => e < entryPoint)
                    .ToList();
                }
            }
            else
            {
                if (ratingType == "positive")
                {
                    finalRatings = priceRatings
                    .Where(e => e > 0 && e >= entryPoint)
                    .ToList();
                }
                else if (ratingType == "negative")
                {
                    finalRatings = priceRatings
                    .Where(e => e < 0 && e >= entryPoint)
                    .ToList();
                }
                else
                {
                    finalRatings = priceRatings
                    .Where(e => e >= entryPoint)
                    .ToList();
                }
            }

            var veryFinalRatings = finalRatings.ToArray();
            var veryFinalEntryPointIndex = priceRatings.Count - veryFinalRatings.Length;

            var leftSide = veryFinalRatings[..veryFinalEntryPointIndex];
            var rightSide = veryFinalRatings[veryFinalEntryPointIndex..];

            var leftSideSum = leftSide.Sum();
            var rightSideSum = rightSide.Sum();

            var result = leftSideSum >= rightSideSum
                ? $"Left - {leftSideSum}"
                : $"Right - {rightSideSum}";

            Console.WriteLine(result);
        }
    }
}
