using Backend.Models;

namespace backend.Interfaces;

public interface IUserService
{
    public Task<bool> Login(string username, string password);
    public Task<User?> Register(string username, string firstName, string lastName, string password);
}