using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class Date
    {
        private int Day { get; set; }
        private int Month { get; set; }
        private int Year { get; set; }

        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public void DisplayDate()
        {
            Console.WriteLine($"{Month}/{Day}/{Year}");
        }   
    }
}
