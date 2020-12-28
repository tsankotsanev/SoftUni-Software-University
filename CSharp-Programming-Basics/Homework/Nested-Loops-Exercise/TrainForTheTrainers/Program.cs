using System;

namespace TrainForTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            var judgesCount = int.Parse(Console.ReadLine());
            var presentationName = Console.ReadLine();
            var currentPresentationSum = 0.0;
            var currentPresentationAverage = 0.0;
            var totalPresentationSum = 0.0;
            var totalPresentationAverage = 0.0;
            var presentationsCount = 0;

            while (presentationName != "Finish")
            {
                for (int i = 0; i < judgesCount; i++)
                {
                    var grade = double.Parse(Console.ReadLine());

                    currentPresentationSum += grade;
                    currentPresentationAverage = currentPresentationSum / judgesCount;
                    totalPresentationSum += grade;
                }

                Console.WriteLine($"{presentationName} - {currentPresentationAverage:F2}.");

                presentationsCount++;
                currentPresentationSum = 0;

                presentationName = Console.ReadLine();
            }

            totalPresentationAverage = totalPresentationSum / (judgesCount * presentationsCount);

            Console.WriteLine($"Student's final assessment is {totalPresentationAverage:F2}.");
        }
    }
}
