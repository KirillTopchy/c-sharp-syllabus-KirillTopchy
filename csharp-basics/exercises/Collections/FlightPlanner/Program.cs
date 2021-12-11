using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace FlightPlanner
{
    class Program
    {
        static readonly string CurrentDir = Directory.GetCurrentDirectory().Replace("\\bin\\Debug", "");
        private static readonly string Path = (CurrentDir + "\\flights.txt");

        private static void Main(string[] args)
        {
            UserInput();
            //var flightList = new List<string>();
            //var readText = File.ReadAllLines(Path);
            //foreach (var s in readText)
            //{
            //    flightList.Add(s);
            //}

            //Console.WriteLine(flightList.Count);
            Console.ReadKey();
        }

        private static void UserInput()
        {
            ProgramMenu();
            var input = Console.ReadKey();
            if (input.KeyChar == '1')
            {
                SelectACity();
                var input2 = Console.ReadKey();
                while (input2.KeyChar != '1')
                {
                    SelectACity();
                    input2 = Console.ReadKey();
                }
                Console.WriteLine();
                Console.WriteLine("Display city");
            } 
            else if (input.KeyChar == '#')
            {
                Console.WriteLine();
                Console.WriteLine("Full road: ");
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

        private static void SelectACity()
        {
            Console.WriteLine();
            Console.WriteLine("To select a city from which you would like to start press 1");
            Console.Write("> ");
        }


    }
}
