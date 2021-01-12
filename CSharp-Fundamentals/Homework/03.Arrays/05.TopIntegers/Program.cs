using System;
using System.Linq;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var isBigger = true;

            for (var i = 0; i < array.Length; i++)
            {
                var currentNumber = array[i];

                for (var j = i + 1; j < array.Length; j++) 
                {
                    if (array[j] >= currentNumber)
                    {
                        isBigger = false;
                        break;
                    }
                }

                if (isBigger)
                {
                    Console.Write(currentNumber + " ");
                }

                isBigger = true;
            }

        }
    }
}
