using System.Text.Json.Serialization;

namespace Backend.Models;

public class Contexts
{
    [JsonPropertyName("groupings")] public List<string>? Groupings { get; set; }
}