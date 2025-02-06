using eFclass.Models.ViewModels;
using eFclass.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eFclass.BookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]

        public IActionResult Get() {
            var res = _userService.GetUsers();
            return Ok(res);
        }

        [HttpGet("id")]

        public IActionResult Get(int id)
        {
            var res = _userService.GetUser(id);
            return Ok(res);
        }

        [HttpGet("email")]

        public IActionResult GetEmail(string email) {
            var result = _userService.GetUserByEmail(email);
            return Ok(result);
        
        }
        [HttpPost]

        public IActionResult Post(UserDto userDto)
        {
            var result = _userService.SaveNewUser(userDto);
            return Ok(result);
        }
    }
}
