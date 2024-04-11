// ------------------------------------
// Magic The Gathering Look Up UI
// ------------------------------------

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace MagicTheGatheringAPI.StorageContracts;

[JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
public class SetStorageContract
{
    [JsonRequired]
    public string Block { get; set; } = string.Empty;

    [JsonRequired]
    public string Code { get; set; } = string.Empty;

    [JsonRequired]
    public Guid Id { get; set; } = default;

    [JsonRequired]
    public string Name { get; set; } = string.Empty;

    public bool? OnlineOnly { get; set; }

    public string PartitionKey => $"set~{Block}~{Type}";

    public string ReleaseDate { get; set; } = string.Empty;

    [JsonRequired]
    public string Type { get; set; } = string.Empty;
}