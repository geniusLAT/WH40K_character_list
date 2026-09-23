using Newtonsoft.Json;
using Wh40kCharacterList.Core.AdministrativeEntities;

namespace Wh40kCharacterList.Core.NetworkDtos;

public class AuthResultDto
{
    [JsonProperty("user")]
    public required UserEntity User { get; set; }
}
