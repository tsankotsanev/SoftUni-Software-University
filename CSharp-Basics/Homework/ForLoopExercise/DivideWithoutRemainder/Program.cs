using System;

namespace DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var p1 = 0.0;
            var p2 = 0.0;
            var p3 = 0.0;

            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    p1++;
                }
                if (number % 3 == 0)
                {
                    p2++;
                }
                if (number % 4 == 0)
                {
                    p3++;
                }
            }

            var p1Percentage = p1 / n * 100;
            var p2Percentage = p2 / n * 100;
            var p3Percentage = p3 / n * 100;

            Console.WriteLine($"{p1Percentage:F2}%");
            Console.WriteLine($"{p2Percentage:F2}%");
            Console.WriteLine($"{p3Percentage:F2}%");
        }
    }
}
