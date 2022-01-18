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
    public class UserController : ControllerBase
    {
        private readonly ILogger<HelloWorldController> _logger;
        private readonly IUseCase<UserAddRequest, UserAddResponse> _userAddService;
        private readonly IUseCase<UserGetRequest, UserGetResponse> _userGetService;
        private readonly IUseCase<UserUpdateRequest, UserUpdateResponse> _userUpdateService;
        private readonly IUseCase<UserDeleteRequest, UserDeleteResponse> _userDeleteService;

        public UserController(ILogger<HelloWorldController> logger, 
                              IUseCase<UserAddRequest, UserAddResponse> _userAddService, 
                              IUseCase<UserGetRequest, UserGetResponse> _userGetService, 
                              IUseCase<UserUpdateRequest, UserUpdateResponse> _userUpdateService,
                              IUseCase<UserDeleteRequest, UserDeleteResponse> _userDeleteService)
        {
            _logger = logger;
            this._userAddService = _userAddService;
            this._userGetService = _userGetService;
            this._userUpdateService = _userUpdateService;
            this._userDeleteService = _userDeleteService;
        }

        [HttpGet]
        public async Task<ActionResult<string>> Get([FromQuery] UserGetRequest request)
        {
            _logger.LogInformation("Running Method User.Get");
            var response = _userGetService.Execute(request);

            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<string>> Add([FromQuery] UserAddRequest request)
        {
            _logger.LogInformation("Running Method User.Add");
            var response = _userAddService.Execute(request);

            return Ok(response);
        }

        [HttpPut]
        public async Task<ActionResult<string>> Put([FromQuery] UserUpdateRequest request)
        {
            _logger.LogInformation("Running Method User.Put");
            var response = _userUpdateService.Execute(request);

            return Ok(response);
        }

        [HttpDelete]
        public async Task<ActionResult<string>> Delete([FromQuery] UserDeleteRequest request)
        {
            _logger.LogInformation("Running Method User.Delete");
            var response = _userDeleteService.Execute(request);

            return Ok(response);
        }
    }
}
