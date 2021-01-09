using System;

namespace StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var strength = 0;

            for (var i = 0; i < input.Length; i++)
            {
                var symbol = input[i];

                if (symbol == '>')
                {
                    strength += int.Parse(input[i + 1].ToString());
                    continue;
                }

                if (strength > 0)
                {
                    input = input.Remove(i, 1);
                    i--;
                    strength--;
                }
            }

            Console.WriteLine(input);
        }
    }
}