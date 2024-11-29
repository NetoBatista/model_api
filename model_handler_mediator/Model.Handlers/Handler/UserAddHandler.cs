

using MediatR;
using Model.Domain.Command.Request;
using Model.Domain.Interfaces.Repository;
using Model.Domain.Response;

namespace Model.Handlers.Handler
{
    public class UserAddHandler : IRequestHandler<UserAddRequest, UserAddResponse>
    {
        private readonly IUserRepository _userRepository;

        public UserAddHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<UserAddResponse> Handle(UserAddRequest request, CancellationToken cancellationToken)
        {
            var response = _userRepository.Add(request.Name);

            return Task.FromResult(
                new UserAddResponse
                {
                    Success = response
                }
            );
        }
    }
}
