using MovieLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary.Repositories
{
    public class MovieRepository
    {
        private static List<Movie> movies = new List<Movie>();

        public void AddMovie(Movie movie)
        {
            movies.Add(movie);
        }

        public List<Movie> GetAllMovies()
        {
            return movies;
        }

        public Movie GetMovieByName(string name)
        {
            return movies.Single(e => e.MovieName == name);
        }

        public List<Movie> GetMoviesByActor(string actor)
        {
            return movies.Where(x => x.Actor == actor).ToList();
        }

        public List<Movie> GetMovieByReleaseYear(int year)
        {
            return movies.Where(e => e.ReleaseDate.Year == year).ToList();
        }

        public List<Movie> GetMovieByDirector(string director)
        {
            return movies.Where(e => e.Director == director).ToList();
        }


    }
}
