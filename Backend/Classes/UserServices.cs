using backend.Interfaces;
using Backend.Models;
using BCrypt.Net;
using Microsoft.AspNetCore.Identity;

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
       throw new NotImplementedException();
    }

    public Task<User?> Register(string username, string password)
    {
        var newUserCreated = new User();
        try
        {
            newUserCreated.UserId = Guid.NewGuid();
            newUserCreated.FirstName = username;
            newUserCreated.LastName = username;
            newUserCreated.Password = BCrypt.Net.BCrypt.HashPassword(password);

            _context.Users.Add(newUserCreated);
            
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Error, e.Message);
        }

        return Task.FromResult<User?>(newUserCreated);
    }
}