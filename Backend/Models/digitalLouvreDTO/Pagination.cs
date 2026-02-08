using System.Text.Json.Serialization;

namespace backend.Models.digitalLouvreDTO;

public record Pagination
{
    [JsonPropertyName("limit")] 
    public int Limit { get; init; }
    [JsonPropertyName("offset")] 
    public int Offset { get; init; }
    [JsonPropertyName("total_pages")] 
    public int TotalPages { get; init; }
    [JsonPropertyName("current_pages")] 
    public int CurrentPage { get; init; }
}