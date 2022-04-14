using YugiohDraftCube.Domain.Models;

namespace YugiohDraftCube.Domain.Dtos;

public class CubeDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Cards cards { get; set; }
    public string Createdby { get; set; }
}
