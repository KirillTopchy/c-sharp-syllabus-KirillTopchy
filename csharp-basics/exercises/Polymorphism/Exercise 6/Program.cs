using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_6
{
    class Program
    {
        private static readonly List<Animal> AnimalList = new List<Animal>();
        static void Main(string[] args)
        {
            var type = "";
            var name = "";
            var weight = 0.0;
            var region = "";
            var breed = "";
            var foodQuantity = 0;

            while (true)
            {
                Console.WriteLine("Enter information about animal according to example below");
                Console.WriteLine("{AnimalType} {AnimalName} {AnimalWeight} {AnimalLivingRegion} [{CatBreed} = Only if its cat]");

                var animalInfo = AnimalInfoInput();

                if (animalInfo.Count == 1 && animalInfo[0].ToLower() == "end")
                {
                    DisplayAnimals();
                    break;
                }

                while (animalInfo.Count is > 1 and < 4)
                {
                    Console.WriteLine("Wrong input: information about animal should contain animal type, name, weight, living region");
                    animalInfo = AnimalInfoInput();
                }

                type = animalInfo[0];
                name = animalInfo[1];
                weight = Convert.ToDouble(animalInfo[2]);
                region = animalInfo[3];

                Console.WriteLine("Enter information about food you should give to the Animal");
                Console.WriteLine("{FoodType}, {FoodQuantity}");

                var animalFoodInfo = AnimalFoodInfoInput();

                foodQuantity = Convert.ToInt32(animalFoodInfo[1]);

                while (animalFoodInfo.Count != 2)
                {
                    Console.WriteLine("Wrong input: information about animal food should contain food type and food quantity");
                    Console.WriteLine("{FoodType}, {FoodQuantity}");
                    animalFoodInfo = AnimalFoodInfoInput();
                }

                if (animalInfo.Count == 5)
                {
                    breed = animalInfo[4];
                }

                switch (animalInfo[0].ToLower())
                {
                    case "cat":
                    {
                        Animal cat = new Cat(name, type, weight, foodQuantity, region, breed);
                        AnimalList.Add(cat);
                        break;
                    }
                    case "tiger":
                    {
                        Animal tiger = new Tiger(name, type, weight, foodQuantity, region);
                        AnimalList.Add(tiger);
                        break;
                    }
                    case "mouse":
                    {
                        Animal mouse = new Mouse(name, type, weight, foodQuantity, region);
                        AnimalList.Add(mouse);
                        break;
                    }
                    case "zebra":
                    {
                        Animal zebra = new Zebra(name, type, weight, foodQuantity, region);
                        AnimalList.Add(zebra);
                        break;
                    }
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }

                switch (animalFoodInfo[0].ToLower())
                {
                    case "vegetable":
                    {
                        var vegetable = new Vegetable(int.Parse(animalFoodInfo[1]));
                        FeedAnimal(AnimalList[^1], vegetable);
                        break;
                    }
                    case "meat":
                    {
                        var meat = new Meat(int.Parse(animalFoodInfo[1]));
                        FeedAnimal(AnimalList[^1], meat);
                        break;
                    }
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

        public static void DisplayAnimals()
        {
            foreach (var animal in AnimalList)
            {
                if (animal.AnimalType.ToLower() == "cat")
                {
                    Console.WriteLine($"{animal.AnimalType} [{animal.AnimalName}, {((Cat)animal).AnimalBread}, " +
                                      $"{animal.AnimalWeight}, {((Mammal)animal).AnimalLivingRegion}, {animal.FoodEaten}]");
                }
                else
                {
                    Console.WriteLine($"{animal.AnimalType} [{animal.AnimalName}, " +
                                      $"{animal.AnimalWeight}, {((Mammal)animal).AnimalLivingRegion}, {animal.FoodEaten}]");
                }
            }
        }

        public static void FeedAnimal(Animal animal, Food food)
        {
            animal.MakeSound();
            animal.Eat(food);
        }
    }
}
