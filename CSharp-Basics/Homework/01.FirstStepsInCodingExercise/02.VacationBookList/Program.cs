using System;

namespace VacationBookList
{
    class Program
    {
        static void Main(string[] args)
        {
            int pagesCountOfTheBook = int.Parse(Console.ReadLine());
            double pagesReadPerHour = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            double totalTimeToReadTheBook = pagesCountOfTheBook / pagesReadPerHour;
            double neededHoursToReadPerDay = totalTimeToReadTheBook / days;

            Console.WriteLine(neededHoursToReadPerDay);
        }
    }
}
