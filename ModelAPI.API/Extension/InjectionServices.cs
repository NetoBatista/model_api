using Microsoft.Extensions.DependencyInjection;
using ModelAPI.Domain.Interfaces;
using ModelAPI.Domain.Interfaces.Service;
using ModelAPI.Infra.Data;
using ModelAPI.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelAPI.API.Extension
{
    public static class InjectionServicesExtension
    {
        public static void InjectionServices(this IServiceCollection services)
        {
            services.AddTransient<IHelloWorldService, HelloWorldService>();
            services.AddTransient<IAuthService, AuthService>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
