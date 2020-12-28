using System;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();

            PrintMiddleCharacter(word);
        }

        private static void PrintMiddleCharacter(string word)
        {
            if (word.Length % 2 == 0)
            {
                var halfWord = word.Length / 2;
                var result = word.Substring(halfWord - 1, 2);

                Console.WriteLine(result);
            }
            else
            {
                var halfWord = word.Length / 2;
                var result = word.Substring(halfWord, 1);

                Console.WriteLine(result);
            }
        }
    }
}
