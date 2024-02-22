using Microsoft.AspNetCore.Mvc;
using Model.Domain.Interfaces;
using Model.Domain.Request;
using Model.Domain.Response;

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
        public ActionResult<UserGetResponse> Get([FromQuery] UserGetRequest request)
        {
            _logger.LogInformation("Running Method User.Get");
            var response = _userGetService.Execute(request);

            return Ok(response);
        }

        [HttpPost]
        public ActionResult<UserAddResponse> Add([FromQuery] UserAddRequest request)
        {
            _logger.LogInformation("Running Method User.Add");
            var response = _userAddService.Execute(request);

            return Ok(response);
        }

        [HttpPut]
        public ActionResult<UserUpdateResponse> Put([FromQuery] UserUpdateRequest request)
        {
            _logger.LogInformation("Running Method User.Put");
            var response = _userUpdateService.Execute(request);

            return Ok(response);
        }

        [HttpDelete]
        public ActionResult<UserDeleteResponse> Delete([FromQuery] UserDeleteRequest request)
        {
            _logger.LogInformation("Running Method User.Delete");
            var response = _userDeleteService.Execute(request);

            return Ok(response);
        }
    }
}
