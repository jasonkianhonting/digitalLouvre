using backend.Interfaces;
using Backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend.Classes;

public class UserService : IUserService
{
    private readonly DigitalLouvreContext _context;
    private readonly ILogger<UserService> _logger;

    public UserService(ILogger<UserService> logger, DigitalLouvreContext context)
    {
        _logger = logger;
        _context = context;
    }

    public Task<bool> Login([FromBody] string username, [FromBody] string password)
    {
        var isSuccess = false;
        try
        {
            if (_context.Users.Any(x =>
                    x.Username == username && x.Password == BCrypt.Net.BCrypt.HashPassword(password))) isSuccess = true;
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Error, e.Message);
        }

        return Task.FromResult(isSuccess);
    }

    public Task<User?> Register([FromBody] string username, [FromBody] string firstName, [FromBody] string lastName,
        [FromBody] string password)
    {
        var newUserCreated = new User();
        try
        {
            newUserCreated.UserId = Guid.NewGuid();
            newUserCreated.FirstName = firstName;
            newUserCreated.LastName = lastName;
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