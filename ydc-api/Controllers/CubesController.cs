using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
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

    [HttpGet("cubes/{cubeID}")]
    public async Task<CubeDto> GetCubes2Async(InputDto id)
    {
        var response = await _cubesService.GetCubeByIdAsync(id);

        return response;
    }
    
    [HttpPost("cubes/draft")]
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

    [HttpPost("cubes")]
    public async Task<IActionResult> CreateCubeAsync(CreateCubeInputDto createCubeInputDto)
    {
        var response = await _cubesService.CreateCubeAsync(createCubeInputDto);

        return CreatedAtAction(nameof(CreateCubeAsync), response);
    }
}
