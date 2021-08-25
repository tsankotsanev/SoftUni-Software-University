using System;
using System.Collections.Generic;
using _03.PizzaCalories.Common;

namespace _03.PizzaCalories.Models
{
    public class Dough
    {
        private string _flourType;
        private string _bakingTechnique;
        private double _gram;

        public readonly Dictionary<string, double> DefaultFlour = new Dictionary<string, double>
       {
           { "white", 1.5},
           { "wholegrain", 1.0}
       };
        public readonly Dictionary<string, double> DefaultBaking = new Dictionary<string, double>
       {
           { "crispy", 0.9},
           { "chewy", 1.1},
           { "homemade", 1.0}
       };
        public Dough(string flourType, string bakingTechnique,
            double gram)
        {
            FlourType = flourType;
            BakingTechnique = bakingTechnique;
            Gram = gram;
        }

        public string FlourType
        {
            get => _flourType;
            private set
            {
                if (!DefaultFlour.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException(Constants.InvalidArgumentOfDough);
                }
                _flourType = value.ToLower();
            }
        }
        public string BakingTechnique
        {
            get => _bakingTechnique;
            private set
            {
                if (!DefaultBaking.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException(Constants.InvalidArgumentOfDough);
                }
                _bakingTechnique = value.ToLower();
            }
        }
        public double Gram
        {
            get => _gram;
            private set
            {
                if (value is < Constants.MinWeightForDough or > Constants.MaxWeightForDough)
                {
                    throw new
                        InvalidOperationException(String.Format(Constants.InvalidOperationForGramOfDough,
                        Constants.MinWeightForDough, Constants.MaxWeightForDough));
                }
                _gram = value;
            }
        }
        
        public double Calories
            => (Constants.MinCaloriesPerGram * _gram) * DefaultFlour[_flourType] * DefaultBaking[_bakingTechnique];
        public double TotalCalories => Calories;
    }
}
