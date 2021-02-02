using System;
using System.Linq;

namespace _02._2X2SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimensions = Console
                .ReadLine()
                ?.Split(" "
                , StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var matrix = ReadMatrix(dimensions[0], dimensions[1]);
            var squaredMatricesCount = 0;

            for (var row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (var col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    var isSquared = matrix[row, col] == matrix[row, col + 1]
                                    && matrix[row + 1, col] == matrix[row + 1, col + 1]
                                    && matrix[row, col] == matrix[row + 1, col];
                    if (isSquared)
                    {
                        squaredMatricesCount++;
                    }
                }
            }

            Console.WriteLine(squaredMatricesCount);
        }

        private static char[,] ReadMatrix(int rows, int cols)
        {
            var matrix = new char[rows, cols];

            for (var row = 0; row < matrix.GetLength(0); row++)
            {
                var rowData = Console
                    .ReadLine()
<<<<<<< HEAD
                    ?.Split(" "
                    , StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
=======
                    .Split(" "
                    , StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
>>>>>>> 0b7d9c4f1b4b28bb1426a695a66484fe9127eb23
                    .ToArray();

                for (var col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            return matrix;
        }
    }
}
