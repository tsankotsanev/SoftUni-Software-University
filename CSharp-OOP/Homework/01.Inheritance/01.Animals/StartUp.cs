using System;
using System.Linq;

namespace _01.Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string type;

            while ((type = Console.ReadLine()) != "Beast!")
            {
                var animalInfo = Console
                  .ReadLine()
                  ?.Split(" ")
                  .ToArray();

                var name = animalInfo[0];
                var age = int.Parse(animalInfo[1]);
                var gender = animalInfo[2];

                Animal animal;
                switch (type)
                {
                    case "Dog":
                        try
                        {
                            animal = new Dog(name, age, gender);
                            Console.WriteLine(animal.ToString());
                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "Cat":
                        try
                        {
                            animal = new Cat(name, age, gender);
                            Console.WriteLine(animal.ToString());
                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "Frog":
                        try
                        {
                            animal = new Frog(name, age, gender);
                            Console.WriteLine(animal.ToString());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "Kittens":
                        try
                        {
                            animal = new Kitten(name, age);
                            Console.WriteLine(animal.ToString());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "Tomcat":
                        try
                        {
                            animal = new Tomcat(name, age);
                            Console.WriteLine(animal.ToString());
                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine(ex.Message);
                        }
                        break;
                }
            }
        }
    }
}
