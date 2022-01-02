using System;

namespace Exercise_6
{
    public class Mouse : Mammal
    {
        public Mouse(string animalName, string animalType, double animalWeight,
            int foodEaten, string livingRegion) : base(animalName, animalType, animalWeight, foodEaten, livingRegion)
        {
        }

        public override string MakeSound()
        {
            return "MiMiMi";
        }

        public override bool Eat(Food food)
        {
            if (food is Vegetable)
            {
                FoodEaten = 0;
                FoodEaten += food.FoodQuantity;
                return true;
            }

            FoodEaten = 0;
            Console.WriteLine($"{AnimalType} is not eating that type of food!");
            return false;
        }
    }
}
