using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            var bestCount = 0;
            var bestIndex = 0;

            for (var currentIndex = 0; currentIndex < array.Length; currentIndex++)
            {
                var currentElement = array[currentIndex];

                var currentCounter = 1;

                for (var nextIndex = currentIndex + 1; nextIndex < array.Length; nextIndex++)
                {
                    if (currentElement == array[nextIndex])
                    {
                        currentCounter++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (currentCounter > bestCount)
                {
                    bestCount = currentCounter;
                    bestIndex = currentIndex;
                }
            }

            for (var bestNumberIndex = 0; bestNumberIndex < bestCount; bestNumberIndex++)
            {
                Console.Write(array[bestIndex] + " ");
            }
;
        }
    }
}
