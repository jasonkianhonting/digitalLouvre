using System.Text.Json.Serialization;

namespace Backend.Models;

public class Color
{
    [JsonPropertyName("h")] public int? Hue { get; set; }

    [JsonPropertyName("l")] public int? Lightness { get; set; }

    [JsonPropertyName("s")] public int? Saturation { get; set; }

    [JsonPropertyName("percentage")] public double? Percentage { get; set; }

    [JsonPropertyName("population")] public int? Population { get; set; }
}