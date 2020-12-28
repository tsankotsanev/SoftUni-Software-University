using System;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = string.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                var isIntegerPalindrome = IsPalindrome(input);

                Console.WriteLine(isIntegerPalindrome ? "true" : "false");
            }
        }

        public static bool IsPalindrome(string input)
        {
            var number = int.Parse(input);
            var result = false;

            if (number >= 0 && number <= 9)
            {
                result = true;
            }
            else
            {
                for (var i = 0; i < input.Length / 2; i++)
                {
                    if (input[i] == input[^1])
                    {
                        result = true;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return result;
        }
    }
}