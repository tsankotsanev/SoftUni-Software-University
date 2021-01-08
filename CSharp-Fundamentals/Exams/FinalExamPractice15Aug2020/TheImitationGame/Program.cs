using System;

namespace TheImitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var message = Console.ReadLine();
            var command = Console.ReadLine();

            while (command != "Decode")
            {
                var tokens = command
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);

                var action = tokens[0];

                switch (action)
                {
                    case "Move":
                        var letters = int.Parse(tokens[1]);
                        var lettersToAdd = message[..letters];

                        message = message.Remove(0, letters);
                        message += lettersToAdd;
                        break;
                    case "Insert":
                        var index = int.Parse(tokens[1]);
                        var value = tokens[2];

                        message = message.Insert(index, value);
                        break;
                    case "ChangeAll":
                        var substring = tokens[1];
                        var replacement = tokens[2];

                        message = message.Replace(substring, replacement);
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
