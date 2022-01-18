

using Model.Domain.Interfaces;
using Model.Domain.Interfaces.Repository;
using Model.Domain.Request;
using Model.Domain.Response;

namespace Model.Services
{
    public class UserUpdateService : IUseCase<UserUpdateRequest, UserUpdateResponse>
    {
        IUserRepository _userRepository;

        public UserUpdateService(IUserRepository userRepository) : base()
        {
            _userRepository = userRepository;
        }

        public UserUpdateResponse Execute(UserUpdateRequest request)
        {
            _userRepository.Update(request.Name, request.Id);

            return new UserUpdateResponse
            {
                Success = true,
                User = request.Name
            };
        }
    }
}
