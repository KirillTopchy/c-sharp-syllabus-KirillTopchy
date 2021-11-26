
using System;

namespace GravityCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            const double gravity = -9.81; // Earth's gravity in m/s^2
            double initialVelocity = 0.0;
            double fallingTime = 10.0;
            double initialPosition = 0.0;
            double finalPosition = (gravity*fallingTime*fallingTime) / 2 + initialVelocity + initialPosition;
            Console.WriteLine("The object's position after " + fallingTime + " seconds is " + finalPosition + " m.");
            Console.ReadKey();
        }
    }
}
