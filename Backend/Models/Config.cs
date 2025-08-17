using System.Text.Json.Serialization;

namespace Backend.Models;

public class Config
{
    [JsonPropertyName("iiif_url")] public string? IiifUrl { get; set; }

    [JsonPropertyName("website_url")] public string? WebsiteUrl { get; set; }
}