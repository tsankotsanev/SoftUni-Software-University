namespace _01.Animals
{
    public class Tomcat : Animal
    {
        private const string TomcatGender = "Male";
        public Tomcat(string name, int age) 
            : base(name, age, TomcatGender)
        {

        }
        public override string ProduceSound()
        {
            var sound = "MEOW";

            return sound;
        }
    }
}
