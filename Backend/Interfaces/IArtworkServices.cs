using Backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend.Interfaces;

public interface IArtworkServices
{
    public Task<Artwork?> GetArtworks();
}