using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Net;

namespace xUnitTesting.IntegrationTesting.Properties
{
    public class ManagingTest : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly HttpClient _client;

        public ManagingTest(WebApplicationFactory<Program> factory)
        {
            _client = factory.CreateDefaultClient();
        }
        [Fact]
        public async Task Get_Product_byId_Returns_product()
        {
            var response = await _client.GetAsync("api/Product/Get-By-ID?id=1");
            
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task Get_product_byId_Returns_()
        {
            var response = await _client.GetAsync("api/Product/Get-By-ID?id=1");
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
        








    }
}
