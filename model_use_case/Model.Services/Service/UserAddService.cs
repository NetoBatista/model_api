

using Model.Domain.Interfaces;
using Model.Domain.Interfaces.Repository;
using Model.Domain.Request;
using Model.Domain.Response;

namespace Model.Services
{
    public class UserAddService : IUseCase<UserAddRequest, UserAddResponse>
    {
        private readonly IUserRepository _userRepository;

        public UserAddService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public UserAddResponse Execute(UserAddRequest request)
        {
            var response = _userRepository.Add(request.Name);

            return new UserAddResponse
            {
                Success = response
            };
        }
    }
}
