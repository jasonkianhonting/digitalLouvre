using System.Net;
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

    [HttpGet("getArtworksForTheDay")]
    public async Task<IActionResult> GetArtworksForTheDay()
    {
        var responseDto = await _artworkService.GetRandomArtworks();

        return responseDto switch
        {
            null => StatusCode((int)HttpStatusCode.InternalServerError, responseDto),
            { IsSuccess: true, Data: null } => NotFound(responseDto),
            { IsSuccess: true } => Ok(responseDto),
            { IsSuccess: false } => BadRequest(responseDto)
        };
    }
}