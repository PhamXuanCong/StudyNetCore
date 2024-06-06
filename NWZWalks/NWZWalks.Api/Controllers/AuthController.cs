using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NWZWalks.Api.Models.DTO;

namespace NWZWalks.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;

        public AuthController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
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
                    return Ok();
                }
            }

            return BadRequest("Something was wrong ");
        }
    }
}
