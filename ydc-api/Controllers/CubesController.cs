using Microsoft.AspNetCore.Mvc;
using YugiohDraftCube.CubeService;
using YugiohDraftCube.Domain.Dtos;

namespace ydc_api.Controllers;

[ApiController]
[Route("api/v1")]
public class CubesController : ControllerBase
{
    private readonly ILogger<CubesController> _logger;
    private readonly ICubeService _cubesService;

    public CubesController(ILogger<CubesController> logger, ICubeService cubesService)
    {
        _cubesService = cubesService;
        _logger = logger;
    }

    [HttpGet("cubes")]
    public async Task<List<CubeDto>> GetCubesAsync()
    {
        var response = await _cubesService.GetCubesAsync();

        return response;
    }

    [HttpGet("cubes/{cube_id}")]
    public async Task<CubeDto> GetCubeByIdAsync(int cube_id)
    {
        var response = await _cubesService.GetCubeByIdAsync(cube_id);

        return response;
    }

    [HttpPost("cube/draft")]
    public async Task<CubeResponseDto> PostDraftAsync(CubeDto cube)
    {
        var response = await _cubesService.PostDraftAsync(cube);

        return response;
    }

    [HttpGet("featured-cubes")]
    public async Task<IActionResult> GetFeaturesDraftAsync()
    {
        return NoContent();
    }

    [HttpPost("cube")]
    public async Task<IActionResult> CreateCubeAsync(CreateCubeInputDto createCubeInputDto)
    {
        var response = await _cubesService.CreateCubeAsync(createCubeInputDto);

        return CreatedAtAction(nameof(CreateCubeAsync), response);
    }
}
