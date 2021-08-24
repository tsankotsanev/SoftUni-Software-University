using System;
using System.Data;
using System.Numerics;

namespace _02.Re_Volt
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimension = int.Parse(Console.ReadLine());
            var matrix = new char[dimension, dimension];
            var commandsCount = int.Parse(Console.ReadLine());
            var playerRow = -1;
            var playerCol = -1;
            var hasWon = false;

            for (var row = 0; row < dimension; row++)
            {
                var currentRow = Console.ReadLine();
                for (var col = 0; col < currentRow.Length; col++)
                {
                    matrix[row, col] = currentRow[col];

                    if (matrix[row, col] == 'f')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            matrix[playerRow, playerCol] = '-';

            for (var i = 0; i < commandsCount; i++)
            {
                var command = Console.ReadLine();
                var previousRow = playerRow;
                var previousCol = playerCol;

                playerRow = MoveRow(matrix, playerRow, command);
                playerCol = MoveCol(matrix, playerCol, command);
                var currentLocation = matrix[playerRow, playerCol];

                if (currentLocation == 'F')
                {
                    hasWon = true;
                    break;
                }

                if (currentLocation == 'B')
                {
                    playerRow = MoveRow(matrix, playerRow, command);
                    playerCol = MoveCol(matrix, playerCol, command);
                }

                if (currentLocation == 'T')
                {
                    playerRow = previousRow;
                    playerCol = previousCol;
                }
            }

            matrix[playerRow, playerCol] = 'f';

            Console.WriteLine(hasWon
                ? "Player won!"
                : "Player lost!");

            PrintMatrix(matrix);
        }

        public static void PrintMatrix(char[,] matrix)
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

        public static int MoveRow(char[,] matrix, int row, string direction)
        {
            var rowsLength = matrix.GetLength(0);

            if (direction == "up")
            {
                row--;
                if (row < 0)
                {
                    row = rowsLength - 1;
                }
            }
            if (direction == "down")
            {
                row++;
                if (row > rowsLength - 1)
                {
                    row = 0;
                }
            }

            return row;
        }
        public static int MoveCol(char[,] matrix, int col, string direction)
        {
            var colsLength = matrix.GetLength(1);

            if (direction == "left")
            {
                col--;
                if (col < 0)
                {
                    col = colsLength - 1;
                }
            }
            if (direction == "right")
            {
                col++;
                if (col > colsLength - 1)
                {
                    col = 0;
                }
            }

            return col;
        }

    }
}