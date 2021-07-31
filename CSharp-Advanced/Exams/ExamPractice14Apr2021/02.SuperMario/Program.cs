using System;

namespace _02.SuperMario
{
    class Program
    {
        static void Main(string[] args)
        {
            var lives = int.Parse(Console.ReadLine());
            var dimension = int.Parse(Console.ReadLine());
            var matrix = new char[dimension, dimension];
            var marioRow = -1;
            var marioCol = -1;
            var isDead = false;

            for (var row = 0; row < dimension; row++)
            {
                var currentRow = Console.ReadLine();
                for (var col = 0; col < currentRow.Length; col++)
                {
                    matrix[row, col] = currentRow[col];

                    if (matrix[row, col] == 'M')
                    {
                        marioRow = row;
                        marioCol = col;
                    }
                }
            }

            matrix[marioRow, marioCol] = '-';

            while (true)
            {
                var command = Console.ReadLine().Split();
                var direction = char.Parse(command[0]);
                var bowserRow = int.Parse(command[1]);
                var bowserCol = int.Parse(command[2]);

                matrix[bowserRow, bowserCol] = 'B';
                lives--;

                MoveRow(matrix, marioRow, direction);
                MoveCol(matrix, marioCol, direction);
                var currentLocation = matrix[marioRow, marioCol];

                if (lives <= 0)
                {
                    matrix[marioRow, marioCol] = 'X';
                    isDead = true;
                    break;
                }

                if (currentLocation == 'B')
                {
                    lives -= 2;
                    if (lives <= 0)
                    {
                        matrix[marioRow, marioCol] = 'X';
                        break;
                    }
                }
                else if (currentLocation == 'P')
                {
                    matrix[marioRow, marioCol] = '-';
                    break;
                }

                matrix[marioRow, marioCol] = 'M';
            }

            Console.WriteLine(!isDead
                ? $"Mario has successfully saved the princess! Lives left: {lives}"
                : $"Mario died at {marioRow};{marioCol}.");

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

        public static int MoveRow(char[,] matrix, int row, char direction)
        {
            var rowsLength = matrix.GetLength(0);
            var previousRow = row;

            if (direction == 'W')
            {
                row--;
                if (row < 0)
                {
                    row = previousRow;
                }

            }
            else if (direction == 'S')
            {
                row++;
                if (row > rowsLength - 1)
                {
                    row = previousRow;
                }
            }

            return row;
        }
        public static int MoveCol(char[,] matrix, int col, char direction)
        {
            var colsLength = matrix.GetLength(1);
            var previousCol = col;

            if (direction == 'L')
            {
                col--;
                if (col < 0)
                {
                    col = previousCol;
                }
            }
            if (direction == 'R')
            {
                col++;
                if (col > colsLength - 1)
                {
                    col = previousCol;
                }
            }

            return col;
        }
    }
}
