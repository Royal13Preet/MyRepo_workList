using Microsoft.AspNetCore.Mvc;
using Service_layer;

namespace Mvc_projectview.Controllers
{
    public class MovieController : Controller
    {
        private readonly Service _service;

        public MovieController(Service service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index(int page = 1, int pageSize = 10, string name = "")
        {
            var movie = await _service.GetAllMovies(page,pageSize,name);

            var totalMovies = await _service.FetchFromJSONUrl();

            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = (int)Math.Ceiling(totalMovies.Count/(double)pageSize);
            return View(movie);

        }
    }
}


