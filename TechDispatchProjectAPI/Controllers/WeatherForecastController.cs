using Microsoft.AspNetCore.Mvc;
using Technician.Dispatch.Project.BL.Interfaces;

namespace TechDispatchProjectAPI.Controllers;


[ApiController]
[Route("api/[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IUser _iUser;


    public WeatherForecastController(ILogger<WeatherForecastController> logger, IUser iUser )
    {
        _logger = logger;
        _iUser = iUser;
    }

    [HttpGet(Name = "GetAllUsers")]
    public async Task<IActionResult> GetAllUsers()
    {
        var users = await _iUser.GetAllUsers();
        return Ok(users);
    }

    
}

