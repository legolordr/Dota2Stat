using System.Text.Json.Serialization;

namespace Dota2Stat.Models;
/// <summary>
/// https://docs.opendota.com/#tag/players
/// </summary>
public class RootObject
{
    [JsonPropertyName("profile")]
    public PlayerProfile? Profile { get; set; }

    [JsonPropertyName("computed_mmr")]
    public int? ComputedMmr { get; set; }

    [JsonPropertyName("rank_tier")]
    public int? RankTier { get; set; }

    [JsonPropertyName("leaderboard_rank")]
    public int? LeaderboardRank { get; set; }
}

public class PlayerProfile
{
    [JsonPropertyName("account_id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("avatarfull")]
    public string? AvatarFull { get; set; }

    [JsonPropertyName("profileurl")]
    public string? ProfileUrl { get; set; }
}