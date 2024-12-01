using AWebsite.API.Models;

namespace AWebsite.API.Services;

public interface IWeatherService
{
    Task<IEnumerable<WeatherForecast>> GetAsync();
}
