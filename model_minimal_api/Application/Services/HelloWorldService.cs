using Application.Contracts;

namespace Application.Services
{
    public class HelloWorldService : IHelloWorldService
    {
        public HelloWorldResponse HelloWorld(HelloWorldRequest request)
        {
            return new HelloWorldResponse
            {
                Response = $"Hello {request.Name ?? "world"}"
            };
        }
    }
}
