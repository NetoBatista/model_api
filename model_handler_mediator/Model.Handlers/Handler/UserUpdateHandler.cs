

using MediatR;
using Model.Domain.Command.Request;
using Model.Domain.Interfaces.Repository;
using Model.Domain.Response;

namespace Model.Handlers.Handler
{
    public class UserUpdateHandler : IRequestHandler<UserUpdateRequest, UserUpdateResponse>
    {
        private readonly IUserRepository _userRepository;

        public UserUpdateHandler(IUserRepository userRepository) : base()
        {
            _userRepository = userRepository;
        }

        public Task<UserUpdateResponse> Handle(UserUpdateRequest request, CancellationToken cancellationToken)
        {
            var response = _userRepository.Update(request.Name, request.Id);

            return Task.FromResult(
                new UserUpdateResponse
                {
                    Success = response,
                    User = request.Name
                }
            );
        }
    }
}
