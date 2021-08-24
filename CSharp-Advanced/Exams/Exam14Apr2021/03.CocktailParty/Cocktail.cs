using System;
using System.Collections.Generic;
using System.Linq;

namespace CocktailParty
{
    public class Cocktail
    {
        private List<Ingredient> ingredients;

        public Cocktail(string name, int capacity, int maxAlcoholLevel)
        {
            ingredients = new List<Ingredient>();
            Name = name;
            Capacity = capacity;
            MaxAlcoholLevel = maxAlcoholLevel;
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int MaxAlcoholLevel { get; set; }

        public int CurrentAlcoholLevel => ingredients.Sum(a => a.Alcohol);

        public void Add(Ingredient ingredient)
        {
            if (!ingredients.Contains(ingredient)
                && ingredients.Count <= Capacity
                && CurrentAlcoholLevel <= MaxAlcoholLevel)
            {
                ingredients.Add(ingredient);
            }
        }

        public bool Remove(string name)
        {
            var ingredient = ingredients.FirstOrDefault(i => i.Name == name);

            if (ingredient != null)
            {
                ingredients.Remove(ingredient);
                return true;
            }

            return false;
        }

        public Ingredient FindIngredient(string name)
        {
            return ingredients.FirstOrDefault(i => i.Name == name);
        }

        public Ingredient GetMostAlcoholicIngredient()
        {
            return ingredients
                .OrderByDescending(i => i.Alcohol)
                .FirstOrDefault();
        }

        public string Report()
        {
            var result = $"Cocktail: {Name} - Current Alcohol Level: {CurrentAlcoholLevel}";

            foreach (var ingredient in ingredients)
            {
                result += Environment.NewLine + $"{ingredient}";
            }

            return result;
        }
    }
}
