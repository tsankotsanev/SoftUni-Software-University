using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentsCount = int.Parse(Console.ReadLine());

            var students = new Dictionary<string, List<double>>();

            for (var i = 0; i < studentsCount; i++)
            {
                var studentName = Console.ReadLine();
                var studentGrade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(studentName))
                {
                    students.Add(studentName, new List<double>());
                }

                students[studentName].Add(studentGrade);
            }

            foreach (var (key, value) in students
                .Where(x => x.Value.Average() >= 4.50)
                .OrderByDescending(x => x.Value.Average()))
            {
                Console.WriteLine($"{key} -> {value.Average():F2}");
            }
        }
    }
}