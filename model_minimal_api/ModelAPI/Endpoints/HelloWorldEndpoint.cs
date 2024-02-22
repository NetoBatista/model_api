using Application.Contracts;
using Application.Services;

namespace ModelAPI.Endpoints
{
    public static class HelloWorldEndpoint
    {
        public static void CreateHelloWorldEndPoint(this WebApplication app)
        {
            app.MapGet("/helloworld", HelloWorld);
        }

        internal static IResult HelloWorld(IHelloWorldService helloWorldService, string? name)
        {
            var response = helloWorldService.HelloWorld(new HelloWorldRequest { Name = name });
            return Results.Ok(response);
        }
    }
}
