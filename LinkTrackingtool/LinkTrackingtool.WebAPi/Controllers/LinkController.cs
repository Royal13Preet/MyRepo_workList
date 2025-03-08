using Manager_Layer.Dto_s;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service_layer;

namespace LinkTrackingtool.WebAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinkController : ControllerBase
    {
        private readonly ILinkService _linkServices;

        public LinkController(ILinkService linkServices)
        {
            _linkServices = linkServices;
        }

        [HttpPost("create-link")]
        public IActionResult CreateLink([FromBody] CreateShortUrl url)
        {
            var link = _linkServices.CreateShortCodeLink(url);
            return CreatedAtAction(nameof(GetAll), link);
        }

        [HttpGet("Get-all-the-list")]
        public IActionResult GetAll()
        {
            var link = _linkServices.GetAllLinks();
            return Ok(link);
        }
        
        [HttpDelete]
        public IActionResult Delete() 
        {
            return NoContent();
        }
    }
}


