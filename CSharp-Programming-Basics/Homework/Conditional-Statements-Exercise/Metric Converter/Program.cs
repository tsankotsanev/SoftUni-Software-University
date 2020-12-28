using System;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            var firstUnit = Console.ReadLine();
            var secondUnit = Console.ReadLine();

            if (firstUnit == "m" && secondUnit == "mm")
            {
                Console.WriteLine("{0:F3}" , number *= 1000);
            }
            else if (firstUnit == "mm" && secondUnit == "m")
            {
                Console.WriteLine("{0:F3}" , number /= 1000);
            }
            else if (firstUnit == "m" && secondUnit == "cm")
            {
                Console.WriteLine("{0:F3}" , number *= 100);
            }
            else if (firstUnit == "cm" && secondUnit == "m")
            {
                Console.WriteLine("{0:F3}" , number /= 100);
            }
            else if (firstUnit == "cm" && secondUnit == "mm")
            {
                Console.WriteLine("{0:F3}" , number *= 10);
            }
            else if (firstUnit == "mm" && secondUnit == "cm")
            {
                Console.WriteLine("{0:F3}", number /= 10);
            }
        }
    }
}
