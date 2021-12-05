using System;

namespace Exercise_3
{
    class FuelGauge
    {
        private static double CurrentAmountOfFuel { get; set; }

        public double GetAmountOfFuel()
        {
            return Math.Round(CurrentAmountOfFuel, 2);
        }

        public void FillFuel(double liters)
        {
            for (int i = 0; i < liters; i++)
            {
                CurrentAmountOfFuel++;
            }

            if (GetAmountOfFuel() > 70)
            {
                CurrentAmountOfFuel = 70;
            }
        }

        public static void FuelDecrease()
        {
            if(CurrentAmountOfFuel > 0)
            {
                CurrentAmountOfFuel = Math.Round(CurrentAmountOfFuel - 0.1, 1);
            }
        }

        public static void FuelLeftMessage()
        {
            Console.WriteLine("Fuel left: {0} liters", CurrentAmountOfFuel);
        }

        public static bool IsFuel()
        {
            return CurrentAmountOfFuel != 0;
        }
    }
}
