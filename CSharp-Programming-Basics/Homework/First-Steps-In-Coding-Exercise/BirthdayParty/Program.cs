using System;

namespace BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double hallRent = double.Parse(Console.ReadLine());
            double cakePrice = hallRent * 0.20;
            double drinksPrice = cakePrice - (cakePrice * 0.45);
            double animatorPrice = hallRent / 3;

            double neededSum = hallRent + cakePrice + drinksPrice + animatorPrice;

            Console.WriteLine(neededSum);
        }
    }
}
