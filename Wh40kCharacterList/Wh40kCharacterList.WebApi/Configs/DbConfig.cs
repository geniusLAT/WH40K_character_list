using Newtonsoft.Json;

namespace Wh40kCharacterList.WebApi.Configs;

public class DbConfig
{
    [JsonProperty(PropertyName = "connection-string")]
    public string ConnectionString { get; set; } = string.Empty;

    [JsonProperty(PropertyName = "database-name")]
    public string DatabaseName { get; set; } = string.Empty;

    public string CreateConnectionString(string? dbName = null)
    {
        return ConnectionString.Replace("[database_name]", dbName ?? DatabaseName);
    }
}

