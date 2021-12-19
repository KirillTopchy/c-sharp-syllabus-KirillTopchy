using System;

namespace Exercise_6
{
    class Cat : Felime
    {
        private string _breed;
        public Cat(string animalName, string animalType, double animalWeight,
            int foodEaten, string livingRegion, string breed) : base(animalName, animalType, animalWeight, foodEaten, livingRegion)
        {
            _breed = breed;
        }

        public string AnimalBread
        {
            get => _breed;
        }

        public override void MakeSound()
        {
            Console.WriteLine("MurMurMur");
        }

        public override bool Eat(Food food)
        {
            if (food is Meat || food is Vegetable)
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
