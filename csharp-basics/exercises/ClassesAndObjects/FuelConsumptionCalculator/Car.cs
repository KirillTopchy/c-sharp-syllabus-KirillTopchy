using System;

namespace FuelConsumptionCalculator
{
    public class Car
    {
        private readonly double _startKilometers;
        private double _endKilometers;
        private double _litres;
        public Car(double startOdo, double endingOdo, double liters)
        {
            _startKilometers = startOdo;
            _endKilometers = endingOdo;
            _litres = liters;
        }

        public Car(double startOdo)
        {
            _startKilometers = startOdo;
        }

        public double CalculateConsumption()
        {
            return ConsumptionPer100Km();
        }

        private double ConsumptionPer100Km()
        {
            return Math.Round(_litres/(_endKilometers-_startKilometers) * 100, 2);
        }

        public bool GasHog()
        {
            return CalculateConsumption() > 15;
        }

        public bool EconomyCar()
        {
            return CalculateConsumption() < 5;
        }

        public void FillUp(int mileage, double liters)
        {
            _endKilometers = mileage;
            _litres = liters;
        }
    }
}
