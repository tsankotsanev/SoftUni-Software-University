using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;


            for (int i = 1; i <= n; i++)
            {
                var input = int.Parse(Console.ReadLine());

                sum += input;
            }
            Console.WriteLine(sum);
        }
    }
}
