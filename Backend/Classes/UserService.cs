using backend.Interfaces;
using Backend.Models;

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

    public Task<DigitalLouvreResponseDto> Login(User userRetrieved)
    {
        var loginUserDto = new DigitalLouvreResponseDto();
        try
        {
            if (!_context.Users.Any(x =>
                    x.Username == userRetrieved.Username &&
                    x.Password == userRetrieved.Password))
            {
                loginUserDto.IsSuccess = false;
                loginUserDto.Message = "Username or password is incorrect";
            }
            else
            {
                loginUserDto.IsSuccess = true;
            }
                
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Error, e.Message);
            loginUserDto.IsSuccess = false;
            loginUserDto.Message = $"{e.Message}, please review the logs.";
            loginUserDto.Exception = e.InnerException?.Message;
        }

        return Task.FromResult(loginUserDto);
    }

    public Task<DigitalLouvreResponseDto> Register(User newUserCreated)
    {
        var createUserDto = new DigitalLouvreResponseDto();
        try
        {
            newUserCreated.UserId = Guid.NewGuid();
            newUserCreated.Password = BCrypt.Net.BCrypt.HashPassword(newUserCreated.Password);
            _context.Users.Add(newUserCreated);
            _context.SaveChanges();
            createUserDto.Message = "User created";
            createUserDto.Exception = null;
            createUserDto.IsSuccess = true;
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Error, e.Message);
            createUserDto.Message = $"{e.Message}, please review the logs.";
            createUserDto.IsSuccess = false;
            createUserDto.Exception = e.InnerException?.Message;
        }

        return Task.FromResult(createUserDto);
    }
}