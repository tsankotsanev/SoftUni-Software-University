using System;

namespace _06.SpeedRacing
{
    public class Car
    {
        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKilometer { get; set; }

        public double TraveledDistance { get; set; }

        public Car(string model, double fuelAmount,
            double fuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            TraveledDistance = 0;
        }

        public void Move(double distance)
        {
            if (distance * FuelConsumptionPerKilometer <= FuelAmount)
            {
                FuelAmount -= distance * FuelConsumptionPerKilometer;
                TraveledDistance += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
        public override string ToString()
        {
            return $"{Model} {FuelAmount:f2}\r\n" +
                   $" {TraveledDistance}";
        }

    }
}
