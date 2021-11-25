using System;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter distance in meters: ");
            var distance = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter hours: ");
            var hours = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter minutes: ");
            var minutes = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter seconds: ");
            var seconds = Convert.ToDouble(Console.ReadLine());

            var metersPerSecond = distance / (seconds + minutes * 60 + hours * 60 * 60);
            var kilometersPerHour = (distance / 1000) / (seconds / 60 /60 + minutes /60 + hours);
            var milesPerHour = (distance / 1609) / (seconds / 60 / 60 + minutes / 60 + hours);

            Console.WriteLine("Your speed in meters/second {0} ",metersPerSecond);
            Console.WriteLine("Your speed in km/h {0} ", kilometersPerHour);
            Console.WriteLine("Your speed in miles/h {0} ", milesPerHour);
        }
    }
}
