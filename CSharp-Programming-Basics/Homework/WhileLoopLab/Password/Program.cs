using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            var username = Console.ReadLine();
            var password = Console.ReadLine();
            var inputPassword = Console.ReadLine();

            while (inputPassword != password)
            {
                inputPassword = Console.ReadLine();
            }

            Console.WriteLine($"Welcome {username}!");
        }
    }
}
