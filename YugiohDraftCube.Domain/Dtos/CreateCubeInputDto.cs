namespace YugiohDraftCube.Domain.Dtos;

public class CreateCubeInputDto
{
    public string Name { get; set; }
    public string Description { get; set; }
    public List<int> CardIDs { get; set; }
  

}
