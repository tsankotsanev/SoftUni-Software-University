using System;

namespace _02.SuperMario
{
    class Program
    {
        static void Main(string[] args)
        {
            var lives = int.Parse(Console.ReadLine());
            var rows = int.Parse(Console.ReadLine());

            var matrix = new char[rows][];
            var marioRow = -1;
            var marioCol = -1;
            var hasWon = false;

            for (var row = 0; row < matrix.GetLength(0); row++)
            {
                var matrixRow = Console.ReadLine();
                matrix[row] = new char[matrixRow.Length];

                for (var col = 0; col < matrixRow.Length; col++)
                {
                    matrix[row][col] = matrixRow[col];
                    if (matrix[row][col] == 'M')
                    {
                        marioRow = row;
                        marioCol = col;
                    }
                }
            }

            while (true)
            {
                var command = Console.ReadLine().Split();
                var direction = char.Parse(command[0]);
                var bowserRow = int.Parse(command[1]);
                var bowserCol = int.Parse(command[2]);

                matrix[bowserRow][bowserCol] = 'B';
                matrix[marioRow][marioCol] = '-';
                lives--;
                switch (direction)
                {
                    case 'W':
                        if (marioRow - 1 < 0)
                        {
                            continue;
                        }

                        marioRow--;
                        break;
                    case 'S':
                        if (marioRow + 1 == rows)
                        {
                            continue;
                        }

                        marioRow++;
                        break;
                    case 'A':
                        if (marioCol - 1 < 0)
                        {
                            continue;
                        }

                        marioCol--;
                        break;
                    case 'D':
                        if (marioCol + 1 == matrix[marioRow].Length)
                        {
                            continue;
                        }

                        marioCol++;
                        break;
                }

                if (lives <= 0)
                {
                    matrix[marioRow][marioCol] = 'X';
                    break;
                }

                if (matrix[marioRow][marioCol] == 'B')
                {
                    lives -= 2;
                    if (lives <= 0)
                    {
                        matrix[marioRow][marioCol] = 'X';
                        break;
                    }
                }
                else if (matrix[marioRow][marioCol] == 'P')
                {
                    hasWon = true;
                    matrix[marioRow][marioCol] = '-';
                    break;
                }
            }

            Console.WriteLine(hasWon
                ? $"Mario has successfully saved the princess! Lives left: {lives}"
                : $"Mario died at {marioRow};{marioCol}.");

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join("", row));
            }
        }
    }
}