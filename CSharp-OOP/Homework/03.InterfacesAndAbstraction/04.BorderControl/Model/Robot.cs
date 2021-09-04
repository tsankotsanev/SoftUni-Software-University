using _004.BorderControl.Contract;

namespace _004.BorderControl.Model
{
    public class Robot : IIDValidatorable
    {
        public Robot(string model, string iD)
        {
            Model = model;
            ID = iD;
        }

        public string Model { get; }

        public string ID { get; set; }

        //public string CheckLastDigit(string ID)
        //{
        //    return ID;
        //}
        public override string ToString() => $"{ID}";
    }
}
