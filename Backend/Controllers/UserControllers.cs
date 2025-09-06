using backend.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers;

[ApiController]
[Route("")]
public class UserControllers : ControllerBase
{
    private readonly IUserServices _userServices;

    public UserControllers(IUserServices userServices)
    {
        _userServices = userServices;
    }

    [HttpGet("login")]
    public async Task<IActionResult> Login(string username, string password)
    {
        _userServices.Login("Test1", "admin");
        return null;
    }
}