using System;
using System.Linq;

namespace _05.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimensions = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var input = Console.ReadLine();
            var snakeMatrix = new char[dimensions[0], dimensions[1]];
            var count = 0;

            for (var row = 0; row < snakeMatrix.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {
                    for (var col = 0; col < snakeMatrix.GetLength(1); col++)
                    {
                        snakeMatrix[row, col] = input[count++];
                        if (count == input.Length)
                        {
                            count = 0;
                        }
                    }
                    continue;
                }
                for (var cols = snakeMatrix.GetLength(1) - 1; cols >= 0; cols--)
                {
                    snakeMatrix[row, cols] = input[count++];

                    if (count == input.Length)
                    {
                        count = 0;
                    }
                }
            }

            PrintMatrix(snakeMatrix);
        }

        private static void PrintMatrix(char[,] matrixSnake)
        {
            for (var row = 0; row < matrixSnake.GetLength(0); row++)
            {
                for (var col = 0; col < matrixSnake.GetLength(1); col++)
                {
                    Console.Write(matrixSnake[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
