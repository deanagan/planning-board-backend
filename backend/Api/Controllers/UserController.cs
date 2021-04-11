using System;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Api.Interfaces;
using Api.Data.Models;


namespace Api.Controllers
{
    [ApiController]
    [Route("v1/api")]
    public class UserController : ControllerBase
    {
        private IUserService _userService;
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        [HttpGet("[action]")]
        public IActionResult Users()
        {
            try
            {
                var result = _userService.GetUsers();
                if (result == null)
                {
                    return NoContent();
                }

                return Ok(result);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpGet("[action]/{id}")]
        public IActionResult Users(int id)
        {
            try
            {
                var result = _userService.GetUser(id);
                if (result == null)
                {
                    return NoContent();
                }
                return Ok(result);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("[action]")]
        public IActionResult Users(User user)
        {
            if (user != null)
            {
                try
                {
                    _userService.CreateUser(user);
                    return CreatedAtAction(nameof(Users), new { Id = user.Id }, _userService.GetUser(user.Id));
                }
                catch(Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }

            return BadRequest("user creation failed.");
        }

        [HttpPut("[action]/{id}")]
        public IActionResult Users(int id, User user)
        {
            if (user != null)
            {
                try
                {
                    user.Id = id;
                    if (_userService.UpdateUser(user))
                    {
                        return NoContent();
                    }
                    else
                    {
                        return BadRequest($"User with {id} not found.");
                    }
                }
                catch(Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }

            return BadRequest("User is null");

        }
    }
}
