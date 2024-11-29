using System.Reflection;
using Model.Domain.Command.Request;
using Model.Domain.Interfaces;
using Model.Domain.Interfaces.Repository;
using Model.Domain.Response;
using Model.Handlers.Handler;
using Model.Infra.Repository;

namespace Model.API.Extension
{
    public static class InjectionServicesExtension
    {
        public static void InjectServices(this IServiceCollection services, IConfiguration configuration)
        {
            InjectServices(services);
            InjectRepository(services);
            InjectMappers(services);
            InjectDataBase(services, configuration);
            InjectSwagger(services);
        }

        private static void InjectSwagger(IServiceCollection services)
        {
            SwaggerExtension.ConfigureSwagger(services);
        }

        private static void InjectDataBase(IServiceCollection services, IConfiguration configuration)
        {

        }

        private static void InjectMappers(IServiceCollection services)
        {

        }

        private static void InjectRepository(IServiceCollection services)
        {
            services.AddTransient<IHelloWorldRepository, HelloWorldRepository>();
            services.AddTransient<IUserRepository, UserRepository>();

        }

        private static void InjectServices(IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(HelloWorldHandler).Assembly));
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(UserAddHandler).Assembly));
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(UserDeleteHandler).Assembly));
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(UserGetHandler).Assembly));
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(UserUpdateHandler).Assembly));
        }
    }
}
