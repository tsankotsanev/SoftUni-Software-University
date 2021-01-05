using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var sum = 0;

            while (sum < number)
            {
                var inputNumber = int.Parse(Console.ReadLine());

                sum += inputNumber;
            }

            Console.WriteLine(sum);
        }
    }
}
