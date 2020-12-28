using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        { 
            var totalMoneySaved = 0.0;

            while (true)
            {
                var destination = Console.ReadLine();

                if (destination == "End")
                {
                    break;
                }

                var moneyNeeded = double.Parse(Console.ReadLine());

                totalMoneySaved = 0;

                while (totalMoneySaved < moneyNeeded)
                {
                    var moneySaved = double.Parse(Console.ReadLine());

                    totalMoneySaved += moneySaved;

                    if (totalMoneySaved >= moneyNeeded)
                    {
                        Console.WriteLine($"Going to {destination}!");
                    }

                }
            }
        }
    }
}
