using System;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            TopNumbersFromOneToValueOf(number);
        }

        private static void TopNumbersFromOneToValueOf(int number)
        {

            for (var i = 1; i <= number; i++)
            {
                var sum = 0;
                var currentNumber = i;
                var isOdd = false;

                while (currentNumber > 0)
                {
                    var currentDigit = currentNumber % 10;
                    sum += currentDigit;

                    if (currentDigit % 2 != 0)
                    {
                        isOdd = true;
                    }

                    currentNumber /= 10;
                }

                if (sum % 8 == 0 && isOdd)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}