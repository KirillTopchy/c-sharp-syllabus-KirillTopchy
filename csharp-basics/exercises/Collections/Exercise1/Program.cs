using System;
using System.Collections.Generic;

namespace Exercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };

            var carBrands = new List<string>();
            carBrands.AddRange(array);
            foreach (var car in carBrands)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine();

            var carsHashSet = new HashSet<string>
            {
                "Audi",
                "BMW",
                "Honda",
                "Mercedes",
                "VolksWagen",
                "Mercedes",
                "Tesla"
            };

            foreach (var car in carsHashSet)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine();

            var carsDictionary = new Dictionary<string, string>
            {
                {"Audi", "Germany"},
                {"BMW", "Germany"},
                {"Honda", "Japan"},
                {"Mercedes", "Germany"},
                {"VolksWagen", "Germany"},
                {"Tesla", "USA"}
            };

            foreach (var car in carsDictionary)
            {
                Console.WriteLine(car.Key+ " " +car.Value);
            }
            Console.ReadKey();
        }
    }
}
