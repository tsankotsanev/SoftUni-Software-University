using System;

namespace ShoppingForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = int.Parse(Console.ReadLine()) * 4.75;
            var x2 = int.Parse(Console.ReadLine()) * 1.80;
            var x3 = int.Parse(Console.ReadLine()) * 6.50;
            var x4 = int.Parse(Console.ReadLine()) * 2.50;

            var result = x1 + x2 + x3 + x4;
            var finalResult = result - result * 0.05;

            Console.WriteLine($"Your total is {finalResult:F2}lv");
        }
    }
}
