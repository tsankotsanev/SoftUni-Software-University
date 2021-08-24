using System;

namespace FirstProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            var journeyCost = double.Parse(Console.ReadLine());
            var months = int.Parse(Console.ReadLine());

            var moneyPerMonth = journeyCost * 0.25;
            var savedMoney = 0.0;

            for (var currentMonth = 1; currentMonth <= months; currentMonth++)
            {

                if (currentMonth % 2 != 0)
                {
                    savedMoney -= savedMoney * 0.16;
                }

                if (currentMonth % 4 == 0)
                {
                    savedMoney += savedMoney * 0.25;
                }

                savedMoney += moneyPerMonth;
            }

            if (savedMoney >= journeyCost)
            {
                var moneyForSouvenirs = savedMoney - journeyCost;

                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {moneyForSouvenirs:F2}lv. for souvenirs.");
            }
            else
            {
                var moneyNeeded = journeyCost - savedMoney;

                Console.WriteLine($"Sorry. You need {moneyNeeded:F2}lv. more.");
            }
        }
    }
}
