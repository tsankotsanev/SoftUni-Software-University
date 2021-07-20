using System;
using System.Data;

namespace _02.Re_Volt
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var matrix = new char[n, n];

            var commandsCount = int.Parse(Console.ReadLine());

            var playerRow = -1;
            var playerCol = -1;
            var finishMarkRow = -1;
            var finishMarkCol = -1;
            var bonusRow = -1;
            var bonusCol = -1;
            var trapRow = -1;
            var trapCol = -1;

            for (var row = 0; row < n; row++)
            {
                var currentRow = Console.ReadLine();
                for (var col = 0; col < currentRow.Length; col++)
                {
                    matrix[row, col] = currentRow[col];

                    switch (matrix[row, col])
                    {
                        case 'f':
                            playerRow = row;
                            playerCol = col;
                            break;
                        case 'F':
                            finishMarkRow = row;
                            finishMarkCol = col;
                            break;
                        case 'B':
                            bonusRow = row;
                            bonusCol = col;
                            break;
                        case 'T':
                            trapRow = row;
                            trapCol = col;
                            break;
                    }
                }
            }

            for (var i = 0; i < commandsCount; i++)
            {
                var command = Console.ReadLine();

                
            }


        }
        private static void PrintMatrix(int[,] matrix)
        {
            for (var row = 0; row < matrix.GetLength(0); row++)
            {
                for (var col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }

        private static int RowIsInvalid(int row, int rows)
        {
            if (row < 0)
            {
                row = rows - 1;
            }
            if (row >= rows)
            {
                row = 0;
            }
            return row;
        }

        private static int ColIsInvalid(int col, int cols)
        {
            if (col < 0)
            {
                col = cols - 1;
            }
            if (col >= cols)
            {
                col = 0;
            }
            return col;
        }
        private static bool IsPositionValid(int row, int col, int rows, int cols)
        {
            if (row < 0 || row >= rows)
            {
                return false;
            }
            if (col < 0 || col >= cols)
            {
                return false;
            }
            return true;
        }
        private static int MoveRow(int row, string direction)
        {
            return direction switch
            {
                "up" => row - 1,
                "down" => row + 1,
                _ => row
            };
        }
        private static int MoveCol(int col, string direction)
        {
            return direction switch
            {
                "left" => col - 1,
                "right" => col + 1,
                _ => col
            };
        }

    }
}
