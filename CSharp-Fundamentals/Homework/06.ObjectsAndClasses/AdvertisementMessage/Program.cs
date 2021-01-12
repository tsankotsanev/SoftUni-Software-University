using System;

namespace AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            var messagesCount = int.Parse(Console.ReadLine());

            var rnd = new Random();

            var phrases = new[]
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            var events = new[]
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            var authors = new[]
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };

            var cities = new[]
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };

            for (var i = 0; i < messagesCount; i++)
            {
                var randomPhrase = rnd.Next(0, phrases.Length);
                var randomEvent = rnd.Next(0, events.Length);
                var randomAuthor = rnd.Next(0, authors.Length);
                var randomCity = rnd.Next(0, cities.Length);

                Console.WriteLine($"{phrases[randomPhrase]} {events[randomEvent]} {authors[randomAuthor]} - {cities[randomCity]}");
            }
        }
    }
}