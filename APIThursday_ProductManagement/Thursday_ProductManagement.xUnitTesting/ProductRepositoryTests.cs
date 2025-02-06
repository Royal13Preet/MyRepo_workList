using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using Thursday_ProductManagement.DataAccess.Repositories;
using Thursday_ProductManagement.DataAccess;
using Xunit;

namespace Thursday_ProductManagement.Tests
{
    public class ProductRepositoryTests
    {
        private readonly ProductDbContext _dbContext;
        private readonly ProductRepository _productRepository;

        public ProductRepositoryTests()
        {
            var options = new DbContextOptionsBuilder<ProductDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            _dbContext = new ProductDbContext(options);

            var logger = new LoggerFactory().CreateLogger<ProductRepository>();

            _productRepository = new ProductRepository(_dbContext, logger);
        }

        [Fact]
        public void CreateProduct_ShouldReturnTrue_WhenProductIsAddedSuccessfully()
        {
            // Arrange
            var product = new Product { Id = 8, Name = "Test Product" ,Price=979};

            // Act
            var result = _productRepository.Create(product);

            // Assert
            Assert.True(result);
            var createdProduct = _dbContext.Products.FirstOrDefault(p => p.Id == 8);
            Assert.NotNull(createdProduct);
            Assert.Equal(product.Id, createdProduct.Id);
        }

        [Fact]
        public void DeleteProduct_ShouldReturnTrue_WhenProductExists()
        {
            // Arrange
            var id = 4;
            _dbContext.Products.Add(new Product { Id = id, Name = "Glass", Price = 1678 });
            _dbContext.SaveChanges();

            // Act
            var result = _productRepository.Delete(id);

            // Assert
            Assert.True(result);
            var deletedProduct = _dbContext.Products.FirstOrDefault(p => p.Id == id);
            Assert.Null(deletedProduct);
        }

        [Fact]
        public void GetAll_ShouldReturnAllProducts()
        {
            // Arrange
            _dbContext.Products.Add(new Product { Id = 1, Name = "Product1", Price = 100 });
            _dbContext.Products.Add(new Product { Id = 2, Name = "Product2", Price = 200 });
            _dbContext.SaveChanges(); 

            // Act
            var result = _productRepository.GetAll();

            // Assert
            Assert.Equal(4, result.Count()); 
        }


        [Fact]
        public void GetProductById_ShouldReturnProduct_WhenProductExists()
        {
            // Arrange
            var id = 3;
            _dbContext.Products.Add(new Product { Id = id, Name = "Sample Product", Price = 100 });
            _dbContext.SaveChanges();

            // Act
            var result = _productRepository.GetById(id);

            // Assert
            Assert.NotNull(result); // Ensure result is not null
            Assert.Equal(id, result.Id); // Verify the correct product is returned
            Assert.Equal("Sample Product", result.Name); // Additional assertion for correctness
        }


        [Fact]
        public void UpdateProduct_ShouldReturnTrue_WhenProductIsUpdatedSuccessfully()
        {
            var updateProduct = new Product { Id = 3, Name = "John Updated", Price = 8908 };

            // Act
            _productRepository.Update(updateProduct);
            var result = _productRepository.GetById(3);

            // Assert
            Assert.NotNull(result); // Check that the user was found
            Assert.Equal(updateProduct.Name, result.Name); // Check that the name was updated
            Assert.Equal(updateProduct.Price, result.Price); // Check that the email was updated
            
        }
    }
}
