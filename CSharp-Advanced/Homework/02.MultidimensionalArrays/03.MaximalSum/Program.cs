using System;
using System.Linq;

namespace _03.MaximalSum
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

            var rows = dimensions[0];
            var cols = dimensions[1];
            var matrix = ReadMatrix(rows, cols);

            var maxSum = int.MinValue;
            var rowIndex = -1;
            var colIndex = -1;

            for (var row = 0; row < rows - 2; row++)
            {
                for (var col = 0; col < cols - 2; col++)
                {
                    var sum = matrix[row, col];
                    sum += matrix[row, col + 1];
                    sum += matrix[row, col + 2];

                    sum += matrix[row + 1, col];
                    sum += matrix[row + 1, col + 1];
                    sum += matrix[row + 1, col + 2];

                    sum += matrix[row + 2, col];
                    sum += matrix[row + 2, col + 1];
                    sum += matrix[row + 2, col + 2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        rowIndex = row;
                        colIndex = col;
                    }
                }
            }

            Console.WriteLine("Sum = " + maxSum);

            for (var row = rowIndex; row < rowIndex + 3; row++)
            {
                for (var col = colIndex; col < colIndex + 3; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }

        private static int[,] ReadMatrix(int rows, int cols)
        {
            var matrix = new int[rows, cols];

            for (var row = 0; row < matrix.GetLength(0); row++)
            {
                var rowData = Console
                    .ReadLine()
                    ?.Split(" "
                    , StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
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
