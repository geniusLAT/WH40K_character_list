using Microsoft.AspNetCore.Mvc;
using Wh40kCharacterList.Core.NetworkDtos;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly TokenService _tokenService;

    public AuthController(TokenService tokenService)
    {
        _tokenService = tokenService;
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginRequest request)
    {
        if (request.UserName != "admin" || request.Password != "password123")
        {
            return Unauthorized(new { message = "Invalid" });
        }
        
        var token = _tokenService.GenerateToken(
            userId: "user-42",
            userName: request.UserName,
            role: "Admin",
            lifetime: TimeSpan.FromDays(400)
        );

        return Ok(new
        {
            access_token = token,
            token_type = "Bearer",
            expires_in = TimeSpan.FromDays(400).TotalSeconds
        });
    }
}
