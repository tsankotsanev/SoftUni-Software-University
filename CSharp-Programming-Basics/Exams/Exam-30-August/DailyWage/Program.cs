using System;

namespace DailyWage
{
    class Program
    {
        static void Main(string[] args)
        {
            var row = int.Parse(Console.ReadLine());
            var position = int.Parse(Console.ReadLine());

            var berry = 0;
            var blueberry = 0;

            for (var i = 1; i <= row; i++)
            {
                for (var j = 1; j <= position; j++)
                {
                    if (i % 2 != 0)
                    {
                        berry++;
                    }
                    if (i % 2 == 0 && j % 3 != 0)
                    {
                        blueberry++;
                    }
                }
            }

            var berryPrice = berry * 3.50;
            var blueberryPrice = blueberry * 5.00;
            var totalMoney = berryPrice + blueberryPrice;
            var discountedMoney = totalMoney * 0.80;

            Console.WriteLine($"Total: {discountedMoney:F2} lv.");
        }
    }
}
