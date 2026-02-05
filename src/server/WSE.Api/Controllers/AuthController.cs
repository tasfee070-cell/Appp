using Microsoft.AspNetCore.Mvc;
using WSE.Domain;

namespace WSE.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    [HttpPost("register")]
    public IActionResult Register([FromBody] User user)
    {
        // Placeholder for registration logic
        return Ok(new { message = "User registered successfully", user.Username });
    }

    [HttpPost("login")]
    public IActionResult Login([Selection] string email, string password)
    {
        // Placeholder for JWT token generation logic
        return Ok(new { token = "fake-jwt-token-for-testing" });
    }
}
