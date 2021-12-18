using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Exercise_6
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter information about animal according to example below");
            Console.WriteLine("{AnimalType} {AnimalName} {AnimalWeight} {AnimalLivingRegion} [{CatBreed} = Only if its cat]");
            Console.WriteLine("Enter information about food you should give to the Animal");

            var animalList = new List<Animal>();

            var type = "";
            var name = "";
            double weight = 0.0;
            var region = "";
            var breed = "";
            var food = "";
            var foodQuantity = 0;

            while (true)
            {
                var animalInfo = AnimalInfoInput();

                if (animalInfo.Count == 1 && animalInfo[0].ToLower() == "end")
                {
                    break;
                }

                var animalFoodInfo = AnimalFoodInfoInput();

                while (animalInfo.Count < 4)
                {
                    Console.WriteLine("Wrong input: information about animal should contain animal type, name, weight, living region");
                    animalInfo = AnimalInfoInput();
                    
                }

                while (animalFoodInfo.Count != 2)
                {
                    Console.WriteLine("Wrong input: information about animal food should contain food type and food quantity");
                    animalFoodInfo = AnimalFoodInfoInput();
                }

                type = animalInfo[0];
                name = animalInfo[1];
                weight = Convert.ToDouble(animalInfo[2]);
                region = animalInfo[3];
                food = animalFoodInfo[0];
                foodQuantity = Convert.ToInt32(animalFoodInfo[1]);

                if (animalInfo.Count == 5)
                {
                    breed = animalInfo[4];
                }

                switch (animalInfo[0].ToLower())
                {
                    case "cat":
                    {
                        Animal cat = new Cat(name, type, weight, foodQuantity, region, breed);
                        animalList.Add(cat);
                        break;
                    }
                    case "tiger":
                    {
                        Animal tiger = new Tiger(name, type, weight, foodQuantity, region);
                        animalList.Add(tiger);
                        break;
                    }
                    case "mouse":
                    {
                        Animal mouse = new Mouse(name, type, weight, foodQuantity, region);
                        animalList.Add(mouse);
                        break;
                    }
                    case "zebra":
                    {
                        Animal zebra = new Zebra(name, type, weight, foodQuantity, region);
                        animalList.Add(zebra);
                        break;
                    }
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }

                Console.WriteLine(animalList.Count);
                foreach (var animal in animalList)
                {
                    Console.WriteLine(animal);
                }
            }
        }

        public static List<string> AnimalInfoInput()
        {
            var animalInfo = Console.ReadLine()?.Split(' ').ToList();
            return animalInfo;
        }

        public static List<string> AnimalFoodInfoInput()
        {
            var animalFoodInfo = Console.ReadLine()?.Split(' ').ToList();
            return animalFoodInfo;
        }
    }
}
