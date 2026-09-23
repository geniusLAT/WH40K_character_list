using System.Security.Claims;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;
using Wh40kCharacterList.WebApi.Repository.Database.Readers.Interfaces;

public class BearerAuthHandler : AuthenticationHandler<AuthenticationSchemeOptions>
{
    public const string SchemeName = "CustomBearer";

    private readonly IUserReader _userReader;

    public BearerAuthHandler(
        IOptionsMonitor<AuthenticationSchemeOptions> options,
        ILoggerFactory logger,
        UrlEncoder encoder,
        IUserReader userReader)
        : base(options, logger, encoder)
    {
        _userReader = userReader;
    }

    protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
    {
        if (!Request.Headers.TryGetValue("Authorization", out var authHeaderValues))
        {
            return AuthenticateResult.NoResult();
        }

        var authHeader = authHeaderValues.ToString();

        if (!authHeader.StartsWith("Bearer ", StringComparison.OrdinalIgnoreCase))
        {
            return AuthenticateResult.NoResult();
        }

        var token = authHeader["Bearer ".Length..].Trim();

        var (isValid, userId, role) = await ValidateTokenAsync(token);

        if (!isValid)
        {
            return AuthenticateResult.Fail("Expired or invalid");
        }

        var claims = new[]
        {
            new Claim(ClaimTypes.NameIdentifier, userId!),
            new Claim(ClaimTypes.Role, role ?? "User")
        };

        var identity = new ClaimsIdentity(claims, SchemeName);
        var principal = new ClaimsPrincipal(identity);
        var ticket = new AuthenticationTicket(principal, SchemeName);

        return AuthenticateResult.Success(ticket);
    }

    private async Task<(bool IsValid, string? UserId, string? Role)> ValidateTokenAsync(string token)
    {
        var user = await _userReader.GetUserByTokenAsync(token);

        if (user is not null)
        {
            string? role = user.Admin ? "Admin" : "CommonUser";
            return await Task.FromResult((true, (string?)user.Name, role));
        }

        return await Task.FromResult((false, (string?)null, (string?)null));
    }
}