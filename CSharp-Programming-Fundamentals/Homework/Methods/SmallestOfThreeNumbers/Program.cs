using System;

namespace SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(SmallestNumber(firstNumber, secondNumber, thirdNumber));
            
        }

        private static int SmallestNumber(int firstNumber, int secondNumber, int thirdNumber)
        {
            var result = Math.Min(Math.Min(firstNumber, secondNumber), thirdNumber);

            return result;
        }
    }
}