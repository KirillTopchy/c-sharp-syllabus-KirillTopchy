using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var odom1 = new Odometer();
            var fuel1 = new FuelGauge();
            fuel1.FillFuel(10);
            Console.WriteLine("Fill the car with {0} liters of fuel",fuel1.GetAmountOfFuel());

            while (fuel1.GetAmountOfFuel() != 0)
            {

            }

            odom1.Drive(30);
            Console.WriteLine("Drive {0}km",odom1.GetSingleDriveDistance());
            Console.WriteLine("Liters of fuel left: {0}", fuel1.GetAmountOfFuel());
            Console.WriteLine("Total odometer kilometer reading: {0}km", odom1.GetTotalKilometers());

            odom1.Drive(70);
            Console.WriteLine("Drive {0}km", odom1.GetSingleDriveDistance());
            Console.WriteLine("Liters of fuel left: {0}", fuel1.GetAmountOfFuel());
            Console.WriteLine("Total odometer kilometer reading: {0}km", odom1.GetTotalKilometers());
        }
    }
}
