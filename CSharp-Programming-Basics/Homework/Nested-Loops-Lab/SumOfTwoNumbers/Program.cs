using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var rangeStart = int.Parse(Console.ReadLine());
            var rangeEnd = int.Parse(Console.ReadLine());
            var magicalNumber = int.Parse(Console.ReadLine());

            var combinationsCounter = 0;

            for (int i = rangeStart; i <= rangeEnd; i++)
            {
                for (int j = rangeStart; j <= rangeEnd; j++)
                {
                    combinationsCounter++;

                    if (i + j == magicalNumber)
                    {
                        Console.WriteLine($"Combination N:{combinationsCounter} ({i} + {j} = {magicalNumber})");

                        Environment.Exit(0);
                    }
                }
            }

            Console.WriteLine($"{combinationsCounter} combinations - neither equals {magicalNumber}");
        }
    }
}
