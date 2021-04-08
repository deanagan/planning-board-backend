using System;

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

        // // TODO: async-await eventually
        // [HttpPost("[action]")]
        // public IActionResult Users(User user)
        // {
        //     if (user != null)
        //     {
        //         try
        //         {
        //             _userService.CreateUser(user);
        //             return CreatedAtAction(nameof(user), new { id = 1 }, user);
        //         }
        //         catch(Exception ex)
        //         {
        //             return BadRequest(ex.Message);
        //         }
        //     }

        //     return BadRequest("user creation failed.");

        // }
    }
}
