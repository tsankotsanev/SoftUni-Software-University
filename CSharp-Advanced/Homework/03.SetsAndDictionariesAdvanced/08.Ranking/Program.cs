using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = string.Empty;
            var data = new Dictionary<string, string>();
            var students = new Dictionary<string, Dictionary<string, int>>();

            while ((input = Console.ReadLine()) != "end of contests")
            {
                var info = input
                          .Split(":")
                          .ToArray();

                if (!data.ContainsKey(info[0]))
                {
                    data[info[0]] = info[1];
                }
            }

            while ((input = Console.ReadLine()) != "end of submissions")
            {
                var info = input
                         .Split("=>")
                         .ToArray();
                var contest = info[0];
                var password = info[1];
                var username = info[2];
                var points = int.Parse(info[3]);

                if (data.ContainsKey(contest) && data[contest] == password)
                {
                    if (!students.ContainsKey(username))
                    {
                        students.Add(username, new Dictionary<string, int>());
                        students[username].Add(contest, points);
                    }
                    else
                    {
                        if (!students[username].ContainsKey(contest))
                        {
                            students[username].Add(contest, points);

                        }
                        else
                        {
                            if (students[username][contest] < points)
                            {
                                students[username][contest] = points;
                            }
                        }

                    }
                }
            }
            var topCandidate = students
                .OrderByDescending(x => x.Value
                .Sum(x => x.Value))
                .FirstOrDefault();

            Console.WriteLine($"Best candidate is {topCandidate.Key} with total {topCandidate.Value.Sum(x => x.Value)} points.");
            Console.WriteLine("Ranking:");

            foreach (var (key, value) in students.OrderBy(x => x.Key))
            {
                Console.WriteLine(key);
                foreach (var contest in value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}