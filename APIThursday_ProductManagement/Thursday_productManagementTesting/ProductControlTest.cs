using FluentAssertions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Moq;
using System.Net;
using System.Net.Http.Json;
using System.Net.NetworkInformation;
using Thursday_ProductManagement.DataAccess;
using Thursday_ProductManagement.Managers.DTO;
using Thursday_ProductManagement.Services;

namespace Thursday_productManagementTesting
{
    public class ProductControlTest : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly HttpClient _client;
        private readonly Mock<IProductService> _productServiceMock;
            public ProductControlTest(WebApplicationFactory<Program> factory)
            {
                _productServiceMock = new Mock<IProductService>();
                _client = factory.WithWebHostBuilder(builder =>
                {
                    builder.ConfigureServices(services =>
                    {
                        var descriptor = services.SingleOrDefault(d => d.ServiceType == typeof(IProductService));
                        if (descriptor != null)
                        {
                            services.Remove(descriptor);
                        }
                       
                        services.AddSingleton(_productServiceMock.Object);
                    });
                }).CreateClient();
            }

        [Fact]
        public async Task Get_All_Products_Should_Return_Ok_With_Product_List()
        {
            var dummyProducts = new List<Product>
            {
                new() {Id = 1, Name = "Product 1", Price = 200},
                new() {Id = 2, Name = "Product 2", Price = 300}
            };
            _productServiceMock.Setup(s => s.GetAlltheProducts()).Returns(dummyProducts);

            var response = await _client.GetAsync("api/Product/Get-All-Products");

            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var products = await response.Content.ReadFromJsonAsync<List<Product>>();
            products.Should().HaveCount(2); 

        }

        [Fact]
        public async Task Create_Products_Return_Created_Response()
        {
            var newProduct = new ProductDto { Name = "New Product", Price = 150 };

            _productServiceMock.Setup(s => s.CreateNewProduct(It.IsAny<ProductDto>())).Returns(true);

            var response = await _client.PostAsJsonAsync("api/Product/Create-Product",newProduct);

            response.StatusCode.Should().Be(HttpStatusCode.Created);
            var responseContent = await response.Content.ReadAsStringAsync();
            responseContent.Should().Contain("Product Created Succesfuly");
        }
     

        [Fact]
        public async Task Delete_Product_Should_Return_NoContent_When_Product_Exists()
        {
            //Arrange
            _productServiceMock.Setup(s => s.DeleteProduct(It.IsAny<int>())).Returns(true);

            //Act
            var response = await _client.DeleteAsync("/api/Product/Delete-Product-By-Id/1");

            //Assert
            response.StatusCode.Should().Be(HttpStatusCode.NoContent);
        }
        
        [Fact]
        public async Task Delete_Product_should_Return_NotFound_When_Product_does_Not_exists()
        {
            _productServiceMock.Setup(s => s.DeleteProduct(It.IsAny<int>())).Returns(false);

            var response = await _client.DeleteAsync("/api/Product/Delete-Product-By-Id/999");

            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }
    }
}

