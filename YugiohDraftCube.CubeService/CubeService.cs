using YugiohDraftCube.Domain.Dtos;

namespace YugiohDraftCube.CubeService;

public interface ICubeService
{
    public Task<List<CubeDto>> GetCubesAsync();
    public Task<CubeResponseDto> PostDraftAsync(CubeDto cube);
    public Task<CubeDto> GetCubeByIdAsync(int input);
    public Task<List<CardDto>> CreateCubeAsync(CreateCubeInputDto createCubeInput);
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
            Name = "Magician Cube",
            Description = "Big Magician Cube",
            Createdby = "David2"
        });

        return listOfCubes;
    }

    public async Task<CubeDto> GetCubeByIdAsync(int id)
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
            Name = "Magician Cube",
            Description = "Big Magician Cube",
            Createdby = "David2"
        });
        listOfCubes.Add(new CubeDto
        {
            Id = 2,
            Name = "Kuribo Cube",
            Description = "Big Kuribo cube",
            Createdby = "David3"
        });

        return listOfCubes[id];
    }

    public async Task<List<CardDto>> CreateCubeAsync(CreateCubeInputDto createCubeInput)
    {
        List<CardDto> listOfCards = new List<CardDto>();

        CardDto card = new CardDto();
        card.Id = createCubeInput.CardIDs[0];
        card.name = "Kuriboh";
        card.image = "https://static.wikia.nocookie.net/yugioh/images/4/47/Scapegoat-OW.png/revision/latest?cb=20140619032211";
        listOfCards.Add(card);

        CardDto card2 = new CardDto();
        card2.Id = createCubeInput.CardIDs[1];
        card2.name = "Dark Magician";
        card2.image = "https://static.wikia.nocookie.net/yugioh/images/4/47/Scapegoat-OW.png/revision/latest?cb=20140619032211";
        listOfCards.Add(card2);

        CardDto card3 = new CardDto();
        card3.Id = createCubeInput.CardIDs[2];
        card3.name = "Magic Dragon";
        card3.image = "https://static.wikia.nocookie.net/yugioh/images/4/47/Scapegoat-OW.png/revision/latest?cb=20140619032211";
        listOfCards.Add(card3);
        
        return listOfCards;
    }
}
