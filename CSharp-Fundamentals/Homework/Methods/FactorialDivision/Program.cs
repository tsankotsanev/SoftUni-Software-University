using System;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());

            var firstNumberFactorial = FindFactorialOf(firstNumber);
            var secondNumberFactorial = FindFactorialOf(secondNumber);

            var result = string.Format($"{firstNumberFactorial / secondNumberFactorial:F2}");

            Console.WriteLine(result);
        }

        private static double FindFactorialOf(int number)
        {
            double result = 1;
            while (number != 1)
            {
                result *= number;
                number -= 1;
            }
            return result;
        }
    }
}
