using backend.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers;

[ApiController]
[Route("")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet("login")]
    public async Task<IActionResult> Login(string username, string password)
    {
        var loginSuccess = await _userService.Login(username, password);
        return new OkObjectResult(loginSuccess);
    }


    [HttpPost("register")]
    public async Task<IActionResult> Register(string username, string firstName, string lastName, string password)
    {
        var registerSuccess = await _userService.Register(username, firstName, lastName, password);
        return new OkObjectResult(registerSuccess);
    }
}