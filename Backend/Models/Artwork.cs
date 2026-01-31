using System.Text.Json.Serialization;

namespace Backend.Models;

public class Artwork
{
    [JsonPropertyName("data")] public IEnumerable<ArtworkData>? Data { get; init; }

    [JsonPropertyName("info")] public Info? Info { get; init; }

    [JsonPropertyName("config")] public Config? Config { get; init; }
}