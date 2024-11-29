

using MediatR;
using Model.Domain.Command.Request;
using Model.Domain.Interfaces.Repository;
using Model.Domain.Response;

namespace Model.Handlers.Handler
{
    public class UserGetHandler : IRequestHandler<UserGetRequest, UserGetResponse>
    {
        private readonly IUserRepository _userRepository;

        public UserGetHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<UserGetResponse> Handle(UserGetRequest request, CancellationToken cancellationToken)
        {
            _userRepository.Get(request.Id);

            return Task.FromResult(
                new UserGetResponse
                {
                    Name = "Name",
                    Description = "Description",
                    Phone = "Phone"
                }
            );
        }
    }
}
