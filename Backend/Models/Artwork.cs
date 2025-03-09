using System.Text.Json.Serialization;

namespace Backend.Models;

public class Artwork
{
    [JsonPropertyName("data")] public List<ArtworkData>? Data { get; set; }

    [JsonPropertyName("info")] public Info? Info { get; set; }

    [JsonPropertyName("config")] public Config? Config { get; set; }
}