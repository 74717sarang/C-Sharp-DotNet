using Crud.Connection;
using Crud.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CurdWebApplication.Auth
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController:ControllerBase
    {
        private readonly CollectionContext collectionContext;
        private readonly IConfiguration _config;
        //public  IConfiguration _configuration;

        public AuthController(IConfiguration configuration , CollectionContext collectionContext)
        {
            _config = configuration;
            collectionContext=collectionContext;
        }




        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginDTO user)
        {
            // Validate user credentials here (hardcoded for example)
            //if (user.Username == "admin" && user.Password == "123")
            //{
            //    var token = GenerateJwtToken(user.Username);
            //    return Ok(new { token });
            //}
            //return Unauthorized();

            using(var context = new CollectionContext())
            {

                var e = context.Employees.Find(user.Username);
                if (e != null) {
                    var token = GenerateJwtToken(e.Name);
                    return Ok(new { token });
                }


                return Ok(e);

            }


            return Unauthorized("Invalid username or password......");
        }


        private string GenerateJwtToken(string username)
        {
            var claims = new[]
            {
            new Claim(JwtRegisteredClaimNames.Sub, username),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddHours(1),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

    }
}
