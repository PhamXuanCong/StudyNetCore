namespace NWZWalks.Api.Models.DTO.Walks
{
    public class AddWalkDto
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public double Length { get; set; }
        public string? WalkImageUrl { get; set; }

        public Guid RegionId { get; set; }
        public Guid WalkDifficultyId { get; set; }
    }
}
