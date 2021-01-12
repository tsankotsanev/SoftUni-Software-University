using System;
 
namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var copyNumber = number;

            var factorialSum = 0;
 
            while (copyNumber != 0)
            {
                var currentNumber = copyNumber % 10;
                copyNumber /= 10;
                var factorial = 1;

                for(var i = 1; i <= currentNumber; i++)
                {
                    factorial *= i;
                }
                factorialSum += factorial;
            }

            Console.WriteLine(number == factorialSum ? "yes" : "no");
        }
    }
}