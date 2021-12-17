using System;

namespace Exercise_6
{
    abstract class Animal
    {
        private string _animalName;
        private string _animalType;
        private double _animalWeight;
        private int _foodEaten;

        protected Animal(string animalName, string animalType, double animalWeight, int foodEaten)
        {
            _animalName = animalName;
            _animalType = animalType;
            _animalWeight = animalWeight;
            _foodEaten = foodEaten;
        }

        public void MakeSound()
        {
            Console.WriteLine("SOUND");
        }

        public void Eat(Food food)
        {

        }
    }
}
