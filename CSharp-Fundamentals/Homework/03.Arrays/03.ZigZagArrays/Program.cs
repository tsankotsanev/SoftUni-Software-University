using System;
using System.Linq;

namespace ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var linesCount = int.Parse(Console.ReadLine());

            var firstArray = new int[linesCount];
            var secondArray = new int[linesCount];

            for (var index = 0; index < linesCount; index++)
            {
                var input = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                if (index % 2 == 0)
                {
                    firstArray[index] = input[0];
                    secondArray[index] = input[1];
                }
                else
                {
                    firstArray[index] = input[1];
                    secondArray[index] = input[0];
                }
            }

            var firstArrayOutput = string.Join(' ', firstArray);
            var secondArrayOutput = string.Join(' ', secondArray);
            var finalOutput = string.Join(Environment.NewLine, firstArrayOutput, secondArrayOutput);

            Console.WriteLine(finalOutput);
        }
    }
}
