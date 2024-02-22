using Application.Contracts;

namespace Application.Services
{
    public interface IHelloWorldService
    {
        HelloWorldResponse HelloWorld(HelloWorldRequest request);
    }
}
