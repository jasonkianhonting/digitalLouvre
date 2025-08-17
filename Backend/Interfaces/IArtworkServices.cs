using Backend.Models;

namespace backend.Interfaces;

public interface IArtworkServices
{
    public Task<Artwork?> GetArtworks();
}