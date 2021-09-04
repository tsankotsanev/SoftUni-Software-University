using System;
using System.Collections.Generic;
using _04.WildFarm.Models.Animal.Contracts;
using _04.WildFarm.Models.Food.Contract;

namespace _04.WildFarm.Models.Animal
{
    public abstract class Animal : IAnimal
    {
        private const string DEF_EXC_MSG = "{0} does not eat {1}!";
        protected Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
            FoodEaten = 0;
        }

        public string Name { get; private set; }

        public double Weight { get; private set; }

        public int FoodEaten { get; private set; }
        public abstract double WeightMultiplier { get; }
        public abstract ICollection<Type> PrefferedFoods { get; }

        public abstract string ProduceSound();

        public void Eat(IFood food)
        {
            if (!PrefferedFoods.Contains(food.GetType()))
            {
                throw new InvalidOperationException
                    (String.Format(DEF_EXC_MSG, GetType().Name, food.GetType().Name));
            }
            Weight += WeightMultiplier * food.Quantity;
            FoodEaten += food.Quantity;
        }
        public override string ToString()
        {
            return $"{GetType().Name} [{ Name},";
        }
    }
}
