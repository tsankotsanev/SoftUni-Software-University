using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var vehicles = new List<Vehicle>();

            while (input != "End")
            {
                var tokens = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                var typeOfVehicle = tokens[0];
                var model = tokens[1];
                var color = tokens[2];
                var horsepower = int.Parse(tokens[3]);

                switch (typeOfVehicle)
                {
                    case "car":
                        vehicles.Add(new Vehicle("Car", model, color, horsepower));
                        break;
                    case "truck":
                        vehicles.Add(new Vehicle("Truck", model, color, horsepower));
                        break;
                }

                input = Console.ReadLine();
            }

            var modelInput = Console.ReadLine();

            while (modelInput != "Close the Catalogue")
            {
                foreach (var vehicle in vehicles.Where(x => x.Model == modelInput))
                {
                    Console.WriteLine($"Type: {vehicle.Type}");
                    Console.WriteLine($"Model: {vehicle.Model}");
                    Console.WriteLine($"Color: {vehicle.Color}");
                    Console.WriteLine($"Horsepower: {vehicle.Horsepower}");
                }

                modelInput = Console.ReadLine();
            }

            var carHorsepower = 0.0;
            var carCounter = 0;

            var totalTruckHorsepower = 0.0;
            var truckCounter = 0;

            foreach (var vehicle in vehicles)
            {
                switch (vehicle.Type)
                {
                    case "Car":
                        carHorsepower += vehicle.Horsepower;
                        carCounter++;
                        break;
                    case "Truck":
                        totalTruckHorsepower += vehicle.Horsepower;
                        truckCounter++;
                        break;
                }
            }

            Console.WriteLine(carCounter > 0
                ? $"Cars have average horsepower of: {carHorsepower / carCounter:F2}."
                : $"Cars have average horsepower of: {0:F2}.");

            Console.WriteLine(truckCounter > 0
                ? $"Trucks have average horsepower of: {totalTruckHorsepower / truckCounter:F2}."
                : $"Trucks have average horsepower of: {0:F2}.");
        }
    }

    public class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsepower)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }

        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int Horsepower { get; set; }
    }

}