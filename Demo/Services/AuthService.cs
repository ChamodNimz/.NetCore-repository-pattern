using Demo.Utilities.Auth;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Services
{
    public interface IAuthService
    {
        string GenerateToken();
    }

    public class AuthService
    {
        public AuthService(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        private readonly AppSettings _appSettings;

        public string GenerateToken()
        {
            //var tokenHandler = new JwtSecurityTokenHandler();
            //var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            //var tokenDescriptor = new SecurityTokenDescriptor
            //{
            //    Subject = new ClaimsIdentity(new Claim[]
            //    {
            //        new Claim(ClaimTypes.Name, "User Id")
            //    }),
            //    Expires = DateTime.UtcNow.AddDays(7),
            //    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            //};
            //var token = tokenHandler.CreateToken(tokenDescriptor);
            //return tokenHandler.WriteToken(token);
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_appSettings.Secret));
            var signingCredentials = new SigningCredentials(key,SecurityAlgorithms.HmacSha256Signature);
            var token = new JwtSecurityToken
                (
                    issuer: "snowflake.in",
                    audience: "readers",
                    expires: DateTime.Now.AddHours(24*7),
                    signingCredentials: signingCredentials
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

    }
}
