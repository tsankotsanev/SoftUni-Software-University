using System;

namespace _02.SuperMario
{
    class Program
    {
        static void Main(string[] args)
        {
            var marioLives = int.Parse(Console.ReadLine());


            var n = int.Parse(Console.ReadLine());

            var matrix = new char[n, n];
            var marioRow = -1;
            var marioCol = -1;
            var princessRow = -1;
            var princessCol = -1;

            for (var row = 0; row < n; row++)
            {
                var currentRow = Console.ReadLine();
                for (var col = 0; col < currentRow.Length; col++)
                {
                    if (matrix[row, col] == 'M')
                    {
                        marioRow = row;
                        marioCol = col;
                    }

                    if (matrix[row, col] == 'P')
                    {
                        princessRow = row;
                        princessCol = col;
                    }

                    matrix[row, col] = currentRow[col];
                }
            }

            while (expression)
            {
                
            }
        }
    }
}
