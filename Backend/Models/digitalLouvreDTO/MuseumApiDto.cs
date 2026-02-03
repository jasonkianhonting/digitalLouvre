using System.Text.Json.Serialization;

namespace backend.Models.digitalLouvreDTO;

public class MuseumApiDto
{
    [JsonPropertyName("data")] public IEnumerable<ArtworkData>? Data { get; init; }

    [JsonPropertyName("info")] public Info? Info { get; init; }

    [JsonPropertyName("config")] public Config? Config { get; init; }
}