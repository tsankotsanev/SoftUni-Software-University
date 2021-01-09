using System;
using System.Linq;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split(", ")
                .ToArray();

            foreach (var word in words)
            {
                var isValid = false;

                if (word.Length >= 3 && word.Length <= 16)
                {
                    foreach (var character in word)
                    {
                        if (char.IsLetterOrDigit(character) ||
                            character == '-' ||
                            character == '_')
                        {
                            isValid = true;
                        }
                        else
                        {
                            isValid = false;
                            break;
                        }
                    }
                }

                if (isValid)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}