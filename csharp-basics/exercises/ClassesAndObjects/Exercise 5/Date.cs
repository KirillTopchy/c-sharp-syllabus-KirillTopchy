using System;

namespace Exercise_5
{
    class Date
    {
        private readonly int _day;
        private readonly int _month;
        private readonly int _year;

        public Date(int day, int month, int year)
        {
            _day = day;
            _month = month;
            _year = year;
        }

        public void DisplayDate()
        {
            Console.WriteLine($"{_month}/{_day}/{_year}");
        }   
    }
}
