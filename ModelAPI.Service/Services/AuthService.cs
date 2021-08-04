using ModelAPI.Domain.Configuration;
using ModelAPI.Domain.DTO;
using ModelAPI.Domain.Interfaces;
using ModelAPI.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ModelAPI.Service.Services
{
    public class AuthService : BaseService, IAuthService
    {
        public AuthService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<ResponseAPI> GenerateToken(SigningConfigurations signingConfigurations, TokenConfig tokenConfig)
        {
            var response =  await _unitOfWork.AuthRepository.GenerateToken(signingConfigurations, tokenConfig);
            return new ResponseAPI
            {
                Object = response
            };
        }
    }
}
