using AutoMapper;
using NWZWalks.Api.Models.Domain;
using NWZWalks.Api.Models.DTO;
using NWZWalks.Api.Models.DTO.Walks;

namespace NWZWalks.Api.Mappers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Walk, WalkDtos>().ReverseMap();
            CreateMap<Region, RegionDtos>().ReverseMap();
            CreateMap<Walk, UpdateWalkDto>().ReverseMap();
            CreateMap<AddWalkDto, Walk>().ReverseMap();

        }
    }
}
