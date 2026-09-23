using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Wh40kCharacterList.Core.AdministrativeEntities;
using Wh40kCharacterList.Core.AdministrativeEntities.DtosToSave;
using Wh40kCharacterList.WebApi.Services;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly UserService _userService;
    public UserController(UserService userService)
    {
        _userService = userService;
    }

    [HttpPost("add-user")]
    [ProducesResponseType(typeof(UserEntity), StatusCodes.Status200OK)]
    public async Task<IActionResult> AddUser([FromBody] UserToSaveDto user)
    {
        bool isAdmin = User.IsInRole("Admin");
        if (!isAdmin)
        {
            return Forbid();
        }
        var createdUser = await _userService.AddUser(user);
        if (createdUser == null)
        {
            return BadRequest("Already exist");
        }
        return Ok(createdUser);
    }

    [HttpGet("users")]
    [ProducesResponseType(typeof(List<UserEntity>), StatusCodes.Status200OK)]
    public async Task<IActionResult> AddUser([FromQuery] int limit, [FromQuery] int offset)
    {
        bool isAdmin = User.IsInRole("Admin");
        if (!isAdmin)
        {
            return Forbid();
        }
        var users = await _userService.GetUsers(limit, offset);
        return Ok(users);
    }
}
