using System;

namespace BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentsCount = int.Parse(Console.ReadLine());
            var lecturesCount = int.Parse(Console.ReadLine());
            var bonus = int.Parse(Console.ReadLine());

            var maxBonus = double.MinValue;
            var maxLectures = int.MinValue;

            if (studentsCount == 0 || lecturesCount == 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, "Max Bonus: 0.",
                    "The student has attended 0 lectures."));
                return;
            }

            for (int i = 0; i < studentsCount; i++)
            {
                var attendances = int.Parse(Console.ReadLine());

                var totalBonus = (double) attendances / lecturesCount * (5 + bonus);

                if (attendances > maxLectures)
                {
                    maxLectures = attendances;
                    maxBonus = totalBonus;
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, $"Max Bonus: {Math.Ceiling(maxBonus)}.",
                $"The student has attended {maxLectures} lectures."));
        }
    }
}
