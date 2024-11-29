using MediatR;
using Microsoft.AspNetCore.Mvc;
using Model.Domain.Command.Request;
using Model.Domain.Response;

namespace Model.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<HelloWorldController> _logger;
        private readonly IMediator _mediator;
        public UserController(ILogger<HelloWorldController> logger,
                              IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<UserGetResponse>> Get([FromQuery] UserGetRequest request)
        {
            _logger.LogInformation("Running Method User.Get");
            var response = await _mediator.Send(request);

            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<UserAddResponse>> Add([FromQuery] UserAddRequest request)
        {
            _logger.LogInformation("Running Method User.Add");
            var response = await _mediator.Send(request);

            return Ok(response);
        }

        [HttpPut]
        public async Task<ActionResult<UserUpdateResponse>> Put([FromQuery] UserUpdateRequest request)
        {
            _logger.LogInformation("Running Method User.Put");
            var response = await _mediator.Send(request);

            return Ok(response);
        }

        [HttpDelete]
        public async Task<ActionResult<UserDeleteResponse>> Delete([FromQuery] UserDeleteRequest request)
        {
            _logger.LogInformation("Running Method User.Delete");
            var response = await _mediator.Send(request);

            return Ok(response);
        }
    }
}
