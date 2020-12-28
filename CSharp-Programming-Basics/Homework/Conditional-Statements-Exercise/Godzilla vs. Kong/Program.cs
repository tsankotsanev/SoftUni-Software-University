using System;

namespace Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            var filmBudget = double.Parse(Console.ReadLine());
            var statistsCount = int.Parse(Console.ReadLine());
            var priceClothingPerStatist = double.Parse(Console.ReadLine());

            var decorSum = filmBudget * 0.10;
            var clothingSum = priceClothingPerStatist * statistsCount;

            if (statistsCount > 150)
            {
                clothingSum -= 0.10 * clothingSum;
            }

            var totalSumForTheMovie = decorSum + clothingSum;

            if (totalSumForTheMovie <= filmBudget)  
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {filmBudget - totalSumForTheMovie:F2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalSumForTheMovie - filmBudget:F2} leva more.");
            }
        }
    }
}
