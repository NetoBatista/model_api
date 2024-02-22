using Microsoft.AspNetCore.Mvc;
using Model.Domain.Interfaces;
using Model.Domain.Request;
using Model.Domain.Response;

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
        public ActionResult<HelloWorldResponse> Get([FromQuery] HelloWorldRequest request)
        {
            _logger.LogInformation("Running Method HelloWorld.Get");
            var response = _helloWorldService.Execute(request);

            return Ok(response);
        }
    }
}
