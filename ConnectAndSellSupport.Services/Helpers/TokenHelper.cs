using ConnectAndSellSupport.Services.Models.Response.User;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace ConnectAndSellSupport.Services.Helpers
{
    public class TokenHelper : ITokenHelper
    {
        #region Private methods
        private (ClaimsPrincipal, JwtSecurityToken) GetSecurityTokenFromExpiredToken(string token, string secretKey)
        {
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateAudience = false,
                ValidateIssuer = false,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(secretKey)),
                ValidateLifetime = false
            };

            var principal = new JwtSecurityTokenHandler()
                .ValidateToken(token, tokenValidationParameters, out SecurityToken securityToken);

            return (principal, securityToken as JwtSecurityToken);
        }
        #endregion

        #region Interface implementations
        public string GenerateToken(string userId, string userName, string email, string role, string secretKey)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, userId),
                new Claim(ClaimTypes.Name, userName),
                new Claim(ClaimTypes.Email, email),
                new Claim(ClaimTypes.Role, role),
                new Claim(JwtRegisteredClaimNames.Nbf, new DateTimeOffset(DateTime.Now).ToUnixTimeSeconds().ToString()),
                new Claim(JwtRegisteredClaimNames.Exp, new DateTimeOffset(DateTime.Now.AddHours(2)).ToUnixTimeSeconds().ToString())
            };

            var token = new JwtSecurityToken(
                new JwtHeader(
                    new SigningCredentials(new SymmetricSecurityKey(Encoding.ASCII.GetBytes(secretKey)), SecurityAlgorithms.HmacSha256)),
                new JwtPayload(claims));

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public string GenerateRefreshToken()
        {
            var randomNumber = new byte[32];
            using var rng = RandomNumberGenerator.Create();
            rng.GetBytes(randomNumber);
            return Convert.ToBase64String(randomNumber);
        }

        public RefreshTokenServiceResponse GetRefreshTokenResponse(string accessToken, string secretKey)
        {
            (var principal, var securityToken) = GetSecurityTokenFromExpiredToken(accessToken, secretKey);

            if (securityToken == null || 
                !securityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
            {
                return new RefreshTokenServiceResponse
                {
                    InvalidRefreshToken = true
                };
            }

            var userId = principal.FindFirst(ClaimTypes.NameIdentifier).Value;
            var userName = principal.Identity.Name;
            var email = principal.FindFirst(ClaimTypes.Email).Value;
            var role = principal.FindFirst(ClaimTypes.Role).Value;

            return new RefreshTokenServiceResponse
            {
                Success = true,
                AccessToken = GenerateToken(userId, userName, email, role, secretKey),
                RefreshToken = GenerateRefreshToken(),
                UserName = userName
            };
        }
        #endregion
    }

    public interface ITokenHelper
    {
        string GenerateToken(string userId, string userName, string email, string role, string secretKey);
        string GenerateRefreshToken();
        RefreshTokenServiceResponse GetRefreshTokenResponse(string accessToken, string jwtSecret);
    }
}
