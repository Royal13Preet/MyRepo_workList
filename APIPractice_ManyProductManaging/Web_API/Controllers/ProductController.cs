using Manager.Dto_s;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service_Layer;

namespace Web_API.Controllers
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
        public IActionResult Ceate([FromBody] CreateProduct createProduct) 
        {
            _service.CreateNewProduct(createProduct);

            return CreatedAtAction(nameof(GetById), new {message = "Created" }, createProduct);
            
        }

        [HttpGet("Get_Product-Id")]
        public IActionResult GetById(int id)
        {
            var productdto = _service.GetProductId(id);
            return Ok(productdto);

        }

        [HttpPut("Update-Product")]

        public IActionResult Update(int id, [FromBody] CreateProduct updateProduct) 
        {
            var update = _service.UpdateNewProduct(id, updateProduct);
            return Ok("Product Updated Succesfuuly");

        }

        [HttpDelete("Delete-Product")]

        public IActionResult DeleteById(int id)
        {
            _service.DeleteProduct(id);
            return NoContent();
        }

    }
}
