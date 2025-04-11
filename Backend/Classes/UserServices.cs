using backend.Interfaces;
using Backend.Models;

namespace backend.Classes;

public class UserServices: IUserServices
{
    private readonly ILogger<UserServices> _logger;
    private readonly ITokenServices _tokenServices;
    public UserServices(ILogger<UserServices> logger, ITokenServices tokenServices )
    {
        _logger = logger;
        _tokenServices = tokenServices;
    }

    public Task<User?> Login(string username, string password)
    {
        throw new NotImplementedException();
    }

    public Task<User?> Register(string username, string password)
    {
        throw new NotImplementedException();
    }
}