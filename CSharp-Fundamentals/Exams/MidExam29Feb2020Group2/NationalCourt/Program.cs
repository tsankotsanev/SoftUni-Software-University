using System;

namespace NationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstEmployeeEfficiency = int.Parse(Console.ReadLine());
            var secondEmployeeEfficiency = int.Parse(Console.ReadLine());
            var thirdEmployeeEfficiency = int.Parse(Console.ReadLine());
            var peopleCount = int.Parse(Console.ReadLine());

            var totalEmployeesEfficiencyPerHour = firstEmployeeEfficiency + secondEmployeeEfficiency + thirdEmployeeEfficiency;
            var hours = 0;

            while (peopleCount > 0)
            {
                hours++;

                if (hours % 4 == 0)
                {
                    continue;
                }
                peopleCount -= totalEmployeesEfficiencyPerHour;
            }
            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}