using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var songsInput = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            var songs = new Queue<string>(songsInput);

            while (songs.Any())
            {
                var command = Console.ReadLine();

                switch (command)
                {
                    case "Play":
                        songs.Dequeue();
                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ", songs));
                        break;
                    default:
                        s
                        {
                            var songToAdd = command[4..];

                            if (songs.Contains(songToAdd))
                            {
                                Console.WriteLine($"{songToAdd} is already contained!");
                            }
                            else
                            {
                                songs.Enqueue(songToAdd);
                            }
                            break;
                        }
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
