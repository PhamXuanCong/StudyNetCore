using System.ComponentModel.DataAnnotations;

namespace NWZWalks.Api.Models.DTO.Walks
{
    public class AddWalkDto
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Range(0,50)]
        public double Length { get; set; }
        public string? WalkImageUrl { get; set; }
        [Required]
        public Guid RegionId { get; set; }
        [Required]
        public Guid WalkDifficultyId { get; set; }
    }
}
