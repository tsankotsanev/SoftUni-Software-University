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

        private static bool IsValidIndex(int row, int col, int rowsLength, int colsLength)
        {
            return row >= 0 && row < rowsLength && col >= 0 && col < colsLength;
        }
    }
}
