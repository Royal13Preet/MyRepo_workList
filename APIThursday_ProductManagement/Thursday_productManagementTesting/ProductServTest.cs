using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thursday_ProductManagement.DataAccess;
using Thursday_ProductManagement.Managers.DTO;
using Thursday_ProductManagement.Managers;
using Thursday_ProductManagement.Services;

namespace Thursday_productManagementTesting
{
    public class ProductServTest
    {
        private readonly Mock<IProductManager> _mockManager;
        private readonly Mock<ILogger<ProductService>> _mockLogger;
        private readonly ProductService _productService;
        public ProductServTest()
        {
            _mockManager = new Mock<IProductManager>();
            _mockLogger = new Mock<ILogger<ProductService>>();
            _productService = new ProductService(_mockManager.Object, _mockLogger.Object);
        }

        [Fact]
        public void GetAllProducts_ReturnProductList()
        {
            var products = new List<Product> { new Product { Id = 1, Name = "Test Products", Price = 32 } };
            _mockManager.Setup(m => m.GetAll()).Returns(products);

            var result = _productService.GetAlltheProducts();

            Assert.NotNull(result);
            Assert.Single(result);
            Assert.Equal("Test Products", result.First().Name);
        }
        [Fact]
        public void CreateNewProduct_ReturnsTrue()
        {
            var productdto = new ProductDto { Name = "New Product" };
            _mockManager.Setup(m => m.Create(productdto)).Returns(true);

            var result = _productService.CreateNewProduct(productdto);

            Assert.True(result);
        }

        [Fact]
        public void DeleteProduct_ReturnsTrue()
        {
            _mockManager.Setup(m => m.Delete(1)).Returns(true);
            var result = _productService.DeleteProduct(1);

            Assert.True(result);
        }

        [Fact]
        public void GetSingleProductById_ReturnsProduct()
        {
            var product = new Product { Id = 1, Name = "Test Product", Price = 34 };
            _mockManager.Setup(m => m.GetById(1)).Returns(product);

            var result = _productService.GetSingleProductById(1);
            Assert.NotNull(result);
            Assert.Equal(1, result.Id);
        }
        [Fact]
        public void UpdateProduct_ReturnsTrue()
        {
            var productdto = new ProductDto { Name = "Updated Product", Price = 23 };
            _mockManager.Setup(m => m.Update(1, productdto)).Returns(true);

            var result = _productService.UpdateProduct(1, productdto);

            Assert.True(result);
        }

        
    }
}
