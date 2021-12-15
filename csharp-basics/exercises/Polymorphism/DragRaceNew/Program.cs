using System;
using System.Collections.Generic;
using System.Linq;

namespace DragRace
{
    class Program
    {
        private static void Main(string[] args)
        {
            var carList = new List<ICar>
            {
                new Audi(),
                new Toyota(),
                new Lexus(),
                new Bmw(),
                new VolksWagen(),
                new Tesla()
            };

            for (int i = 1; i <= 10; i++)
            {
                foreach (var car in carList)
                {
                    if (i == 1)
                    {
                        car.StartEngine();
                        continue;
                    }

                    if (i == 3)
                    {
                        if (car is IBoostable boostable)
                        {
                            boostable.UseNitrousOxideEngine();
                            continue;
                        }
                    }
                    car.SpeedUp();
                }
            }

            var maxSpeed = 0;
            var fastest = "";

            foreach (var car in carList.Where(car => int.Parse(car.ShowCurrentSpeed()) > maxSpeed))
            {
                maxSpeed = int.Parse(car.ShowCurrentSpeed());
                fastest = car.GetType().Name;
            }
            Console.WriteLine($"Drag race won {fastest}, top speed is: {maxSpeed}");
        }
    }
}