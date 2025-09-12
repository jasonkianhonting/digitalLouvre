using Backend.Models;

namespace backend.Interfaces;

public interface IUserService
{
    public Task<DigitalLouvreResponseDto> Login(User user);
    public Task<DigitalLouvreResponseDto> Register(User user);
}