using backend.Interfaces;
using Microsoft.AspNetCore.Mvc;

using Backend.Models;


namespace Backend.Controllers;


[ApiController]
[Route("artworks")]
public class ArtworkController : ControllerBase
{
    private readonly IArtworkServices _artworkServices;
    public ArtworkController(IArtworkServices artworkServices)
    {
        _artworkServices = artworkServices;
    }

    [HttpGet("getartwork")]
    public async Task<IActionResult> GetArtwork()
    {
         Artwork? artworks = await _artworkServices.GetArtworks();
         if (artworks == null) return NotFound();
         return new OkObjectResult(artworks);
    }
}