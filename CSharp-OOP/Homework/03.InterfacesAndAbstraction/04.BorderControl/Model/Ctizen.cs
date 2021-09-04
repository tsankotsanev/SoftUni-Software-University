using _004.BorderControl.Contract;

namespace _004.BorderControl.Model
{
    public class Ctizen : IIDValidatorable
    {
        public Ctizen(string name, int age, string iD)
        {
            Name = name;
            Age = age;
            ID = iD;
        }

        public string Name { get; }

        public int Age { get; }

        public string ID { get; set; }

        //public string CheckLastDigit(string ID)
        //{

        //    return ID;
        //}
        public override string ToString() => $"{ID}";
    }
}
