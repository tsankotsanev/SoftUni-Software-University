using System;

namespace NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var biggestNumber = int.MinValue;
            var smallestNumber = int.MaxValue;

            for (int i = 1; i <= n; i++)
            {
                var number = int.Parse(Console.ReadLine());

                if (number < smallestNumber)
                {
                    smallestNumber = number;
                }
                if (number > biggestNumber)
                {
                    biggestNumber = number;
                }
            }
            Console.WriteLine($"Max number: {biggestNumber}");
            Console.WriteLine($"Min number: {smallestNumber}");
        }
    }
}
