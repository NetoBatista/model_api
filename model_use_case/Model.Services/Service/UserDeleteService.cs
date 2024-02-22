

using Model.Domain.Interfaces;
using Model.Domain.Interfaces.Repository;
using Model.Domain.Request;
using Model.Domain.Response;

namespace Model.Services
{
    public class UserDeleteService : IUseCase<UserDeleteRequest, UserDeleteResponse>
    {
        private readonly IUserRepository _userRepository;

        public UserDeleteService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public UserDeleteResponse Execute(UserDeleteRequest request)
        {
            var response = _userRepository.Delete(request.Id);

            return new UserDeleteResponse
            {
                Success = response
            };
        }
    }
}
