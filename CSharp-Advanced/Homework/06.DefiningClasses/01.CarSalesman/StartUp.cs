using System;
using System.Collections.Generic;
using System.Linq;
using CarSalesman;

namespace _01.CarSalesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>();
            var engines = new List<Engine>();

            var count = int.Parse(Console.ReadLine());
            for (var i = 0; i < count; i++)
            {
                var dataEngine = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var engineModel = dataEngine[0];
                var power = int.Parse(dataEngine[1]);

                var displacement = 0;
                var efficiency = "n/a";

                if (dataEngine.Length == 4)
                {
                    displacement = int.Parse(dataEngine[2]);
                    efficiency = dataEngine[3];
                }
                else if (dataEngine.Length == 3)
                {
                    if (char.IsLetter(char.Parse(dataEngine[2][0].ToString())))
                    {
                        efficiency = dataEngine[2];
                    }
                    else
                    {
                        displacement = int.Parse(dataEngine[2]);
                    }
                }

                var engine = new Engine(engineModel, power, displacement, efficiency);
                engines.Add(engine);
            }

            count = int.Parse(Console.ReadLine());

            for (var i = 0; i < count; i++)
            {
                var dataCar = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var CarModel = dataCar[0];
                var CarEngine = dataCar[1];
                var weight = 0;
                var color = "n/a";

                if (dataCar.Length == 4)
                {
                    weight = int.Parse(dataCar[2]);
                    color = dataCar[3];
                }
                else if (dataCar.Length == 3)
                {
                    if (char.IsLetter(char.Parse(dataCar[2][0].ToString())))
                    {
                        color = dataCar[2];
                    }
                    else
                    {
                        weight = int.Parse(dataCar[2]);
                    }
                }
                var engine = engines.Where(x => x.EngineModel == CarEngine).FirstOrDefault();
                var car = new Car(CarModel, engine, weight, color);

                cars.Add(car);

            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}
