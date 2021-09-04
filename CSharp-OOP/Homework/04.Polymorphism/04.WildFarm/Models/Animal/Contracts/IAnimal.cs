using _04.WildFarm.Models.Food.Contract;

namespace _04.WildFarm.Models.Animal.Contracts
{
    public interface IAnimal
    {
        public string Name { get; }
        public double Weight { get; }
        string ProduceSound();
        void Eat(IFood food);
    }
}
