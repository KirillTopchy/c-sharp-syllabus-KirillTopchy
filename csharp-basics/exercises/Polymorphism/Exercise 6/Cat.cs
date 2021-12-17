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
    }
}
