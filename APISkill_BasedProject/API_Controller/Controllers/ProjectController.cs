using API_manager.DTo_s;
using API_Servicelayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Controller.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectService _projectService;

        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet("Get-all-the-Project")]
        public IActionResult GetAll()
        {
            var allProject = _projectService.GetAllProjects();
            return Ok(allProject);
        }
        

        [HttpGet("Get-all-ProjectById")]
        public IActionResult GetById(int id)
        {
            var get = _projectService.GetById(id);
            return Ok(get);
        }

        [HttpPost("Create-Project")]
        public IActionResult Create([FromBody] CreateProject skill)
        {
            var skills = _projectService.CreateProject(skill);
            return CreatedAtAction(nameof(GetById), skills);
        }
    }
}
