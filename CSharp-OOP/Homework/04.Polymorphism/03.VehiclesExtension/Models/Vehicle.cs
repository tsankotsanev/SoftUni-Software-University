using System;
using _03.VehiclesExtension.Common;
using _03.VehiclesExtension.Contracts;

namespace _03.VehiclesExtension.Models
{
    public abstract class Vehicle : IDriveable, IRefulable
    {
        private const double tank = 0.95;
        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            TankCapacity = tankCapacity;
        }

        protected double FuelQuantity { get; set; }
        protected double FuelConsumption { get; set; }
        protected double TankCapacity { get; set; }
        protected abstract double AirCondition { get; }
        protected abstract bool Hole { get; }
        public virtual void  Drive(double distance)
        {
            var distanceWithFuel = distance * (FuelConsumption + AirCondition);
            if (distanceWithFuel <= FuelQuantity)
            {
                FuelQuantity -= distanceWithFuel;
                Console.WriteLine(String.Format(GlobalConstants.TraveledDistance, GetType().Name, distance));
            }
            else
            {
                Console.WriteLine(String.Format(GlobalConstants.NeededRefueling, GetType().Name));
            }
        }

        public void Refuel(double liters)
        {
            var IsQuantityMoreThanCapacity =
                (liters + FuelQuantity) > TankCapacity;
            if (liters <= 0)
            {
                throw new ArgumentException(
                    String.Format(GlobalConstants.IsLessThanOrToZero));
            }
            if (IsQuantityMoreThanCapacity)
            {
                throw new InvalidOperationException(
                    String.Format(GlobalConstants.IsMoreThanCapacity, liters));
            }
            if (Hole)
            {
                FuelQuantity += liters * tank;
            }
            else
            {
                FuelQuantity += liters;
            }
        }
        public override string ToString() => $"{GetType().Name}: {FuelQuantity:f2}";
    }
}
