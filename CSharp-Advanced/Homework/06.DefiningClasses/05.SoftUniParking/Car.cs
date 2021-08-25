using System.Text;

namespace _05.SoftUniParking
{
    public class Car
    {
        public Car(string make, string model, int horsePower, string registrationNumber)
        {
            Make = make;
            Model = model;
            HorsePower = horsePower;
            RegistrationNumber = registrationNumber;
        }

        public string Make { get; set; }

        public string Model { get; set; }

        public int HorsePower { get; set; }

        public string RegistrationNumber { get; set; }

        public override string ToString()
        {
            return $"Make: {Make}\r\n" +
                   $"Model: {Model}\r\n" +
                   $"HorsePower: {HorsePower}\r\n" +
                   $"RegistrationNumber: {RegistrationNumber}";
        }
    }
}
