using Microsoft.AspNetCore.Mvc;

namespace ydc_api.Controllers;

[ApiController]
[Route("[controller]")]
public class DraftRoomController : ControllerBase
{

    private readonly ILogger<DraftRoomController> _logger;

    public DraftRoomController(ILogger<DraftRoomController> logger)
    {
        _logger = logger;
    }

    [HttpPost("room/{ConferenceGUID}/start")]
    public async Task<IActionResult> StartAsync()
    {
        return NoContent();
    }

    [HttpGet("broadcast/Receive")]
    public async Task<IActionResult> GetBroadcastAsync()
    {
        return NoContent();
    }

    [HttpPost("room/{ConferenceGUID}/join")]
    public async Task<IActionResult> JoinAsync()
    {
        return NoContent();
    }
}
