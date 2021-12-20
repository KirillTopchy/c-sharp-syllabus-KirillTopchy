namespace Exercise_6
{
    abstract class Mammal : Animal
    {
        private string _livingRegion;

        protected Mammal(string animalName, string animalType, double animalWeight, 
            int foodEaten, string livingRegion) : base(animalName, animalType, animalWeight, foodEaten)
        {
            _livingRegion = livingRegion;
        }

        public string AnimalLivingRegion
        {
            get => _livingRegion;
        }
    }
}
