using Manager_Layer.Dto_s;
using Microsoft.AspNetCore.Mvc;
using Service_Layer;

namespace Web_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IService _service;

        public ProductController(IService service)
        {
            _service = service;
        }

        [HttpPost("Create-Product")]
        public ActionResult<ResponseDto> Create([FromBody] CreateProduct createProduct)
        {
            try
            {
                var response = _service.CreteProduct(createProduct);
                return CreatedAtAction(nameof(GetById), new { id = response.Id }, response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Get-Product")]
        public IActionResult GetById(int id)
        {
            var product = _service.GetById(id);
            return Ok(product);

        }

        [HttpPut("Update-Product/{id}")]

        public IActionResult update(int id, [FromBody] CreateProduct createProduct)
        {
            try
            {
                var update = _service.UpdateProduct(id, createProduct);

                return Ok(update);
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
            
        }

        [HttpDelete("Delete-Product")]
        public IActionResult DeleteById(int id)
        {
            var deletedId = _service.DeleteProduct(id);
            if (!deletedId)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
