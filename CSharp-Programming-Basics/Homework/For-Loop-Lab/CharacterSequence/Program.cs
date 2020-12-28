using System;

namespace CharacterSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                var letter = input[i];
                Console.WriteLine(letter);
            }
        }
    }
}
