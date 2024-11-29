

using MediatR;
using Model.Domain.Command.Request;
using Model.Domain.Interfaces.Repository;
using Model.Domain.Response;

namespace Model.Handlers.Handler
{
    public class HelloWorldHandler : IRequestHandler<HelloWorldRequest, HelloWorldResponse>
    {
        private readonly IHelloWorldRepository _helloWorldRepository;

        public HelloWorldHandler(IHelloWorldRepository helloWorldRepository)
        {
            _helloWorldRepository = helloWorldRepository;
        }

        public Task<HelloWorldResponse> Handle(HelloWorldRequest request, CancellationToken cancellationToken)
        {
            var name = request?.Name ?? "";
            var response = _helloWorldRepository.Execute(name);
            return Task.FromResult(
                new HelloWorldResponse
                {
                    Message = response
                }
            );
        }
    }
}
