using Microsoft.AspNetCore.Mvc;
using Secureuser.Models;
using Secureuser.Models.ViewModel;
using Secureuser.Services;
using System;
using System.Security.Claims;

namespace Secureuser.UserProject.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]

    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
           
        }
        [HttpPost("login")]
        
        public IActionResult Login([FromBody] Loginuserdto loginUser)
        {
            var token = _authService.Login(loginUser);
            
            if (token.StartsWith("Invalid"))
            {
                return Unauthorized(new { message = token });
            }
            return Ok(new { token });
        }
       
        [HttpPost("Create-user")]
       
        public IActionResult Register([FromBody] UserCreatedto newUser)
        {
            var currentUserRole = User.FindFirstValue(ClaimTypes.Role);
            if (currentUserRole != "admin")
            {
                return StatusCode(403, new { message = "Only admins can create new users." });
            }
            var result = _authService.Register(newUser);
            if (result.StartsWith("Username already exists"))
            {
                return Conflict(new { message = result });
            }
            return Ok(new { message = result });
        }

        [HttpDelete("delete")]
        
        public IActionResult DeleteUser(string usernameToDelete)
        {
            var currentUserRole = User.FindFirstValue(ClaimTypes.Role);
            
            if (currentUserRole != "admin")
            {
                return StatusCode(403, new { message = "Only admins can delete users." });
            }
            var result = _authService.DeleteUser(usernameToDelete);
            if (result.StartsWith("User not found"))
            {
                return NotFound(new { message = result });
            }
            return Ok(new { message = result });
        }
        
        [HttpGet("all-users")]
        
        public IActionResult GetAllUsers()
        {
            var currentUserRole = User.FindFirstValue(ClaimTypes.Role);

            if (currentUserRole != "admin")
            {
                return StatusCode(403, new { message = "Only admins can view the user list." });
            }

            var users = _authService.GetAllUsers();

            if (users == null || !users.Any())
            {
                return NotFound(new { message = "No users found." });
            }

            return Ok(new { users });

        }

    }
}

