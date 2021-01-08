using System;
using System.Linq;

namespace PasswordReset
{
    class PasswordReset
    {
        static void Main(string[] args)
        {
            var password = Console.ReadLine();

            var command = "";

            while ((command = Console.ReadLine()) != "Done")
            {
                var splitCommand = command.Split(" ",
                    StringSplitOptions.RemoveEmptyEntries);

                var action = splitCommand[0];

                switch (action)
                {
                    case "TakeOdd":
                        password = password
                            .Where((ch, i) => i % 2 != 0)
                            .Aggregate(string.Empty,
                                (t, ch) => t + ch);

                        Console.WriteLine(password);

                        break;
                    case "Cut":
                        var index = int.Parse(splitCommand[1]);
                        var length = int.Parse(splitCommand[2]);

                        password = password.Remove(index,length);

                        Console.WriteLine(password);

                        break;
                    case "Substitute":
                        var substring = splitCommand[1];
                        var substitute = splitCommand[2];

                        if (password.Contains(substring))
                        {
                            password = password.Replace(substring
                                , substitute);

                            Console.WriteLine(password);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }

                        break;
                }
            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}
