using System;
using System.Linq;
using _06.Telephony.Common;
using _06.Telephony.Contract;
using _06.Telephony.Model;

namespace _06.Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            var numbers = ReadConsole();

            foreach (var num in numbers)
            {
                try
                {
                    if (num.Length == Validator.NUMBER_IS_LONG)
                    {
                        Calling(num);
                    }
                    else
                    {
                        Dialing(num);
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

            }
            var sites = ReadConsole();

            foreach (var url in sites)
            {
                try
                {
                    Browsing(url);

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static string[] ReadConsole()
        {
            return Console.ReadLine()
                          .Split(" ")
                          .ToArray();
        }

        private static void Calling(string num)
        {
            ICallable number = new Smartphone();

            Console.WriteLine(number.Calling(num));
        }

        private static void Dialing(string num)
        {
            ICallable number = new StationaryPhone();

            Console.WriteLine(number.Calling(num));
        }

        private static void Browsing(string url)
        {
            IBrowsing webSite = new Smartphone();

            Console.WriteLine(webSite.Browsing(url));
        }
    }
}
