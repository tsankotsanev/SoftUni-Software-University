using System;

namespace Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int confectioners = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int gofrettes = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            int cakesSoldPerDay = cakes * 45;
            double gofrettesSoldPerDay = gofrettes * 5.80;
            double pancakesSoldPerDay = pancakes * 3.20;

            double totalSumPerDay = (cakesSoldPerDay + gofrettesSoldPerDay + pancakesSoldPerDay) * confectioners;
            double totalSumForTheWholeCampaign = totalSumPerDay * days;
            double math = totalSumForTheWholeCampaign / 8;
            double totalSumAfterTheExpenses = totalSumForTheWholeCampaign - math;

            Console.WriteLine(totalSumAfterTheExpenses);
        }
    }
}
