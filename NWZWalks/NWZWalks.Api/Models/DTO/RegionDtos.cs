using System.ComponentModel.DataAnnotations;

namespace NWZWalks.Api.Models.DTO
{
    public class RegionDtos
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
