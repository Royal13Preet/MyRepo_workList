using LinkTrackerTool.Manager.Dto;
using LinkTrackerTool.Service;
using Microsoft.AspNetCore.Mvc;

namespace LinkTrackerTool.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinksController : ControllerBase
    {

        private readonly ILinkService _linkService;

        public LinksController(ILinkService linkService)
        {
            _linkService = linkService;
        }

        [HttpPost("Create")]
        public IActionResult Create([FromBody] CreateShortUrlRequest request)
        {
            try
            {
                var result = _linkService.CreateShortUrl(request);
                return Created(string.Empty, result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}


