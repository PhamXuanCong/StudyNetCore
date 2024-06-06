using Microsoft.AspNetCore.Identity;

namespace NWZWalks.Api.Repositories
{
    public interface ITokenRepository
    {
        public string CraeteJWTToken(IdentityUser user, List<string> roles);
    }
}
