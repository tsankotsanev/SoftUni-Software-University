using System;
using _02.Vehicles.Models;

namespace _02.Vehicles.Core.Factoriess
{
    public class VehicleFactory
    {
        public Vehicle ProduceVehicle(string type, double fuelQty,
          double fuelConsumption)
        {
            Vehicle vehicle = type switch
            {
                "Car" => new Car(fuelQty, fuelConsumption),
                "Truck" => new Truck(fuelQty, fuelConsumption),
                _ => null
            };
            if (vehicle == null)
            {
                throw new ArgumentException(Common.Exeptions.InvalidTypeExeptionMessage);
            }
            return vehicle;
        }
    }
}
