using System;

namespace _02.Bees
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var matrix = new char[n, n];

            for (var row = 0; row < n; row++)
            {
                var currentRow = Console.ReadLine();
                for (var col = 0; col < currentRow.Length; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            var beeRow = 0;
            var beeCol = 0;

            for (var row = 0; row < n; row++)
            {
                for (var col = 0; col < n; col++)
                {
                    if (matrix[row, col] != 'B') continue;
                    beeRow = row;
                    beeCol = col;
                }
            }

            var input = "";
            var flowers = 0;

            while ((input = Console.ReadLine()) != "End")
            {
                matrix[beeRow, beeCol] = '.';
                beeRow = MoveRow(beeRow, input);                                                                                                                                              
                beeCol = MoveCol(beeCol, input);

                if (!IsPositionValid(beeRow, beeCol, n,n))
                {
                    Console.WriteLine("The bee got lost!");
                    break;
                }

                if (matrix[beeRow, beeCol] == 'f')
                {
                    flowers++;
                }

                if (matrix[beeRow, beeCol] == 'O')
                {
                    matrix[beeRow, beeCol] = '.';
                    beeRow = MoveRow(beeRow, input);
                    beeCol = MoveCol(beeCol, input);
                    if (!IsPositionValid(beeRow, beeCol, n, n))
                    {
                        Console.WriteLine("The bee got lost!");
                        break;
                    }
                    if (matrix[beeRow, beeCol] == 'f')
                    {
                        flowers++;
                    }
                }

                matrix[beeRow, beeCol] = 'B';
            }

            Console.WriteLine(flowers < 5
                ? $"The bee couldn't pollinate the flowers, she needed {5 - flowers} flowers more"
                : $"Great job, the bee managed to pollinate {flowers} flowers!");

            for (var row = 0; row < matrix.GetLength(0); row++)
            {
                for (var col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]);
                }

                Console.WriteLine();
            }
        }

        public static bool IsPositionValid(int row, int col, int rows, int cols)
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

        public static int MoveRow(int row, string movement)
        {
            return movement switch
            {
                "up" => row - 1,
                "down" => row + 1,
                _ => row
            };
        }

        public static int MoveCol(int col, string movement)
        {
            return movement switch
            {
                "left" => col - 1,
                "right" => col + 1,
                _ => col
            };
        }
    }
}
