using Microsoft.AspNetCore.Mvc;
using Saturday_ManagingProducts.Manager.Dtos;
using Saturday_ManagingProducts.Service;

namespace Saturday_ManagingProducts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productRepository)
        {
            _productService = productRepository;
        }

        [HttpGet("Get-By-ID")]
        public IActionResult GetProductById(int id)
        {
            var productDto = _productService.GetSingleProductById(id);
            return Ok(productDto);
        }


        [HttpPost("Create-Product")]
        public IActionResult Create(ProductCreateRequestDto productDto)
        {
            var isCreated = _productService.CreateNewProduct(productDto);

            return CreatedAtAction(nameof(GetProductById), new { }, productDto);
        }



        [HttpPut("ProductUpdate/{id}")]

        public IActionResult update(int id, [FromBody] ProductCreateRequestDto productDto)
        {
            var product = _productService.UpdateProduct(id, productDto);

            return Ok(product);
        }


    }

}
