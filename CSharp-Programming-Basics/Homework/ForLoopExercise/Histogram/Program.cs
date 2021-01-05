using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var p1 = 0.0;
            var p2 = 0.0;
            var p3 = 0.0;
            var p4 = 0.0;
            var p5 = 0.0;

            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());

                if (number < 200)
                {
                    p1++;
                }
                else if (number >= 200 && number <= 399)
                {
                    p2++;
                }
                else if (number >= 400 && number <= 599)
                {
                    p3++;
                }
                else if (number >= 600 && number <= 799)
                {
                    p4++;
                }
                else if (number >= 800)
                {
                    p5++;
                }
            }

            var p1Percentage = p1 / n * 100;
            var p2Percentage = p2 / n * 100;
            var p3Percentage = p3 / n * 100;
            var p4Percentage = p4 / n * 100;
            var p5Percentage = p5 / n * 100;

            Console.WriteLine($"{p1Percentage:F2}%");
            Console.WriteLine($"{p2Percentage:F2}%");
            Console.WriteLine($"{p3Percentage:F2}%");
            Console.WriteLine($"{p4Percentage:F2}%");
            Console.WriteLine($"{p5Percentage:F2}%");
        }
    }
}
