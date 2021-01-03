using System;
using System.Linq;

namespace CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstPlayerDeck = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var secondPlayerDeck = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            for (var i = 0; i < firstPlayerDeck.Count; i++)
            {
                for (var j = i; j < secondPlayerDeck.Count; j++)
                {
                    var firstPlayerCard = firstPlayerDeck[i];
                    var secondPlayerCard = secondPlayerDeck[i];

                    if (firstPlayerCard > secondPlayerCard)
                    {
                        firstPlayerDeck.Add(firstPlayerCard);
                        firstPlayerDeck.RemoveAt(i);
                        firstPlayerDeck.Add(secondPlayerCard);

                        secondPlayerDeck.RemoveAt(j);
                    }
                    else if (secondPlayerCard > firstPlayerCard)
                    {
                        secondPlayerDeck.Add(secondPlayerCard);
                        secondPlayerDeck.RemoveAt(j);
                        secondPlayerDeck.Add(firstPlayerCard);

                        firstPlayerDeck.RemoveAt(j);
                    }
                    else
                    {
                        firstPlayerDeck.RemoveAt(i);
                        secondPlayerDeck.RemoveAt(j);
                    }

                    if (firstPlayerDeck.Count == 0)
                    {
                        Console.WriteLine($"Second player wins! Sum: {secondPlayerDeck.Sum()}");
                        return;
                    }
                    if (secondPlayerDeck.Count == 0)
                    {
                        Console.WriteLine($"First player wins! Sum: {firstPlayerDeck.Sum()}");
                        return;
                    }

                    i = 0;
                    j = -1;
                }
            }
        }
    }
}