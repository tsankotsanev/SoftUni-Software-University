using System;

namespace Sequence2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var k = 1;

            while (k <= number)
            {
                Console.WriteLine(k);

                k = k * 2 + 1;
            }
        }
    }
}
