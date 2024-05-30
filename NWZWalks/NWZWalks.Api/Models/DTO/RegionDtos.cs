using System.ComponentModel.DataAnnotations;

namespace NWZWalks.Api.Models.DTO
{
    public class RegionDtos
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
