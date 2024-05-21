using Microsoft.EntityFrameworkCore;
using NWZWalks.Api.Models.Domain;

namespace NWZWalks.Api.Data
{
    public class NZWalksDbContext :DbContext
    {
        public NZWalksDbContext(DbContextOptions<NZWalksDbContext> options) : base(options)
        {
            
        }

        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }

        public DbSet<Region>Regions { get; set; }
        public DbSet<Walk>Walks { get; set; }
    }
}
