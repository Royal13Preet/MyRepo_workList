using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Moq;
using Thursday_ProductManagement.DataAccess;
using Thursday_ProductManagement.Managers.DTO;
using Thursday_ProductManagement.Services;
using Thursday_ProductManagement.WebApi.Controllers;

namespace Thursday_ProductManagement.Tests
{
    public class ProductControllerTests

    {

        private readonly Mock<IProductService> _mockProductService;
        private readonly Mock<IMemoryCache> _mockMemoryCache;
        private readonly ProductController _controller;
        private readonly Mock<HttpContext> _mockHttpContext;
        private readonly Mock<ISession> _mockSession;
        private readonly Mock<IResponseCookies> _mockResponseCookies;



        public ProductControllerTests()
        {

            _mockProductService = new Mock<IProductService>();
            _mockMemoryCache = new Mock<IMemoryCache>();

            // Mock HttpContext, Session, and Cookies
            _mockHttpContext = new Mock<HttpContext>();
            _mockSession = new Mock<ISession>();
            _mockResponseCookies = new Mock<IResponseCookies>();

            _mockHttpContext.Setup(ctx => ctx.Session).Returns(_mockSession.Object);
            _mockHttpContext.Setup(ctx => ctx.Response.Cookies).Returns(_mockResponseCookies.Object);

            _controller = new ProductController(_mockProductService.Object, _mockMemoryCache.Object)
            {
                ControllerContext = new ControllerContext
                {
                    HttpContext = _mockHttpContext.Object
                }
            };
        }

        [Fact]
        public void Get_ReturnsOkResult_WhenProductsExistInCache()
        {
            var products = new List<Product>
        {
            new Product {Id = 1, Name = "Product1", Price = 100 },
            new Product {Id = 2, Name = "Product2", Price = 200 }
        };
            object cachedProducts = products;
            _mockMemoryCache.Setup(mc => mc.TryGetValue("AllProducts", out cachedProducts)).Returns(true);

            var result = _controller.Get();

            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnValue = Assert.IsAssignableFrom<IEnumerable<Product>>(okResult.Value);
            Assert.Equal(2, returnValue.Count());

            ////// Verify that session and cookies are being set
            //_mockSession.Verify(s => s.SetString("ProductFetched", It.IsAny<string>()), Times.Once);
            //_mockResponseCookies.Verify(c => c.Append("ProductFetched", It.IsAny<string>(), It.IsAny<CookieOptions>()), Times.Once);
        }



        [Fact]
        public void Get_ReturnsOkResult_WhenProductsAreFetchedFromService()
        {
            var products = new List<Product>
            {
            new Product {  Id =1,Name = "Product1", Price = 100 },
            new Product { Id =2, Name = "Product2", Price = 200 }
            };
            _mockProductService.Setup(service => service.GetAlltheProducts()).Returns(products);
            var memoryCache = new MemoryCache(new MemoryCacheOptions());
            var controller = new ProductController(_mockProductService.Object, memoryCache);


            var result = controller.Get();

            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnValue = Assert.IsAssignableFrom<IEnumerable<Product>>(okResult.Value);
            Assert.Equal(products.Count, returnValue.Count());

            //_mockSession.Verify(s => s.SetString("ProductFetched", It.IsAny<string>()), Times.Once);
            //_mockResponseCookies.Verify(c => c.Append("ProductFetched", It.IsAny<string>(), It.IsAny<CookieOptions>()), Times.Once);
        }

        [Fact]
        public void Create_ReturnsStatusCode201_WhenProductIsCreatedSuccessfully()
        {
            // Arrange
            var productDto = new ProductDto { Name = "Product1", Price = 100 };

            _mockProductService.Setup(service => service.CreateNewProduct(productDto)).Returns(true);

            // Act
            var result = _controller.Create(productDto);

            // Assert
            var createdResult = Assert.IsType<CreatedResult>(result);
            Assert.Equal(201, createdResult.StatusCode);

            //// Verify that session and cookies are being set
            //_mockSession.Verify(s => s.SetString("LastCreatedTimestamp", It.IsAny<string>()), Times.Once);
            //_mockResponseCookies.Verify(c => c.Append("ProductCreated", "Product Created Successfully", It.IsAny<CookieOptions>()), Times.Once);
        }


        [Fact]
        public void Update_ReturnsOkResult_WhenProductIsUpdatedSuccessfully()
        {
            var product = new ProductDto { Name = "Updated Product", Price = 150 };
            _mockProductService.Setup(service => service.UpdateProduct(1, product)).Returns(true);

            var result = _controller.Update(1, product);

            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.Equal("Product updated successfully.", okResult.Value);
        }


        [Fact]
        public void Update_ReturnsNotFound_WhenProductDoesNotExist()
        {
            var product = new ProductDto { Name = "Updated Product", Price = 150 };
            _mockProductService.Setup(service => service.UpdateProduct(1, product)).Returns(false);

            var result = _controller.Update(1, product);

            var notFoundResult = Assert.IsType<NotFoundObjectResult>(result);
            Assert.Equal("Product with this ID 1 is not found", notFoundResult.Value);
        }

        [Fact]
        public void Delete_ReturnsNoContent_WhenProductIsDeletedSuccessfully()
        {
            _mockProductService.Setup(service => service.DeleteProduct(1)).Returns(true);

            var result = _controller.Delete(1);

            Assert.IsType<NoContentResult>(result);
        }

        [Fact]
        public void Delete_ReturnsNotFound_WhenProductDoesNotExist()
        {
            _mockProductService.Setup(service => service.DeleteProduct(1)).Returns(false);

            var result = _controller.Delete(1);

            var notFoundResult = Assert.IsType<NotFoundObjectResult>(result);
            Assert.Equal("Product with ID 1 not found", notFoundResult.Value);
        }
    }

}

