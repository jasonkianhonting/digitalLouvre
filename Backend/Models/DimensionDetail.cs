using System.Text.Json.Serialization;

namespace Backend.Models;

public class DimensionsDetail
{
    [JsonPropertyName("depth")] public object? Depth { get; set; }

    [JsonPropertyName("width")] public int? Width { get; set; }

    [JsonPropertyName("height")] public int? Height { get; set; }

    [JsonPropertyName("diameter")] public object? Diameter { get; set; }

    [JsonPropertyName("clarification")] public string? Clarification { get; set; }
}