using System;
using System.Linq;
using Console = System.Console;

namespace _02.Warships
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine()!);
            var matrix = new char[n, n];
            var coordinates = Console
                .ReadLine()
                ?.Split(',', StringSplitOptions.RemoveEmptyEntries);

            var playerOneShips = 0;
            var playerTwoShips = 0;
            var totalCountShipsDestroyed = 0;
            var playerOneHasWon = false;
            var playerTwoHasWon = false;
            var drawGame = false;

            for (var row = 0; row < n; row++)
            {
                var rowData = Console.ReadLine()
                    ?.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (var col = 0; col < n; col++)
                {
                    matrix[row, col] = rowData[col];

                    if (matrix[row, col] == '<')
                    {
                        playerOneShips++;
                    }
                    else if (matrix[row, col] == '>')
                    {
                        playerTwoShips++;
                    }
                }
            }

            foreach (var coordinate in coordinates)
            {
                var currentCoordinate = coordinate
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                var currentRow = currentCoordinate[0];
                var currentCol = currentCoordinate[1];

                if (currentRow < 0 || currentRow >= n || currentCol < 0 || currentCol >= n)
                {
                    continue;
                }

                if (IsPlayerOneShip(matrix, currentRow, currentCol))
                {
                    playerOneShips--;
                    matrix[currentRow, currentCol] = 'X';
                    totalCountShipsDestroyed++;
                }
                else if (IsPlayerTwoShip(matrix, currentRow, currentCol))
                {
                    playerTwoShips--;
                    matrix[currentRow, currentCol] = 'X';
                    totalCountShipsDestroyed++;
                }
                else if (matrix[currentRow, currentCol] == '#')
                {
                    for (var row = currentRow - 1; row <= currentRow + 1; row++)
                    {
                        for (var col = currentCol - 1; col <= currentCol + 1; col++)
                        {
                            if (row >= 0 && row < n &&
                                col >= 0 && col < n)
                            {
                                if (IsPlayerOneShip(matrix, row, col))
                                {
                                    playerOneShips--;
                                    matrix[row, col] = 'X';
                                    totalCountShipsDestroyed++;
                                }
                                else if (IsPlayerTwoShip(matrix, row, col))
                                {
                                    playerTwoShips--;
                                    matrix[row, col] = 'X';
                                    totalCountShipsDestroyed++;
                                }
                            }
                        }
                    }
                }


                if (playerTwoShips <= 0)
                {
                    playerOneHasWon = true;
                    break;
                }

                if (playerOneShips <= 0)
                {
                    playerTwoHasWon = true;
                    break;
                }

            }

            if (playerOneShips > 0 && playerTwoShips > 0)
            {
                drawGame = true;
            }

            if (drawGame)
            {
                Console.WriteLine($"It's a draw! Player One has {playerOneShips} ships left. Player Two has {playerTwoShips} ships left.");
            }

            else if (playerOneHasWon)
            {
                Console.WriteLine($"Player One has won the game! {totalCountShipsDestroyed} ships have been sunk in the battle.");
            }

            else if (playerTwoHasWon)
            {
                Console.WriteLine($"Player Two has won the game! {totalCountShipsDestroyed} ships have been sunk in the battle.");
            }

        }

        public static bool IsPlayerOneShip(char[,] matrix, int row, int col)
        {
            return matrix[row, col] == '<';
        }

        public static bool IsPlayerTwoShip(char[,] matrix, int row, int col)
        {
            return matrix[row, col] == '>';
        }
    }
}