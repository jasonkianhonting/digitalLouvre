using backend.Models;

namespace backend.Interfaces;

public interface IArtworkService
{
    public Task<ResponseDto?> GetArtworks(int? id, int page, int limit);

    public Task<ResponseDto?> SearchArtwork(string query);
}