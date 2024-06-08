using System.Data.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NWZWalks.Api.Models.DTO;
using NWZWalks.Api.Repositories;

namespace NWZWalks.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ITokenRepository _itokenRepository;

        public AuthController(UserManager<IdentityUser> userManager, ITokenRepository itokenRepository)
        {
            _userManager = userManager;
            _itokenRepository = itokenRepository;
        }

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequestDto registerRequestDto)
        {
            var identityUser = new IdentityUser
            {
                UserName = registerRequestDto.UserName,
                Email = registerRequestDto.UserName
            };

            var identityResult = await _userManager.CreateAsync(identityUser, registerRequestDto.PassWord);

            if (identityResult.Succeeded)
            {
                //Add roles to this user
                if (registerRequestDto.Roles.Any())
                {
                     identityResult = await _userManager.AddToRolesAsync(identityUser, registerRequestDto.Roles);
                     if (identityResult.Succeeded)
                     {
                         return Ok("user was registered! Please login.");
                     }
                }
            }

            return BadRequest("Something was wrong ");
        }


        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDto loginRequestDto)
        {
            var user =await _userManager.FindByEmailAsync(loginRequestDto.UserName);

            if (user != null)
            {
                if (await _userManager.CheckPasswordAsync(user, loginRequestDto.Password))
                {
                    var roles = await _userManager.GetRolesAsync(user);

                    if (roles != null)
                    {
                        //Craete Token
                        var jwtToken = _itokenRepository.CraeteJWTToken(user, roles.ToList());

                        var response = new LoginResponseDto
                        {
                            JwtToken = jwtToken,
                        };

                        return Ok(response);
                    }

                    return Ok();
                }
            }

            return BadRequest("Something was wrong ");
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _userManager.Users.ToListAsync();

            return Ok(users);
        }
    }
}
