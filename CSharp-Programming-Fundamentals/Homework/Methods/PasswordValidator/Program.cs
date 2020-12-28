using System;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            var password = Console.ReadLine();


            if (IsContainingAtLeastTwoDigits(password)
                && IsBetweenSixAndTenCharacters(password)
                && IsContainingOnlyDigitsAndLetters(password))
            {
                Console.WriteLine("Password is valid");
            }
            else
            {

                if (!IsBetweenSixAndTenCharacters(password))
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }

                if (!IsContainingOnlyDigitsAndLetters(password))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }

                if (!IsContainingAtLeastTwoDigits(password))
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }

            }
        }

        public static bool IsContainingOnlyDigitsAndLetters(string text)
        {

            for (var index = 0; index < text.Length; index++)
            {
                var symbol = text[index];

                if (!char.IsLetterOrDigit(symbol))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsBetweenSixAndTenCharacters(string text)
        {
            if (text.Length >= 6 && text.Length <= 10)
            {
                return true;
            }

            return false;
        }

        public static bool IsContainingAtLeastTwoDigits(string text)
        {
            var counter = 0;

            foreach (var symbol in text)
            {
                if (char.IsDigit(symbol))
                {
                    counter++;
                }
            }

            if (counter >= 2)
            {
                return true;
            }

            return false;

        }
    }
}
