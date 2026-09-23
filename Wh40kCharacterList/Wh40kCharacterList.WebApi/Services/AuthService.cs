using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Wh40kCharacterList.Core.AdministrativeEntities;
using Wh40kCharacterList.Core.NetworkDtos;
using Wh40kCharacterList.WebApi.Repository.Database.Readers.Interfaces;
using Wh40kCharacterList.WebApi.Repository.Database.Writers.Interfaces;

namespace Wh40kCharacterList.WebApi.Services;

public class AuthService
{
    private readonly TokenService _tokenService;

    private readonly IUserWriter _userWriter;

    public AuthService(
        TokenService tokenService,
        IUserWriter userWriter)
    {
        _userWriter = userWriter;
        _tokenService = tokenService;
    }

    public async Task<AuthResultDto> Login(UserEntity user)
    {
        var token = _tokenService.GenerateToken(
            userId: user.Id.ToString(),
            userName: user.Name,
            role: user.Admin ? "Admin" : "CommonUser",
            lifetime: TimeSpan.FromDays(400)
        );

        user.LastToken = token;
        var updatedUser = await _userWriter.UpdateUserAsync(user);

        return new()
        {
            User = updatedUser
        };
    }
}
