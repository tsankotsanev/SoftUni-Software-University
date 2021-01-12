using System;
using System.Numerics;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = BigInteger.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());

            var result = firstNumber * secondNumber;

            Console.WriteLine(result);
        }
    }
}