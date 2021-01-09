using System;
using System.Text;

namespace ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            var sb = new StringBuilder();

            for (var i = 0; i < text.Length - 1; i++)
            {
                var currentCharacter = text[i];
                var nextCharacter = text[i + 1];

                if (currentCharacter != nextCharacter)
                {
                    sb.Append(currentCharacter);
                }

                if (i == text.Length - 2)
                {
                    sb.Append(nextCharacter);
                }
            }

            Console.WriteLine(sb);
        }
    }
}