using Contact_Management.DataAccess.Model;
using FluentAssertions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace Contact_Management.Testing
{
    public class ContactControllerTest : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly HttpClient _client;
        public ContactControllerTest(WebApplicationFactory<Program> factory)
        {
            
            _client = factory.WithWebHostBuilder(builder =>
                {
                    builder.UseSolutionRelativeContentRoot("..\\Contact_Management");
                }).CreateClient();

        }

        [Fact]
        public async Task GetContacts_ShouldReturnOk()
        {
            var response = await _client.GetAsync("/api/Contact");
            
           
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            //Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
        
        [Fact]
        public async Task CreateContact_ValidData_ShouldReturnCreated()
        {
            var contact = new Contact { Name = "John Doe", PhoneNumber = 1234567890, Email = "johndoe@example.com" };
            var content = new StringContent(JsonSerializer.Serialize(contact), Encoding.UTF8, "application/json");

            var response = await _client.PostAsync("/api/Contact", content);
            response.StatusCode.Should().Be(HttpStatusCode.Created);
            //Assert.Equal(HttpStatusCode.Created, response.StatusCode);
        }

        [Fact]
        public async Task CreateContact_InvalidData_ShouldReturnBadRequest()
        {
            var contact = new Contact { Name = "", PhoneNumber = 6689, Email = "invalidemail" };
            var content = new StringContent(JsonSerializer.Serialize(contact), Encoding.UTF8, "application/json");

            var response = await _client.PostAsync("/api/Contact", content);
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
            //Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }


        [Fact]
        public async Task GetContactById_ExistingContact_ShouldReturnOk()
        {
            var newContact = new Contact
            {
                Id = 1,
                Name = "Jan Doe",
                PhoneNumber = 98765210,
                Email = "jane@example.com"
            };
            var postResponse = await _client.PostAsJsonAsync("/api/Contact", newContact);

            var response = await _client.GetAsync("/api/Contact/1");
            
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            //Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

       
        
        [Fact]
        public async Task GetContactById_NonExistingContact_ShouldReturnNotFound()
        {
            var response = await _client.GetAsync("/api/Contact/999");

            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
            //Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }

   

        [Fact]
        public async Task UpdateContact_ValidData_ShouldReturnOk()
        {
            var newContact = new Contact
            {
                Name = "John Doe",
                PhoneNumber = 1234567890,
                Email = "johndoe@example.com"
            };

            var postResponse = await _client.PostAsJsonAsync("/api/Contact", newContact);
            postResponse.StatusCode.Should().Be(HttpStatusCode.Created);

            var createdContact = await postResponse.Content.ReadFromJsonAsync<Contact>();

            var updatedContact = new Contact
            {
                Id = createdContact!.Id,
                Name = "John Updated",
                PhoneNumber = 987654320,
                Email = "updated@example.com"
            };

            var putResponse = await _client.PutAsJsonAsync($"/api/Contact/{createdContact.Id}", updatedContact);
            putResponse.StatusCode.Should().Be(HttpStatusCode.OK);
            var responseMessage = await putResponse.Content.ReadAsStringAsync();
            responseMessage.Should().Be("Updated succefully");
        }


        [Fact]
        public async Task UpdateContact_NonExistingContact_ShouldReturnNotFound()
        {
            var contact = new Contact { Id = 999, Name = "Does Not Exist", PhoneNumber = 00000000, Email = "notfound@example.com" };
            var content = new StringContent(JsonSerializer.Serialize(contact), Encoding.UTF8, "application/json");

            var response = await _client.PutAsync("/api/contact/999", content);
            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
            //Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }

        [Fact]
        public async Task DeleteContact_ExistingContact_ShouldReturnNoContent()
        {
            var newContact = new Contact
            {
                Id =2,
                Name = "Jane Doe",
                PhoneNumber = 98765210,
                Email = "jane@example.com"
            };

            var postResponse = await _client.PostAsJsonAsync("/api/Contact", newContact);

            var response = await _client.DeleteAsync("/api/Contact/2");

            response.StatusCode.Should().Be(HttpStatusCode.NoContent);
            //Assert.Equal(HttpStatusCode.NoContent, response.StatusCode);
        }

        [Fact]
        public async Task DeleteContact_NonExistingContact_ShouldReturnNotFound()
        {
            var response = await _client.DeleteAsync("/api/Contact/999");

            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }
    }
}



    

    