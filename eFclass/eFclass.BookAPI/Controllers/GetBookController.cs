using eFclass.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eFclass.BookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetBookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public GetBookController(IBookService bookService)
        {
            _bookService = bookService;
        }
        [HttpGet]
        public IActionResult GetAlBooks()
        {

            return Ok(_bookService.GetAllBooks());
        }
    }
}
