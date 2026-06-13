using System.Text.Json.Serialization;

namespace Dota2Stat.Models;

public class HeroStats
{
    [JsonPropertyName("hero_id")]
    public long HeroId { get; set; }

    [JsonPropertyName("games")]
    public long Games { get; set; }

    [JsonPropertyName("win")]
    public long Wins { get; set; }

    [JsonPropertyName("with_games")]
    public long WithGames { get; set; }

    [JsonPropertyName("with_win")]
    public long WithWins { get; set; }

    [JsonPropertyName("against_games")]
    public long AgainstGames { get; set; }

    [JsonPropertyName("against_win")]
    public long AgainstWins { get; set; }

    public double WinRate => Games > 0 ? Math.Round((double)Wins / Games * 100, 1) : 0;
}