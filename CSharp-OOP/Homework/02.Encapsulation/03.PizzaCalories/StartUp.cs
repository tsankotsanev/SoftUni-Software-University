using System;
using _03.PizzaCalories.Core;

namespace _03.PizzaCalories
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
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
