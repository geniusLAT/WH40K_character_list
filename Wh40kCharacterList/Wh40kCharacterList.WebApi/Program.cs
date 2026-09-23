using FluentMigrator.Runner;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi;
using Npgsql;
using Wh40kCharacterList.WebApi.Configs;
using Wh40kCharacterList.WebApi.Migrations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();


builder.Services
    .AddOptions<DbConfig>()
    .Bind(builder.Configuration.GetSection("DatabaseConnection"))
    .Validate(
        config => !string.IsNullOrWhiteSpace(config.ConnectionString),
        "Database connection string is not configured.")
    .Validate(
        config => !string.IsNullOrWhiteSpace(config.DatabaseName),
        "Database name is not configured.")
    .ValidateOnStart();

builder.Services.AddSingleton<NpgsqlDataSource>(serviceProvider =>
{
    var dbConfig = serviceProvider.GetRequiredService<IOptions<DbConfig>>().Value;
    var dataSourceBuilder = new NpgsqlDataSourceBuilder(dbConfig.CreateConnectionString());

    dataSourceBuilder.UseLoggerFactory(
        serviceProvider.GetRequiredService<ILoggerFactory>());

    return dataSourceBuilder.Build();
});

builder.Services
    .AddFluentMigratorCore()
    .ConfigureRunner(runner => runner
        .AddPostgres()
        .WithGlobalConnectionString(serviceProvider =>
            serviceProvider
                .GetRequiredService<IOptions<DbConfig>>()
                .Value
                .CreateConnectionString())
        .ScanIn(typeof(Initial).Assembly).For.Migrations());


builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "My API",
        Version = "v1"
    });

    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "Введите ваш JWT токен"
    });

    options.AddSecurityRequirement(document => new OpenApiSecurityRequirement
    {
        [new OpenApiSecuritySchemeReference("Bearer", document)] = []
    });
});

builder.Services.AddCustomBearerAuthentication();
builder.Services.AddSingleton<TokenService>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var migrationRunner = scope.ServiceProvider.GetRequiredService<IMigrationRunner>();
    migrationRunner.MigrateUp();
}


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "My API v1");
        options.RoutePrefix = string.Empty;
    });
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();