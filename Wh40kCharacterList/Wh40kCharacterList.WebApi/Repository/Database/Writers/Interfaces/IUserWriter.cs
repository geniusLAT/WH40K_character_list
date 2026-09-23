using Wh40kCharacterList.Core.AdministrativeEntities;

namespace Wh40kCharacterList.WebApi.Repository.Database.Writers.Interfaces;

public interface IUserWriter
{
    Task<UserEntity> SaveUserAsync(UserToSaveDto userToSave);
}
