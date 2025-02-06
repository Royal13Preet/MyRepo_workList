using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Product_Managementmvc.DataAccess.DBModel;
using Product_Managementmvc.Managers.ProductDto;
using Product_Managementmvc.MvcView.Models;
using Product_Managementmvc.Services;


namespace Product_Managementmvc.MvcView.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ILogger<ProductController> _logger;
        private readonly IMemoryCache _memoryCache;

        public ProductController(IProductService productService, ILogger<ProductController> logger, IMemoryCache memoryCache)
        {
            _productService = productService;
            _logger = logger;
            _memoryCache = memoryCache;
        }

        
        public IActionResult GetAll()
        {
            try
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

                HttpContext.Session.SetString("ProductFetched", DateTime.UtcNow.ToString());

                Response.Cookies.Append("ProductFetched", "Products fetched successfully", new CookieOptions
                {
                    Expires = DateTimeOffset.Now.AddMinutes(5),
                    HttpOnly = true,
                    Secure = true,
                    SameSite = SameSiteMode.Strict
                });
                return View(products);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching all products.");
                return View("Error", new ErrorViewModel { Message = "Unable to fetch products." });
            }
        }


        // GET: Product/Add
        [HttpGet]

        public ActionResult Add()
        {
            return View();
        }


        //// POST: Product/Add
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Add(ProductCreateDto productDto)
        {
            if (ModelState.IsValid)
            {
                var result = _productService.CreateNewProduct(productDto);
                HttpContext.Session.SetString("LastCreatedTimestamp", DateTime.UtcNow.ToString());

                Response.Cookies.Append("ProductCreated", "Product Created Successfully", new CookieOptions
                {
                    Expires = DateTimeOffset.Now.AddMinutes(5),
                    HttpOnly = true,
                    Secure = true,
                    SameSite = SameSiteMode.Strict
                });
                return RedirectToAction(nameof(GetAll));
            }
            else
            {
                return BadRequest(ModelState);
            }
            //return View(productDto);
        }

        [HttpGet("Edit/{id}")]

        public IActionResult Edit(int id)
        {
            try
            {

                var product = _productService.GetSingleProductById(id);
                if (product == null)
                {
                    return NotFound();
                }
                return View(product);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching product for edit.");
                return View("Error", new ErrorViewModel { Message = "Unable to fetch product for edit." });
            }
        }

        [HttpPost("Edit/{id}")]
        [ValidateAntiForgeryToken]

        public IActionResult Edit(int id, ProductCreateDto product)
        {
            _logger.LogInformation("Edit action called for ID: {Id}", id);
            if (ModelState.IsValid)
            {
                var result = _productService.UpdateProduct(id, product);
                if (!result)
                {
                    _logger.LogInformation("Product with this ID {id} is not found",id);
                }
                if (result)
                {
                    _logger.LogInformation("Product with ID {Id} updated successfully.", id);
                    HttpContext.Session.SetString("LastUpdatedTimestamp", DateTime.UtcNow.ToString());

                    Response.Cookies.Append("ProductUpdated", "Product updated successfully", new CookieOptions
                    {
                        Expires = DateTimeOffset.Now.AddMinutes(5),
                        HttpOnly = true,
                        Secure = true,
                        SameSite = SameSiteMode.Strict
                    });
                    return RedirectToAction(nameof(GetAll));
                }
            }

            return View(product);
        }


        public IActionResult Delete(int id)
        {
            try
            {
                var product = _productService.GetSingleProductById(id);
                if (product == null)
                {
                    return NotFound();
                }
                return View(product);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching product for deletion.");
                return View("Error", new ErrorViewModel { Message = "Unable to fetch product for deletion." });
            }
        }


        [HttpPost]

        public IActionResult ConfirmDelete(int id)
        {
            try
            {
                _productService.DeleteProduct(id);
                HttpContext.Session.SetString("LastDeletedTimestamp", DateTime.UtcNow.ToString());

                Response.Cookies.Append("ProductDeleted", "Product deleted successfully", new CookieOptions
                {
                    Expires = DateTimeOffset.Now.AddMinutes(5),
                    HttpOnly = true,
                    Secure = true,
                    SameSite = SameSiteMode.Strict

                });
               

                return RedirectToAction("GetAll");
            }


            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while deleting product.");
                return View("Error", new { message = "Unable to delete product." });
            }
        }


    }
}

