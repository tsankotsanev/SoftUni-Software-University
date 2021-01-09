using System;
using System.Linq;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split(" ")
                .ToArray();

            var firstWord = words[0];
            var secondWord = words[1];

            var totalSum = CharacterMultiplier(firstWord, secondWord);

            Console.WriteLine(totalSum);
        }

        private static int CharacterMultiplier(string firstWord, string secondWord)
        {
            var totalSum = 0;

            if (firstWord.Length == secondWord.Length)
            {
                totalSum += firstWord.Select((t, i) => t * secondWord[i]).Sum();
            }
            else
            {
                if (firstWord.Length > secondWord.Length)
                {
                    totalSum += secondWord.Select((t, i) => firstWord[i] * t).Sum();

                    for (var i = secondWord.Length; i < firstWord.Length; i++)
                    {
                        totalSum += firstWord[i];
                    }
                }
                else if (secondWord.Length > firstWord.Length)
                {
                    for (var i = firstWord.Length - 1; i >= 0; i--)
                    {
                        var multiply = firstWord[i] * secondWord[i];
                        totalSum += multiply;
                    }

                    for (var i = firstWord.Length; i < secondWord.Length; i++)
                    {
                        totalSum += secondWord[i];
                    }
                }
            }

            return totalSum;
        }
    }
}