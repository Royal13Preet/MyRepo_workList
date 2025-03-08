using Microsoft.AspNetCore.Mvc;
using Service_layer;

namespace Web_api.Controllers
{
    public class MovieController : Controller
    {
        private readonly Service _service;

        public MovieController(Service service)
        {
            _service = service;
        }


        public async Task<IActionResult> GetAll(string title = "", List<string> genre = null!, int page = 1, int pageSize = 10)
        {
            var movies = await _service.FetchMovieFromLocalJSONAsync();

            var genresss = movies.SelectMany(m => m.genres!).Distinct().ToList();

            if (!string.IsNullOrEmpty(title))
            {
                movies = movies.Where(m => m.Title.Contains(title, StringComparison.OrdinalIgnoreCase)).ToList();
            }
            if (genre != null && genre.Any())
            {
                movies = movies.Where(m => m.genres!.Any(g => genre.Contains(g))).ToList();
            }

            var totalMovies = movies.Count;
            var totalPages = (int)Math.Ceiling(totalMovies / (double)pageSize);

            var pagedMovies = movies.Skip((page - 1) * pageSize).Take(pageSize).ToList();



            ViewData["CurrentPage"] = page;
            ViewData["TotalPages"] = totalPages;
            ViewData["TitleSearch"] = title;

            ViewData["Genres"] = genresss;
            ViewData["SelectedGenre"] = genre ?? new List<string>();


            return View(pagedMovies);
        }

    }
}

