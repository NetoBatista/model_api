using ModelAPI.Domain.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace ModelAPI.Domain.Interfaces.Repository
{
    public interface IAuthRepository
    {
        Task<string> GenerateToken(SigningConfigurations signingConfigurations, TokenConfig tokenConfig);
    }
}