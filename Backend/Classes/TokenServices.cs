using backend.Interfaces;

namespace backend.Classes;

public class TokenServices : ITokenServices
{
    private readonly ILogger<TokenServices> _logger;

    public TokenServices(ILogger<TokenServices> logger)
    {
        _logger = logger;
    }

    public Task<string> GenerateToken()
    {
        throw new NotImplementedException();
    }
}