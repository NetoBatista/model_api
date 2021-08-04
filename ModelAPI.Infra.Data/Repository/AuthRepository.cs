using Microsoft.IdentityModel.Tokens;
using ModelAPI.Domain.Configuration;
using ModelAPI.Domain.Enum;
using ModelAPI.Domain.Interfaces;
using ModelAPI.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ModelAPI.Infra.Data.Repository
{
    public class AuthRepository : BaseRepository, IAuthRepository
    {
        public AuthRepository(IUnitOfWork uow) : base(uow) { }

        public async Task<string> GenerateToken(SigningConfigurations signingConfigurations, TokenConfig tokenConfig)
        {
            var random = new Random().Next(1, 999);
            var identity = CreateIdentity(random);
            return CreateToken(identity, signingConfigurations, tokenConfig);
        }

        private string CreateToken(ClaimsIdentity identity , SigningConfigurations signingConfigurations , TokenConfig tokenConfig)
        {
            DateTime dataCriacao = DateTime.Now;
            DateTime dataExpiracao = dataCriacao + TimeSpan.FromSeconds(tokenConfig.Seconds);

            var handler = new JwtSecurityTokenHandler();
            var securityToken = handler.CreateToken(new SecurityTokenDescriptor
            {
                Issuer = tokenConfig.Issuer,
                Audience = tokenConfig.Audience,
                SigningCredentials = signingConfigurations.SigningCredentials,
                Subject = identity,
                NotBefore = dataCriacao,
                Expires = dataExpiracao
            });

            var tokenRetorno = handler.WriteToken(securityToken);
            return tokenRetorno;
        }

        private ClaimsIdentity CreateIdentity(int randomId)
        {
            return new ClaimsIdentity(
                    new GenericIdentity(randomId.ToString(), "UserID"),
                    new[] {
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString("N")),
                        new Claim(JwtRegisteredClaimNames.UniqueName, randomId.ToString()),
                        new Claim(EnumClaims.ClaimsNames.UserId, randomId.ToString())
                    }
                );
        }

    }
}
