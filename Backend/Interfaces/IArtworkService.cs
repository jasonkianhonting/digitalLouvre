using backend.Models;

namespace backend.Interfaces;

public interface IArtworkService
{
    public Task<ResponseDto?> GetRandomArtworks();

    public Task<ResponseDto?> SearchArtwork(string query);
}