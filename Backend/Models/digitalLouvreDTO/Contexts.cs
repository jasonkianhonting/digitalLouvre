using System.Text.Json.Serialization;

namespace backend.Models.digitalLouvreDTO;

public class Contexts
{
    [JsonPropertyName("groupings")] public List<string>? Groupings { get; set; }
}