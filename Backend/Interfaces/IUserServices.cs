using Backend.Models;

namespace backend.Interfaces;

public interface IUserServices
{
    public Task<User?> Login(string username, string password);
    public Task<User?> Register(string username, string password);
}