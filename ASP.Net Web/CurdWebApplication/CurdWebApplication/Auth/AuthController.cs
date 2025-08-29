using Crud.Models;
using CurdWebApplication.Connection;
using CurdWebApplication.EmpDTO;
using CurdWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public readonly CollectionContext _context;
        private readonly IConfiguration _config;
        //public  IConfiguration _configuration;

        public AuthController(IConfiguration configuration , CollectionContext context)
        {
            _config = configuration;
            _context = context;
        }




        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginDTO user)
        {


            ////Validate user credentials here(hardcoded for example)
            //    if (user.Username == "admin" && user.Password == "123")
            //    {
            //        var token = GenerateJwtToken(user.Username);
            //        return Ok(new { token });
            //    }
            //return Unauthorized();



            //using (var context = new CollectionContext())
            

                // var e = context.Employees.Find(user.Username);
                var e = _context.
                    Users.FirstOrDefault(u => u.UserName == user.Username 
                                 && u.Password == user.Password);

            var e1 = _context.
               Employees.FirstOrDefault(u => u.Name == user.Username
                            );
            if (e != null)
                {
                string role =e1
                    .Role;
                var token = GenerateJwtToken(e.UserName,role);
                    return Ok(new { token });
                }



            return Unauthorized("Invalid username or password......");
        }


        private string GenerateJwtToken(string username,string role)
        {
            var claims = new[]
            {
            new Claim(JwtRegisteredClaimNames.Sub, username),
         //   new Claim(ClaimTypes.Role, role),
            new Claim("role", role),        // custom claim
            new Claim("name", username),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),


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


        [HttpPost("/register")]
        public  IActionResult RegisterEmp([FromBody] RegistrationDTO request) {


            if (request == null) 
            {
                return BadRequest("Fill All Data in From ....");
            }

            var employee = new Employee
            {
                Name = request.Name,
                Designation = request.Designation,
                Role = request.Role,
            };
            var user = new User
            {
                UserName = request.Name,
                Password = request.Password,    
            };
            //con
           _context.Employees.Add(employee);
            _context.Users.Add(user);
            _context.SaveChanges();



            return Ok(new { message = "Registration successful!" });
        }

    }
}
