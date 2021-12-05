using System.Collections.Generic;

namespace Exercise_4
{
    class Movie
    {
        private string _title { get; set; }
        private string _studio { get; set; }
        public string Rating { get; private set; }

        public Movie(string title, string studio, string rating)
        {
            _title = title;
            _studio = studio;
            Rating = rating;
        }

        public Movie(string title, string studio)
        {
            _title = title;
            _studio = studio;
            Rating = "PG";
        }

        public string Display()
        {
            return $"{_title} {_studio} {Rating}";
        }
    }
}
