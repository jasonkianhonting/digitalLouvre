using backend.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers;

[ApiController]
[Route("artworks")]
public class ArtworkController : ControllerBase
{
    private readonly IArtworkService _artworkService;

    public ArtworkController(IArtworkService artworkService)
    {
        _artworkService = artworkService;
    }

    [HttpGet("getartwork")]
    public async Task<IActionResult> GetArtwork()
    {
        var artworks = await _artworkService.GetArtworks();
        if (artworks == null) return NotFound();
        return new OkObjectResult(artworks);
    }
}