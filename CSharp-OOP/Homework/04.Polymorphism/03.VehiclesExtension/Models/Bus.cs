using System;
using _03.VehiclesExtension.Common;

namespace _03.VehiclesExtension.Models
{
    public class Bus : Vehicle
    {
        private const double AIR_CONDITION = 1.4;
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {

        }
        protected override bool Hole => false;
        protected override double AirCondition => AIR_CONDITION;
        public void EmptyBus(double distance)
        {
            var fuelWithDistance = distance * FuelConsumption;
            if (fuelWithDistance <= FuelQuantity)
            {
                FuelQuantity -= distance;
                Console.WriteLine(String.Format(GlobalConstants.TraveledDistance, GetType().Name, distance));
            }
            else
            {

                Console.WriteLine(String.Format(GlobalConstants.NeededRefueling, GetType().Name));
            }
        }
    }
}
