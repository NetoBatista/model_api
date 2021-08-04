using System.Threading.Tasks;
using ModelAPI.Domain.DTO;
using ModelAPI.Domain.Interfaces.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ModelAPI.Controllers
{
    [Route("ModelAPI/[controller]")]
    [Authorize("Bearer")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        private readonly IHelloWorldService _helloWorldService;
        public HelloWorldController(IHelloWorldService helloWorldService)
        {
            _helloWorldService = helloWorldService;
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("NoAuth")]
        public async Task<ResponseAPI> ObterVersao()
        {
            return await _helloWorldService.HelloWorld();
        }

        [HttpGet]
        [Route("Auth")]
        public async Task<ResponseAPI> Helloworld()
        {
            return await _helloWorldService.HelloWorld();
        }


    }
}