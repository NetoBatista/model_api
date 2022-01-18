

using Model.Domain.Interfaces;
using Model.Domain.Interfaces.Repository;
using Model.Domain.Request;
using Model.Domain.Response;

namespace Model.Services
{
    public class UserAddService : IUseCase<UserAddRequest, UserAddResponse>
    {
        IUserRepository _userRepository;

        public UserAddService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public UserAddResponse Execute(UserAddRequest request)
        {
            _userRepository.Add(request.Name);

            return new UserAddResponse
            {
                Success = true
            };
        }
    }
}
