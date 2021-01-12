using System;

namespace PrintAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var startingNumber = int.Parse(Console.ReadLine());
            var endingNumber = int.Parse(Console.ReadLine());

            var numbersSum = 0;

            for (var i = startingNumber; i <= endingNumber; i++)
            {
                numbersSum += i;

                Console.Write(i + " ");
            }

            Console.WriteLine(Environment.NewLine + $"Sum: {numbersSum}");
        }
    }
}
