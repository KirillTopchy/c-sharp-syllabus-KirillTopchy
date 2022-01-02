using System;

namespace Exercise_6
{
    public class Animal
    {
        private string _animalName;
        private string _animalType;
        private double _animalWeight;
        private int _foodEaten = 0;

        protected Animal(string animalName, string animalType, double animalWeight, int foodEaten)
        {
            _animalName = animalName;
            _animalType = animalType;
            _animalWeight = animalWeight;
            _foodEaten = foodEaten;
        }

        public  string AnimalName
        {
            get => _animalName;
        }

        public string AnimalType
        {
            get => _animalType;
        }

        public double AnimalWeight
        {
            get => _animalWeight;
        }

        public int FoodEaten
        {
            get => _foodEaten;
            set => _foodEaten = value;
        }

        public virtual string MakeSound()
        {
           return "SOUND";
        }

        public virtual bool Eat(Food food)
        {
            return false;
        }
    }
}
