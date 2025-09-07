using System.Text.Json;
using backend.Interfaces;
using Backend.Models;

namespace backend.Classes;

public class ArtworkService : IArtworkService
{
    private readonly HttpClient _httpClient;
    private readonly ILogger<ArtworkService> _logger;

    public ArtworkService(ILogger<ArtworkService> logger, IHttpClientFactory httpClientFactory)
    {
        _logger = logger;
        _httpClient = httpClientFactory.CreateClient("ArtworkClient");
    }

    public async Task<Artwork?> GetArtworks()
    {
        Artwork? jsonContent;
        try
        {
            var response = await _httpClient.GetAsync(_httpClient.BaseAddress);

            var content = await response.Content.ReadAsStringAsync();

            jsonContent = JsonSerializer.Deserialize<Artwork>(content);
        }
        catch (Exception e)
        {
            _logger.LogError(e, e.Message);
            throw;
        }

        return jsonContent;
    }
}