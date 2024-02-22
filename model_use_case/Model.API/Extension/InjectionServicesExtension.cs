using Model.Domain.Interfaces;
using Model.Domain.Interfaces.Repository;
using Model.Domain.Request;
using Model.Domain.Response;
using Model.Infra.Repository;
using Model.Services;

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
            services.AddTransient<IUseCase<HelloWorldRequest, HelloWorldResponse>, HelloWorldService>();
            services.AddTransient<IUseCase<UserAddRequest, UserAddResponse>, UserAddService>();
            services.AddTransient<IUseCase<UserGetRequest, UserGetResponse>, UserGetService>();
            services.AddTransient<IUseCase<UserUpdateRequest, UserUpdateResponse>, UserUpdateService>();
            services.AddTransient<IUseCase<UserDeleteRequest, UserDeleteResponse>, UserDeleteService>();
        }
    }
}
