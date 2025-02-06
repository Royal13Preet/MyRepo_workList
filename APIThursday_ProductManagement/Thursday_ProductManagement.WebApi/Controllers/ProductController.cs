using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Thursday_ProductManagement.DataAccess;
using Thursday_ProductManagement.Filters;
using Thursday_ProductManagement.Managers.DTO;
using Thursday_ProductManagement.Services;
using Thursday_ProductManagement.WebApi.Helper;

namespace Thursday_ProductManagement.WebApi.Controllers
{
    [ServiceFilter(typeof(ValidateActionFilter))]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMemoryCache _memoryCache;

        public ProductController(IProductService productService, IMemoryCache memoryCache)
        {
            _productService = productService;
            _memoryCache = memoryCache;
        }

        [HttpGet("Get-All-Products")]
        [BasicAuthorization]
        public IActionResult Get()
        {
            if (!_memoryCache.TryGetValue("AllProducts", out IEnumerable<Product> products))
            {
                products = _productService.GetAlltheProducts();
                var cacheOptions = new MemoryCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5),
                    SlidingExpiration = TimeSpan.FromMinutes(2)
                };
                _memoryCache.Set("AllProducts", products, cacheOptions);
            }

            HttpContext.Session.SetString("ProductAll", DateTime.UtcNow.ToString());

            Response.Cookies.Append("ProductFetched", "Products fetched successfully", new CookieOptions
            {
                Expires = DateTimeOffset.Now.AddMinutes(5),
                HttpOnly = true
            });

            return Ok(products);
        }

        [HttpPost("Create-Product")]
        [BasicAuthorization]
        public IActionResult Create(ProductDto product)
        {
            var create = _productService.CreateNewProduct(product);
            if (!create)
            {
                return BadRequest();
            }


            HttpContext.Session.SetString("LastCreatedTimestamp", DateTime.UtcNow.ToString());

            Response.Cookies.Append("ProductCreated", "Product Created Successfully", new CookieOptions
            {
                Expires = DateTimeOffset.Now.AddMinutes(5),
                HttpOnly = true
            });

            return Created("", new { message = "Product Created Successfully", product });
        }

        [HttpPut("Update-Product/{id}")]
        [BasicAuthorization]
        public IActionResult Update(int id, [FromBody] ProductDto product)
        {
            var updateSuccess = _productService.UpdateProduct(id, product);
            if (!updateSuccess)
            {
                return NotFound($"Product with this ID {id} is not found");
            }

            HttpContext.Session.SetString("LastUpdatedTimestamp", DateTime.UtcNow.ToString());

            Response.Cookies.Append("ProductUpdated", "Product updated successfully", new CookieOptions
            {
                Expires = DateTimeOffset.Now.AddMinutes(5),
                HttpOnly = true
            });
            
            return Ok("Product updated successfully.");
        }

        [HttpDelete("Delete-Product-By-Id/{id}")]
        [BasicAuthorization]
        public IActionResult Delete(int id)
        {
            var product = _productService.DeleteProduct(id);
            if (!product)
            {
                return NotFound($"Product with ID {id} not found");
            }
            
            HttpContext.Session.SetString("LastDeletedTimestamp", DateTime.UtcNow.ToString());

            Response.Cookies.Append("ProductDeleted", "Product deleted successfully", new CookieOptions
            {
                Expires = DateTimeOffset.Now.AddMinutes(5),
                HttpOnly = true
                
            });

            return NoContent();
        }
    }
}
