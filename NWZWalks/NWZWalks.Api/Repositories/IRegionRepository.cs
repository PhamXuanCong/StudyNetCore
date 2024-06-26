﻿using NWZWalks.Api.Models.Domain;
using NWZWalks.Api.Models.DTO;

namespace NWZWalks.Api.Repositories
{
    public interface IRegionRepository
    {
         Task<List<Region>> GetAllAsync(string? filterOn, string? filterQuery, string? sortByOn, bool isAscending);
         Task<Region> GetById(Guid id);
         Task<Region> Delete(Guid id);
         Task<Region> Update(Guid id,Region  region);
         Task<Region> Create(Region region);
    }
}
