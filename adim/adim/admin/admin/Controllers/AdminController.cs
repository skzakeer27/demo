using admin.bal;
using admin.context;
using admin.model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IUserService _userService;

        public AdminController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] admins request)
        {
            var user = _userService.AuthenticateUser(request.username, request.password);

            if (user != null)
            {
                // Authentication successful, you can generate a token here
                return Ok(new { Message = "Login successful"});
            }

            return Unauthorized(new { Message = "Invalid credentials" });
        }
    }
    }
