using Microsoft.EntityFrameworkCore;
using NWZWalks.Api.Models.Domain;

namespace NWZWalks.Api.Data
{
    public class NZWalksDbContext : DbContext
    {
        public NZWalksDbContext(DbContextOptions<NZWalksDbContext> options) : base(options)
        {

        }

        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }

        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //var regions = new List<Region>()
            //{
            //    new Region()
            //    {
            //        Id = Guid.Parse("73176b3b-effe-434b-861a-aa0e1f4b43b1"),
            //        Name = "Cong dep trai",
            //        Code = "1234"
            //    },
            //    new Region()
            //    {
            //        Id = Guid.Parse("42d8f71c-f6c7-465e-8236-2677caff8988"),
            //        Name = "Cong dep trai",
            //        Code = "12345"
            //    },
            //};

            //modelBuilder.Entity<Region>().HasData(regions);

            var walkDifficulties = new List<WalkDifficulty>()
            {

            };

            for (int i = 0; i < 50; i++)
            {
                walkDifficulties.Add(new WalkDifficulty()
                {
                    Id = Guid.NewGuid(),
                    Code = "codeName" + i.ToString()
                });
            }

            modelBuilder.Entity<WalkDifficulty>().HasData(walkDifficulties);
        }
    }
}
