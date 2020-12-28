using System;

namespace KartRankList
{
    class Program
    {
        static void Main(string[] args)
        {
            var goldCards = 0;
            var silverCards = 0;
            var bronzeCards = 0;
            var fastestPilot = double.MaxValue;
            var minutes = 0.0;
            var seconds = 0.0;
            var fastestPilotName = string.Empty;
            var time = 0.0;
            var winnerMinutes = 0.0;
            var winnerSeconds = 0.0;

            while (true)
            {
                var name = Console.ReadLine();

                if ( name == "Finish")
                {
                    break;
                }

                minutes = int.Parse(Console.ReadLine());
                seconds = int.Parse(Console.ReadLine());

                time = seconds + (minutes * 60);

                if (time < fastestPilot)
                {
                    fastestPilot = time;
                    fastestPilotName = name;

                    winnerMinutes = Math.Floor(time / 60);
                    winnerSeconds = time % 60;
                }
                
                if (time < 55)
                {
                    goldCards++;
                }
                else if (time >= 55 && time <= 85)
                {
                    silverCards++;
                }
                else if (time > 85 && time <= 120)
                {
                    bronzeCards++;
                }
            }

            Console.WriteLine($"With {winnerMinutes} minutes and {winnerSeconds} seconds {fastestPilotName} is the winner of the day!");
            Console.WriteLine($"Today's prizes are {goldCards} Gold {silverCards} Silver and {bronzeCards} Bronze cards!");
        }
    }
}
