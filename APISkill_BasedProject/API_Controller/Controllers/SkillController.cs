using API_manager;
using API_manager.DTo_s;
using API_Servicelayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Controller.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillController : ControllerBase
    {
        private readonly ISkillService _skillService;

        public SkillController(ISkillService skillService)
        {
            _skillService = skillService;
        }

        [HttpGet("Get-all-skills")]
        public IActionResult Get() 
        {
            var skill = _skillService.GetAllSkills();
            return Ok(skill);
        }
        


        [HttpPost("Add-skills")]
        public IActionResult Create([FromBody] AddSkill skill)
        {
            var skilsl = _skillService.AddSkill(skill);
                return CreatedAtAction(nameof(Get), skill);
        }
    }
}
