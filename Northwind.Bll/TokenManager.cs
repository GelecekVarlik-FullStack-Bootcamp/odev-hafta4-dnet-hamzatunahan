using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Northwind.Entity.Dto;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bll
{
    public class TokenManager
    {
        IConfiguration configuration;

        public TokenManager(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public string CreateAccessToken(DtoLoginUser user)
        {
            //claim
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub,user.UserCode),
                new Claim(JwtRegisteredClaimNames.Jti, user.UserId.ToString())
            };
            var claimsIdentity = new ClaimsIdentity(claims, "Token");

            //claim roller
            var claimsRoleList = new List<Claim>
            {
                new Claim("role", "Admin"),
                //new Claim("role2", "Admin2")
            };
            //security key
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Tokens:Key"]));

            //sifrelenmis kimlik olusturmak
            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            // token ayarları
            var token = new JwtSecurityToken
            (
                issuer: configuration["Tokens:Issuer"], //token dagıtıcı url
                audience: configuration["Tokens:Issuer"], //erisilebilcek apiler
                expires: DateTime.Now.AddDays(1),  //token suresi 5 dakika
                notBefore: DateTime.Now,  //token uretildikten ne kadar sure sonra devreye girsin
                signingCredentials: cred, //kimlik verir
                claims: claimsIdentity.Claims //claimsleri verdik

            );
            //token olusturma sınıfı ıle ornek alıp uretmek
            var tokenHandler = new { token = new JwtSecurityTokenHandler().WriteToken(token) };
            return tokenHandler.token;

        }
    }
}
