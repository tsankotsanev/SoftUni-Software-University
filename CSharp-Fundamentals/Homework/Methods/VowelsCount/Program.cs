using System;
using System.Linq;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToLower();

            CountVowels(text);
        }

        private static void CountVowels(string text)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };

            var vowelsCount = text.Count(x => vowels.Contains(x));

            Console.WriteLine(vowelsCount);
        }
    }
}
