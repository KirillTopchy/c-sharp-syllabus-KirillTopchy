using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        /**
           * Origination:
           * Audi -> Germany
           * BMW -> Germany
           * Honda -> Japan
           * Mercedes -> Germany
           * VolksWagen -> Germany
           * Tesla -> USA
           */

        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };

            //todo - replace array with an List and print out the results

            var carBrands = new List<string>();
            carBrands.AddRange(array);
            foreach (var car in carBrands)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine();

            //todo - replace array with a HashSet and print out the results

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

            //todo - replace array with a Dictionary (use brand as key and origination as value) and print out the results

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
