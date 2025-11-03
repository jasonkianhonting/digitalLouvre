using Backend.Models;

namespace backend.Interfaces;

public interface ITokenService
{
    public Task<DigitalLouvreResponseDto> GenerateToken();
    public Task<DigitalLouvreResponseDto> ValidateToken();
    public Task<DigitalLouvreResponseDto> RefreshToken();
}