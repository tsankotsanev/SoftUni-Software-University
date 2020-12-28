using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var depositSum = double.Parse(Console.ReadLine());
            var depositTime = int.Parse(Console.ReadLine());
            var annualInterestRate = double.Parse(Console.ReadLine());

            var interestRateForTheWholeYear = depositSum * annualInterestRate / 100;
            var interestRatePerMonth = interestRateForTheWholeYear / 12;
            var finalSum = depositSum + depositTime * interestRatePerMonth;

            Console.WriteLine(finalSum);
        }
    }
}
