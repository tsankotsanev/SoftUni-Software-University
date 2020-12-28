using System;

namespace TriangleOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            for (var i = 1; i <= number; i++)
            {
                for (var j = 1; j <= i; j++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
        }
    }
}