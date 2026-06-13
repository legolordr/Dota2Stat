using System.Text.Json.Serialization;

namespace Dota2Stat.Models;

public class WL
{
    [JsonPropertyName("win")]
    public int Win { get; set; }

    [JsonPropertyName("lose")]
    public int Loss { get; set; }
}