using YugiohDraftCube.Domain.Dtos;

namespace YugiohDraftCube.CubeService;

public interface ICubeService
{
    public Task<List<CubeDto>> GetCubesAsync();
    public Task<CubeResponseDto> PostDraftAsync(CubeDto cube);
    public Task<CubeDto> GetCubeByIdAsync(InputDto input);
    public Task<List<CardsDto>> CreateCubeAsync(CreateCubeInputDto createCubeInput);
    public Task<List<CubeDto>> GetFeaturedCubeAsync(GetFeaturedCubeInputDto getFeaturedCubeInputDto);
}

public class CubeService : ICubeService
{
    public async Task<CubeResponseDto> PostDraftAsync(CubeDto cube)
    {
        var cubeResponseDto = new CubeResponseDto();

        cubeResponseDto.results = "THIS IS A TEST";

        return cubeResponseDto;
    }

    public async Task<List<CubeDto>> GetCubesAsync()
    {
        List<CubeDto> listOfCubes = new List<CubeDto>();
        listOfCubes.Add(new CubeDto
        {
            Id = 0,
            Name = "Dragon Cube",
            Description = "Big Dragon Cube",
            Createdby = "David"
        });

        listOfCubes.Add(new CubeDto
        {
            Id = 1,
            Name = "Dark Magician",
            Description = "Big Magician Cube",
            Createdby = "David2"
        });

        return listOfCubes;
    }

    public async Task<CubeDto> GetCubeByIdAsync(InputDto input)
    {
        List<CubeDto> listOfCubes = new List<CubeDto>();
        listOfCubes.Add(new CubeDto
        {
            Id = 0,
            Name = "Blue Eyes White Dragon",
            Description = "Big Dragon",
            Createdby = "David"
        });

        listOfCubes.Add(new CubeDto
        {
            Id = 1,
            Name = "Dark Magician",
            Description = "Big Magician",
            Createdby = "David2"
        });

        listOfCubes.Add(new CubeDto
        {
            Id = 2,
            Name = "Kuribo",
            Description = "Big Kuribo",
            Createdby = "David3"
        });

        return listOfCubes[input.Id];
    }

    public async Task<List<CardsDto>> CreateCubeAsync(CreateCubeInputDto createCubeInput)
    {
        List<CardsDto> listOfCards = new List<CardsDto>();

        CardsDto card = new CardsDto();
        card.Id = createCubeInput.CardIDs[0];
        card.name = "Kuriboh";
        card.image = "https://static.wikia.nocookie.net/yugioh/images/4/47/Scapegoat-OW.png/revision/latest?cb=20140619032211";
        listOfCards.Add(card);

        CardsDto card2 = new CardsDto();
        card2.Id = createCubeInput.CardIDs[1];
        card2.name = "Dark Magician";
        card2.image = "https://static.wikia.nocookie.net/yugioh/images/4/47/Scapegoat-OW.png/revision/latest?cb=20140619032211";
        listOfCards.Add(card2);

        CardsDto card3 = new CardsDto();
        card3.Id = createCubeInput.CardIDs[2];
        card3.name = "Magic Dragon";
        card3.image = "https://static.wikia.nocookie.net/yugioh/images/4/47/Scapegoat-OW.png/revision/latest?cb=20140619032211";
        listOfCards.Add(card3);
        
        return listOfCards;
    }

    public async Task<List<CubeDto>> GetFeaturedCubeAsync(GetFeaturedCubeInputDto getFeaturedCubeInput)
    { 
        List<CubeDto> listOfFeaturedCubes = new List<CubeDto>();

        GetFeaturedCubeInputDto featuredCube = new GetFeaturedCubeInputDto();
        featuredCube.Id = getFeaturedCubeInput.CubeIDs[0];
        featuredCube.Name = "Fusion";
        featuredCube.Description = "Only Fusion monsters";
        featuredCube.Format = "Fusions";

        return listOfFeaturedCubes;

    }
}
