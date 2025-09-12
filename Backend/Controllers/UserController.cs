using backend.Interfaces;
using Backend.Models;
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
    public async Task<IActionResult> Login(User user)
    {
        var loginSuccess = await _userService.Login(user);
        return new OkObjectResult(loginSuccess);
    }


    [HttpPost("register")]
    public async Task<IActionResult> Register(User user)
    {
        var registerSuccess = await _userService.Register(user);
        return new OkObjectResult(registerSuccess);
    }
}