using System;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            const int minutesInOneDay = 1440;
            const int daysInOneYear = 365;

            Console.WriteLine("Enter a number of minutes");
            var minutes = Convert.ToInt32(Console.ReadLine());
            var days = Math.Round((double)minutes / minutesInOneDay,2); // 1 day has 1440 minutes.
            var years = Math.Round((double)minutes / (minutesInOneDay*daysInOneYear),2); // 1 year has 365 days.

            Console.WriteLine("{0} minutes = {1} days = {2} years", minutes, days, years);
        }
    }
}
