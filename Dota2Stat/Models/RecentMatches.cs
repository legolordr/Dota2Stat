using System.Text.Json.Serialization;

namespace Dota2Stat.Models;

public class RecentMatch
{
    [JsonPropertyName("match_id")]
    public long MatchId { get; set; }

    [JsonPropertyName("hero_id")]
    public long HeroId { get; set; }

    [JsonPropertyName("kills")]
    public long Kills { get; set; }

    [JsonPropertyName("deaths")]
    public long Deaths { get; set; }

    [JsonPropertyName("assists")]
    public long Assists { get; set; }

    [JsonPropertyName("duration")]
    public long Duration { get; set; }

    [JsonPropertyName("radiant_win")]
    public bool RadiantWin { get; set; }

    [JsonPropertyName("player_slot")]
    public long PlayerSlot { get; set; }

    [JsonPropertyName("game_mode")]
    public long GameMode { get; set; }

    [JsonPropertyName("lobby_type")]
    public long LobbyType { get; set; }

    [JsonPropertyName("start_time")]
    public long StartTime { get; set; }

    [JsonPropertyName("gold_per_min")]
    public long GoldPerMin { get; set; }

    [JsonPropertyName("xp_per_min")]
    public long XpPerMin { get; set; }

    [JsonPropertyName("last_hits")]
    public long LastHits { get; set; }

    [JsonPropertyName("denies")]
    public long Denies { get; set; }
}