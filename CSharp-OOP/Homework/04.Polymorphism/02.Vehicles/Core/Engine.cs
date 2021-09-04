using System;
using System.Linq;
using _02.Vehicles.Core.Factoriess;
using _02.Vehicles.Models;

namespace _02.Vehicles.Core
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

            var n = int.Parse(Console.ReadLine());

            for (var i = 0; i < n; i++)
            {
                try
                {
                    ProcessCommand(car, truck);
                }
                catch (InvalidOperationException ioe)
                {

                    Console.WriteLine(ioe.Message);
                }
            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
        }

        private static void ProcessCommand(Vehicle car, Vehicle truck)
        {
            var cmndArgs = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var cmndType = cmndArgs[0];
            var vehicleType = cmndArgs[1];
            var arg = double.Parse(cmndArgs[2]);
            try
            {
                if (cmndType == "Drive")
                {
                    switch (vehicleType)
                    {
                        case "Car":
                            Console.WriteLine(car.Drive(arg));
                            break;
                        case "Truck":
                            Console.WriteLine(truck.Drive(arg));
                            break;
                    }
                }
                else
                {
                    switch (vehicleType)
                    {
                        case "Car":
                            car.Refuel(arg);
                            break;
                        case "Truck":
                            truck.Refuel(arg);
                            break;
                    }
                }
            }
            catch (Exception ioe )
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

            return vehicleFactory.ProduceVehicle(type, fuelQty, fuelConumption);
        }
    }
}
