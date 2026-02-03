using System.Text.Json.Serialization;

namespace backend.Models.digitalLouvreDTO;

public class Config
{
    [JsonPropertyName("iiif_url")] public string? IiifUrl { get; set; }

    [JsonPropertyName("website_url")] public string? WebsiteUrl { get; set; }
}