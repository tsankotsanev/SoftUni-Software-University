using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double squareMeters = double.Parse(Console.ReadLine());
            double pricePerSquareMeter = 7.61;
            double priceBeforeTheDiscount = squareMeters * pricePerSquareMeter;
            double discount = priceBeforeTheDiscount * 0.18;
            double finalPrice = priceBeforeTheDiscount - discount;

            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
