﻿using System;
using System.Collections.Generic;
using _04.WildFarm.Models.Food;

namespace _04.WildFarm.Models.Animal
{
    public class Mouse : Mammal
    {
        private const double INCREASE_WEIGHT = 0.10;
        public Mouse(string name, double weight,  string livingRegion)
            : base(name, weight,  livingRegion)
        {

        }
        public override double WeightMultiplier => INCREASE_WEIGHT;

        public override ICollection<Type> PrefferedFoods => new List<Type>
                                       { typeof(Vegetable), typeof(Fruit)};

        public override string ProduceSound()
        {
            return $"Squeak";
        }
        public override string ToString()
        {
            return base.ToString() + $" {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
