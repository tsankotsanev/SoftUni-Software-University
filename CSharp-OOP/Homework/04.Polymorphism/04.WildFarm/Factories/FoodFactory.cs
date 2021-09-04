using _04.WildFarm.Models.Food;
using _04.WildFarm.Models.Food.Contract;

namespace _04.WildFarm.Factories
{
    public class FoodFactory
    {
        public IFood ProduceFood(string type, int quantity)
        {
            IFood food = type switch
            {
                "Vegetable" => new Vegetable(quantity),
                "Fruit" => new Fruit(quantity),
                "Meat" => new Meat(quantity),
                "Seeds" => new Seeds(quantity),
                _ => null
            };

            return food;
        }
    }
}
