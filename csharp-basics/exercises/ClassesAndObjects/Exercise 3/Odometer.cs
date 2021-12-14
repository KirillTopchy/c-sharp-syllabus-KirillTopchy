using System;

namespace Exercise_3
{
    class Odometer
    {
        public int CurrentKilometer { get; set; }

        public int GetCurrentKilometers()
        {
            CurrentKilometer = CurrentKilometer > 999999 ? 0 : CurrentKilometer;
            return CurrentKilometer;
        }

        public int Drive()
        {
            while (FuelGauge.IsFuel())
            {
                if (CurrentKilometer <= 999999)
                {
                    CheckMileageAndFuelLeft();
                }
                else
                {
                    CurrentKilometer = 0;
                    CheckMileageAndFuelLeft();
                }
            }
            return CurrentKilometer;
        }

        public void CheckMileageAndFuelLeft()
        {
            DecreaseFuelWhenDriving();
            CurrentKilometer++;
            DriveMessage();
            FuelGauge.FuelLeftMessage();
        }

        public void DecreaseFuelWhenDriving()
        {
            FuelGauge.FuelDecrease();
        }

        public void DriveMessage()
        {
            Console.WriteLine("ODOMETER: {0} km", GetCurrentKilometers());
        }
    }
}
