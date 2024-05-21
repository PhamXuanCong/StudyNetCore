using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using NWZWalks.Api.Data;
using NWZWalks.Api.Models.Domain;
using NWZWalks.Api.Models.DTO;

namespace NWZWalks.Api.Repositories
{
    public class RegionrRepository : IRegionRepository
    {
        public readonly NZWalksDbContext dbContext;
        public RegionrRepository(NZWalksDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Region> Create(Region region)
        {

            await dbContext.Regions.AddAsync(region);

            await dbContext.SaveChangesAsync();

            return region;
        }

        public async Task<List<Region>> GetAllAsync()
        {
            var regions = await dbContext.Regions.ToListAsync();

            if (regions == null)
                return null;

            return regions;
        }


        public async Task<Region> Delete(Guid id)
        {
            var region = dbContext.Regions.FirstOrDefault(r => r.Id == id);

            if (region == null)
            {
                return null;
            }

            dbContext.Remove(region);
            await dbContext.SaveChangesAsync();

            return region;
        }

        public async Task<Region> GetById(Guid id)
        {


            return await dbContext.Regions.FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task<Region> Update(Guid id, Region region)
        {
            var regionNew = await dbContext.Regions.FirstOrDefaultAsync(r => r.Id == id);

            if(regionNew == null)
            {
                return null;
            }

            regionNew.Code = region.Code;
            regionNew.Area = region.Area;
            regionNew.Name = region.Name;

            await dbContext.SaveChangesAsync();

            return regionNew;
        }
    }
}
