using Asp.Versioning;
using AWebsite.API.Models;
using AWebsite.API.Services;
using Microsoft.AspNetCore.Mvc;
namespace AWebsite.API.Controllers;

[ApiController]
[Route("[controller]")]
[ApiVersion("2.0")]
public class WeatherForecast2Controller : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IWeatherService _weatherService;

    public WeatherForecast2Controller(ILogger<WeatherForecastController> logger,IWeatherService  weatherService)
    {
        _logger = logger;
        _weatherService = weatherService;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public async Task<IEnumerable<WeatherForecast>> Get()
    {
      return   await  _weatherService.GetAsync();
    }
}
