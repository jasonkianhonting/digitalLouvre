using System.Text.Json;
using backend.Interfaces;
using Backend.Models;

namespace backend.Classes;

public class UserServices : IUserServices
{
    private readonly DigitalLouvreContext _context;
    private readonly ILogger<UserServices> _logger;
    private readonly ITokenServices _tokenServices;

    public UserServices(ILogger<UserServices> logger, ITokenServices tokenServices, DigitalLouvreContext context)
    {
        _logger = logger;
        _tokenServices = tokenServices;
        _context = context;
    }

    public Task<bool> Login(string username, string password)
    {
        var test = _context.Users.Any(x => x.FistName == username);
        return Task.FromResult(test);
    }

    public Task<User?> Register(string username, string password)
    {
        throw new NotImplementedException();
    }
}