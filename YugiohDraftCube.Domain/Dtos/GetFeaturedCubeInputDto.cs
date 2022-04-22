using YugiohDraftCube.Domain.Models;

namespace YugiohDraftCube.Domain.Dtos
{
    public class GetFeaturedCubeInputDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Format { get; set; }
        public int Id { get; set; }

        public List<int> CubeIDs { get; set; }

    }
}
