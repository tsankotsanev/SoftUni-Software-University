using System;
using System.Collections.Generic;
using System.Linq;
using _04.WildFarm.Core.Contract;
using _04.WildFarm.Factories;
using _04.WildFarm.Models.Animal;
using _04.WildFarm.Models.Animal.Contracts;

namespace _04.WildFarm.Core
{
    public class Engine : IEngine
    {
        private List<IAnimal> animals;
        private FoodFactory foodFactory;

        public Engine()
        {

            animals = new List<IAnimal>();
            foodFactory = new FoodFactory();
        }
        public void Run()
        {
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                var animalArgs = command
                          .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                          .ToArray();
                var foodArgs = Console
                       .ReadLine()
                       .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                       .ToArray();

                var animal = ProduceAnimal(animalArgs);

                var food = foodFactory.ProduceFood(foodArgs[0], int.Parse(foodArgs[1]));

                animals.Add(animal);

                Console.WriteLine(animal.ProduceSound());

                try
                {
                    animal.Eat(food);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            foreach (var animal1 in animals)
            {
                Console.WriteLine(animal1);
            }
        }
        private static IAnimal ProduceAnimal(string[] animalArgs)
        {
            IAnimal animal = null;

            var animalType = animalArgs[0];
            var name = animalArgs[1];
            var weight = double.Parse(animalArgs[2]);

            switch (animalType)
            {
                case "Owl":
                {
                    var wingSize = double.Parse(animalArgs[3]);
                    animal = new Owl(name, weight, wingSize);
                    break;
                }
                case "Hen":
                {
                    var wingSize = double.Parse(animalArgs[3]);
                    animal = new Hen(name, weight, wingSize);
                    break;
                }
                default:
                {
                    var livingRegion = animalArgs[3];

                    switch (animalType)
                    {
                        case "Dog":
                            animal = new Dog(name, weight, livingRegion);
                            break;
                        case "Mouse":
                            animal = new Mouse(name, weight, livingRegion);
                            break;
                        default:
                        {
                            var breed = animalArgs[4];
                            animal = animalType switch
                            {
                                "Cat" => new Cat(name, weight, livingRegion, breed),
                                "Tiger" => new Tiger(name, weight, livingRegion, breed),
                                _ => animal
                            };

                            break;
                        }
                    }

                    break;
                }
            }

            return animal;
        }
    }
}
