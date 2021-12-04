using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Odometer
    {
        private int _odometerTotalKilometers;
        private int _singleDriveDistance;
        public int CurrentKilometer { get; set; }

        public int GetCurrentKilometers()
        {
            CurrentKilometer = CurrentKilometer > 999999 ? 0 : CurrentKilometer;
            return CurrentKilometer;
        }

        public int GetTotalKilometers()
        {
            return _odometerTotalKilometers;
        }

        public int GetSingleDriveDistance()
        {
            return _singleDriveDistance;
        }

        public int Drive(int distance)
        {
            _odometerTotalKilometers += distance;
            _singleDriveDistance = distance;
            if (CurrentKilometer <= 999999)
            {
                for (int i = 1; i <= distance; i++)
                {
                    if (i % 10 == 0)
                    {
                        DecreaseFuelWhenDriving();
                    }
                    CurrentKilometer++;
                }
            }
            else
            {
                CurrentKilometer = 0;
                for (int i = GetCurrentKilometers(); i < distance; i++)
                {
                    CurrentKilometer++;
                }
            }
            return CurrentKilometer;
        }

        public void DecreaseFuelWhenDriving()
        {
            FuelGauge.FuelDecrease();
        }
    }
}
