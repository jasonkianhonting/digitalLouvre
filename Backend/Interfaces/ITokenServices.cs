using Backend.Models;

namespace backend.Interfaces;

public interface ITokenServices
{
    public Task<string> GenerateToken();
}