using System;

namespace Exercise_7
{
    class DogTest
    {
        static void Main(string[] args)
        {
            var max = new Dog("Max", "male","Lady", "Rocky");
            var rocky = new Dog("Rocky", "male", "Molly", "Sam");
            var sparky = new Dog("Sparky", "male");
            var buster = new Dog("Buster", "male", "Lady", "Sparky");
            var sam = new Dog("Sam", "male");
            var lady = new Dog("Lady", "female");
            var molly = new Dog("Molly", "female");
            var coco = new Dog("Coco", "female", "Molly", "Buster");

            Console.WriteLine(coco.FathersName());
            Console.WriteLine(sparky.FathersName());
            Console.WriteLine(coco.HasSameMotherAs(rocky));
            Console.WriteLine(coco.HasSameMotherAs(buster));
            Console.WriteLine(coco.HasSameMotherAs(sam));
        }
    }
}
