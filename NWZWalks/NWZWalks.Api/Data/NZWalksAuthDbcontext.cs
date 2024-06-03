using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace NWZWalks.Api.Data
{
    public class NZWalksAuthDbcontext: IdentityDbContext
    {
        public NZWalksAuthDbcontext(DbContextOptions options): base(options)
        {
            
        }
    }
}
