using System;

namespace GraduationPt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentName = Console.ReadLine();
            var gradeCounter = 0;
            var failedGradesCounter = 0;
            var gradeSum = 0.0;

            while (true)
            {
                var grade = double.Parse(Console.ReadLine());

                gradeSum += grade;

                if (grade < 4.00)
                {
                    failedGradesCounter++;
                }
                if (failedGradesCounter == 2)
                {
                    Console.WriteLine($"{studentName} has been excluded at {gradeCounter} grade");
                    break;
                }

                gradeCounter++;

                if (gradeCounter == 12)
                {
                    var averageGrade = gradeSum / gradeCounter;

                    Console.WriteLine($"{studentName} graduated. Average grade: {averageGrade:F2}");
                    break;
                }
            }
        }
    }
}
