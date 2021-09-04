using System;
using System.Linq;
using _03.VehiclesExtension.Factories;
using _03.VehiclesExtension.Models;

namespace _03.VehiclesExtension.Core
{
    public class Engine : IEngine
    {
        private VehicleFactory vehicleFactory;
        public Engine()
        {
            vehicleFactory = new VehicleFactory();
        }
        public void Run()
        {
            var car = ProduceVehicle();
            var truck = ProduceVehicle();
            var bus = ProduceVehicle();

            var n = int.Parse(Console.ReadLine());

            for (var i = 0; i < n; i++)
            {
                try
                {
                    ProcessCommand(car, truck, bus);
                }
                catch (InvalidOperationException ioe)
                {

                    Console.WriteLine(ioe.Message);
                }
            }
            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());
            Console.WriteLine(bus.ToString());
        }
        private static void ProcessCommand(Vehicle car, Vehicle truck, Vehicle bus)
        {
            var cmndArgs = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var cmndType = cmndArgs[0];
            var vehicleType = cmndArgs[1];
            var arg = double.Parse(cmndArgs[2]);
            try
            {
                switch (cmndType)
                {
                    case "Drive" when vehicleType == "Car":
                        car.Drive(arg);
                        break;
                    case "Drive" when vehicleType == "Truck":
                        truck.Drive(arg);
                        break;
                    case "Drive":
                    {
                        if (vehicleType == "Bus")
                        {
                            bus.Drive(arg);
                        }

                        break;
                    }
                    case "DriveEmpty":
                    {
                        if (vehicleType == "Bus")
                        {
                            ((Bus)bus).EmptyBus(arg);
                        }

                        break;
                    }
                    default:
                    {
                        switch (vehicleType)
                        {
                            case "Car":
                                car.Refuel(arg);
                                break;
                            case "Truck":
                                truck.Refuel(arg);
                                break;
                            case "Bus":
                                bus.Refuel(arg);
                                break;
                        }

                        break;
                    }
                }
            }
            catch (Exception ioe)
            {

                Console.WriteLine(ioe.Message);
            }

        }
        private Vehicle ProduceVehicle()
        {
            var vehicleArgs = Console.ReadLine()
                                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                   .ToArray();
            var type = vehicleArgs[0];
            var fuelQty = double.Parse(vehicleArgs[1]);
            var fuelConumption = double.Parse(vehicleArgs[2]);
            var tankCapacity = double.Parse(vehicleArgs[3]);

            return vehicleFactory.ProduceVehicle(type, fuelQty, fuelConumption, tankCapacity);
        }
    }
}
