using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            var companies = new Dictionary<string, List<string>>();

            var command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                var splitCommand = command
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                var companyName = splitCommand[0];
                var employeeId = splitCommand[1];

                if (!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName, new List<string>());
                }

                if (!companies[companyName].Contains(employeeId))
                {
                    companies[companyName].Add(employeeId);
                }
            }

            foreach (var (key, value) in companies.OrderBy(x => x.Key))
            {
                Console.WriteLine(key);

                foreach (var employee in value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}