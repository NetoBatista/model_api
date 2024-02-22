using Microsoft.AspNetCore.Mvc;
using Model.Domain.Interfaces.Service;

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
        public ActionResult<string> Get()
        {
            _logger.LogInformation("Running Method HelloWorld.Get");
            var response = _helloWorldService.Execute();
            if (string.IsNullOrEmpty(response))
            {
                return NoContent();
            }
            return Ok(response);
        }
    }
}
