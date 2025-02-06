//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Service_layer
//{
//    public class Service 
//    {
//        private readonly HttpClient _httpClient;

//        public Service()
//        {
//            _httpClient = new HttpClient();
//        }

//        public async Task<List<Movie>> FetchMovieFromJSON()
//        {
//            var JSonUrl = "https://raw.githubusercontent.com/prust/wikipedia-movie-data/master/movies.json";

//            var response = await _httpClient.GetStringAsync(JSonUrl);
//            var movie = JsonConvert.DeserializeObject<List<Movie>>(response);
//            return movie ?? new List<Movie>();
//        }

//        public async Task<List<Movie>> GetMoviesAsync()
//        {
//            return await FetchMovieFromJSON();
//        }

//        public List<Movie> GetMoviesBySelectedGenre(List<string> genre)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}


using Newtonsoft.Json;

namespace Service_layer
{
    public class Service
    {
        private readonly string _jsonFilePath;

        public Service()
        {
           
            _jsonFilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "data", "movies.json");
        }

        public async Task<List<Movie>> FetchMovieFromLocalJSONAsync()
        {
            if (!File.Exists(_jsonFilePath))
            {
                throw new FileNotFoundException($"JSON file not found: {_jsonFilePath}");
            }


            using (var reader = new StreamReader(_jsonFilePath))
            {
                var jsonContent = await reader.ReadToEndAsync();
                var movies = JsonConvert.DeserializeObject<List<Movie>>(jsonContent);
                return movies ?? new List<Movie>();
            }
        }
    }
}
