using API_manager.DTo_s;
using API_Servicelayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Controller.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly IProfileService _profileService;

        public ProfileController(IProfileService profileService)
        {
            _profileService = profileService;
        }

        [HttpPost("Create-Profile")]
        public IActionResult Create([FromBody] UserProfileDto createDto)
        {
            try
            {
                var user = _profileService.CreateProfile(createDto);
                return CreatedAtAction(nameof(Get) ,new {}, user);
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Get-Profile-By-ProfileId")]

        public IActionResult Get(int id) 
        {
            try
            {
                var profile = _profileService.GetUserProfile(id);
                return Ok(profile);
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("Update-Profile")]
        public IActionResult Update(int id, [FromBody] UserProfileDto profileDto)
        {
            try
            {
                var updated = _profileService.UpdateProfile(id, profileDto);
                if (updated != null)
                {
                    return Ok(updated);
                }
                return BadRequest("Error while fetching");
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
           

        }
    }
}
