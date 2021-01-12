using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            var websitesOpenCount = int.Parse(Console.ReadLine());
            var salary = int.Parse(Console.ReadLine());

            for (int i = 0; i < websitesOpenCount; i++)
            {
                var website = Console.ReadLine();

                if (website == "Facebook")
                {
                    salary -= 150;
                }
                else if (website == "Instagram")
                {
                    salary -= 100;
                }
                else if (website == "Reddit")
                {
                    salary -= 50;
                }
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }

            }
            if (salary > 0)
            {
                Console.WriteLine(salary);
            }
        }
    }
}
