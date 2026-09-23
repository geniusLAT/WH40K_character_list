using Microsoft.AspNetCore.Authentication;

public static class AuthenticationExtensions
{
    public static IServiceCollection AddCustomBearerAuthentication(this IServiceCollection services)
    {
        services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = BearerAuthHandler.SchemeName;
            options.DefaultChallengeScheme = BearerAuthHandler.SchemeName;
        })
        .AddScheme<AuthenticationSchemeOptions, BearerAuthHandler>(
            BearerAuthHandler.SchemeName, null);

        return services;
    }
}