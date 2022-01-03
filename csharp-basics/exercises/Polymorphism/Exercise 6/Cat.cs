using System;

namespace Exercise_6
{
    public class Cat : Felime
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

        public override string MakeSound()
        {
            return "MurMurMur";
        }

        public override bool Eat(Food food)
        {
            if (food is Meat || food is Vegetable)
            {
                FoodEaten = 0;
                FoodEaten += food.FoodQuantity;
                return true;
            }

            return false;
        }
    }
}
