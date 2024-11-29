

using MediatR;
using Model.Domain.Command.Request;
using Model.Domain.Interfaces.Repository;
using Model.Domain.Response;

namespace Model.Handlers.Handler
{
    public class UserDeleteHandler : IRequestHandler<UserDeleteRequest, UserDeleteResponse>
    {
        private readonly IUserRepository _userRepository;

        public UserDeleteHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<UserDeleteResponse> Handle(UserDeleteRequest request, CancellationToken cancellationToken)
        {
            var response = _userRepository.Delete(request.Id);

            return Task.FromResult(
                new UserDeleteResponse
                {
                    Success = response
                }
            );
        }
    }
}
