using System;
using System.Linq;

namespace MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            var magicNumber = int.Parse(Console.ReadLine());

            for (var currentIndex = 0; currentIndex < array.Length; currentIndex++)
            {
                var currentNumber = array[currentIndex];

                if (currentNumber > magicNumber)
                {
                    break;
                }

                for (var nextIndex = currentIndex + 1; nextIndex < array.Length; nextIndex++)
                {
                    var nextNumber = array[nextIndex];

                    if (currentNumber + nextNumber == magicNumber)
                    {
                        Console.WriteLine($"{currentNumber} {nextNumber}" + " ");
                    }
                }
            }
        }
    }
}
