using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Sample_Webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductDbContext _dbContext;
        private readonly IMapper _mapper;

        public ProductController(ProductDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Create([FromBody] Product product)
        {
            var add = _dbContext.Products.Add(product);
            _dbContext.SaveChanges();

            return Ok("Product added succesfully");
        }

        [HttpGet]
        public IActionResult Get()
        {
            var getAll = _dbContext.Products.ToList();
            return Ok(getAll);
        }

        [HttpPut]
        public IActionResult Update(int id, [FromBody] Createproductdto product)
        {
            var isId = _dbContext.Products.Where(x => x.Id == id).FirstOrDefault();

            if (isId != null)
            {
                _mapper.Map(product, isId);
                //    isId.ProductName = product.ProductName;
                //    isId.Price = product.Price;
                _dbContext.SaveChanges();
            }

            return Ok("product updated succesfully");

        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var isIDD = _dbContext.Products.FirstOrDefault(x => x.Id == id);

            if (isIDD != null)
            {
                _dbContext.Remove(isIDD);
                _dbContext.SaveChanges();

            }
            return NoContent();

        }

    }
}


