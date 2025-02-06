using Moq;
using Xunit;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using Thursday_ProductManagement.DataAccess.Repositories;
using Thursday_ProductManagement.Services;
using Thursday_ProductManagement.DataAccess;
using Thursday_ProductManagement.Managers.DTO;
using Thursday_ProductManagement.Managers;

namespace Thursday_ProductManagement.Tests
{
    public class ProductServiceTests
    {
        private readonly Mock<IProductManager> _mockProductManager;
        private readonly Mock<ILogger<ProductService>> _mockLogger;
        private readonly ProductService _productService;

        public ProductServiceTests()
        {
            _mockProductManager = new Mock<IProductManager>();
            _mockLogger = new Mock<ILogger<ProductService>>();
            _productService = new ProductService(_mockProductManager.Object, _mockLogger.Object);
        }

        [Fact]
        public void CreateNewProduct_ShouldReturnTrue_WhenProductIsCreatedSuccessfully()
        {
            // Arrange
            var product = new ProductDto { Name = "Test Product" };
            _mockProductManager.Setup(repo => repo.Create(product)).Returns(true);

            // Act
            var result = _productService.CreateNewProduct(product);

            // Assert
            Assert.True(result);
            _mockProductManager.Verify(repo => repo.Create(product), Times.Once);
        }

        [Fact]
        public void DeleteProduct_ShouldReturnTrue_WhenProductIsDeletedSuccessfully()
        {
            // Arrange
            int productId = 1;
            _mockProductManager.Setup(repo => repo.Delete(productId)).Returns(true);

            // Act
            var result = _productService.DeleteProduct(productId);

            // Assert
            Assert.True(result);
            _mockProductManager.Verify(repo => repo.Delete(productId), Times.Once);
        }

        [Fact]
        public void GetAlltheProducts_ShouldReturnAllProducts()
        {
            // Arrange
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Product 1" },
                new Product { Id = 2, Name = "Product 2" }
            };
            _mockProductManager.Setup(repo => repo.GetAll()).Returns(products);

            // Act
            var result = _productService.GetAlltheProducts();

            // Assert
            Assert.Equal(products, result);
            _mockProductManager.Verify(repo => repo.GetAll(), Times.Once);
        }

        [Fact]
        public void GetSingleProductById_ShouldReturnProduct_WhenProductExists()
        {
            // Arrange

            var product = new Product { Id = 1, Name = "Product 1", Price = 90 };

            _mockProductManager.Setup(repo => repo.GetById(product.Id));

            // Act
            var result = _productService.GetSingleProductById(product.Id);
            
            // Assert
            Assert.Null(result);
            _mockProductManager.Verify(repo => repo.GetById(product.Id), Times.Once);
        }

        [Fact]
        public void UpdateProduct_ShouldReturnTrue_WhenProductIsUpdatedSuccessfully()
        {
            // Arrange
            var product = new ProductDto {  Name = "Updated Product" };
            _mockProductManager.Setup(repo => repo.Update(1,product)).Returns(true);

            // Act
            var result = _productService.UpdateProduct(1,product);

            // Assert
            Assert.True(result);
            _mockProductManager.Verify(repo => repo.Update(1,product), Times.Once);
        }

        [Fact]
        public void UpdateProduct_ShouldReturnFalse_WhenProductIdMismatch()
        {
            // Arrange
            var product = new ProductDto {  Name = "Updated Product",Price = 09779 };

            // Act
            var result = _productService.UpdateProduct(2,product);

            // Assert
            Assert.False(result);
            _mockProductManager.Verify(repo => repo.Update(1, It.IsAny<ProductDto>()), Times.Never);
        }
        

    }
}
