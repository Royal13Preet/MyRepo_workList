using Newtonsoft.Json;
using System.ComponentModel;
using System;
using System.Text.Json.Serialization;
using System.Diagnostics.CodeAnalysis;

namespace Service_layer
{
    public class Service
    {
        private readonly HttpClient _httpClient;

        public Service()
        {
            _httpClient = new HttpClient();
        }

        
        public async Task<List<Movie>> FetchFromJSONUrl()
        {
            var Jsonurl = "https://raw.githubusercontent.com/prust/wikipedia-movie-data/master/movies.json";

            var response = await _httpClient.GetStringAsync(Jsonurl);

            var movie = JsonConvert.DeserializeObject<List<Movie>>(response);

            return movie ?? [];                        
        }


        public async Task<List<Movie>> GetAllMovies(int page,int pageSize, string name)
        {
            var movie = await FetchFromJSONUrl();

            if (!string.IsNullOrEmpty(name))
            {
                movie = movie.Where(m => m.title != null &&
                         m.title.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
                //movie = movie.Where(m => m.title.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            var pagination = movie.Skip((page-1) * pageSize).Take(pageSize).ToList();
            return pagination;
        }

        

    }
}


