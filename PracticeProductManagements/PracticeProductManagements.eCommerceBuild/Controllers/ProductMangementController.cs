using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PracticeProductManagements.Models.Dtos;
using PracticeProductMangements.Services;
using System;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Runtime.Intrinsics.X86;

namespace PracticeProductManagements.eCommerceBuild.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductMangementController : ControllerBase
    {
        private readonly IProductServices _service;
        private readonly IMapper _mapper;

        public ProductMangementController(IProductServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet("get-products")]
        public IActionResult GetProducts(int page = 1, int pageSize = 10, string? name = null)
        {
            var result = _service.GetAlltheProductDetails(page, pageSize, name);
            return Ok(result);
        }
        [HttpGet("get-product-id")]
        public IActionResult GetProductById(Guid id)
        {
            var product = _service.GetProductDetails(id);

            if (product == null)
            {
                return NotFound($"Product with ID {id} not found.");
            }

            return Ok(product);
        }
        [HttpPost("Create-new-product")]
        public IActionResult CreateProduct(ProductDetailsDto productDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var createdProduct = _service.AddNewProduct(productDto);
            return CreatedAtAction(nameof(GetProductById), new { id = createdProduct.Id }, createdProduct);
            //return StatusCode(203, new { product = createdProduct });
        }

        [HttpPut("Update-Exsting-Product-ById")]
        public IActionResult UpdateProduct(Guid id, [FromBody] ProductDetailsDto productDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var isUpdated = _service.UpdateProduct(id, productDto);

            if (!isUpdated)
            {
                return NotFound("Product not found.");
            }

            return Ok("Product updated successfully.");
        }

        [HttpDelete("Delete-existing-product-ById")]
        public IActionResult DeleteProduct(Guid id)
        {
            var isDeleted = _service.DeleteProduct(id);

            if (!isDeleted)
            {
                return NotFound("Product not found.");
            }

            return NoContent();
        }
    }
}


