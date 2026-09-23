using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Wh40kCharacterList.Core.AdministrativeEntities.DtosToSave;

public class UserToSaveDto
{
    [Required]
    [JsonProperty("name")]
    public required string Name { get; set; } = string.Empty;

    [Required]
    [JsonProperty("admin")]
    public required bool Admin { get; set; }

    [Required]
    [JsonProperty("password")]
    public required string Password { get; set; } = string.Empty;

    [Required]
    [JsonProperty("last_token")]
    public required string LastToken { get; set; } = string.Empty;
}
