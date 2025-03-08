using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Contact_Management.WebApi;

namespace Contact_Management.Testing
{
    public class WeatherCastControllerTest : IClassFixture<WebApplicationFactory<Program>>
    {
            private readonly HttpClient _client;

            public WeatherCastControllerTest(WebApplicationFactory<Program> factory)
            {
                _client = factory.CreateClient();
            }

            [Fact]
            public async Task GetWeatherForecast_ReturnsSuccessStatusCode()
            {
                // Act
                var response = await _client.GetAsync("/WeatherForecast");

                // Assert
                Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            }

            [Fact]
            public async Task GetWeatherForecast_ReturnsNonEmptyList()
            {
                // Act
                var response = await _client.GetAsync("/WeatherForecast");
                response.EnsureSuccessStatusCode();
                var forecasts = await response.Content.ReadFromJsonAsync<List<WeatherForecast>>();

                // Assert
                Assert.NotNull(forecasts);
                Assert.NotEmpty(forecasts);
                Assert.Equal(5, forecasts.Count);
            }
      
    }
}

