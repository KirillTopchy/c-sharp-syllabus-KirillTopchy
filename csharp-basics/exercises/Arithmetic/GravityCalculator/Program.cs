
using System;

namespace GravityCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var finalPosition = FinalPositionCalculator.GetFinalPosition(-9.81, 10, 0, 0);
            Console.WriteLine($"{finalPosition} m");
            Console.ReadKey();
        }
    }
}
