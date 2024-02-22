using Application.Services;

namespace ModelAPI
{
    public static class InjectionDependences
    {
        public static void InjectDependences(this IServiceCollection services)
        {
            services.AddSingleton<IHelloWorldService, HelloWorldService>();
        }
    }
}
