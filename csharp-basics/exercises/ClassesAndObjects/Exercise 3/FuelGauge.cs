using System;

namespace Exercise_3
{
    class FuelGauge
    {
        private static int CurrentAmountOfFuel { get; set; }

        public int GetAmountOfFuel()
        {
            return CurrentAmountOfFuel;
        }

        public void FillFuel(int liters)
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
                CurrentAmountOfFuel--;
            }
        }
    }
}
