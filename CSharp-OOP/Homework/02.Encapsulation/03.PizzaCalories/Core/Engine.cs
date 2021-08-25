using System;
using System.Linq;
using _03.PizzaCalories.Models;

namespace _03.PizzaCalories.Core
{
    public class Engine
    {
        public void Run()
        {
            var pizzaData = Console
              .ReadLine()
              ?.Split(" ")
              .ToArray();

            var doughData = Console
              .ReadLine()
              ?.Split(" ")
              .ToArray();

            var dough = MadeDough(doughData);
            var pizza = new Pizza(pizzaData[1],dough);

            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                var toppingData = input.Split().ToArray();
                var topping = CreateTopping(toppingData);
                pizza.AddToppings(topping);
            }
            Console.WriteLine(pizza);

        }

        private Dough  MadeDough(string[] doughData)
        {
            var typeOfDough = doughData[1];
            var technique = doughData[2];
            var weight = double.Parse(doughData[3]);

            var dough = new Dough(typeOfDough, technique, weight);
            return dough;
        }
        private Topping CreateTopping(string[] toppingInfo)
        {
            var type = toppingInfo[1];
            var weight = double.Parse(toppingInfo[2]);
            var topping = new Topping(type, weight);
            return topping;
        }
    }
}
