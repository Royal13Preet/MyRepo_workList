using API_manager.DTo_s;
using API_Servicelayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Controller.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpPost("Create-User")]
        public IActionResult Create([FromBody] UserCreateDto userCreateDto)
        {
            var user = _service.Create(userCreateDto);
            return Created(nameof(GetUserById),user);
        }
       
        [HttpPost("User-Login")]
        public IActionResult Get([FromBody] UserLogin userLogin) 
        {
            var token = _service.Login(userLogin);

            if (string.IsNullOrEmpty(token))
            {
                return Unauthorized("Invalid credentials");
            }
            return Ok(new { Token = token });
        }

        [HttpGet("Get-UserById")]
        public IActionResult GetUserById(int id)
        {
            var singleUser = _service.GetUserById(id);
            if(singleUser == null)
            {
                return NotFound($"User with this {id} not found");
            }
            return Ok(singleUser);
        }
    }
}


