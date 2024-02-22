

using Model.Domain.Interfaces;
using Model.Domain.Interfaces.Repository;
using Model.Domain.Request;
using Model.Domain.Response;

namespace Model.Services
{
    public class HelloWorldService : IUseCase<HelloWorldRequest, HelloWorldResponse>
    {
        private readonly IHelloWorldRepository _helloWorldRepository;

        public HelloWorldService(IHelloWorldRepository helloWorldRepository)
        {
            _helloWorldRepository = helloWorldRepository;
        }

        public HelloWorldResponse Execute(HelloWorldRequest request)
        {
            var name = request?.Name ?? "";
            var response = _helloWorldRepository.Execute(name);
            return new HelloWorldResponse
            {
                Message = response
            };
        }
    }
}
