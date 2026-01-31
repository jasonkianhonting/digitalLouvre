using System.Text;
using System.Text.Json;
using backend.Interfaces;
using Backend.Models;

namespace backend.Services;

public class ArtworkService(ILogger<ArtworkService> logger, IHttpClientFactory httpClientFactory)
    : IArtworkService
{
    private readonly HttpClient _httpClient = httpClientFactory.CreateClient("ArtworkClient");

    public async Task<Artwork?> GetArtworks()
    {
        Artwork? jsonContent;
        try
        {
            
            var response = await _httpClient.GetAsync(_httpClient.BaseAddress);

            var content = await response.Content.ReadAsStringAsync();

            jsonContent = JsonSerializer.Deserialize<Artwork>(content);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, ex.Message);
            throw;
        }

        return jsonContent;
    }
}