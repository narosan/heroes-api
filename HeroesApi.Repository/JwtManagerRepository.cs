using HeroesApi.Models;
using HeroesApi.Repository.Interfaces;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.Extensions.Configuration;

namespace HeroesApi.Repository
{
    public class JwtManagerRepository : IJwtManagerRepository
    {
        private readonly IConfiguration _configuration;
        public JwtManagerRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Tokens Authenticate(string nome, string password)
        {
            var tokenKey = Encoding.UTF8.GetBytes(_configuration["JWT:Key"]);

            var jwtHandler = new JwtSecurityTokenHandler();
            

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(
                    new Claim[]
                    {
                        new Claim(ClaimTypes.Name, nome)
                    }
                ),
                Expires = DateTime.UtcNow.AddMinutes(30),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(tokenKey), 
                    SecurityAlgorithms.HmacSha256Signature
                )
            };

            var token = jwtHandler.CreateToken(tokenDescriptor);

            return new Tokens { Token = jwtHandler.WriteToken(token) };
        }
    }
}
