using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UsersAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccessController : ControllerBase
    {
        /// <summary>
        /// Validates the user's minimum age according to the JWT token.
        /// </summary>
        /// <returns>IActionResult</returns>
        /// <response code="404">If there is an error validating the JWT token.</response>
        /// <response code="200">User logged in successfully.</response>
        [HttpGet]
        [Authorize(Policy = "MinimumAge")]
        public IActionResult Get()
        {
            return Ok("Access allowed");
        }
    }
}
