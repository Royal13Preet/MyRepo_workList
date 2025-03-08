using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thursday_ProductManagement.DataAccess.Repositories;
using Thursday_ProductManagement.DataAccess;
using AutoMapper;
using Thursday_ProductManagement.Managers;
using Thursday_ProductManagement.Managers.DTO;

namespace Thursday_productManagementTesting
{
    public class ProductManTest
    {
        private readonly Mock<IRepository<Product>> _mockRepository;
        private readonly IMapper _mapper;
        private readonly Mock<ILogger<ProductManager>> _mockLogger;
        private readonly ProductManager _productManager;
            
        public ProductManTest()
        {
            _mockRepository = new Mock<IRepository<Product>>();
            _mockLogger = new Mock<ILogger<ProductManager>>();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Product, ProductDto>().ReverseMap();
            });

            _mapper = config.CreateMapper();
            _productManager = new ProductManager(_mockRepository.Object, _mapper, _mockLogger.Object);

        }

        [Fact]
        public void Create_Product_ShouldReturnTrue()
        {
            var productDto = new ProductDto { Name = "Pencil", Price = 89 };
            _mockRepository.Setup(r => r.Create(It.IsAny<Product>())).Returns(true);
            //Act
            var result = _productManager.Create(productDto);
            //Assert
            Assert.True(result);
            _mockRepository.Verify(r => r.Create(It.IsAny<Product>()), Times.Once);
        }
        [Fact]
        public void GetAll_ShouldReturnMappedProducts()
        {
            var product = new List<Product> { new Product { Id = 1, Name = "Test Product", Price = 34 } };
            _mockRepository.Setup(r => r.GetAll()).Returns(product);

            var result = _productManager.GetAll();

            Assert.NotNull(result);
            Assert.Single(result);
            _mockRepository.Verify(r => r.GetAll(), Times.Once);
        }
        [Fact]
        public void GetById_ProductExists_ShouldReturnMapped()
        {
            var product = new Product { Id = 1, Name = "Test Product", Price = 21 };
            _mockRepository.Setup(r => r.GetById(1)).Returns(product);

            var result = _productManager.GetById(1);

            Assert.NotNull(result);
            Assert.Equal(1, result.Id);
            Assert.Equal("Test Product", result.Name);
            Assert.Equal(21, result.Price);
        }
        [Fact]
        public void Update_ProductExists_ShouldReturnsTrue()
        {
            var product = new Product { Id = 1, Name = "old name", Price = 23 };
            var productdto = new ProductDto { Name = "New Name", Price = 34 };
            _mockRepository.Setup(r => r.GetById(1)).Returns(product);
            _mockRepository.Setup(r => r.Update(It.IsAny<Product>())).Returns(true);

            var result = _productManager.Update(1, productdto);

            Assert.True(result);
            _mockRepository.Verify(r => r.Update(It.IsAny<Product>()), Times.Once);
        }
        [Fact]
        public void Delete_ProductExists_shouldReturnstrue()
        {
            _mockRepository.Setup(r => r.Delete(1)).Returns(true);

            var result = _productManager.Delete(1);

            Assert.True(result);
            _mockRepository.Verify(r => r.Delete(1), Times.Once);
        }
        
    }
}    