using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Model.Domain.Interfaces;
using Model.Domain.Request;
using Model.Domain.Response;
using System.Threading.Tasks;

namespace Model.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        private readonly ILogger<HelloWorldController> _logger;
        private readonly IUseCase<HelloWorldRequest, HelloWorldResponse> _helloWorldService;

        public HelloWorldController(ILogger<HelloWorldController> logger, IUseCase<HelloWorldRequest, HelloWorldResponse> helloWorldService)
        {
            _logger = logger;
            _helloWorldService = helloWorldService;
        }

        [HttpGet]
        public async Task<ActionResult<string>> Get([FromQuery] HelloWorldRequest request)
        {
            _logger.LogInformation("Running Method HelloWorld.Get");
            var response = _helloWorldService.Execute(request);

            return Ok(response);
        }
    }
}
