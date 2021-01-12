using System;

namespace EvenPowersOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var num = 1;

            for (int i = 0; i <= n; i += 2)
            {
                Console.WriteLine(num);
                num *= 2 * 2;
            }
        }
    }
}
