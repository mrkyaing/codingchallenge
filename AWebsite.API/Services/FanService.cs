using AWebsite.API.Models;
namespace AWebsite.API.Services;
public class FanService : IFanService
{
    public Task<List<Fan>> GetAllFansAsync()
    {
        var fans= new List<Fan>() {
            new Fan()
            {
                Id = 1,
                Name = "Test",
                Email="test@mail"
            }
        };
        return Task.FromResult(fans);
    }
}
