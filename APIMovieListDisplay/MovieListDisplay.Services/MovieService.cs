using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieListDisplay.Services
{
    public class MovieService
    {
        private readonly HttpClient _httpClient;

        public MovieService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public List<Movie> FetchMoviesFromJson()
        {
            var jsonUrl = "https://raw.githubusercontent.com/prust/wikipedia-movie-data/master/movies.json";


            var response = _httpClient.GetStringAsync(jsonUrl).Result;
            var movies = JsonConvert.DeserializeObject<List<Movie>>(response);
            return movies;
        }

        public List<Movie> GetMoviesBySelectedTitle(string title)
        {
            List<Movie> movies = FetchMoviesFromJson();
            movies = movies.Where(m => m.Title.Contains(title, StringComparison.OrdinalIgnoreCase)).ToList();
            return movies;
        }

        public List<Movie> GetMoviesBySelectedGenres(List<string> selectedGenres)
        {
            List<Movie> movies = FetchMoviesFromJson();
            var filteredMovies = movies.Where(m => selectedGenres.All(g => m.Genres.Contains(g, StringComparer.OrdinalIgnoreCase)))
                                       .ToList();

            return filteredMovies;
        }

    }
}
