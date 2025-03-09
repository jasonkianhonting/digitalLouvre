using System.Text.Json.Serialization;

namespace Backend.Models;

public class SuggestAutocompleteAll
{
    [JsonPropertyName("input")] public List<string>? Input { get; set; }

    [JsonPropertyName("contexts")] public Contexts? Contexts { get; set; }

    [JsonPropertyName("weight")] public int? Weight { get; set; }
}