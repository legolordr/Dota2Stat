using System.Text.Json.Serialization;

namespace Dota2Stat.Models;

public class Hero
{
    [JsonPropertyName("id")]
    public long Id { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("localized_name")]
    public string LocalizedName { get; set; }
}