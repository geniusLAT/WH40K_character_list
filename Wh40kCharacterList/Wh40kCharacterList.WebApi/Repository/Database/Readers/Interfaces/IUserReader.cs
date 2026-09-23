using Npgsql;
using Dapper;
using Wh40kCharacterList.Core.AdministrativeEntities;

namespace Wh40kCharacterList.WebApi.Repository.Database.Readers.Interfaces;

public interface IUserReader 
{
    Task<UserEntity?> GetUserByIdAsync(long id, CancellationToken cancellationToken = default);

    Task<UserEntity?> GetUserByTokenAsync(string token, CancellationToken cancellationToken = default);

    Task<UserEntity?> GetUserByLoginAsync(string login, CancellationToken cancellationToken = default);

    Task<UserEntity?> GetAdminAsync(CancellationToken cancellationToken = default);

    Task<IEnumerable<UserEntity>> GetUsersAsync(int limit, int offset, CancellationToken cancellationToken = default);
}
