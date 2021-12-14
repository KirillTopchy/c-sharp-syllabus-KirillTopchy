using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FlightPlanner
{
    class Program
    {
        private static readonly string CurrentDir = Directory.GetCurrentDirectory().Replace("\\bin\\Debug", "");
        private static readonly string Path = (CurrentDir + "\\flights.txt");
        public static string Route = "";
        public static string StartCity = "";

        private static void Main(string[] args)
        {
            ProgramMenu();
            UserInput();
            Console.ReadKey();
        }

        private static void UserInput()
        {
            var input = Console.ReadKey();
            if (input.KeyChar == '1')
            {
                var listOfCities = GetListOfCities();
                DisplayPossibleDestinations(listOfCities);

                var citySelected = SelectACity();
                var roundTripNotSelected = true;
                while (roundTripNotSelected)
                {
                    int.TryParse(citySelected, out var city);
                    if (city < 1 || city > listOfCities.Count)
                    {
                        citySelected = SelectACity();
                    }
                    else
                    {
                        if (StartCity.Length == 0)
                        {
                            StartCity = listOfCities.ToList()[city - 1];
                        }
                        Route += listOfCities.ToList()[city - 1];
                        Route += " -> ";
                        listOfCities = GetPossibleDestinations(listOfCities.ToList()[city - 1]);
                        DisplayPossibleDestinations(listOfCities);
                        citySelected = SelectACity();
                        
                        if (listOfCities.Contains(StartCity))
                        {
                            roundTripNotSelected = false;
                            Route += StartCity;
                        }
                    }
                }
                Console.WriteLine(Route);
            } 
            else if (input.KeyChar == '#')
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("WRONG INPUT");
                UserInput();
            }
        }

        private static void ProgramMenu()
        {
            Console.WriteLine("What would you like to do:");
            Console.WriteLine("To display list of the cities press 1");
            Console.WriteLine("To exit program press # ");
            Console.Write("> ");
        }

        private static string SelectACity()
        {
            Console.WriteLine();
            Console.WriteLine("To select a NUMBER of city from which you would like to start and press ENTER");
            Console.Write("> ");
            var citySelected = Console.ReadLine();
            if (citySelected == "#")
            { 
                Environment.Exit(0);
            }
            return citySelected;
        }

        private static List<string> GetListOfCities()
        {
            var cities = new HashSet<string>();
            var readText = File.ReadAllLines(Path);
            foreach (var s in readText)
            {
                var route =  s.Replace(" ","").Replace("-", "").Split('>');
                cities.Add(route[0]);
                cities.Add(route[1]);
            }
            return cities.ToList();
        }

        private static void DisplayPossibleDestinations(List<string> listOfCities)
        {
            Console.WriteLine();
            Console.WriteLine("Possible destinations:");
            for (int i = 0; i < listOfCities.Count; i++)
            {
                Console.WriteLine("{0}: {1}", i+1, listOfCities[i]);
            }
        }

        private static List<string> GetPossibleDestinations(string departureCity)
        {
            var possibleDestinations = new List<string>();
            var readText = File.ReadAllLines(Path);
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
    }
}
