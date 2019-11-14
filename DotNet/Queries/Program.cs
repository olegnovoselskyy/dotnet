using System;
using System.Collections.Generic;
using System.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var movies = new List<Movie>()
            {
                new Movie { Title = "The Dark Knight", Rating = 9.0f, Year = 2008},
                new Movie { Title = "Fight Club", Rating = 8.8f, Year = 1999},
                new Movie { Title = "Star Wars V", Rating = 8.7f, Year = 1980},
                new Movie { Title = "Avengers: Endgame", Rating = 8.5f, Year = 2019}
            };

            foreach (var movie in movies.Filter(m => m.Year > 2000))
            {
                Console.WriteLine(movie.Title);
            }
        }
    }
}
