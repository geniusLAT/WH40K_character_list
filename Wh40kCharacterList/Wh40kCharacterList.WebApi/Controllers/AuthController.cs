using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Wh40kCharacterList.Core.NetworkDtos;
using Wh40kCharacterList.WebApi.Repository.Database.Readers.Interfaces;
using Wh40kCharacterList.WebApi.Repository.Database.Writers.Interfaces;
using Wh40kCharacterList.WebApi.Services;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{

    private readonly AuthService _authService;

    public AuthController(
        AuthService authService,
        IUserReader userReader)
    {
       
        _authService = authService;
    }

    [AllowAnonymous]
    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequest request)
    {
        var updatedUser = await _authService.Login(request);
        if (updatedUser is null)
        {
            return Unauthorized(new { message = "Invalid" });
        }

        return Ok(updatedUser);
    }
}
