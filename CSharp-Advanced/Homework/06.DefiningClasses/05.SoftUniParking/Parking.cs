using System.Collections.Generic;
using System.Linq;

namespace _05.SoftUniParking
{
    public class Parking
    {
        public Parking(int capacity)
        {
            Capacity = capacity;
            AllCars = new List<Car>();
        }

        public List<Car> AllCars { get; set; }

        public int Capacity { get; set; }

        public int Count => AllCars.Count;


        public string AddCar(Car car)
        {
            if (AllCars.Any(x => x.RegistrationNumber == car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }
            if (Count >= Capacity)
            {
                return "Parking is full!";
            }

            AllCars.Add(car);
            return $"Successfully added new car {car.Make } {car.RegistrationNumber}";
        }
        public string RemoveCar(string registrationNumber)
        {
            if (AllCars.All(x => x.RegistrationNumber != registrationNumber))
            {
                return "Car with that registration number, doesn't exist!";
            }
            else
            {
                AllCars.Remove(AllCars.FirstOrDefault(x => x.RegistrationNumber == registrationNumber));
                return $"Successfully removed {registrationNumber}";
            }

        }
        public Car GetCar(string registrationNumber)
        {

            return AllCars.FirstOrDefault(x => x.RegistrationNumber == registrationNumber);
        }
        public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
        {
            foreach (var number in RegistrationNumbers)
            {
                if (AllCars.Any(x => x.RegistrationNumber == number.ToString()))
                {
                    AllCars.RemoveAll(x => x.RegistrationNumber == number);
                }
            }
        }
    }
}
