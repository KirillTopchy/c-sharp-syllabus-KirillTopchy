using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelConsumptionCalculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            int startKilometers;
            int liters;
            
            Console.WriteLine();

            var car = new Car(12000.0);
            var car1 = new Car(0.0);
            
            for (int i = 0; i < 2; i++)
            {
                Console.Write("Enter first reading for car: ");
                startKilometers = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter liters reading for car: ");
                liters = Convert.ToInt32(Console.ReadLine());
                car.FillUp(startKilometers, liters);

                Console.Write("Enter first reading for car1: ");
                startKilometers = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter liters reading for car1: ");
                liters = Convert.ToInt32(Console.ReadLine());
                car1.FillUp(startKilometers, liters);
            }

            Console.WriteLine("Car Kilometers per liter are " + car.CalculateConsumption() + " gasHog:" + car.GasHog() + " economyCar:" + car.EconomyCar());
            Console.WriteLine("Car1 Kilometers per liter are " + car1.CalculateConsumption() + " gasHog:" + car1.GasHog() + " economyCar:" + car1.EconomyCar());
            Console.ReadKey();
        }
    }
}
