using System;
using System.Collections.Generic;
using System.Linq;

namespace FlightPlanner
{
    public static class PlanYourFlight
    {
        public static string ChoseCity()
        {
            Console.WriteLine();
            Console.WriteLine("Select a NUMBER of city from which you would like to start and press ENTER");
            Console.Write("> ");
            return Console.ReadLine();
        }

        public static List<string> GetListOfCities(string[] readText)
        {
            var cities = new HashSet<string>();
            foreach (var s in readText)
            {
                var route = s.Replace(" ", "").Replace("-", "").Split('>');
                cities.Add(route[0]);
                cities.Add(route[1]);
            }
            return cities.ToList();
        }

        public static void DisplayPossibleDestinations(List<string> listOfCities) 
        {
            Console.WriteLine();
            Console.WriteLine("Possible destinations:");
            for (int i = 0; i < listOfCities.Count; i++)
            {
                Console.WriteLine("{0}: {1}", i + 1, listOfCities[i]);
            }
        }

        public static List<string> GetPossibleDestinations(string departureCity, string[] readText) //3
        {
            var possibleDestinations = new List<string>();
            foreach (var s in readText)
            {
                var route = s.Replace(" ", "").Replace("-", "").Split('>');
                if (route[0] == departureCity)
                {
                    possibleDestinations.Add(route[1]);
                }
            }
            return possibleDestinations;
        }

        public static void DisplayWrongInput()
        {
            Console.WriteLine();
            Console.WriteLine("WRONG INPUT");
        }
    }
}
