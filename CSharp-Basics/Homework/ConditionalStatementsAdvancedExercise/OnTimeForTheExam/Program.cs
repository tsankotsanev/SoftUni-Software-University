using System;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            int examTime = (examHour * 60) + examMinutes;
            int arrivalTime = (arrivalHour * 60) + arrivalMinutes;
            int timeDiff = Math.Abs(examTime - arrivalTime);
            int diffHour = timeDiff / 60;
            int diffMinutes = timeDiff % 60;
            if (arrivalTime > examTime)
            {
                Console.WriteLine("Late");
                if (timeDiff < 60)
                {
                    Console.WriteLine($"{timeDiff} minutes after the start");
                }
                else if (timeDiff >= 60)
                {
                    Console.WriteLine($"{diffHour}:{diffMinutes:D2} hours after the start");
                }
            }
            else if (arrivalTime >= examTime - 30 && arrivalTime <= examTime)
            {
                Console.WriteLine("On time");
                if (timeDiff != 0 && timeDiff < 60)
                {
                    Console.WriteLine($"{timeDiff} minutes before the start");
                }
                else if (timeDiff != 0 && timeDiff >= 60)
                {
                    Console.WriteLine($"{diffHour}:{diffMinutes:D2} hours before the start");
                }
            }
            else if (arrivalHour < examTime - 30)
            {
                Console.WriteLine("Early");
                if (timeDiff < 60)
                {
                    Console.WriteLine($"{timeDiff} minutes before the start");
                }
                else if (timeDiff >= 60)
                {
                    Console.WriteLine($"{diffHour}:{diffMinutes:D2} hours before the start");
                }
            }
        }
    }
}
