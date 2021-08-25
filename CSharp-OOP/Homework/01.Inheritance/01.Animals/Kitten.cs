namespace _01.Animals
{
    public class Kitten : Animal
    {
        private const string KittenCatGender = "Female";
        public Kitten(string name, int age)
            : base(name, age, KittenCatGender)
        {

        }
        public override string ProduceSound()
        {
            var sound = "Meow";

            return sound;
        }
    }
}
