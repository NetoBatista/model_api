using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Model.Domain.Interfaces.Service;
using System.Threading.Tasks;

namespace Model.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        private readonly ILogger<HelloWorldController> _logger;
        private readonly IHelloWorldService _helloWorldService;

        public HelloWorldController(ILogger<HelloWorldController> logger, IHelloWorldService helloWorldService)
        {
            _logger = logger;
            _helloWorldService = helloWorldService;
        }

        [HttpGet]
        public async Task<ActionResult<string>> Get()
        {
            _logger.LogInformation("Running Method HelloWorld.Get");
            var response = _helloWorldService.Execute();

            return Ok(response);
        }
    }
}
