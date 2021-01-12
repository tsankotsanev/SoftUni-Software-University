using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var groupSize = int.Parse(Console.ReadLine());
            var groupType = Console.ReadLine();
            var currentDay = Console.ReadLine();

            var price = 0.0;

            if (currentDay == "Friday")
            {
                if (groupType == "Students")
                {
                    price = 8.45 * groupSize;
                }
                else if (groupType == "Business")
                {
                    price = 10.90 * groupSize;
                }
                else if (groupType == "Regular")
                {
                    price = 15 * groupSize;
                }
            }
            else if (currentDay == "Saturday")
            {
                if (groupType == "Students")
                {
                    price = 9.80 * groupSize;
                }
                else if (groupType == "Business")
                {
                    price = 15.60 * groupSize;
                }
                else if (groupType == "Regular")
                {
                    price = 20 * groupSize;
                }
            }
            else if (currentDay == "Sunday")
            {
                if (groupType == "Students")
                {
                    price = 10.46 * groupSize;
                }
                else if (groupType == "Business")
                {
                    price = 16 * groupSize;
                }
                else if (groupType == "Regular")
                {
                    price = 22.50 * groupSize;
                }
            }

            if (groupType == "Students" && groupSize >= 30)
            {
                price -= price * 0.15;
            }
            else if (groupType == "Business" && groupSize >= 100)
            {
                if (currentDay == "Friday")
                {
                    price -= 10 * 10.90;
                }
                else if (currentDay == "Saturday")
                {
                    price -= 10 * 15.60;
                }
                else
                {
                    price -= 10 * 16;
                }
            }
            else if (groupType == "Regular" && groupSize >= 10 && groupSize <= 20)
            {
                price -= price * 0.05;
            }

            Console.WriteLine($"Total price: {price:F2}");
        }
    }
}