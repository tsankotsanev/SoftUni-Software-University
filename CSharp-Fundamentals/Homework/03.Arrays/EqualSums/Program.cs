using System;
using System.Linq;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            var isFound = false;

            for (var currentIndex = 0; currentIndex < array.Length; currentIndex++)
            {
                var sumRightSide = 0;

                for (var rightSide = currentIndex + 1; rightSide < array.Length; rightSide++)
                {
                    sumRightSide += array[rightSide];
                }

                var sumLeftSide = 0;

                for (var leftSide = currentIndex - 1; leftSide >= 0; leftSide--)
                {
                    sumLeftSide += array[leftSide];
                }

                if (sumRightSide == sumLeftSide)
                {
                    Console.WriteLine(currentIndex);
                    isFound = true;
                    break;
                }

            }

            if (!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
