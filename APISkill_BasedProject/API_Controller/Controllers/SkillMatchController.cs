using API_DataAccessLayer.Repositories;
using API_Servicelayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Controller.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillMatchController : ControllerBase
    {
        private readonly IUserSkillService _userSkillService;

        public SkillMatchController(IUserSkillService userSkillService)
        {
            _userSkillService = userSkillService;
        }

        [HttpPost("users/{id}/Add-Skills")]
        public  IActionResult AssignSkillsToUser(int id, [FromBody] List<int> skillIds)
        {
             _userSkillService.AssignSkillsToUser(id, skillIds);
            return Ok("Skills assigned to user successfully.");
        }

        [HttpPost("projects/{id}/Add-Skills")]
        public IActionResult AssignSkillsToProject(int id, [FromBody] List<int> skillIds)
        {
            _userSkillService.AssignSkillsToProject(id, skillIds);
            return Ok("Skills assigned to project successfully.");
        }

        [HttpGet("projects/match/{userId}")]
        public IActionResult GetMatchingProjects(int userId)
        {
            var projects = _userSkillService.GetMatchingProjects(userId);
            return Ok(projects);
        }
    }
}
