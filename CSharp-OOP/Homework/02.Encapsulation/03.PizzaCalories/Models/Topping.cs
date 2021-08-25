using System;
using System.Collections.Generic;
using System.Linq;
using _03.PizzaCalories.Common;

namespace _03.PizzaCalories.Models
{
    public class Topping
    {
        private string _toppingTypes;
        private double _gram;

        private readonly Dictionary<string, double> _defaultToppingTypes = new Dictionary<string, double>()
        {
            {"meat", 1.2},
            {"veggies", 0.8},
            {"cheese", 1.1},
            {"sauce", 0.9},
        };

        public Topping(string topingTypes, double gram)
        {
            ToppingTypes = topingTypes;
            Gram = gram;
        }

        public double Gram
        {
            get => _gram;
            private set
            {
                if (value is < Constants.MinWeightForTopping or > Constants.MaxWeightForTopping)
                {
                    var currentToppingType = _toppingTypes.First().ToString().ToUpper() + _toppingTypes.Substring(1);
                    throw new
                        InvalidOperationException(String.Format(Constants.InvalidOperationForGramOfTopping,
                       currentToppingType, Constants.MinWeightForTopping, Constants.MaxWeightForTopping));
                }
                _gram = value;
            }
        }
        public string ToppingTypes
        {
            get => _toppingTypes;
            private set
            {
                if (!_defaultToppingTypes.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException(String.Format(Constants.InvalidArgumentOfTopping, value));
                }
                _toppingTypes = value.ToLower();
            }
        }

        public double ToppingCalories
            => _defaultToppingTypes[_toppingTypes] * _gram * Constants.MinCaloriesPerGram;

        public double TotalCalorie => ToppingCalories;
    }
}
