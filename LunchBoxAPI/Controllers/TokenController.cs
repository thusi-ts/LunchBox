using LunchBox.Shared;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using LunchBox.API.Models;

namespace LunchBoxAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TokenController : ControllerBase
    {
        private readonly IConfiguration config;
        private readonly UserManager<User> userManager;

        public TokenController(IConfiguration config, UserManager<User> userManager) 
        {
            this.config = config;
            this.userManager = userManager;
        }

        [HttpPost()]
        public async Task<IActionResult> Post([FromBody] LoginRequest loginRequest)
        {
            if (loginRequest.UserName != null && loginRequest.Password != null)
            {
                var user = await GetUserAsync(loginRequest.UserName, loginRequest.Password);
                if (user != null)
                {
                    var token = GenerateJwtTokenAsync(user);
                    return Ok(new LoginResponse { Token = token, Username = user.UserName, Id = user.Id });
                }
            }
            return BadRequest("Invalid credentials");
        }
        
        private String GenerateJwtTokenAsync(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(config.GetSection("Jwt:key").Value);

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id ?? ""),
                new Claim(ClaimTypes.Email, user.Email ?? ""),
                new Claim(ClaimTypes.Name, user.Fullname ?? "")
            };

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddHours(5),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
                Issuer = config.GetSection("Jwt:Issuer").Value,
                Audience = config.GetSection("Jwt:Audience").Value
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        private async Task<User> GetUserAsync(string email, string password)
        {
            var user = await userManager.FindByEmailAsync(email);
            if (user == null)
            {
                return null;
            }

            var result = userManager.PasswordHasher.VerifyHashedPassword(user, user.PasswordHash, password);
            if (result != PasswordVerificationResult.Success)
            {
                return null;
            }
            return user;
        }
    }
}
