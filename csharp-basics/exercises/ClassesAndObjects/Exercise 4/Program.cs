using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstMovie = new Movie("Casino Royale", "Eon Productions", "PG13");
            var secondMovie = new Movie("Glass", "Buena Vista International", "PG13");
            var thirdMovie = new Movie("Spider-Man: Into the Spider-Verse", "Columbia Pictures", "PG");

            var movies = new List<Movie>()
            {
                firstMovie,
                secondMovie,
                thirdMovie
            };
            Console.WriteLine("All movies");
            PrintInfo(movies);

            Console.WriteLine("Movies with PG rating");
            var filtered = GetPg(movies.ToArray());
            PrintInfo(filtered);
        }

        public static Movie[] GetPg(Movie[] movies)
        {
            return movies.Where(movie => movie.Rating == "PG").ToArray();
        }

        public static void PrintInfo(Movie[] movies)
        {
            foreach (var movie in movies)
            {
                Console.WriteLine(movie.Display());
            }
        }

        public static void PrintInfo(List<Movie> movies)
        {
            foreach (var movie in movies)
            {
                Console.WriteLine(movie.Display());
            }
            Console.WriteLine();
        }
    }
}
