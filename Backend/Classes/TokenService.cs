using backend.Interfaces;
using Backend.Models;

namespace backend.Classes;

public class TokenService : ITokenService
{
    private readonly ILogger<TokenService> _logger;

    public TokenService(ILogger<TokenService> logger)
    {
        _logger = logger;
    }

    public Task<DigitalLouvreResponseDto> ValidateToken()
    {
        throw new NotImplementedException();
    }

    public Task<DigitalLouvreResponseDto> RefreshToken()
    {
        throw new NotImplementedException();
    }

    Task<DigitalLouvreResponseDto> ITokenService.GenerateToken()
    {
        throw new NotImplementedException();
    }
}