using ModelAPI.Domain.Configuration;
using ModelAPI.Domain.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace ModelAPI.Domain.Interfaces.Service
{
    public interface IAuthService
    {
        Task<ResponseAPI> GenerateToken(SigningConfigurations signingConfigurations, TokenConfig tokenConfig);
    }
}