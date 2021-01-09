using System;
using System.Linq;
using System.Text;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            var sb = new StringBuilder();

            foreach (var encryptedSymbol in text.Select(symbol => (char)(symbol + 3)))
            {
                sb.Append(encryptedSymbol);
            }

            Console.WriteLine(sb);
        }
    }
}