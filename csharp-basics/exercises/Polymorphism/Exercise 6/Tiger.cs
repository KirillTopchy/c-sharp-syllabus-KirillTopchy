using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    class Tiger : Felime
    {
        private string _livingRegion;
        public Tiger(string animalName, string animalType, double animalWeight,
            int foodEaten, string livingRegion) : base(animalName, animalType, animalWeight, foodEaten, livingRegion)
        {
            _livingRegion = livingRegion;
        }
    }
}
