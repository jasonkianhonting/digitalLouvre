using backend.Interfaces;
using Microsoft.AspNetCore.Mvc;
namespace Backend.Controllers;

[ApiController]
[Route("users")]
public class UserControllers : ControllerBase
{
    private readonly IUserServices _userServices;
    public UserControllers(IUserServices userServices)
    {
        _userServices = userServices;
    }

    [HttpGet("getartwork")]
    public async Task<IActionResult> Login()
    {
        return null;
    }
}