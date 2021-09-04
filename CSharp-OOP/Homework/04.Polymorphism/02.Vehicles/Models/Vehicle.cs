using System;
using _02.Vehicles.Contracts;

namespace _02.Vehicles.Models
{
    public abstract class Vehicle : IRefuelable, IDriveable
    {
        private const double tank = 0.95;
        protected Vehicle(double fuelQuantity, double fuelConsumption)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public abstract bool Hole { get; }
        public string Drive(double distance)
        {
            var fuelNeeded = FuelConsumption * distance;
            if (FuelQuantity < fuelNeeded)
            {
                throw new ArgumentException
                    (string.Format(Common.Exeptions.ExeptionOverloadFuel, GetType().Name));
            }
            FuelQuantity -= fuelNeeded;
            return $"{GetType().Name} travelled { distance} km";
        }
        public virtual void Refuel(double liters)
        {
            if (Hole)
            {
                FuelQuantity += liters * tank;

            }
            else
            {
                FuelQuantity += liters;
            }
        }
        public override string ToString()
        {
            return $"{GetType().Name}: {FuelQuantity:F2}";
        }
    }
}
