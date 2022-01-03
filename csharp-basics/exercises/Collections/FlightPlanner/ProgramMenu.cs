using System;
namespace FlightPlanner
{
    public class ProgramMenu
    {
        public static void DisplayProgramMenu()
        {
            Console.WriteLine("What would you like to do:");
            Console.WriteLine("To display list of the cities press 1");
            Console.WriteLine("To exit program press # ");
            Console.Write("> ");
        }
    }
}
