using Wh40kCharacterList.Core.AdministrativeEntities;
using Wh40kCharacterList.Core.AdministrativeEntities.DtosToSave;
using Wh40kCharacterList.WebApi.Repository.Database.Readers.Interfaces;
using Wh40kCharacterList.WebApi.Repository.Database.Writers.Interfaces;

namespace Wh40kCharacterList.WebApi.Services;

public class UserService
{
    private readonly IUserReader _userReader;

    private readonly IUserWriter _userWriter;

    public UserService(
        IUserWriter userWriter,
        IUserReader userReader)
    {
        _userReader = userReader;
        _userWriter = userWriter;
    }

    public async Task<UserEntity?> AddUser(UserToSaveDto userToSave)
    {
        var user = await _userReader.GetUserByLoginAsync(userToSave.Name);
        if (user is not null)
        {
            return null;
        }

        var savedUser = await _userWriter.SaveUserAsync(userToSave);

        return savedUser;
    }

    public async Task<IEnumerable<UserEntity>> GetUsers(int limit, int offset)
    {
        var users = await _userReader.GetUsersAsync(limit, offset);
        return users;
    }
}
