using AutoMapper;
using Microsoft.Extensions.Logging;
using Moq;
using Thursday_ProductManagement.DataAccess;
using Thursday_ProductManagement.DataAccess.Repositories;
using Thursday_ProductManagement.Managers;
using Thursday_ProductManagement.Managers.DTO;

namespace Thursday_ProductManagement.xUnitTesting
{
    public class ProductManagerTest
    {
        private readonly Mock<IRepository<Product>> _mockRepository;
        private readonly Mock<IMapper> _mockMapper;
        private readonly Mock<ILogger<ProductManager>> _mockLogger;
        private readonly ProductManager _productManager;


        public ProductManagerTest()
        {
            _mockRepository = new Mock<IRepository<Product>>();
            _mockMapper = new Mock<IMapper>();
            _mockLogger = new Mock<ILogger<ProductManager>>();

            _productManager = new ProductManager(_mockRepository.Object, _mockMapper.Object, _mockLogger.Object);
        }

        [Fact]
        public void Create_ShouldReturnTrue_WhenProductIsCreatedSuccessfully()
        {
            // Arrange
            var productDto = new ProductDto { Name = "Test Product", Price = 100 };
            var product = new Product { Name = "Test Product", Price = 100 };

            _mockMapper.Setup(m => m.Map<Product>(productDto)).Returns(product);
            _mockRepository.Setup(repo => repo.Create(product)).Returns(true);

            // Act
            var result = _productManager.Create(productDto);

            // Assert
            Assert.True(result);
        }

      
        [Fact]
        public void Create_ShouldReturnFalse_WhenProductCreationFails()
        {
            // Arrange
            var productDto = new ProductDto { Name = "Test Product", Price = 100 };
            var product = new Product { Name = "Test Product", Price = 100 };

            _mockMapper.Setup(m => m.Map<Product>(productDto)).Returns(product);
            _mockRepository.Setup(repo => repo.Create(product)).Returns(false);

            // Act
            var result = _productManager.Create(productDto);

            // Assert
            Assert.False(result);
        }


        [Fact]
        public void GetAll_ShouldReturnListOfProducts()
        {
            // Arrange
            var products = new List<Product>
            {
            new Product { Name = "Product1", Price = 100 },
            new Product { Name = "Product2", Price = 200 }
            };

            _mockRepository.Setup(repo => repo.GetAll()).Returns(products);
            _mockMapper.Setup(m => m.Map<IEnumerable<Product>>(products)).Returns(products);

            // Act
            var result = _productManager.GetAll();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count());
        }
        [Fact]
        public void GetById_ShouldReturnProductDto_WhenProductExists()
        {
            // Arrange
            var product = new Product { Id = 1, Name = "Product1", Price = 100 };
            var productDto = new ProductDto { Name = "Product1", Price = 100 };

            _mockRepository.Setup(repo => repo.GetById(1)).Returns(product);
            _mockMapper.Setup(m => m.Map<ProductDto>(product)).Returns(productDto);

            // Act
            var result = _productManager.GetById(1);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Product1", result.Name);
        }

        
        [Fact]
        public void GetById_ShouldReturnNull_WhenProductDoesNotExist()
        {
            // Arrange
            _mockRepository.Setup(repo => repo.GetById(1)).Returns((Product)null!);

            // Act
            var result = _productManager.GetById(1);

            // Assert
            Assert.Null(result);
        }

     
        [Fact]
        public void Update_ShouldReturnTrue_WhenProductIsUpdatedSuccessfully()
        {
            // Arrange
            var productDto = new ProductDto { Name = "Updated Product", Price = 150 };
            var existingProduct = new Product { Id = 1, Name = "Product1", Price = 100 };

            _mockRepository.Setup(repo => repo.GetById(1)).Returns(existingProduct);
            _mockMapper.Setup(m => m.Map(productDto, existingProduct)).Returns(existingProduct);
            _mockRepository.Setup(repo => repo.Update(existingProduct)).Returns(true);

            // Act
            var result = _productManager.Update(1, productDto);

            // Assert
            Assert.True(result);
        }

        
        [Fact]
        public void Update_ShouldReturnFalse_WhenProductDoesNotExist()
        {
            // Arrange
            var productDto = new ProductDto { Name = "Updated Product", Price = 150 };

            _mockRepository.Setup(repo => repo.GetById(1)).Returns((Product)null);

            // Act
            var result = _productManager.Update(1, productDto);

            // Assert
            Assert.False(result);
        }

      
        [Fact]
        public void Delete_ShouldReturnTrue_WhenProductIsDeletedSuccessfully()
        {
            // Arrange
            _mockRepository.Setup(repo => repo.Delete(1)).Returns(true);

            // Act
            var result = _productManager.Delete(1);

            // Assert
            Assert.True(result);
        }

       
        [Fact]
        public void Delete_ShouldReturnFalse_WhenProductDeletionFails()
        {
            // Arrange
            _mockRepository.Setup(repo => repo.Delete(1)).Returns(false);

            // Act
            var result = _productManager.Delete(1);

            // Assert
            Assert.False(result);
        }


    }
}

        
