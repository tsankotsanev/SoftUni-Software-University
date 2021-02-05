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
                ?.Split(" "
                , StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var rows = dimensions[0];
            var cols = dimensions[1];

            var matrix = ReadMatrix(rows, cols);
        }

        private static string[,] ReadMatrix(int rows, int cols)
        {
            var matrix = new string[rows, cols];

            for (var row = 0; row < matrix.GetLength(0); row++)
            {
                var rowData = Console
                    .ReadLine()
                    ?.Split(" "
                    , StringSplitOptions.RemoveEmptyEntries)
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
