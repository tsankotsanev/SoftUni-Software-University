using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var courses = new Dictionary<string, List<string>>();

            var command = "";

            while ((command = Console.ReadLine()) != "end")
            {
                var splitCommand = command
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                var courseName = splitCommand[0];
                var studentName = splitCommand[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                }

                courses[courseName].Add(studentName);

            }

            foreach (var (key, value) in courses.OrderByDescending(x => x.Value.Count()))
            {
                Console.WriteLine($"{key}: {value.Count}");

                foreach (var student in value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}