using Microsoft.EntityFrameworkCore;
using NWZWalks.Api.Data;
using NWZWalks.Api.Models.Domain;

namespace NWZWalks.Api.Repositories
{
    public class WalkRepository : IWalkRepository
    {
        private readonly NZWalksDbContext dbContext;

        public WalkRepository(NZWalksDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<Walk>> GetAllAsync(string? filterOn , string? filterQuery, string sortBy, bool isAscending, int pageIndex, int pageSize )
        {
            var walks =  dbContext.Walks.Include("Region").Include("WalkDifficulty").AsQueryable();

            //filter
            if (string.IsNullOrWhiteSpace(filterOn) == false && string.IsNullOrWhiteSpace(filterQuery) == false)
            {
                if (filterOn.Equals("Name", StringComparison.OrdinalIgnoreCase))
                {
                    walks = walks.Where(x => x.Name.Contains(filterQuery));
                }
            }

            //sort\
            if (string.IsNullOrWhiteSpace(sortBy) == false )
            {
                if (sortBy.Equals("length", StringComparison.OrdinalIgnoreCase))
                {
                    walks = isAscending ? walks.OrderBy(x => x.Length) : walks.OrderByDescending(x => x.Length);
                }
            }

            //pagination
            var skipResults = (pageIndex - 1) * pageSize;

            return await walks.Skip(skipResults).Take(pageSize).ToListAsync();
        }

        public async Task<Walk> GetAsync(Guid id)
        {
            var walks =await dbContext.Walks.FirstOrDefaultAsync(x => x.Id == id);

            return walks;
        }

        public async Task<Walk> Create(Walk walk)
        {
            await dbContext.Walks.AddRangeAsync(walk);
            await dbContext.SaveChangesAsync();

            return  walk;
        }

        public async Task<Walk> UpdateAsync(Guid id, Walk walk)
        {
            var walk1 = await dbContext.Walks.FirstOrDefaultAsync(x => x.Id == id);

            if (walk1 == null)
                return null;

            walk1.Name = walk.Name;
            walk1.Length = walk.Length;
            walk1.RegionId = walk.RegionId;
            walk1.WalkDifficulty = walk.WalkDifficulty;

            await dbContext.SaveChangesAsync();

            return walk1;
        }

        public async Task<Walk> DeleteAsync(Guid id)
        {
            var walk = await dbContext.Walks.FirstOrDefaultAsync(x => x.Id == id);

            dbContext.Remove(walk);

            await dbContext.SaveChangesAsync();

            return walk;
        }
    }
}
