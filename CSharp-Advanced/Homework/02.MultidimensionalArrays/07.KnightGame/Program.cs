using System;

namespace _07.KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimensions = int.Parse(Console.ReadLine());
            var chessBoard = ReadMatrix(dimensions, dimensions);

            var knightCount = 0;
            var killerRow = 0;
            var killerCol = 0;

            while (true)
            {
                var maxAttacks = 0;

                for (var row = 0; row < chessBoard.GetLength(0); row++)
                {
                    for (var col = 0; col < chessBoard.GetLength(1); col++)
                    {
                        var currentAttacks = 0;

                        if (chessBoard[row, col] == 'K')
                        {
                            if (IsValid(chessBoard, row + 1, col - 2) && chessBoard[row + 1, col - 2] == 'K')
                            {
                                currentAttacks++;
                            }
                            if (IsValid(chessBoard, row + 1, col + 2) && chessBoard[row + 1, col + 2] == 'K')
                            {
                                currentAttacks++;
                            }
                            if (IsValid(chessBoard, row + 2, col - 1) && chessBoard[row + 2, col - 1] == 'K')
                            {
                                currentAttacks++;
                            }
                            if (IsValid(chessBoard, row + 2, col + 1) && chessBoard[row + 2, col + 1] == 'K')
                            {
                                currentAttacks++;
                            }
                            if (IsValid(chessBoard, row - 2, col - 1) && chessBoard[row - 2, col - 1] == 'K')
                            {
                                currentAttacks++;
                            }
                            if (IsValid(chessBoard, row - 2, col + 1) && chessBoard[row - 2, col + 1] == 'K')
                            {
                                currentAttacks++;
                            }
                            if (IsValid(chessBoard, row - 1, col - 2) && chessBoard[row - 1, col - 2] == 'K')
                            {
                                currentAttacks++;
                            }
                            if (IsValid(chessBoard, row - 1, col + 2) && chessBoard[row - 1, col + 2] == 'K')
                            {
                                currentAttacks++;
                            }
                        }
                        if (currentAttacks > maxAttacks)
                        {
                            maxAttacks = currentAttacks;
                            killerCol = col;
                            killerRow = row;
                        }
                    }
                }
                if (maxAttacks > 0)
                {
                    chessBoard[killerRow, killerCol] = '0';
                    knightCount++;
                }
                else
                {
                    Console.WriteLine(knightCount);
                    break;
                }
            }
        }
        private static bool IsValid(char[,] chessBoard, int row, int column)
        {
            return row >= 0 && row < chessBoard.GetLength(0)
               && column >= 0 && column < chessBoard.GetLength(1);
        }
        private static char[,] ReadMatrix(int rows, int cols)
        {
            var matrix = new char[rows, cols];

            for (var row = 0; row < matrix.GetLength(0); row++)
            {
                var rowDate = Console
                           .ReadLine()
                           .ToCharArray();
                for (var col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowDate[col];
                }
            }

            return matrix;
        }
    }
}
