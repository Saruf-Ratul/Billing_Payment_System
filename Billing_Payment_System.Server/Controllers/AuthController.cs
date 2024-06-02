using Billing_Payment_System.Server.Models;
using Billing_Payment_System.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace Billing_Payment_System.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _authService;

        public AuthController(AuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] User user)
        {
            var token = _authService.Authenticate(user.Username, user.Password);
            if (token == null)
                return Unauthorized();
            return Ok(new { Token = token });
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] User user)
        {
            _authService.Register(user);
            return Ok();
        }
    }

}
