using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieListDisplay.Services;

namespace MovieListDisplay.Webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieListDisplayController : ControllerBase
    {
        private readonly MovieService _movieService;

        public MovieListDisplayController(MovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet("GetMovies")]
        public IActionResult GetMovies(string title)
        {
            List<Movie> movies = _movieService.GetMoviesBySelectedTitle(title);
            return Ok(movies);
        }

        [HttpPost("FilterMoviesByGenres")]
        public IActionResult FilterMoviesByGenres([FromBody] List<string> genres)
        {
         
            List<Movie> filteredMovies = _movieService.GetMoviesBySelectedGenres(genres);
            return Ok(filteredMovies);

        }
    }
}
