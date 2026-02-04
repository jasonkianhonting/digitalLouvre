using System.Net;
using backend.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers;

[ApiController]
[Route("artworks")]
public class ArtworkController(IArtworkService artworkService) : ControllerBase
{
    [HttpGet("getArtworks/{id?}")]
    public async Task<IActionResult> GetArtworks(int id, [FromQuery] int page, [FromQuery] int limit)
    {
        var responseDto = await artworkService.GetArtworks(id, page, limit);

        return responseDto switch
        {
            null => StatusCode((int)HttpStatusCode.InternalServerError, responseDto),
            { IsSuccess: true, Data: null } => NotFound(responseDto),
            { IsSuccess: true } => Ok(responseDto),
            { IsSuccess: false } => BadRequest(responseDto)
        };
    }

    [HttpGet("searchArtworks")]
    public async Task<IActionResult> SearchArtworks([FromQuery] string query)
    {
        var responseDto = await artworkService.SearchArtwork(query);

        return responseDto switch
        {
            null => StatusCode((int)HttpStatusCode.InternalServerError, responseDto),
            { IsSuccess: true, Data: null } => NotFound(responseDto),
            { IsSuccess: true } => Ok(responseDto),
            { IsSuccess: false } => BadRequest(responseDto)
        };
    }
}