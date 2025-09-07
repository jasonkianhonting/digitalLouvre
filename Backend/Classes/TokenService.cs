using backend.Interfaces;

namespace backend.Classes;

public class TokenService : ITokenService
{
    private readonly ILogger<TokenService> _logger;

    public TokenService(ILogger<TokenService> logger)
    {
        _logger = logger;
    }

    public Task<string> GenerateToken()
    {
        throw new NotImplementedException();
    }
}