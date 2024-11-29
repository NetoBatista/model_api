using MediatR;
using Microsoft.AspNetCore.Mvc;
using Model.Domain.Command.Request;
using Model.Domain.Response;

namespace Model.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        private readonly ILogger<HelloWorldController> _logger;
        private readonly IMediator _mediator;

        public HelloWorldController(ILogger<HelloWorldController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<HelloWorldResponse>> Get([FromQuery] HelloWorldRequest request)
        {
            _logger.LogInformation("Running Method HelloWorld.Get");
            var response = await _mediator.Send(request);

            return Ok(response);
        }
    }
}
