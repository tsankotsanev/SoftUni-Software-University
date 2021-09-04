using System;
using _03.VehiclesExtension.Common;
using _03.VehiclesExtension.Models;

namespace _03.VehiclesExtension.Factories
{
    public class VehicleFactory
    {
        public Vehicle ProduceVehicle(string type, double fuelQty,
          double fuelConsumption, double tankCapacity)
        {
            Vehicle vehicle = type switch
            {
                "Car" => new Car(fuelQty, fuelConsumption, tankCapacity),
                "Truck" => new Truck(fuelQty, fuelConsumption, tankCapacity),
                "Bus" => new Bus(fuelQty, fuelConsumption, tankCapacity),
                _ => null
            };
            if (vehicle == null)
            {
                throw new ArgumentException(GlobalConstants.InvalidTypeExeptionMessage);
            }
            return vehicle;
        }

    }
}
