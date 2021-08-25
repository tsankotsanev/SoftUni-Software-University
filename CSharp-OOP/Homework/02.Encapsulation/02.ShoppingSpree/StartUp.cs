using System;
using _02.ShoppingSpree.Core;

namespace _02.ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                var engine = new Engine();
                engine.Run();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
