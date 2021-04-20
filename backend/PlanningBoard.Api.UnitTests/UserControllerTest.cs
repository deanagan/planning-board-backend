using System.Collections.Generic;

using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

using FluentAssertions;
using FluentAssertions.Execution;
using FakeItEasy;
using Xunit;
using Moq;

using PlanningBoard.Api.Interfaces;
using PlanningBoard.Api.Controllers;
using PlanningBoard.Api.Data.Models;


namespace PlanningBoard.Api.Tests
{
    public class UserControllerUnitTest
    {
        private IUserService _userService = Mock.Of<IUserService>();
        private ILogger<UserController> _fakeLogger = Mock.Of<ILogger<UserController>>();

        [Fact]
        public void ReturnOk_WhenDataExists()
        {

            // Arrange
            var controller = new UserController(_fakeLogger, _userService);
            Mock.Get(_userService).Setup(svc => svc.GetUsers())
                    .Returns(new List<UserView>{ A.Fake<UserView>(), A.Fake<UserView>() });

            // Act
            var result = controller.GetUsers() as ObjectResult;

            // Assert
            using (new AssertionScope())
            {
                result.StatusCode.Should().Be(StatusCodes.Status200OK);
                (result.Value as IEnumerable<UserView>).Should().NotBeEmpty().And.HaveCount(2);
            }
        }
    }
}
