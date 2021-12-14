namespace Exercise_4
{
    class Movie
    {
        private readonly string _title;
        private readonly string _studio;
        public string Rating { get; }

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
