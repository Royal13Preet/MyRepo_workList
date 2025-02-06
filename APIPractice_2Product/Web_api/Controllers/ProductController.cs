using Manager_layer.DTo_s;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service_Layer;

namespace Web_api.Controllers
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
        public IActionResult Create(CreateProductDto productdto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var createdProduct = _service.CreateProduct(productdto);
            return CreatedAtAction(nameof(Get), new { id = createdProduct.Id }, createdProduct);
        }

        [HttpGet("Get-By-Id")]
        public IActionResult GetById(int id) 
        {
            var product = _service.GetProductById(id);
            if (product == null) 
            {
                return NotFound("Product with this Id is not Found");
            }
            return Ok(product);
        }

        [HttpGet("Get-All-Products")]
        public IActionResult Get(int page = 1, int pageSize = 10, string? name = null)
        {
            var products = _service.GetProducts(page,pageSize,name);
            return Ok(products);
        }

        [HttpPut("Update-product/{id}")]
        public IActionResult Update(int id,[FromBody] CreateProductDto productDto)
        {
            try
            {
                var products = _service.UpdateProduct(id, productDto);
                return Ok(products);
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("Delete-Product-By-Id")]
        public IActionResult Delete(int id) 
        {
            _service.DeleteProduct(id);
            return NoContent();
        }

    }
}
