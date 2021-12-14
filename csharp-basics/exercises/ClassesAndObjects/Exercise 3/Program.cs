using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var odom1 = new Odometer();
            var fuel1 = new FuelGauge();
            Console.Write("Fill fuel: ");
            fuel1.FillFuel(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Fill the car with {0} liters of fuel",fuel1.GetAmountOfFuel());
            while (fuel1.GetAmountOfFuel() != 0)
            {
                odom1.Drive();
                Console.Write("Refill fuel: ");
                fuel1.FillFuel(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("Fuel amount: {0}", fuel1.GetAmountOfFuel());
            }
        }
    }
}
