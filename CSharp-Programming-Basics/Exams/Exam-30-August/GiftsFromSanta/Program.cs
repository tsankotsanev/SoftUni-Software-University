using System;

namespace GiftsFromSanta
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var s = int.Parse(Console.ReadLine());

            for (int i = m; i >= n; i--)
            {
                var currentNumber = i;

                if (currentNumber % 2 == 0 && currentNumber % 3 == 0)
                {
                    if (currentNumber == s)
                    {
                        break;
                    }

                    Console.Write(i + " ");
                }
            }
        }
    }
}
