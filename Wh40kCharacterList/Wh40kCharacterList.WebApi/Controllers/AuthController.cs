using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Wh40kCharacterList.Core.NetworkDtos;
using Wh40kCharacterList.WebApi.Repository.Database.Readers.Interfaces;
using Wh40kCharacterList.WebApi.Repository.Database.Writers.Interfaces;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly TokenService _tokenService;

    private readonly IUserReader _userReader;

    private readonly IUserWriter _userWriter;

    public AuthController(
        TokenService tokenService,
        IUserReader userReader,
        IUserWriter userWriter)
    {
        _userReader = userReader;
        _userWriter = userWriter;
        _tokenService = tokenService;
    }

    [AllowAnonymous]
    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequest request)
    {
        var user =await _userReader.GetUserByLoginAsync(request.UserName);
        if (user is null || request.Password != user.Password)
        {
            return Unauthorized(new { message = "Invalid" });
        }

        var token = _tokenService.GenerateToken(
            userId: "user-42",
            userName: request.UserName,
            role: "Admin",
            lifetime: TimeSpan.FromDays(400)
        );

        user.LastToken = token;
        var updatedUser = await _userWriter.UpdateUserAsync(user);

        return Ok(new
        {
            access_token = token,
            token_type = "Bearer",
            expires_in = TimeSpan.FromDays(400).TotalSeconds,
            User = updatedUser
        });
    }
}
