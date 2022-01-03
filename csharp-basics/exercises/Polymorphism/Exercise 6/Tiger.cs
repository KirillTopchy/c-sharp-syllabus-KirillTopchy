using System;

namespace Exercise_6
{
    public class Tiger : Felime
    {
        private string _livingRegion;
        public Tiger(string animalName, string animalType, double animalWeight,
            int foodEaten, string livingRegion) : base(animalName, animalType, animalWeight, foodEaten, livingRegion)
        {
            _livingRegion = livingRegion;
        }

        public override string MakeSound()
        {
            return "ROAR";
        }

        public override bool Eat(Food food)
        {
            if (food is Meat)
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
