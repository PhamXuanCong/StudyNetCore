using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;

namespace NWZWalks.Api.Repositories
{
    public class ToeknRepository:ITokenRepository
    {
        private readonly IConfiguration _iConfiguration;

        public ToeknRepository(IConfiguration iConfiguration)
        {
            _iConfiguration = iConfiguration;
        }

        public string CraeteJWTToken(IdentityUser user, List<string> roles)
        {
            var claims = new List<Claim>();
            // thông tin người dùng đươc đưa vào token
            claims.Add(new Claim(ClaimTypes.Email, user.Email));

            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            //Tạo khóa bảo mật đối xưng khóa trong cấu hình
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_iConfiguration["JwtLKey"]));

            //Tạo thông tin xác thực bằng thuật toán HmacSha256
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            //Tạo token
            var token = new JwtSecurityToken(
                _iConfiguration["Jwt:Issuer"],
                _iConfiguration["Jwt:Audience"],
                claims,
                expires:DateTime.Now.AddMinutes(15),
                signingCredentials:credentials
            );

            //viết token thành chuỗi
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
