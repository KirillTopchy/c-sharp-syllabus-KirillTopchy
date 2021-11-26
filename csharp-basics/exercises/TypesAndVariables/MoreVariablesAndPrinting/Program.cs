using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Zed A. Shaw";
            var age = 35;
            var heightInInches = 74;
            var weightInPounds = 180;
            var eyesColor = "Blue";
            var teethColor = "White";
            var hairColor = "Brown";

            var heightInCentimeters = Math.Round((heightInInches * 2.54), 2);
            var weightInKilos = Math.Round((weightInPounds * 0.453592), 2);

            Console.WriteLine("Let's talk about " + name + ".");
            Console.WriteLine("He's " + heightInInches + " inches tall.");
            Console.WriteLine("He's " + weightInPounds + " pounds heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " + eyesColor + " eyes and " + hairColor + " hair.");
            Console.WriteLine("His teeth are usually " + teethColor + " depending on the coffee.");

            Console.WriteLine("If I add " + age + ", " + heightInCentimeters + ", and " + weightInKilos
                               + " I get " + (age + heightInCentimeters + weightInKilos) + ".");

            Console.ReadKey();
        }
    }
}