using System.Text.Json;
using Microsoft.AspNetCore.Mvc;

using Backend.Models;

namespace Backend.Controllers;

[ApiController]
[Route("artworks")]
public class ArtworkController : ControllerBase
{
    private readonly ILogger<ArtworkController> _logger;
    
    private HttpClient _httpClient;

    public ArtworkController(ILogger<ArtworkController> logger, IHttpClientFactory httpClientFactory)
    {
        _logger = logger;
        _httpClient = httpClientFactory.CreateClient("ArtworkClient");
        
    }

    [HttpGet("getartwork")]
    public async Task<IActionResult> GetArtwork()
    {
         Artwork? jsonContent; 
        try
        {
            var response = await _httpClient.GetAsync(_httpClient.BaseAddress);

            if (!response.IsSuccessStatusCode) return BadRequest();

            var content = await response.Content.ReadAsStringAsync();
            
            jsonContent = JsonSerializer.Deserialize<Artwork>(content);
        }
        catch (Exception e)
        {
            _logger.LogError(e, e.Message);
            throw;
        }

        return Ok(jsonContent);
    }
    
    
    
    
}