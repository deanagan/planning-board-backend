using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;
using Xunit;
using FluentAssertions;
using Microsoft.AspNetCore.Hosting;

using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.TestHost;
using System;


namespace Api.Tests
{
    public class UserControllerIntegrationTest : BaseIntegrationTest
    {


        [Fact]
        public async Task ShouldReturnOk_WhenGettingAllUsers()
        {
            // Arrange

            // Act
            var result = await GetClient().GetAsync("/v1/api/users");

            if (result.IsSuccessStatusCode)
            {
                var response = await result.Content.ReadAsStringAsync();
            }
            // Assert
            result.StatusCode.Should().Be(HttpStatusCode.OK);

        }

        [Fact(Skip = "Skip for now")]
        public async void ReturnOk_WhenDoingGetUser()
        {
            // Act
            var result = await GetClient().GetAsync("/v1/api/users/1");

            // Assert
            result.StatusCode.Should().Be(HttpStatusCode.OK);
        }

    }
}
