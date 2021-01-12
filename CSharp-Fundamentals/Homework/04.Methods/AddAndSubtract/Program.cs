using System;

namespace AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var thirdNumber = int.Parse(Console.ReadLine());

            AddAndSubtractNumbers(firstNumber,secondNumber,thirdNumber);
        }

        private static int AddAndSubtractNumbers(int firstNumber, int secondNumber, int thirdNumber)
        {
            var result = (firstNumber + secondNumber) - thirdNumber;

            Console.WriteLine(result);

            return result;
        }
    }
}
