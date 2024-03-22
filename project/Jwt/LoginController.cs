using JwtExample.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Web.Http;

namespace JwtExample.Controllers
{
    public class LoginController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Authenticate(LoginRequest login)
        {
            if (login == null)
            {
                return BadRequest("Invalid login request.");
            }

            string username = login.Username.ToLower();
            string password = login.Password;

            bool isUsernamePasswordValid = (password == "admin");

            if (isUsernamePasswordValid)
            {
                string token = CreateToken(username);
                return Ok(token);
            }
            else
            {
                HttpResponseMessage responseMsg = new HttpResponseMessage(HttpStatusCode.Unauthorized);
                return ResponseMessage(responseMsg);
            }
        }

        private string CreateToken(string username)
        {
            // Set issued at date
            DateTime issuedAt = DateTime.UtcNow;

            // Set the time when it expires
            DateTime expires = DateTime.UtcNow.AddMinutes(10);

            // Load secret key from configuration
            string secretKey = "hgshgdhfghdgsgfgdkjkajsfhagd";

            var securityKey = new SymmetricSecurityKey(Encoding.Default.GetBytes(secretKey));
            var signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);

            var token = new JwtSecurityToken(
                issuer: "https://localhost:44380",
                audience: "https://localhost:44380",
                claims: new[] { new Claim(ClaimTypes.Name, username) },
                notBefore: issuedAt,
                expires: expires,
                signingCredentials: signingCredentials
            );

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenString = tokenHandler.WriteToken(token);

            return tokenString;
        }

    }
}
