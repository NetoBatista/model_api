

using Model.Domain.Interfaces;
using Model.Domain.Interfaces.Repository;
using Model.Domain.Request;
using Model.Domain.Response;

namespace Model.Services
{
    public class HelloWorldService : IUseCase<HelloWorldRequest, HelloWorldResponse>
    {
        IHelloWorldRepository _helloWorldRepository;

        public HelloWorldService(IHelloWorldRepository helloWorldRepository)
        {
            _helloWorldRepository = helloWorldRepository;
        }

        public HelloWorldResponse Execute(HelloWorldRequest request)
        {
            return new HelloWorldResponse 
            {
                Message = $"Hello world {request?.Name ?? ""}"
            };
        }
    }
}
