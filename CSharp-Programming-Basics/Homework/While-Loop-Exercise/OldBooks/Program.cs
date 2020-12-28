using System;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = Console.ReadLine();
            var currentBook = Console.ReadLine();
            var bookCounter = 0;

            while (currentBook != "No More Books" || currentBook == book)
            {
                currentBook = Console.ReadLine();

                bookCounter++;

                if (currentBook == book)
                {
                    Console.WriteLine($"You checked {bookCounter} books and found it.");
                    Environment.Exit(0); 
                }
            }

            Console.WriteLine("The book you search is not here!");  
            Console.WriteLine($"You checked {bookCounter} books.");
        }
    }
}
