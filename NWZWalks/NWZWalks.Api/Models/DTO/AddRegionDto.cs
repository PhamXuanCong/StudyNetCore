using System.ComponentModel.DataAnnotations;

namespace NWZWalks.Api.Models.DTO
{
    public class AddRegionDto
    {
        [Required]
        public string Code { get; set; }
        [Required]
        [MinLength(6, ErrorMessage = "Length maximum 200")]
        [MaxLength(200, ErrorMessage = "Length maximum 200")]
        public string Name { get; set; }
    }
}
