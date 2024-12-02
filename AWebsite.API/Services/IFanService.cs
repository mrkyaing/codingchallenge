using AWebsite.API.Models;
namespace AWebsite.API.Services;
public interface IFanService
{
    Task<List<Fan>> GetAllFansAsync();
}
