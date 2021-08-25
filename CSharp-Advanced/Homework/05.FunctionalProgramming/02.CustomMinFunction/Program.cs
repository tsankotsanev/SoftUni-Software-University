using System;
using System.Linq;

namespace _02.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> smallestNumber = number =>
            {
                var minValue = int.MaxValue;

                foreach (var num in number)
                {
                    if (num < minValue)
                    {
                        minValue = num;
                    }
                }
                return minValue;
            };

            var numbers = Console
                .ReadLine()
                ?.Split()
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(smallestNumber(numbers));
        }
    }
}