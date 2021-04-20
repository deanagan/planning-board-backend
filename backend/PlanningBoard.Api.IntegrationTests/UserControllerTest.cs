using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;
using Xunit;
using FluentAssertions;
using FluentAssertions.Execution;

using Microsoft.AspNetCore.Hosting;

using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.TestHost;
using System;


namespace PlanningBoard.Api.IntegrationTests
{
    public class UserControllerIntegrationTest : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly HttpClient _client;

        public UserControllerIntegrationTest(WebApplicationFactory<Startup> factory)
        {
            _client = factory.CreateDefaultClient();
        }

        [Fact]
        public async Task ShouldReturnOk_WhenGettingAllUsers()
        {
            var response = await _client.GetAsync("/v1/api/users");

            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task ShouldReturnExpectedMediaType_WhenGettingAllUsers()
        {
            var response = await _client.GetAsync("/v1/api/users");

            response.Content.Headers.ContentType.MediaType.Should().Be("application/json");
        }

        [Fact]
        public async Task ShouldReturnExpectedContent_WhenGettingAllUsers()
        {
            var response = await _client.GetAsync("/v1/api/users");

            using (new AssertionScope())
            {
                response.Content.Should().NotBeNull();
                response.Content.Headers.ContentLength.Should().BeGreaterThan(0);
            }
        }

        [Fact(Skip = "Skip for now")]
        public async void ReturnOk_WhenDoingGetUser()
        {
            // Act
            var result = await _client.GetAsync("/v1/api/users/1");

            // Assert
            result.StatusCode.Should().Be(HttpStatusCode.OK);
        }

    }
}
