using System.Collections.Generic;

namespace _05.Restaurant
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var listing = new List<Product>();

            var coffe = new Coffee("Lavaza", 30);
            var desert = new Dessert("Nedelq", 25, 500, 1000);
            var tea = new Tea("Twings", 2, 250);
            var soup = new Soup("Potato", 3, 250);

            listing.Add(coffe);
            listing.Add(desert);
            listing.Add(tea);
            listing.Add(soup);

            foreach (var item in listing)
            {
                System.Console.WriteLine($"{item.GetType()}, {item.Name}, {item.Price},{item}");
            }
        }
    }
}