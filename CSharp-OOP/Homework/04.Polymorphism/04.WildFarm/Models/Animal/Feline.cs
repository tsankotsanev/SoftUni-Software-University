namespace _04.WildFarm.Models.Animal
{
    public abstract class Feline : Mammal
    {
        public Feline(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion)
        {
            Breed = breed;
        }
        public string Breed { get; private set; }
        public override string ToString()
        {
            return base.ToString() + 
                $" {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
