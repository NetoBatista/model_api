using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Model.Domain.Interfaces.Repository;
using Model.Domain.Interfaces.Service;
using Model.Services;
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
        }

        private static void InjectServices(IServiceCollection services)
        {
            services.AddTransient<IHelloWorldService, HelloWorldService>();
        }
    }
}
