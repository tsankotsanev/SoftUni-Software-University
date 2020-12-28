using System;

namespace WorkingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var day = Console.ReadLine();

            if (day == "Sunday")
            {
                Console.WriteLine("closed");
                return;
            }
            else if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday" || day == "Saturday") ;
            {
                if (hour >= 10 && hour <= 18)
                {
                    Console.WriteLine("open");
                }
                else
                {
                    Console.WriteLine("closed");
                }
            }
        }
    }
}
