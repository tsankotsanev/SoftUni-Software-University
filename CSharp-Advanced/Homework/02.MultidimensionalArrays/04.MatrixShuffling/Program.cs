using System;
using System.Linq;

namespace _04.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimensions = Console
                          .ReadLine()
                          ?.Split()
                          .Select(int.Parse)
                          .ToArray();

            var matrix = ReadMatrix(dimensions[0], dimensions[1]);
            var command = string.Empty;

            while ((command = Console.ReadLine()) != "END")
            {
                var splitCommand = command
                          .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                          .ToArray();

                var action = splitCommand[0];

                if (action == "swap")
                {
                    var row1 = int.Parse(splitCommand[1]);
                    var col1 = int.Parse(splitCommand[2]);
                    var row2 = int.Parse(splitCommand[3]);
                    var col2 = int.Parse(splitCommand[4]);

                    var isValid = row1 >= 0 && row1 < matrix.GetLength(0) &&
                                       row2 >= 0 && row2 < matrix.GetLength(0)
                                       && col1 >= 0 && col1 < matrix.GetLength(1)
                                       && col2 >= 0 && col2 < matrix.GetLength(1);
                    if (isValid)
                    {
                        var currentMatrix = matrix[row1, col1];
                        matrix[row1, col1] = matrix[row2, col2];
                        matrix[row2, col2] = currentMatrix;

                        for (var row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (var col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write(matrix[row, col] + " ");
                            }

                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
        private static string[,] ReadMatrix(int rows, int cols)
        {
            var matrix = new string[rows, cols];

            for (var row = 0; row < matrix.GetLength(0); row++)
            {
                var rowDate = Console
                           .ReadLine()
                           ?.Split(" "
                            , StringSplitOptions.RemoveEmptyEntries)
                           .ToArray();
                for (var col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowDate[col];
                }
            }

            return matrix;
        }
    }
}
