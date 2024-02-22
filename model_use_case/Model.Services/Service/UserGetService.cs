

using Model.Domain.Interfaces;
using Model.Domain.Interfaces.Repository;
using Model.Domain.Request;
using Model.Domain.Response;

namespace Model.Services
{
    public class UserGetService : IUseCase<UserGetRequest, UserGetResponse>
    {
        private readonly IUserRepository _userRepository;

        public UserGetService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public UserGetResponse Execute(UserGetRequest request)
        {
            _userRepository.Get(request.Id);

            return new UserGetResponse
            {
                Name = "Name",
                Description = "Description",
                Phone = "Phone"
            };
        }
    }
}
