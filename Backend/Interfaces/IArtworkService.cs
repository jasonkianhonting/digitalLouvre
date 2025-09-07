using Backend.Models;

namespace backend.Interfaces;

public interface IArtworkService
{
    public Task<Artwork?> GetArtworks();
}