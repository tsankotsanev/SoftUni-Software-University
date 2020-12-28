using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            var username = Console.ReadLine();

            var usernameReversed = username.ToCharArray();
            Array.Reverse(usernameReversed);

            var password = new string(usernameReversed);
            
            var passwordTries = 0;

            while (true)
            {
                var inputPassword = Console.ReadLine();

                passwordTries++;

                if (inputPassword == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }

                if (passwordTries == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }

                if (inputPassword != password)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }
        }
    }
}
