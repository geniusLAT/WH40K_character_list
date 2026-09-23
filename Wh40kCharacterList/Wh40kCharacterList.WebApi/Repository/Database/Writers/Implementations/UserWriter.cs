using Dapper;
using Npgsql;
using Wh40kCharacterList.Core.AdministrativeEntities;
using Wh40kCharacterList.Core.AdministrativeEntities.DtosToSave;
using Wh40kCharacterList.WebApi.Repository.Database.Writers.Interfaces;

namespace Wh40kCharacterList.WebApi.Repository.Database.Writers.Implementations;

public sealed class UserWriter : IUserWriter
{
    private readonly NpgsqlDataSource _dataSource;
    private readonly ILogger<UserWriter> _logger;

    public UserWriter(
        NpgsqlDataSource dataSource,
        ILogger<UserWriter> logger)
    {
        _dataSource = dataSource;
        _logger = logger;
    }

    public async Task<UserEntity> SaveUserAsync(UserToSaveDto userToSave)
    {

        var parameters = new DynamicParameters();

        const string sql = """
                            INSERT INTO public.user_tbl (
                                name,
                                admin,
                                password,
                                last_token
                                ) 
                            VALUES (
                                @name,
                                @admin,
                                @password,
                                @last_token) 
                            RETURNING 
                                id AS Id,
                                name AS Name,
                                admin AS Admin,
                                password AS Password,
                                last_token AS LastToken,
                                creation_date AS CreationDate,
                                last_update AS LastUpdate
                            """;

        parameters.Add("@name", userToSave.Name);
        parameters.Add("@admin", userToSave.Admin);
        parameters.Add("@password", userToSave.Password);
        parameters.Add("@last_token", userToSave.LastToken);
       
        try
        {
            await using var connection = await _dataSource.OpenConnectionAsync();
            var result = await connection.QuerySingleAsync<UserEntity>(sql, parameters);
            _logger.LogInformation($"AnswerEntity saved to PostgreSQL");
            return result;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.Message);
            throw;
        }
    }


    public async Task<UserEntity> UpdateUserAsync(UserEntity user)
    {

        var parameters = new DynamicParameters();

        const string sql = """
                            UPDATE public.user_tbl 
                            SET
                                name = @name,
                                admin = @admin,
                                password = @password,
                                last_token = @last_token,
                                last_update = CURRENT_TIMESTAMP
                            WHERE 
                                id = @id
                            RETURNING 
                                id AS Id,
                                name AS Name,
                                admin AS Admin,
                                password AS Password,
                                last_token AS LastToken,
                                creation_date AS CreationDate,
                                last_update AS LastUpdate
                            """;

        parameters.Add("@id", user.Id);
        parameters.Add("@name", user.Name);
        parameters.Add("@admin", user.Admin);
        parameters.Add("@password", user.Password);
        parameters.Add("@last_token", user.LastToken);

        try
        {
            await using var connection = await _dataSource.OpenConnectionAsync();
            var result = await connection.QuerySingleAsync<UserEntity>(sql, parameters);
            _logger.LogInformation($"AnswerEntity saved to PostgreSQL");
            return result;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.Message);
            throw;
        }
    }
}
