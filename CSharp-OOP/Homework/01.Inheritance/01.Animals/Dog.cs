namespace _01.Animals
{
    public class Dog : Animal
    {
        public Dog(string name, int age, string gender)
            : base(name, age, gender)
        {

        }
        public override string ProduceSound()
        {
            var sound = "Woof!";

            return sound;
        }
    }
}
