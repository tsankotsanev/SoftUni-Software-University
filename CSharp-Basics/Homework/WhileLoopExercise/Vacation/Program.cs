using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var moneyNeeded = double.Parse(Console.ReadLine());
            var moneyOwned = double.Parse(Console.ReadLine());
            var daysCounter = 0;
            var spendingCounter = 0;

            while (true)
            {
                var command = Console.ReadLine();
                var money = double.Parse(Console.ReadLine());

                daysCounter++;

                if (command == "save")
                {
                    moneyOwned += money;
                    spendingCounter = 0;
                }
                else if (command == "spend")
                {
                    moneyOwned -= money;
                    spendingCounter++;
                }
                if (moneyOwned <= 0)
                {
                    moneyOwned = 0;
                }

                if (spendingCounter == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine($"{daysCounter}");
                    break;
                }
                if (moneyOwned >= moneyNeeded)
                {
                    Console.WriteLine($"You saved the money for {daysCounter} days.");
                    break;
                }
            }
        }
    }
}
