using BillingTeremokRouter.Infrastructure.Repository.Database.Readers.Implementations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Wh40kCharacterList.Core.AdministrativeEntities;
using Wh40kCharacterList.Core.NetworkDtos;
using Wh40kCharacterList.WebApi.Repository.Database.Readers.Interfaces;
using Wh40kCharacterList.WebApi.Repository.Database.Writers.Interfaces;

namespace Wh40kCharacterList.WebApi.Services;

public class AuthService
{

    private readonly IUserReader _userReader;

    private readonly TokenService _tokenService;

    private readonly IUserWriter _userWriter;

    public AuthService(
        TokenService tokenService,
        IUserWriter userWriter,
        IUserReader userReader)
    {
        _userReader = userReader;
        _userWriter = userWriter;
        _tokenService = tokenService;
    }

    public async Task<AuthResultDto?> Login(LoginRequest request)
    {
        var user = await _userReader.GetUserByLoginAsync(request.UserName);
        if (user is null || request.Password != user.Password)
        {
            return null;
        }

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
