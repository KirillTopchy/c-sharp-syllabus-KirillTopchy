using System;
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
            ProgramMenu.DisplayProgramMenu();
            UserInput();
            Console.ReadKey();
        }

        public static void UserInput()
        {
            var input = Console.ReadKey();
            if (input.KeyChar == '1')
            {
                var listOfCities = PlanYourFlight.GetListOfCities(File.ReadAllLines(Path));
                PlanYourFlight.DisplayPossibleDestinations(listOfCities);

                var chosenCity = PlanYourFlight.ChoseCity();
                ExitProgram(chosenCity);

                var roundTripNotSelected = true;
                while (roundTripNotSelected)
                {
                    int.TryParse(chosenCity, out var city);
                    if (city < 1 || city > listOfCities.Count)
                    {
                        chosenCity = PlanYourFlight.ChoseCity();
                    }
                    else
                    {
                        if (StartCity.Length == 0)
                        {
                            StartCity = listOfCities.ToList()[city - 1];
                        }
                        Route += listOfCities.ToList()[city - 1];
                        Route += " -> ";
                        listOfCities = PlanYourFlight.GetPossibleDestinations(listOfCities.ToList()[city - 1], File.ReadAllLines(Path));
                        PlanYourFlight.DisplayPossibleDestinations(listOfCities);
                        chosenCity = PlanYourFlight.ChoseCity();
                        ExitProgram(chosenCity);

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
                return;
            }
            else
            {
                PlanYourFlight.DisplayWrongInput();
                UserInput();
            }
        }

        public static void ExitProgram(string chosenCity)
        {
            if (chosenCity == "#")
            {
                Environment.Exit(0);
            }
        }
    }
}
