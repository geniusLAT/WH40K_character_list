using Dapper;
using Npgsql;
using Wh40kCharacterList.Core.AdministrativeEntities;
using Wh40kCharacterList.WebApi.Repository.Database.Readers.Interfaces;

namespace BillingTeremokRouter.Infrastructure.Repository.Database.Readers.Implementations;

public sealed class UserReader  : IUserReader
{
    private readonly NpgsqlDataSource _dataSource;
    private readonly ILogger<UserReader> _logger;

    public UserReader(
        NpgsqlDataSource dataSource,
        ILogger<UserReader> logger)
    {
        _dataSource = dataSource;
        _logger = logger;
    }

    public async Task<UserEntity?> GetUserByIdAsync(
        long id,
        CancellationToken cancellationToken = default)
    {
        const string sql = """
                           SELECT id AS Id,
                                  name AS Name,
                                  admin AS Admin,
                                  password AS Password,
                                  last_token AS LastToken,
                                  creation_date AS CreationDate,
                                  last_update AS LastUpdate
                           FROM public.user_tbl
                           WHERE id = @id
                           """;

        try
        {
            await using var connection = await _dataSource.OpenConnectionAsync(cancellationToken);
            var command = new CommandDefinition(
                sql,
                new { id },
                cancellationToken: cancellationToken);

            return await connection.QuerySingleOrDefaultAsync<UserEntity>(command);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, "Failed to load UserEntity with id {id}", id);
            throw;
        }
    }

    public async Task<UserEntity?> GetUserByTokenAsync(
        string token,
        CancellationToken cancellationToken = default)
    {
        const string sql = """
                           SELECT id AS Id,
                                  name AS Name,
                                  admin AS Admin,
                                  password AS Password,
                                  last_token AS LastToken,
                                  creation_date AS CreationDate,
                                  last_update AS LastUpdate
                           FROM public.user_tbl
                           WHERE last_token = @token
                           """;

        try
        {
            await using var connection = await _dataSource.OpenConnectionAsync(cancellationToken);
            var command = new CommandDefinition(
                sql,
                new { token },
                cancellationToken: cancellationToken);

            return await connection.QuerySingleOrDefaultAsync<UserEntity>(command);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, "Failed to load UserEntity with id {token}", token);
            throw;
        }
    }

    public async Task<UserEntity?> GetUserByLoginAsync(
        string login,
        CancellationToken cancellationToken = default)
    {
        const string sql = """
                           SELECT id AS Id,
                                  name AS Name,
                                  admin AS Admin,
                                  password AS Password,
                                  last_token AS LastToken,
                                  creation_date AS CreationDate,
                                  last_update AS LastUpdate
                           FROM public.user_tbl
                           WHERE name = @login
                           """;

        try
        {
            await using var connection = await _dataSource.OpenConnectionAsync(cancellationToken);
            var command = new CommandDefinition(
                sql,
                new { login },
                cancellationToken: cancellationToken);

            return await connection.QuerySingleOrDefaultAsync<UserEntity>(command);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, "Failed to load UserEntity with id {login}", login);
            throw;
        }
    }

    public async Task<UserEntity?> GetAdminAsync(
        CancellationToken cancellationToken = default)
    {
        const string sql = """
                           SELECT id AS Id,
                                  name AS Name,
                                  admin AS Admin,
                                  password AS Password,
                                  last_token AS LastToken,
                                  creation_date AS CreationDate,
                                  last_update AS LastUpdate
                           FROM public.user_tbl
                           WHERE admin = TRUE
                           LIMIT 1
                           """;

        try
        {
            await using var connection = await _dataSource.OpenConnectionAsync(cancellationToken);
            var command = new CommandDefinition(
                sql,
                cancellationToken: cancellationToken);

            return await connection.QuerySingleOrDefaultAsync<UserEntity>(command);
        }
        catch (Exception exception)
        {
            throw;
        }
    }
}
