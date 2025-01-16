using System;
using System.Linq;
using System.Collections.Generic;

namespace _4._Movies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int moviesNum = int.Parse(Console.ReadLine());
            List<Movie> movies = new List<Movie>();

            for (int i = 0; i < moviesNum; i++)
            {
                List<string> list = Console.ReadLine()
                    .Split('|')
                    .ToList();

                Movie movie = new Movie();
                movie.Genre = list[0];
                movie.Name = list[1];
                movie.Duration = list[2];

                movies.Add(movie);
            }

            string movieType = Console.ReadLine();

            if (movieType == "all")
            {
                foreach (Movie movie in movies)
                {
                    Console.WriteLine(movie.Name);
                }
            }
            else
            {
                foreach (Movie movie in movies)
                {
                    if (movieType == movie.Genre)
                    {
                        Console.WriteLine(movie.Name);
                    }
                }
            }
        }
    }

    public class Movie
    {
        public string Genre;
        public string Name;
        public string Duration;
    }
}
