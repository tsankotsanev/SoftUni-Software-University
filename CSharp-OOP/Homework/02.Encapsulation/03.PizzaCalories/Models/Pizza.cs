using System;
using System.Collections.Generic;
using System.Linq;
using _03.PizzaCalories.Common;
using static System.String;

namespace _03.PizzaCalories.Models
{
    public class Pizza
    {
        private string _name;
        public Dough Dough;
        public readonly List<Topping> Toppings;
        public Pizza(List<Topping> toppings)
        {
            Toppings = new List<Topping>();
        }

        public Pizza(string name, Dough dough)
        {
            Name = name;
            Toppings = new List<Topping>();
            Dough = dough;
        }


        public string Name
        {
            get => _name;
            private set
            {
                if (IsNullOrWhiteSpace(value) ||
                    value.Length is > Constants.MaxLengthOfPizzaName or < Constants.MinLengthOfPizzaName)
                {
                    throw new ArgumentException(Format(Constants.InvalidArgumentLengthOfPizzaName,
                        Constants.MinLengthOfPizzaName, Constants.MaxLengthOfPizzaName));
                }
                _name = value;
            }
        }

        public int CountOfToppings => Toppings.Count;

        public double TotalCalories
            => Dough.Calories + Toppings.Sum(s => s.ToppingCalories);

        public void AddToppings(Topping topping)
        {
            if (Toppings.Count > Constants.MaxCountOfToppings)
            {
                throw new InvalidOperationException
                       (Format(Constants.InvalidOperationForToppingCount, 0, Constants.MaxCountOfToppings));

            }
            Toppings.Add(topping);
        }

        public override string ToString()
        {
            return $"{Name} - {TotalCalories:f2} Calories.";
        }
    }
}
