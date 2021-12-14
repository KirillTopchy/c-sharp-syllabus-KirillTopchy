using System;

namespace Exercise_3
{
    class FuelGauge
    {
        private static double _currentAmountOfFuel;

        public double GetAmountOfFuel()
        {
            return Math.Round(_currentAmountOfFuel, 2);
        }

        public void FillFuel(double liters)
        {
            for (int i = 0; i < liters; i++)
            {
                _currentAmountOfFuel++;
            }

            if (GetAmountOfFuel() > 70)
            {
                _currentAmountOfFuel = 70;
            }
        }

        public static void FuelDecrease()
        {
            if(_currentAmountOfFuel > 0)
            {
                _currentAmountOfFuel = Math.Round(_currentAmountOfFuel - 0.1, 1);
            }
        }

        public static void FuelLeftMessage()
        {
            Console.WriteLine("Fuel left: {0} liters", _currentAmountOfFuel);
        }

        public static bool IsFuel()
        {
            return _currentAmountOfFuel != 0;
        }
    }
}
