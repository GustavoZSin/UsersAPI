using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UsersAPI.Data.Dtos;
using UsersAPI.Models;
using UsersAPI.Services;

namespace UsersAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private UserService _userService;
        public UserController(UserService registerService)
        {
            this._userService = registerService;
        }

        /// <summary>
        /// Adds a new user to the database.
        /// </summary>
        /// <param name="userDto">Object with necessary fields to create a user.</param>
        /// <returns>IActionResult</returns>
        /// <response code="400">If an error occurs during the registration process.</response>
        /// <response code="200">User successfully registered.</response>
        [HttpPost("register")]
        public async Task<IActionResult> AddUser([FromBody] CreateUserDto userDto)
        {
            await _userService.RegisterAsync(userDto);
            return Ok("The user has been registered successfully");
        }

        /// <summary>
        /// Logs in to the API and returns a JWT token.
        /// </summary>
        /// <param name="loginDto">Object with necessary fields to realize login.</param>
        /// <returns>IActionResult</returns>
        /// <response code="200">User successfully logged.</response>
        [HttpPost("login")]
        public async Task<IActionResult> LoginAsync(LoginUserDto loginDto)
        {
            var token = await _userService.LoginAsync(loginDto);
            return Ok(token);
        }
    }
}
