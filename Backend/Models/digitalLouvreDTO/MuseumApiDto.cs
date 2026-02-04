using System.Text.Json.Serialization;
using backend.Helpers;

namespace backend.Models.digitalLouvreDTO;

public class MuseumApiDto
{
    [JsonPropertyName("data")][JsonConverter(typeof(ArrayObjectJsonConverter<ArtworkData?>))]
    public IEnumerable<ArtworkData>? Data { get; init; }

    [JsonPropertyName("info")] public Info? Info { get; init; }

    [JsonPropertyName("config")] public Config? Config { get; init; }
}