using System.Threading.Tasks;
using ModelAPI.Domain.DTO;
using ModelAPI.Domain.Interfaces.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using ModelAPI.Domain.Configuration;

namespace ModelAPI.Controllers
{
    [Route("ModelAPI/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpGet]
        public async Task<ResponseAPI> GenerateToken([FromServices] SigningConfigurations signingConfigurations , [FromServices] TokenConfig tokenConfig)
        {
            return await _authService.GenerateToken(signingConfigurations, tokenConfig);
        }

    }
}