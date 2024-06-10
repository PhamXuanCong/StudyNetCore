using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace NWZWalks.Api.Data
{
    public class NzWalksAuthDbcontext(DbContextOptions<NzWalksAuthDbcontext> options) : IdentityDbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var roles = new List<IdentityRole>()
            {
                new IdentityRole
                {
                    Id = "34a7f549-91f1-488a-85b7-2d20f7688111",
                    ConcurrencyStamp = "34a7f549-91f1-488a-85b7-2d20f7688111",
                    Name = "Reader",
                    NormalizedName = "Reader".ToUpper()
                },
                new IdentityRole
                {
                    Id = "5d29359b-71ea-4136-983a-71b928c15e3c",
                    ConcurrencyStamp = "5d29359b-71ea-4136-983a-71b928c15e3c",
                    Name = "Wrtier",
                    NormalizedName = "Wrtier".ToUpper(),
                }
            };

            //builder.Entity<IdentityRole>().HasData(roles);
        }
    }
}
