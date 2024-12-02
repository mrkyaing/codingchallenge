using AWebsite.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace AWebsite.API.Controllers;

[ApiController]
[Route("[controller]")]
public class FansController : ControllerBase
{
    private readonly IFanService _fanService;

    public FansController(IFanService fanService)
    {
        this._fanService = fanService;
    }

    // Assign a specific route to this action
    [HttpGet("sayhi")]
    public async Task<IActionResult> SayHi() => Ok("fans"); // HttpStatusCode 200

    // The default route for HttpGet will now handle this action
    [HttpGet]
    public async Task<IActionResult> GetFans()
    {
        var fans = await _fanService.GetAllFansAsync();
        if (fans.Any())
            return Ok(fans);
        return NotFound();
    }
}
