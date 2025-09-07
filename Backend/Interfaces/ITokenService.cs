namespace backend.Interfaces;

public interface ITokenService
{
    public Task<string> GenerateToken();
}