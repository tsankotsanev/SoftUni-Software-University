using System;

namespace World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentRecordInSeconds = double.Parse(Console.ReadLine());
            var currentDistanceInMeters = double.Parse(Console.ReadLine());
            var timeInSecondsPerMeter = double.Parse(Console.ReadLine());
            var totalAddedTime = 0.0;

            if (currentDistanceInMeters >= 15)
            {
                totalAddedTime = Math.Floor(currentDistanceInMeters / 15) * 12.5;
            }

            var totalDistanceHeHasToSwim = currentDistanceInMeters * timeInSecondsPerMeter;
            var totalTime = totalDistanceHeHasToSwim + totalAddedTime;

            if (totalTime < currentRecordInSeconds)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {totalTime - currentRecordInSeconds:F2} seconds slower.");
            }
        }
    }
}
