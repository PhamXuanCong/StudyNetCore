using NWZWalks.Api.Models.Domain;

namespace NWZWalks.Api.Repositories
{
    public interface IWalkRepository
    {
        Task<List<Walk>> GetAllAsync(string? filterOn , string? filterQuery, string sortBy, bool isAscending, int pageIndex, int pageSize );
        Task<Walk> GetAsync(Guid id);

        Task<Walk>Create(Walk walk);
        Task<Walk> UpdateAsync(Guid id,Walk walk);
        Task<Walk> DeleteAsync(Guid id);
    }
}
