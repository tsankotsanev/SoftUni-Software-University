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

            var n = dimensions[0];
            var m = dimensions[1];
            var matrix = new char[n, m];
            var squaredMatricesCount = 0;

            for (var row = 0; row < n; row++)
            {
                var rowData = Console
                    .ReadLine()
                    ?.Split(' '
                    , StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (var col = 0; col < m; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            for (var row = 0; row < n - 1; row++)
            {
                for (var col = 0; col < m - 1; col++)
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
    }
}