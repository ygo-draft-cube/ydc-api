using Microsoft.AspNetCore.Mvc;
using YugiohDraftCube.CubesService;
using YugiohDraftCube.Domain.Dtos;

namespace ydc_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CubesController : ControllerBase
    {
        private readonly ILogger<DraftRoomController> _logger;
        private readonly ICubesService _cubesService;

        public CubesController(ILogger<DraftRoomController> logger, ICubesService cubesService)
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
        public async Task<List<CardsDto>> CreateCubeAsync(CreateCubeInputDto createCubeInputDto)
        {
            var response = await _cubesService.CreateCubeAsync(createCubeInputDto);

            return response;
        }
    }
}