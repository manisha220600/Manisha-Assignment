using Microsoft.AspNetCore.Mvc;
using MovieLibrary;
using MovieLibrary.Models;
using MovieLibrary.Repositories;

namespace MovieService.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class MovieController : Controller
    {
        private MovieRepository movieRepository;
        public MovieController()
        {
            movieRepository = new MovieRepository();
        }
        [HttpGet,Route("GetAllMovies")]
        public IActionResult GetAll()
        {
            try
            {
                List<Movie> movies = movieRepository.GetAllMovies();
                return StatusCode(200, movies);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet,Route("GetMovieByName/{name}")]
        public IActionResult GetMovieName(string name)
        {
            try
            {
                Movie movie = movieRepository.GetMovieByName(name);
                return StatusCode(200, movie);
            }
            catch (Exception ex)
            {
                return StatusCode(500,ex.Message);
            }
        }
        [HttpGet,Route("GetMoviesByActor/{actor}")]
        public IActionResult GetMoviesByActor(string actor)
        {
            try
            {
                List<Movie> movies = movieRepository.GetMoviesByActor(actor);
                return StatusCode(200, movies);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet, Route("GetMoviesByReleaseYear/{year}")]
        public IActionResult GetMoviesByReleaseYear(int year)
        {
            try
            {
                List<Movie> movies = movieRepository.GetMovieByReleaseYear(year);
                return StatusCode(200, movies);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet, Route("GetMoviesByDirector/{director}")]
        public IActionResult GetMoviesByDirector(string director)
        {
            try
            {
                List<Movie> movies = movieRepository.GetMovieByDirector(director);
                return StatusCode(200, movies);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost, Route("AddMovie")]
        public IActionResult AddMovie(Movie movie)
        {
            try
            {
                movieRepository.AddMovie(movie);
                return StatusCode(200,movie);
            }
            catch(Exception ex)
            {
                return StatusCode(500,ex.Message);
            }
        }


    }
}
