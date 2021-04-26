using System.Collections.Generic;

using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

using FluentAssertions;
using FluentAssertions.Execution;
using FakeItEasy;
using Xunit;

using PlanningBoard.Api.Interfaces;
using PlanningBoard.Api.Controllers;
using PlanningBoard.Api.Data.Models;


namespace PlanningBoard.Api.Tests
{
    public class UsersControllerUnitTest
    {
        private IUserService _userService = A.Fake<IUserService>();
        private ILogger<UsersController> _fakeLogger = A.Fake<ILogger<UsersController>>();

        [Fact]
        public async void ReturnOk_WhenDataExists()
        {
            // Arrange
            var controller = new UsersController(_fakeLogger, _userService);
            var fakeUser1 = A.Fake<UserView>();
            var fakeUser2 = A.Fake<UserView>();
            A.CallTo(() => _userService.GetUsersAsync()).Returns(new List<UserView>{ fakeUser1, fakeUser2 });

            // Act
            var result = await controller.GetUsers() as ObjectResult;

            // Assert
            using (new AssertionScope())
            {
                result.StatusCode.Should().Be(StatusCodes.Status200OK);
                (result.Value as IEnumerable<UserView>).Should().NotBeEmpty().And.HaveCount(2);
            }
        }
    }
}
