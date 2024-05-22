using AutoMapper;
using NWZWalks.Api.Models.Domain;
using NWZWalks.Api.Models.DTO.Walks;

namespace NWZWalks.Api.Mappers
{
    public class WalksProfile : Profile
    {
        public WalksProfile()
        {
            CreateMap<Walk, WalkDtos>().ReverseMap();
        }
    }
}
